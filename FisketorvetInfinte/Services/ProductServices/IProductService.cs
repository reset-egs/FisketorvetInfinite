namespace FisketorvetInfinte.Services.StoreServices
{
    public interface IProductService
    {
        List<Product> AllProducts { get; }
        
        Product FindProduct (int productId);

        void AddProduct (Product product);

        void UpdateProduct (Product product);

        void DeleteProduct (Product product);
    }
}
