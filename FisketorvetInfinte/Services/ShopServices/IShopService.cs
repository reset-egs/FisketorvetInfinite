namespace FisketorvetInfinte.Services.ShopServices
{
    public interface IShopService
    {
        List<Shop> AllShops { get; }
        public Shop FindShop(int id);

        void AddShop(Shop shop);

        public void UpdateShop(Shop shop);

        void DeleteShop(Shop shop);
    }
}
