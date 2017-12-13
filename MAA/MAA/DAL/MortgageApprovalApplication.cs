using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MAA.Models
{
    public partial class MortgageApprovalApplication
    {
        [NotMapped]
        public string Message { get; set; }
    }
}