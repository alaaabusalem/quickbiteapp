﻿using FoodiApp.Models;
using FoodiApp.Models.DTOs;
using FoodiApp.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stripe.Checkout;
using Stripe;
using System.Security.Claims;

namespace FoodiApp.Controllers
{
	public class OrdersController : Controller
	{
		private readonly IEmail emailService;
        private readonly IShoppingCart _shoppingCart;
        private readonly IUser _user;
        private readonly IConfiguration _configuration;
		private readonly IOrder _order;

		public OrdersController(IEmail emailservice, IShoppingCart shoppingCart, IUser user, IConfiguration configuration, IOrder order)
        {
            emailService= emailservice;	
			_shoppingCart= shoppingCart;	
            _user= user; 
            _configuration= configuration;
            _order= order;
        }
        [Authorize(Roles = "Client")]

        public async Task<IActionResult> Index()
		{
            
                return RedirectToAction("Index", "ShoppingCarts");
        }

        [Authorize(Roles = "Client")]

        public async Task<IActionResult> Summary()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Get the user's ID
            var cartitems = await  _shoppingCart.GetShoppingCartItems(userId);
            var user= await _user.GetUserById(userId);
            float Total =  _shoppingCart.GetTotal(cartitems);
            SummaryDTO summaryDTO = new SummaryDTO()
            {
                CartItems = cartitems,
                User = user,
                Total=Total
            };
            return View(summaryDTO);
        }

		[Authorize(Roles = "Client")]

		public async Task<IActionResult> PaymentProcces()
        {
			StripeConfiguration.ApiKey = _configuration.GetSection("StripeSettings:SecretKey").Get<string>();

			//var domain = "https://localhost:7238/";
			var domain = "https://quickfoodiapp20231001201422.azurewebsites.net/";
			var options = new SessionCreateOptions
			{
				SuccessUrl = domain + "Orders/ConfirmPayment",
				CancelUrl = domain + "Orders/FailedPayment",
				LineItems = new List<SessionLineItemOptions>(),
				Mode = "payment",
			};
			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Get the user's ID

            // add cart items to the session informations
			var cartitems = await _shoppingCart.GetShoppingCartItems(userId);
             foreach (var cartitem in cartitems) {
                var sessionLineItem = new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions()
                    {
                        UnitAmount = (long)(cartitem.foodItem.Price * 100), // 20.50 => 2050
                        Currency = "usd",
                        ProductData = new SessionLineItemPriceDataProductDataOptions()
                        {
                            Name = cartitem.foodItem.Name
						}
					},
					Quantity = cartitem.Quantity
				};

				options.LineItems.Add(sessionLineItem);
			}

			// adding delivery price
			var sessionLineItemDelivery = new SessionLineItemOptions
			{
				PriceData = new SessionLineItemPriceDataOptions()
				{
					UnitAmount = (long)(10 * 100), // 20.50 => 2050
					Currency = "usd",
					ProductData = new SessionLineItemPriceDataProductDataOptions()
					{
						Name = "delivery"
					}
				},
				Quantity=1
			};

			options.LineItems.Add(sessionLineItemDelivery);

			var service = new SessionService();
			var session = service.Create(options);

			var sessionId = session.Id;

			TempData["sessionId"] = sessionId;


			Response.Headers.Add("Location", session.Url);

