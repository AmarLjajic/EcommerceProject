using Microsoft.AspNetCore.Mvc;
using Inlämnmingsuppgift_ASP.Models.ViewModels;

namespace Inlämnmingsuppgift_ASP.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<ProductViewModel> product = null;
            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44303/api/Product");
                var responseTask = client.GetAsync("product");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsAsync<IList<ProductViewModel>>();
                    readJob.Wait();
                    product = readJob.Result;
                }
                else
                {
                    product = Enumerable.Empty<ProductViewModel>();
                    ModelState.AddModelError(String.Empty, "Server error occured. Please contact admin for help");
                }

            }
            return View(product);
        }
    }
}
