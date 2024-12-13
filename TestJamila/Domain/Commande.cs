using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TJ.ApplicationCore.Domain
{
    public class Commande
    {
        public DateTime DateCommande { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double MontantTotal {  get; set; }
    
    public Client Client { get; set; }
     public JouetEducatif JouetEducatif { get; set; }

    
    }
}
