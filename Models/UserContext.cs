using Microsoft.EntityFrameworkCore;

namespace SqlBaglantiliJqueryAjax.Models
{
    public class UserContext:DbContext
    {
        public DbSet<Student> Students { get; set; }        
    }
}
