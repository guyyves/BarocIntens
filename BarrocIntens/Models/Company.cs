using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrocIntens.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string City { get; set; }
        public string CountryCode { get; set; }
        public DateTime? BkrCheckedAt { get; set; } = null;
        public string ContactName { get; set; }
        public string ContactPhoneNumber { get; set; }
        public ObservableCollectionListSource<Note> Notes { get; } = new ObservableCollectionListSource<Note>();
        public ObservableCollectionListSource<MaintenanceAppointment> MaintenanceAppointments { get; } = new ObservableCollectionListSource<MaintenanceAppointment>();
        public ObservableCollectionListSource<CustomInvoice> CustomInvoices { get; } = new ObservableCollectionListSource<CustomInvoice>();
        public ObservableCollectionListSource<LeaseContract> LeaseContracts { get; } = new ObservableCollectionListSource<LeaseContract>();


        public override string ToString()
        {
            return Name;
        }
    }
}
