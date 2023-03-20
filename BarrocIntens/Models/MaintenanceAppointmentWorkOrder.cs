using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrocIntens.Models
{
    public class MaintenanceAppointmentWorkOrder
    {
        public int Id { get; set; }
        public string Description { get; set; } = null;
        public ObservableCollectionListSource<MaintenanceAppointmentWorkOrderProduct> MaintenanceAppointmentWorkOrderProducts { get; } = new ObservableCollectionListSource<MaintenanceAppointmentWorkOrderProduct>();
        public ObservableCollectionListSource<MaintenanceAppointment> MaintenanceAppointments { get; } = new ObservableCollectionListSource<MaintenanceAppointment>();
    }
}
