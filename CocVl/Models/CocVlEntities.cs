using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CocVl.Models
{
    public class CocVlEntities : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=INFINITY9591;Initial Catalog=SV;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
            );
        }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        //public virtual DbSet<StudentManageView> StudentManageView { get; set;}
        
    }
}