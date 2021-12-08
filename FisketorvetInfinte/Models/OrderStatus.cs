namespace FisketorvetInfinte.Models
{
    //Not used in code currently
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