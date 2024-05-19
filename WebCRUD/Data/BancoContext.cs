using Microsoft.EntityFrameworkCore;
using WebCRUD.Controllers;
using WebCRUD.Models;

namespace WebCRUD.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) { }

        public DbSet<ContatoModel> Contatos { get; set; }
    }

}
