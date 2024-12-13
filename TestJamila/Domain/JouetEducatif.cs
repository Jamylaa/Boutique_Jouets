using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TJ.ApplicationCore.Domain
{
    public class JouetEducatif
    {
        [Required]
        [Range(0,10 ,ErrorMessage = " AgeMAx <= 10 ")]
        public int AgeMax   { get; set; }
        public int AgeMin { get; set;}

        [Key]
        public int Code { get; set; }
        public String Description { get; set; }
        public String Libelle { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double Prix { get; set; }

         public ICollection<Commande> Commandes { get; set;

    }
}
