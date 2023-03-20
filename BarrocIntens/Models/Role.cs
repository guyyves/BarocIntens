using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrocIntens.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ObservableCollectionListSource<User> Users { get; } = new ObservableCollectionListSource<User>();
    }
}
