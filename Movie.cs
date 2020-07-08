using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Movie : Media
    {
       
        public float RunTime { get; set; }

        public Movie(int runtime,string title, string mediatype) :base(title,"movie")
        {
            RunTime = runtime;

        }


    }
}
