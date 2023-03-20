using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrocIntens.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string NoteText { get; set; }
        public DateTime Date { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; } = null;
        public int AuthorId { get; set; }
        public User Author { get; set; } = null;
    }
}
