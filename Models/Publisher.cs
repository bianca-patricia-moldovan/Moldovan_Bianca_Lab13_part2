using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moldovan_Bianca_Lab8.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        public string PublisherName { get; set; }
        public ICollection<Book> Books { get; set; } //navigation property
    }
}
