using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using FizzBuzzMainLogic;
using FizzBuzz.NetProject.Models;

namespace FizzBuzz.NetProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFizzBuzzLogic _logic;

        public HomeController(IFizzBuzzLogic logic)
        {
            this._logic = logic;
        }

        public ActionResult Index(FizzBuzzModel model, int? currentPageNumber)
        {
            if(ModelState.IsValid)
            {
                model.ResultList = this._logic.OutputList(model.InputNumber).ToPagedList(currentPageNumber ?? 1, 20);
            }
            return View(model);
        }
    }
}