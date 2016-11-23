using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class EmployeeSalaryInfo
    {
        public Guid EmploymentId { get; set; }
        public Guid LevelDetailsId { get; set; }
        public bool IsCurrent { get; set; }
        public PaymentCategory PaymentCategories { get; set; }
    }

    public enum PaymentCategory
    {
    }
}
