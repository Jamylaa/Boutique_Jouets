using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TJ.Infrastructure
{
    public class TJContext : DbContext 
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<JouetEducatif> JouetEducatifs { get; set; }
        public DbSet<JouetEducatifCognitif> JouetEducatifsCognitifs { get; set; }
        public DbSet<JouetEducatifMoteur> JouetEducatifMoteurs { get; set; }
    }
}
