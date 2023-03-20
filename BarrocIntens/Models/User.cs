using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrocIntens.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool isManager { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; } = null;
        public ObservableCollectionListSource<Note> Notes { get; } = new ObservableCollectionListSource<Note>();
        public ObservableCollectionListSource<MaintenanceAppointment> MaintenanceAppointments { get; } = new ObservableCollectionListSource<MaintenanceAppointment>();
    }
}
