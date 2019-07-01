using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore2.Models;

namespace SportsStore2.Controllers
{
    public class OrderController : Controller
    { 
        private Cart cart;

        public ViewResult Checkout() => View(new Order());
    }
}