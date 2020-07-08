using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class LibraryMember
    {
       
        public static List<Media> CurrentlyBorrowed = new List<Media>();
      
        public string Name { get; private set; }


        public  LibraryMember( string libraryMembers)
        {
            Name = libraryMembers;
        }

        
    }
}
