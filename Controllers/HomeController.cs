﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;  
using nestedviewtest.Models;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
namespace nestedviewtest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult GetValveComponents([DataSourceRequest] DataSourceRequest request)
        {
            var data = new List<ValvesViewModel>();
            ValvesViewModel vcvm = new ValvesViewModel();
            vcvm.CalculatedCost=100;
            vcvm.EquipmentNumber="A";
            vcvm.ValveModel="26AD";
            data.Add(vcvm);
            return Json(data.ToDataSourceResult(request));
        }


		[AcceptVerbs("Post")]
		public ActionResult EditingInline_Update([DataSourceRequest] DataSourceRequest request, ValvesViewModel product)
        {
            if (product != null && ModelState.IsValid)
            {
                //request.Update(product);
            }            

            return Json(new[]{product}.ToDataSourceResult(request,ModelState));
        }

    }
}
