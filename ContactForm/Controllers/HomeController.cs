using Microsoft.AspNetCore.Mvc;

namespace ContactFormApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
            
        }

        [HttpPost]
        public ActionResult SubmitForm(string name, string email, string message)
        {
            //display data into the terminal
            var result = Json(new { success = true, name, email, message });
            Console.WriteLine(result.Value);
            return result;
        }
    }
}