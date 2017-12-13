using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MAA.Models;

namespace MAA.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Application([FromServices] MaaContext maaContext)
        {
            ViewData["Message"] = "Application";
            ViewBag.VBInterestList = Interest.GetAll(maaContext);
            return View();
        }

        public IActionResult Calculate([FromServices] MaaContext maaContext, MortgageApprovalApplication mortgageApprovalApplication)
        {
            Dictionary<long, double> interestDictionary = Interest.GetAll(maaContext);
            ViewBag.VBInterestList = interestDictionary;
            if (!interestDictionary.ContainsKey(mortgageApprovalApplication.InterestId))
            {
                return View("Application");
            }
            double interestRate = interestDictionary[mortgageApprovalApplication.InterestId];

            double monthlyPayment = Helper.CalculateMonthlyPayments(
                (double)mortgageApprovalApplication.LoanAmount,
                interestRate,
                mortgageApprovalApplication.TermOfLoan);

            mortgageApprovalApplication.MonthlyRepayment = Helper.Truncate2DecimalPoints((decimal)monthlyPayment);

            return View("Application", mortgageApprovalApplication);
        }        

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
