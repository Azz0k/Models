using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Page<T>
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public List<T> Records { get; set; }
        public int TotalPages { get; set; }
        
    }
}
