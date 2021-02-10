using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentApp.Models
{
    public class AppointmentModel
    {
        [Required]
        [StringLength(20,MinimumLength = 4)]
        [DisplayName("Patient's Full Name")]
        public string PatientName { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Appointment Request Date")]
        public DateTime AppointmentDate { get; set; }

        [DataType(DataType.Currency)]
        [DisplayName("Patient's Approximate Net Worth")]
        public decimal PatientNetWorth { get; set; }

        [DisplayName("Primary Doctor's Last Name")]
        public string DoctorName { get; set; }

        [Range(1,10)]
        [DisplayName("Patient's  Perceived Level of Pain (1 low to 10 high")]
        public int PainLevel { get; set; }

       
    }
}
