using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazzorDbzPersonagem.Models
{
    public class Transformation
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string ki { get; set; }
        public object deletedAt { get; set; }
    }
}