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
                        product.ProductId = p.ProductId;
                        product.Price = p.Price;
                        product.Size = p.Size;
                        product.Colour = p.Colour;
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
                        AllProducts.Remove(p);
                    }
                }
            }
            JsonFileProductService.WriteToJson(AllProducts, ".Data/Products.json");
        }
    }
}
