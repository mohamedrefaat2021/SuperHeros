using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohamedRefaat_TechnicalTest.Application.DTOs
{
    public class AppearanceDto
    {
        public string Gender { get; set; }
        public string Race { get; set; }
        public List<string> Height { get; set; }
        public List<string> Weight { get; set; }
        public string Eye_color { get; set; }
        public string Hair_color { get; set; }
    }
}
