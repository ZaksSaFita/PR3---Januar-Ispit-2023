using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.ispitIB220116
{
    public class StudentiUvjerenjaIB220116
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime Datum { get; set; }
        public string Vrsta { get; set; }
        public string Svrha { get; set; }

        public byte[] Uplatnica { get; set; }
        public bool Printano { get; set; }






    }
}
