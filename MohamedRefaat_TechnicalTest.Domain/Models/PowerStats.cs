using MohamedRefaat_TechnicalTest.Domain.Models.DomainMetadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohamedRefaat_TechnicalTest.Domain.Models
{
    public class PowerStats : BaseEntity<int>
    {
      
        public int Intelligence { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Durability { get; set; }
        public int Power { get; set; }
        public int Combat { get; set; }

        public int SuperheroId { get; set; }
    }
}
