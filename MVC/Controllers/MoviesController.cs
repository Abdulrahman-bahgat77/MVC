using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult GetMovie(int id,string name )
        {
            return Content($"Movie Id={id},name={name}");
        }
        //Action Parameter binding
        //1-Form
        //2-Segment
        //3-Query string
        //4-file
        public IActionResult Index()
        {
            ContentResult result = new ContentResult();
             result.Content= "Hello Index";
            return result;
        }

        public IActionResult Test()
        {
            RedirectResult result = new RedirectResult("https://localhost:44356/Movies/index");
            return result;
        }
    }
}
