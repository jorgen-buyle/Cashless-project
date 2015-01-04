using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class LogboekModel
    {
        public int RegisterID { get; set; }
        public string Timestamp { get; set; }
        public string Message { get; set; }
        public string Stacktrace { get; set; }
    }
}