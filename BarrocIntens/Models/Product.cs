using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrocIntens.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; } = null;
        public decimal Price { get; set; }
        public int Stock { get; set; } = 0;
        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; } = null;
        public bool isPart { get; set; }
        public bool IsLeasable { get; set; } = false;
        public ObservableCollectionListSource<CustomInvoiceProduct> CustomInvoiceProducts { get; } = new ObservableCollectionListSource<CustomInvoiceProduct>();
        public ObservableCollectionListSource<MaintenanceAppointmentWorkOrderProduct> MaintenanceAppointmentWorkOrderProducts { get; } = new ObservableCollectionListSource<MaintenanceAppointmentWorkOrderProduct>();
        public ObservableCollectionListSource<LeaseContract> LeaseContracts { get; } = new ObservableCollectionListSource<LeaseContract>();


        public override string ToString()
        {
            double doublePrice = (double)Price;
            return $"{Name} (€{doublePrice})";
        }
    }
