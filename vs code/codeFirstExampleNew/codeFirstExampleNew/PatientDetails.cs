using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirstExampleNew
{
    internal class PatientDetails
    {
        public int id { get; set; }
        public string name { get; set; }

        public int docpatientId { get; set; }

        public DoctorDetails doctor { get; set; }

    }
}
