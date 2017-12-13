using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MAA.CustomValidation;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MAA.Models
{
    public partial class MortgageApprovalApplication
    {
        public long Id { get; set; }
        [Range(1, 500000)]
        public decimal ValueOfHome { get; set; }
        [Loan("ValueOfHome", ErrorMessage = "The loan amount is numeric only and cannot be less than 60% of the value of the home or more than 80% of the value of the home.")]
        public decimal LoanAmount { get; set; }
        [Range(10, 25)]
        public short TermOfLoan { get; set; }
        public long InterestId { get; set; }
        public decimal MonthlyRepayment { get; set; }
        public DateTime CreationDatetime { get; set; }
    }
}
