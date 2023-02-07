using Microsoft.EntityFrameworkCore;

namespace CocVl.Models
{
    [Keyless]
    public class StudentManageView
    {
        public int StudentId { get; set; }
        public string? Name { get; set;}
        public int ClassId { get; set;}
        public string? ClassName { get; set;}

    }
}
