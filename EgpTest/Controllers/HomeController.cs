using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EgpTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
       [HttpGet]
        public ActionResult userPost()
        {
            return View();
        }

       [HttpPost]
        public ActionResult userPost(string userinput, string response, FormCollection input)
        {
            //var letssee = input["userinput"];
            var tione = userinput;
            ViewBag.InputNumber = tione;
            if (tione.Length == 0)
            {
                ViewBag.InputNumber = "Please enter a number";
            }
            else
            {
                try
                {
                    for(int i = 0; i< tione.Length; i++)
                    {
                        char theNumber = tione[i];
                        String left_result = tione.Substring(0, i);
                        String right_result = tione.Substring(i + 1);
                        String result = left_result + right_result;
                        var FinalOutput = userPost(result, response + theNumber,input);
                        
                        ViewBag.Maresults = FinalOutput;
                    }
                    return View();
                }
                catch(Exception)
                {

                }
                                 
            }
            
            //int userMaxRes = userinput.Max();
            //int userMinresult = userinput.Min();

            return View();
        }
        //[HttpGet]
        //public ActionResult userPost(string userinput)
        //{
        //    int userNumber = userinput.Max();
            

        //    return View();
        //}

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}