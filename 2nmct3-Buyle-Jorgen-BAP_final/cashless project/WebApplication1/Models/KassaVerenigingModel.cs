using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class KassaVerenigingModel
    {
        public int Id { get; set; }
        public string RegisterName { get; set; }
        public string Device { get; set; }
        public string FromData { get; set; }
        public string UntilData { get; set; }
    }
}