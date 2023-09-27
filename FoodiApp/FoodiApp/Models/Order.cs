namespace FoodiApp.Models
{
	public class Order
	{
        public int OrderId { get; set; }
		public string UserId { get; set; }
		public string? sessionId { get; set; }
		public DateTime Date { get; set; }
		public bool IsDeliverd { get; set; }
		//NP
		public ApplicationUser? User { get; set; }
		public List<OrderItem>? OrderItems { get; set; }

	}
}
