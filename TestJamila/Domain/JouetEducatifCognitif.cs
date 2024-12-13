using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TJ.ApplicationCore.Domain
{
    public class JouetEducatifCognitif : JouetEducatif
    {
        public int NiveauDifficulte { get; set; }
        public String Objectif {  get; set; }

    }
}
