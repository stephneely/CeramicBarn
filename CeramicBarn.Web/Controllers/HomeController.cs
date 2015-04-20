using CeramicBarn.DataLayer.Repositories;
using CeramicBarn.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CeramicBarn.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductRepository _repository;

        public HomeController()
        {
            _repository = new ProductRepository();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var products = _repository.GetAll();
            return View(products);
        }
    }
}