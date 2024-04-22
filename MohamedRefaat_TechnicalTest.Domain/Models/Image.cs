using MohamedRefaat_TechnicalTest.Domain.Models.DomainMetadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohamedRefaat_TechnicalTest.Domain.Models
{
    public class Image : BaseEntity<int>
    {
        
        public string Url { get; set; }

        public int SuperheroId { get; set; }
    }
}
