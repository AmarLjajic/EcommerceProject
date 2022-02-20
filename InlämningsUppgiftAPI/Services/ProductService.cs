using InlämningsUppgiftAPI.Models;

namespace InlämningsUppgiftAPI.Services
{
    public interface IProductService
    {
        void Create();
        IEnumerable<ProductModel> Read();
        ProductModel Read(int id);
        void Update();
        void Delete();

    }

    public class ProductService
    {
    }
}
