using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrocIntens.Models
{
    public class CustomInvoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime PaidAt { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; } = null;
        public ObservableCollectionListSource<CustomInvoiceProduct> CustomInvoiceProducts { get; } = new ObservableCollectionListSource<CustomInvoiceProduct>();
    }
}
