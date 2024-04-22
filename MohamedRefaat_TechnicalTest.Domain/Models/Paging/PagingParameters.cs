using System;
using System.Collections.Generic;
using System.Text;

namespace MohamedRefaat_TechnicalTest.Domain.Models.Paging
{
    public class PagingParameters
    {
        
        public int PageNumber { get; set; } = 1;
        private int _pageSize = 10;
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize =  value;
            }
        }
    }
}
