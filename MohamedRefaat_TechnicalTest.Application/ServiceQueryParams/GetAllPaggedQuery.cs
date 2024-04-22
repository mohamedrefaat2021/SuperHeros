using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace MohamedRefaat_TechnicalTest.Application.ServiceQueryParams
{
    public class GetAllPaggedQuery 
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public GetAllPaggedQuery() {}
        public GetAllPaggedQuery(int pageNumber,int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize; 
        }
    }
}
