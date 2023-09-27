using FoodiApp.Models.DTOs;

namespace FoodiApp.Models.Interfaces
{
	public interface IOrder
	{
		Task<Order> Create(Order order, List<CartItem> cartItems);
		Task<List<Order>> GetOrdersInProcess();

		Task<Order> GetOrderInProcessById(int orderId);
		Task <float> GetTotal(int orderId);

	}

}
