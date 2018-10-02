using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiemThiHocSinhGioi.Models.DTO
{
    public class ReturnResults
    {
        public int StatusCode { get; set; }
        public String Message { get; set; }
        public object Results { get; set; }

        public ReturnResults(int statusCode, string message, object results)
        {
            StatusCode = statusCode;
            Message = message;
            Results = results;
        }
    }
}