using System;


namespace UAS.Models
{
  public class Enrollment { 
        public string studentID { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public DateTime enrollmentDate { get; set; }      
        public int enrollmentID { get; set; } 
        public string grade { get; set; }
        public int courseID { get; set; }
        public string title { get; set; }
        public int credits { get; set; }       

   }   
}