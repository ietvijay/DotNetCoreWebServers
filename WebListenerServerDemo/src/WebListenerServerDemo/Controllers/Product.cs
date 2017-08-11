using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebListenerServerDemo.Controllers
{
    public class Product: Controller
    {
        [HttpGet]
        public  JsonResult List()
        {
            List<string> products = new List<string>();
            products.Add("apple");
            products.Add("google");
            products.Add("microsoft");
            return  Json(products);
        }

           
    }
}
