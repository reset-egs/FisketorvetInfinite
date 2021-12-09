namespace FisketorvetInfinte.Services.ShopServices
{
    public class ShopService : IShopService
    {
        public List<Shop> AllShops { get; } = JsonFileShopService.ReadJson("./Data/Shop.json");

        public Shop FindShop (int shopId)
        {
            foreach (var shop in AllShops)
            {
                if (shop.ShopId == shopId)
                {
                    return shop;
                }
            }
            return null;
        }

        public void AddShop (Shop shop)
        {
            shop.ShopId = AllShops.Count + 1;
            AllShops.Add(shop);
            JsonFileShopService.WriteToJson(AllShops, "./Data/Shop.json");
        }

        public void UpdateShop(Shop shop)
        {
            if (shop != null)
            {
                foreach (var s in AllShops)
                {
                    if (s.ShopId == shop.ShopId)
                    {
                        s.Name = shop.Name;
                        s.Category = shop.Category;
                        s.WorkHour = shop.WorkHour;
                        s.PhoneNumber = shop.PhoneNumber;
                        s.Description = shop.Description;
                    }
                }
            }
            JsonFileShopService.WriteToJson(AllShops, "./Data/Shop.json");
        }

        public void DeleteShop(Shop shop)
        {
            if (shop != null)
            {
                foreach (var s in AllShops)
                {
                    if (shop.ShopId == s.ShopId)
                    {
                        AllShops.Remove(shop);
                        break;
                    }
                }
            }
            JsonFileShopService.WriteToJson(AllShops, "./Data/Shop.json");
        }
    }
}

