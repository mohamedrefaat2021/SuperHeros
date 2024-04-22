using MohamedRefaat_TechnicalTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohamedRefaat_TechnicalTest.Application.DTOs
{
    public class GetSuperherosDto
    {
        public string response { get; set; }
        public string results_for { get; set; }
        public List<SuperheroDto> results { get; set; }
    }
}
