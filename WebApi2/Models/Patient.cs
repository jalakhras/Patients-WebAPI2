using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi2.Models
{
    public class Patient
    {
     
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Ailment> Ailments { get; set; }
        public ICollection<Medication> Medications { get; set; }
    }

    public class Medication
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Doses { get; set; }
        [ForeignKey("Patient")]
        public int? Patient_Id { get; set; }
        public Patient Patient { get; set; }

    }

    public class Ailment
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Patient")]
        public int? Patient_Id { get; set; }
        public Patient Patient { get; set; }

    }
}
