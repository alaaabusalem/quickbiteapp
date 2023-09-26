namespace FoodiApp.Models.DTOs
{
    public class SummaryDTO
    {
        public List<CartItem> CartItems { get; set; }  
        public  UserDto User { get; set; }
		public float Total {  get; set; }  
    }
}
