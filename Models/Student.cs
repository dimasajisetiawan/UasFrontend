using System;
using System.ComponentModel.DataAnnotations;

namespace UAS.Models
{
    public class Student {
        [Key]
        public string studentID { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public DateTime enrollmentDate { get; set; }
    }
}