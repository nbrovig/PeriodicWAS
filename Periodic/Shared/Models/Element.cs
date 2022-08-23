using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periodic.Shared.Models
{
    public class Element
    {
        public int? AtomicNumber { get; set; }
        public string? ElementName { get; set; }
        public string? Symbol { get; set; }
        public double? AtomicMass { get; set; }
        public int? NumberofNeutrons { get; set; }
        public int? NumberofProtons { get; set; }
        public int? NumberofElectrons { get; set; } 
        public int? Period { get; set; }    
        public int? Group { get; set; }
        public string? Phase { get; set; }
        public bool? Radioactive { get; set; }
        public bool? Natural { get; set; }
        public bool? Metal { get; set; }
        public bool? Nonmetal { get; set; }
        public bool? Metalloid { get; set; }
        public string? Type { get; set; }
        public double? AtomicRadius { get; set; }
        public double? Electronegativity { get; set; }
        public double? FirstIonization { get; set; }
        public double? Density { get; set; }
        public double? MeltingPoint { get; set; }
        public double? BoilingPoint { get; set; }
        public int? NumberOfIsotopes { get; set; }
        public string? Discoverer { get; set; }
        public int? Year { get; set; }
        public double? SpecificHeat { get; set; }
        public int? NumberofShells { get; set; }
        public int? NumberofValence { get; set; }
    }
}
