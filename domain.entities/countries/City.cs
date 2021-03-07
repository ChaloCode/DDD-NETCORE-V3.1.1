using System;

namespace domain.entities.countries
{
    public class City
    {
        public int Id {get;set;}
        public int SateId {get;set;}
        public string Name {get;set;}
        public State Sate {get;set;}

    }
}
