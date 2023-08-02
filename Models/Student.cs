using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NDHTHI.Models
{
    public class Student
    {
        [Key]
        public string ID { get; set; }
        public string  Name { get; set; }
        public string FacultyID { get; set; }
        [ForeignKey("FacultyID")]
        public Faculty? Faculty { get; set; } 
    }
}
