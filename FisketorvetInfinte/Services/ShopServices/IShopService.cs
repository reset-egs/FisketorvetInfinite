namespace FisketorvetInfinte.Services.ShopServices
{
    public interface IShopService
    {
        public Shop GetShop(int id);

        void AddShop(Shop shop);

        public void UpdateShop(Shop shop);

        void DeleteShop(int id);
    }
}
