using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UiModels
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
        public Author Author { get; set; }
    }
}
