using FoodiApp.Data;
using FoodiApp.Models.DTOs;
using FoodiApp.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodiApp.Models.Services
{
	public class OrderService : IOrder
	{
		private readonly FoodieDBContext _context;

		public OrderService(FoodieDBContext context)
		{
			_context = context;
		}
		public async Task<Order> Create(Order order, List<CartItem> cartItems)
		{
			await _context.Orders.AddAsync(order);
			await _context.SaveChangesAsync();

			foreach (var cartItem in cartItems)
			{
				await _context.OrderItems.AddAsync(new OrderItem
				{
					OrderId = order.OrderId,
					FoodItemId = cartItem.FoodItemId,
					Quantity = cartItem.Quantity,
					Price = cartItem.foodItem.Price
				});
			}
			await _context.SaveChangesAsync();
			return order;
		}

		public async Task<List<Order>> GetDeliverdOrders()
		{
			var orders = await _context.Orders.Where(order => order.IsDeliverd == true).OrderByDescending(order => order.Date).ToListAsync();
			return orders;
		}

		public async Task<Order> GetOrdersById(int orderId)
		{
			var order = await _context.Orders.Include(order=>order.User)
				.Include(order=> order.OrderItems)
				.ThenInclude(orderItem=> orderItem.foodItem)
				.FirstOrDefaultAsync(order => order.OrderId == orderId);
			if (order == null) return null;
			return order;
		}

		public async Task<List<Order>> GetOrdersInProcess()
		{
			var orders = await _context.Orders.Where(order=> order.IsDeliverd==false).OrderByDescending(order=>order.Date).ToListAsync();
			return orders;
		}

		public async Task< float> GetTotal(int orderId)
		{
			float Total = 0;
			var order = await GetOrdersById(orderId);
			if(order.OrderItems!= null)
			{
				foreach(var item in order.OrderItems)
				{
					Total = (float)(Total + (item.Quantity * item.Price));

				}

			}
			return Total;
		}

		public async Task UpdateOrderStatus(Order order)
		{
			var orderToUpdate = await _context.Orders.FindAsync(order.OrderId);
			if (orderToUpdate != null)
			{
				orderToUpdate.IsDeliverd = true;
				_context.Entry(orderToUpdate).State = EntityState.Modified;
				await _context.SaveChangesAsync();
			}
		}
	}
}
