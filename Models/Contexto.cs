using Microsoft.EntityFrameworkCore;

namespace ALMIR071023.Models
{
    public class Contexto:DbContext
    {

        public Contexto(DbContextOptions<Contexto> options): base(options){}

        public DbSet<Celular> Celulares { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }    
    }
}
