using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsuranceExercise.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string carYear { get; set; }
        public string carMake { get; set; }
        public string carModel { get; set; }
        public string duiCheck { get; set; }
        public int speedingTickets { get; set; }
        public string coverageType { get; set; }
        public decimal quote { get; set; }
    }
}