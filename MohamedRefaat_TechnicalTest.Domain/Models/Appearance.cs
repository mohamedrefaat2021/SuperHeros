using MohamedRefaat_TechnicalTest.Domain.Models.DomainMetadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohamedRefaat_TechnicalTest.Domain.Models
{
    public class Appearance : BaseEntity<int>
    {
       
        public string Gender { get; set; }
        public string Race { get; set; }
        public List<string> Height { get; set; }
        public List<string> Weight { get; set; }
        public string Eye_color { get; set; }
        public string Hair_color { get; set; }

        public int SuperheroId { get; set; }
    }
}
