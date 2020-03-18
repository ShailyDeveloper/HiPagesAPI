using System;
using System.Collections.Generic;

namespace tradiesJobs.Models
{
    public partial class Cust
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Date { get; set; }
        public string Time { get; set; }
        public string Suburb { get; set; }
        public int? Zipcode { get; set; }
        public string Category { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
    }
}
