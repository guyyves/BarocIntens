using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrocIntens.Models
{
    public class MaintenanceAppointmentWorkOrderProduct
    {
        public int Id { get; set; }
        public int MaintenanceAppointmentWorkOrderId { get; set; }
        public MaintenanceAppointmentWorkOrder MaintenanceAppointmentWorkOrder { get; set; } = null;
        public int ProductId { get; set; }
        public Product Product { get; set; } = null;
        public int Amount { get; set; }
    }
}
