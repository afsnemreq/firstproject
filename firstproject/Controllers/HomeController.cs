using firstproject.Models;
using firstproject.service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace firstproject.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly TransactionService _transactionService;

		public HomeController(ILogger<HomeController> logger,TransactionService transactionService)
		{
			_logger = logger;
			_transactionService = transactionService;
		}

	
		
		//sectionsJsonDataUpdate += `{"sectionName":"${$(this).find("input[name='sectionName']").val()}","mobileSlides":[` + mobileJson.substr(0, mobileJson.length - 1) + `],"order":"${$(this).find("input[name='order']").val()}","slides":[` + json.substr(0, json.length - 1) + "]},";

		public IActionResult Privacy()
		{
			return View();
		}
		
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		[HttpPost]
		public JsonResult InsertUpdate([FromBody] Transaction transaction) {

			_transactionService.Add(transaction);
			return Json("OK");
		}
		public ActionResult Index()
        {
			return View(_transactionService.GetTransactions());

        }

		public ActionResult ekle()
        {
			return View();
        }
	}
}
