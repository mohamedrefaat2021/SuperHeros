using MohamedRefaat_TechnicalTest.Domain.Models.DomainMetadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohamedRefaat_TechnicalTest.Domain.Models
{
    public class Biography : BaseEntity<int>
    {
        
        public string Full_name { get; set; }
        public string Alter_egos { get; set; }
        public List<string> Aliases { get; set; }
        public string Place_of_birth { get; set; }
        public string First_appearance { get; set; }
        public string Publisher { get; set; }
        public string Alignment { get; set; }

        public int SuperheroId { get; set; }
    }
}
