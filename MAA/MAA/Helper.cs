using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAA
{
    public class Helper
    {
        public static double CalculateMonthlyPayments(double loanAmount, double interestRate, short termOfLoan)
        {
            double annualInterest = interestRate / (100 * 12);
            int n = termOfLoan * 12;

            double tempPow = Math.Pow(1 + annualInterest, -n);
            double monthlyPayment = (loanAmount * annualInterest) / (1 - tempPow);
            return monthlyPayment;
        }

        public static decimal Truncate2DecimalPoints(decimal amount)
        {
            return Math.Truncate(100 * amount) / 100;
        }
    }
}
