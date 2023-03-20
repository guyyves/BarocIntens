using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrocIntens.Models
{
    public class LeaseContract
    {
        public int Id { get; set; }
        public bool Monthly { get; set; } // Periodically if false
        public int ProductId { get; set; }
        public Product Product { get; set; } = null;
        public int CompanyId { get; set; }
        public Company Company { get; set; } = null;
        public DateTime StartDate { get; set; }
        public int Periods { get; set; }


    }
}
