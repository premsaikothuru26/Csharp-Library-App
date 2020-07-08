using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{

    class Book : Media
    {
       
        public int Count { get; set; }
        public Book(int pagecount,string title,string mediatype) : base(title,mediatype)
        {
            Count = pagecount;

        }
    }
}