			return new StatusCodeResult(303);
		}

		public async Task SendOrderEmail(string userId)
		{

            var claimsIdentity = User.Identity as ClaimsIdentity;
            if (claimsIdentity != null)
            {
                var emailClaim = claimsIdentity.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Email);
                if (emailClaim != null)
                {
                    var emailValue = emailClaim.Value;
                    string Textmsg = $"thank you {User.Identity.Name} for your order from our website QuickBites \r\n \r\n Quick Bites Team";
                    string subject = "Welcome";
                   await emailService.SendEmailAsync(emailValue, subject, Textmsg);

                    // summary of Client purchase
                    subject = "Sumarry to Your purchases";
                    Textmsg = "this is a sumarry for purchases: \r\n";
                    var cartItems = await _shoppingCart.GetShoppingCartItems(userId);
                    float totalprice = _shoppingCart.GetTotal(cartItems);
                    foreach (var item in cartItems)
                    {
                        Textmsg = Textmsg + $"Name: {item.foodItem.Name} => Price: {item.foodItem.Price}$ => Quantity: {item.Quantity} => subTotal: {item.foodItem.Price * item.Quantity} \r\n";
                    }
                    totalprice = totalprice + 10;
					Textmsg = Textmsg + $" Delivary => 10$ \r\n ===>>>> Total price :{totalprice}$ \r\n \r\n Quick Bites Team";
                    await emailService.SendEmailAsync(emailValue, subject, Textmsg);

                    ////// administrator
                    subject = "to Sale Department purchases";
                    await emailService.SendEmailAsync("alaa.abusalem94@hotmail.com", subject, $"Client {User.Identity.Name} \r\n" +Textmsg);

                    //warehouse
                    subject = "to warehouse Department  purchases";
                    await emailService.SendEmailAsync("alaa.abusalem94@hotmail.com", subject, $"Client {User.Identity.Name} \r\n" + Textmsg);


                }
            }


        }

		[Authorize(Roles = "Client")]

		public async Task<IActionResult> ConfirmPayment()
        {
			var sessionId = TempData["sessionId"].ToString();

			var service = new SessionService();

			Session session = service.Get(sessionId);

			if (session != null)
			{
				if (session.PaymentStatus.ToLower() == "paid")
				{
					var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Get the user's ID
                    var CartItems = await _shoppingCart.GetShoppingCartItems(userId);
                    Order order = new Order() { 
                    UserId=userId,
                    sessionId=sessionId,
                    Date= DateTime.Now, 
                    IsDeliverd=false,   
                    };

					var newOrder = await _order.Create(order, CartItems);
					await SendOrderEmail(userId);

					await _shoppingCart.EmptyTheCart(userId);
					return View();
				}
			}

			return Content("Not completed suucessfully");
			
        }

		[Authorize(Roles = "Client")]

		public IActionResult FailedPayment()
        {
            return View();
        }

		[Authorize(Roles = "Admin")]

		public async Task<IActionResult> AdminGetOrdersInProcess()
		{
            var orders = await _order.GetOrdersInProcess();
            return View(orders);
		}

		[Authorize(Roles = "Admin")]

		public async Task<IActionResult> AdminGetDeliverdsOrders()
		{
			var orders = await _order.GetDeliverdOrders();
			return View(orders);
		}

		[Authorize(Roles = "Admin")]

		public async Task<IActionResult> AdminGetDeliveredOrderDetails(int orderId)
		{
			var order = await _order.GetOrdersById(orderId);

			ViewBag.Total = await _order.GetTotal(orderId);
			return View(order);
		}
		[Authorize(Roles = "Admin")]

		public async Task<IActionResult> AdminGetOrderInProcessDetails(int orderId)
		{
			var order = await _order.GetOrdersById(orderId);
           
			ViewBag.Total = await _order.GetTotal(orderId);
			return View(order);
		}

		[HttpPost]
		[Authorize(Roles = "Admin")]

		public async Task<IActionResult> AdminGetOrderInProcessDetails(int OrderId, bool isDeliverd)
		{
			var order = await _order.GetOrdersById(OrderId);
			if(order !=null && isDeliverd == true)
			{
				await _order.UpdateOrderStatus(order);
			}
			//ViewBag.Total = await _order.GetTotal(orderId);
			return RedirectToAction("AdminGetOrdersInProcess");
		}

		[Authorize(Roles = "Client")]

        public async Task<IActionResult> ClientGetOrdersInProcess()
        {
			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Get the user's ID

			var orders = await _order.GetOrdersInProcess();
            List<Order> list = new List<Order>();
             
            foreach(var order in orders) 
            {
                if (order.UserId== userId && order.IsDeliverd==false)
                {
                    list.Add(order);
                }
            }
            return View(list);

        }
		[Authorize(Roles = "Client")]
		public async Task<IActionResult> ClientGetDeliveredOrders()
		{
			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Get the user's ID

			var orders = await _order.GetDeliverdOrders();
			List<Order> list = new List<Order>();

			foreach (var order in orders)
			{
				if (order.UserId == userId  )
				{
					if (order.IsDeliverd == true)
					{
						list.Add(order);
					}
				}
			}
			return View(list);

		}
		[Authorize(Roles = "Client")]
		public async Task<IActionResult> ClientGetOrderDetails(int orderId)
		{
			var order = await _order.GetOrdersById(orderId);

			ViewBag.Total = await _order.GetTotal(orderId);
			return View(order);
		}

	}
}
