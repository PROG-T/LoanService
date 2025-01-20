using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanDomain.Entities
{
    public class Loan
    {
        public long Id { get; set; }
        public string BorrowerName { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; } // Pending, Approved, Rejected
        public DateTime ApplicationDate { get; set; }
    }
}
