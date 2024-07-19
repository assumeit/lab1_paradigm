using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetcoreapp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (Request.Method.Equals("POST", System.StringComparison.OrdinalIgnoreCase))
            {
                if (Request.Form["ADD"] == "+")
                {
                    ViewData["Result"] = double.Parse(Request.Form["num1"]) + double.Parse(Request.Form["num2"]);
                }
                if (Request.Form["Minus"] == "-")
                {
                    ViewData["Result"] = double.Parse(Request.Form["num1"]) - double.Parse(Request.Form["num2"]);
                }
                if (Request.Form["SQR"] == "SQR")
                {
                    ViewData["Result"] = double.Parse(Request.Form["num1"]) * double.Parse(Request.Form["num1"]);
                }
                if (Request.Form["MULT"] == "*")
                {
                    ViewData["Result"] = double.Parse(Request.Form["num1"]) * double.Parse(Request.Form["num2"]);
                }
                if (Request.Form["PWR"] == "PWR")
                {
                    ViewData["Result"] = Math.Pow(double.Parse(Request.Form["num1"]), double.Parse(Request.Form["num2"]));
                }
                if (Request.Form["DIVIDE"] == "/")
                {
                    double num2 = double.Parse(Request.Form["num2"]);
                    if (num2 != 0)
                    {
                        ViewData["Result"] = double.Parse(Request.Form["num1"]) / num2;
                    }
                    else
                    {
                        ViewData["Result"] = "the number must not be zero";
                    }
                }
                if (Request.Form["Cube"] == "Cube")
                {
                    ViewData["Result"] = double.Parse(Request.Form["num1"]) * double.Parse(Request.Form["num1"]) * double.Parse(Request.Form["num1"]);
                }
            }
        }
    }
}
