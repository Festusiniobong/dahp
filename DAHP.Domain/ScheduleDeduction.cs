using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Domain
{
    public class ScheduleDeduction
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int DeductionAmount { get; set; }
    }
}
