using MohamedRefaat_TechnicalTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohamedRefaat_TechnicalTest.Application.DTOs
{
    public class SuperheroDto
    {
     
        public string name { get; set; }
        public PowerStatsDto powerstats { get; set; }
        public BiographyDto biography { get; set; }
        public AppearanceDto appearance { get; set; }
        public WorkDto work { get; set; }
        public ConnectionsDto connections { get; set; }
        public ImageDto image { get; set; }
    }
}
