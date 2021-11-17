using financial_chat.Models;
using Microsoft.EntityFrameworkCore;

namespace financial_chat.Data
{
    public class ChatContext : DbContext
    {
        private IConfiguration _config;

        public ChatContext(IConfiguration config, DbContextOptions options) : base(options)
        {
            _config = config;
        }

        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(_config["ConnectionStrings:DefaultConnection"]);
        }
        
    }
}
