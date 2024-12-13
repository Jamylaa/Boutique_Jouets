using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TJ.ApplicationCore.Domain
{
    public class Client
    {
        public string Adresse { get; set; }
       
        [Key]
        public string Cin { get; set; }
        public string Email { get; set; }
        public string Nom { get; set; }
        [Required]
        [StringLength(8,MinimumLength=8,
            ErrorMessage="Le Numero de telephone est fixé à 8 chiffres ")]
        public int NuTelephone { get; set; }
        public string Prenom { get; set; }


        public ICollection<Commande>commandes { get; set; }

        public override string ToString()
        {
            return
                "Adresse : " + Adresse
                + "Cin : " + Cin
                + "Email : " + Email
                + "Nom : " + Nom
                + "NuTelephone : " + NuTelephone
                + "Prenom : " + Prenom;
        }
    }
}
