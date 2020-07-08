using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
   
    abstract class Media
    { 
        public string Title { get; private set; }
        public string Mediatype { get; private set; }
        public int Serialnumber { get; protected set; }
        public int NumberOfTimeslent { get;  set; } = 0;

        public bool Availability { get;  set; } = true;

        public string libraryMembers { get;  set; }

       

        public Media(string title,string mediatype)
        {
            Title = title;
            Mediatype = mediatype;
           
        }

    }

   
}
