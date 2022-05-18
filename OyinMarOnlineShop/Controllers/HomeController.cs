using DataBase.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OyinMarOnlineShop.Models;
using OyinMarOnlineShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OyinMarOnlineShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        /// <summary>
        /// Returns a view of Top deal products
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                TopDealProducts = _productRepository.TopDealProducts
            };

            return View(homeViewModel);
        }
    }
}
