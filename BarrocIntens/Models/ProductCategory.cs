using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrocIntens.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IsEmployeeOnly { get; set; }
        public ObservableCollectionListSource<Product> Products { get; } = new ObservableCollectionListSource<Product>();
    }
}
