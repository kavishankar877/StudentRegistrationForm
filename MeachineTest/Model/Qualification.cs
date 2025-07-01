using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeachineTest.Model
{
    public class Qualification
    {
        [Key]
        public int QualificationId { get; set; }

        public string CourseName { get; set; }
        public string University { get; set; }
        public int YearOfPassing { get; set; }
        public double Percentage { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }

        
    }
}
