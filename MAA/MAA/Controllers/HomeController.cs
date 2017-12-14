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
        public IActionResult Index([FromServices] MaaContext maaContext)
        {
            Dictionary<long, double> interestDictionary = Interest.GetAll(maaContext);
            ViewBag.VBInterestList = interestDictionary;
            return View("Application");
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

        public IActionResult Submit([FromServices] MaaContext maaContext, MortgageApprovalApplication mortgageApprovalApplication)
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

            if (mortgageApprovalApplication.MonthlyRepayment == Helper.Truncate2DecimalPoints((decimal)monthlyPayment))
            {
                //submit here
                maaContext.MortgageApprovalApplication.Add(mortgageApprovalApplication);
                maaContext.SaveChanges();
                //Reset model and set message
                mortgageApprovalApplication = new MortgageApprovalApplication
                {
                    Message =
                        $"Quote No {mortgageApprovalApplication.Id}   " +
                        $"(Value of Home = {mortgageApprovalApplication.ValueOfHome}; " +
                        $"Loan Amount = {mortgageApprovalApplication.LoanAmount}; " +
                        $"Term of Loan = {mortgageApprovalApplication.TermOfLoan}; " +
                        $"Interest on Loan = {interestRate}; " +
                        $"Monthly Repayment = {mortgageApprovalApplication.MonthlyRepayment})"
                };
                ModelState.Clear();
            }
            else
            {
                mortgageApprovalApplication.MonthlyRepayment = Helper.Truncate2DecimalPoints((decimal)monthlyPayment);
                mortgageApprovalApplication.Message = "Monthly Repayment recalculated, please submit again";
            }

            return View("Application", mortgageApprovalApplication);
        }

        public IActionResult List([FromServices] MaaContext maaContext)
        {
            var applications = from application in maaContext.MortgageApprovalApplication
                orderby application.Id descending
                select application;

            return View(applications.ToList());
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Details([FromServices] MaaContext maaContext, long id)
        {
            MortgageApprovalApplication mortgageApprovalApplication = MortgageApprovalApplication.Get(maaContext, id);
            //return View(mortgageApprovalApplication);
            return View(mortgageApprovalApplication);            
        }

        public IActionResult Delete([FromServices] MaaContext maaContext, long id)
        {
            MortgageApprovalApplication.Delete(maaContext, id);
            //return List(maaContext);
            return RedirectToAction("List","Home");
        }
    }
}
