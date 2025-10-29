using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazzorDbzPersonagem.Models
{
    public class Personagem
    {
        public int id { get; set; }
        public string name { get; set; }
        public string ki { get; set; }
        public string maxKi { get; set; }
        public string race { get; set; }
        public string gender { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public string affiliation { get; set; }
        public object deletedAt { get; set; }
        public OriginPlanet originPlanet { get; set; }
        public List<Transformation> transformations { get; set; }
    }
}