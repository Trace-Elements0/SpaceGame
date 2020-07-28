using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static ClassLibrary.Enumerations;

namespace ClassLibrary
{
    public class Planets
    {
        public PlanetTypes PlanetType { get; set; }
        public List<Alien> Aliens { get; set; }

        //public Planet(PlanetTypes types)
        //{
        //    this.PlanetType = types;
        //    AssignPlanet(types);
        //}

        //private void AssignPlanet(PlanetTypes types)
        //{
        //    switch (types)
        //    {
        //        //case PlanetTypes.Musket:
        //        //    this.HitPoints = 4;
        //        //    this.Range = 6;
        //        //    this.Rank = 2;
        //        //    break;

        //        //case PlanetTypes.Sword:
        //        //    this.HitPoints = 6;
        //        //    this.Range = 2;
        //        //    this.Rank = 3;
        //        //    break;
        //    }
        //}

    }
}

    
