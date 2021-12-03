namespace FisketorvetInfinte.Services.StoreServices
{
    public interface IProductService
    {
        Product GetProduct (int productId);

        void AddProduct (Product product);

        void UpdateProduct (Product product);

        void DeleteProduct (int productId);
    }
}
