using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nmctBaWPF1.Models
{
    public class MedewerkerInfo
    {
        public int ID { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string RFID { get; set; }

        public List<MedewerkerInfo> Datalist
        {
            get
            {
                List<MedewerkerInfo> MI = new List<MedewerkerInfo>();
                //MI = DAMedewerker.GetData();
                return null;
            }
            set {}
        }
    }
    
}
