using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrocIntens.Models
{
    public class MaintenanceAppointment
    {
        public int Id { get; set; }
        public string Remark { get; set; }
        public DateTime? NextAppointment { get; set; } = null;
        public DateTime? LastAppointment { get; set; } = null;
        public bool IsRoutine { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; } = null;
        public int WorkerId { get; set; }
        public User Worker { get; set; } = null;
        public int? MaintenanceAppointmentWorkOrderId { get; set; } = null;
        public MaintenanceAppointmentWorkOrder MaintenanceAppointmentWorkOrder { get; set; } = null;
    }
}
