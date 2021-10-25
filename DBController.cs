
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MVCDemoAppMastek.Models;

namespace MVCDemoAppMastek.Controllers
{
    public class DBController : Controller
    {
        ProductDataStore datastore; 
        public DBController(ProductDataStore store)
        {
            datastore = store;
        }
        public IActionResult Index()
        {
            List<Product> products = datastore.GetProducts();
            return View(products);
        }
    }
}

