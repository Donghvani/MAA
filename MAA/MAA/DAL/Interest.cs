using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAA.Models
{
    public partial class Interest
    {
        /// <summary>
        /// Get all interest rates in the Dictionary object,
        /// where Key = interest.Id and Value = interest.Rate
        /// </summary>
        /// <param name="maaContext"></param>
        public static Dictionary<long, double> GetAll(MaaContext maaContext)
        {
            //Commented code for testing purpose, when there is no DB connection
            //return new Dictionary<long, double>
            //{
            //    {1, 1.5 }, {2, 3.5 }, {3, 6 },
            //};
            IQueryable<Interest> rtn = from interest in maaContext.Interest select interest;
            return rtn.ToDictionary(x => x.Id, x => x.Rate);
        }
    }
}
