namespace FisketorvetInfinte.Models
{
    public abstract class OrderStatus
    {
        public enum OrderStatusEnum
        {
            New,
            Packed,
            Dispatched,
            Delivered,
            Closed
        }
    }
}
