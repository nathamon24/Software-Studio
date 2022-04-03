using Microsoft.AspNetCore.Mvc;

namespace _62010285.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("{path}/{func}/{value}/{btn}")]
        public IActionResult Calculate(string value, string btn)
        {
            Console.Write(value, btn);
       
            if (btn == "=")
            {
                string[] list = value.Split(" ");
                var result = float.Parse(list[0]);
                
                if (list[1] == "+")
                {
                    result += float.Parse(list[2]);
                }
                else if (list[1] == "-")
                {
                    result -= float.Parse(list[2]);
                }
                else if (list[1] == "*")
                {
                    result *= float.Parse(list[2]);
                }
                else if (list[1] == "÷")
                {
                    result /= float.Parse(list[2]);
                }

                return Content(result.ToString(),"text/plain", System.Text.Encoding.UTF8);
            }
            else if (btn == "C")
            {
                return Content("0", "text/plain", System.Text.Encoding.UTF8); 
            }
            else
            {
                var str = btn;
         
                if(btn == "+" || btn == "-" || btn == "*" || btn == "÷")
                {
                    str = " " + str + " ";
                }
                str = value + str;
                return Content(str, "text/plain", System.Text.Encoding.UTF8);
            }

            

        }



    }
}