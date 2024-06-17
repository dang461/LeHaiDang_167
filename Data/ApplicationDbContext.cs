using Microsoft.EntityFrameworkCore;

namespace LeHaiDang_167.Data{
    public class ApplicationDbContext : DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
    }
}