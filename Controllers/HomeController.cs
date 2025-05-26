using Microsoft.AspNetCore.Mvc;

namespace SurveyPortalUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Login() => View();
        public IActionResult Register() => View();
        public IActionResult Profile() => View();

        public IActionResult Surveys() => View();
        public IActionResult MySurveys() => View();
        public IActionResult AllSurveys() => View();

        public IActionResult Questions(int surveyId) => View();
        public IActionResult SurveyResponses(int surveyId) => View();
        public IActionResult MyResponses() => View();

        public IActionResult Users() => View();
        public IActionResult UserDetail(int id) => View();
        public IActionResult Roles(int userId) => View();
    }
}