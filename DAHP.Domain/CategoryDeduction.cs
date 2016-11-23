using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class CategoryDeduction
    {
        public Guid Id { get; set; }
        public DateTime DeductionDate { get; set; }
        public int DeductionAmount { get; set; }
 
    }
}
