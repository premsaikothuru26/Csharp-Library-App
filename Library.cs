using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{

    static class Library
    {

        public static List<Media> MediaList = new List<Media>()
        {
             new Book(22,"Tales","Book"),
             new Book(24,"Rise","Book"),
             new Book(202,"Light","Book"),
             new Book(222,"Sky","Book"),
             new Book(272,"Amaze","Book"),

              new Movie(2,"Saaho","Movie"),
              new Movie(3,"Baahubali","Movie"),
              new Movie(2,"Jack Ryan","Movie"),
              new Movie(2,"John Wick","Movie"),
              new Movie(2,"SyeRaa","Movie"),

              new Magazine(001,"StarDust",15,"Magazine"),
              new Magazine(007,"Forbes",16,"Magazine"),
              new Magazine(005,"Vogue",20,"Magazine"),
              new Magazine(041,"NewYork Times",22,"Magazine"),
              new Magazine(501,"India Times",10,"Magazine"),

            };


        public static List<LibraryMember> libraryMembers = new List<LibraryMember>()
        {
            new LibraryMember("Arif"),
            new LibraryMember("Sai" ),
            new LibraryMember("Preamsai" ),
            new LibraryMember("Jared")

        };

        


    }
}
