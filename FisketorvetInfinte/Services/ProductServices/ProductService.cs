namespace FisketorvetInfinte.Services.StoreServices
{
    public class ProductService : IProductService
    {
        public List<Product> AllProducts { get; } = JsonFileProductService.ReadJson("./Data/Products.json");

        public Product FindProduct(int productId)
        {
            foreach (Product product in AllProducts)
            {
                if (product.ProductId == productId)
                {
                    return product;
                }
            }
            return null;
        }

        public void AddProduct(Product product)
        {
            AllProducts.Add(product);
            JsonFileProductService.WriteToJson(AllProducts, "./Data/Products.json");
        }

        public void UpdateProduct(Product product)
        {
            if (product != null)
            {
                foreach(var p in AllProducts)
                {
                    if(p.ProductId == product.ProductId)
                    {
                        p.ProductName = product.ProductName;
                        p.Price = product.Price;
                        p.Size = product.Size;
                        p.Colour = product.Colour;
                    }
                }
            }
            JsonFileProductService.WriteToJson(AllProducts, "./Data/Products.json");
        }

        public void DeleteProduct(Product product)
        {
            if (product != null)
            {
                foreach(var p in AllProducts)
                {
                    if(product.ProductId == p.ProductId)
                    {
                        AllProducts.Remove(product);
                        break;
                    }
                }
            }
            JsonFileProductService.WriteToJson(AllProducts, "./Data/Products.json");
        }
    }
}
