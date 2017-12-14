using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace MAA.Models
{
    public partial class MortgageApprovalApplication
    {
        [NotMapped]
        public string Message { get; set; }

        /// <summary>
        /// Get application by id
        /// </summary>
        /// <param name="maaContext">DB context</param>
        /// <param name="id">record id</param>
        /// <returns></returns>
        public static MortgageApprovalApplication Get(MaaContext maaContext, long id)
        {
            return maaContext.MortgageApprovalApplication.SingleOrDefault(mortgageApprovalApplication =>
                mortgageApprovalApplication.Id == id);
        }

        public static bool Delete(MaaContext maaContext, long id)
        {
            MortgageApprovalApplication mortgageApprovalApplication =
                maaContext.MortgageApprovalApplication.SingleOrDefault(application =>
                    application.Id == id);
            try
            {
                maaContext.MortgageApprovalApplication.Remove(mortgageApprovalApplication);
                maaContext.SaveChanges();
            }
            catch (Exception exception)
            {
                //TODO: log exception 
                return false;
            }
            return true;
        }
    }
}