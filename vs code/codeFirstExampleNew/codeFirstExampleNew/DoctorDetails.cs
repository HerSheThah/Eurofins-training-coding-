using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirstExampleNew
{
    internal class DoctorDetails
    {
        [Key]
        public int docid { get; set; }
        public string docname { get; set; }
        public string specialization { get; set; }

        public List<PatientDetails> patients { get; set; }

    }
}
