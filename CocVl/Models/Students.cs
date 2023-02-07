using System.ComponentModel.DataAnnotations;

namespace CocVl.Models
{
    public class Students
    {
        [Key]
        public int ID { get; set; }

        public string? Name { get; set;}
        public string? Phone { get; set;}
        public string? Email { get; set;}
        public string? Address { get; set; }
        public int ClassID { get; set; }
        //public Class? Class { get; set; }
    }
}
