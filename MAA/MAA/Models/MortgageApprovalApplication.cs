using System;
using System.Collections.Generic;

namespace MAA.Models
{
    public partial class MortgageApprovalApplication
    {
        public long Id { get; set; }
        public decimal ValueOfHome { get; set; }
        public decimal LoanAmount { get; set; }
        public short TermOfLoan { get; set; }
        public long InterestId { get; set; }
        public decimal MonthlyRepayment { get; set; }
        public DateTime CreationDatetime { get; set; }
    }
}
