using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APIEscola.Data
{
    public class APIEscolaContext : IdentityDbContext //Herança do IndentityDbContext para autenticação
    {
        // Construtor que recebe as opções de configuração do DbContext
        public APIEscolaContext(DbContextOptions<APIEscolaContext> options) : base(options)
        {
        }

        // Propriedade DbSet para cada tabela

        // Sobrecarga do método OnModel(Creating para configurar o modelo a partir da IdentityDbContext
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Chama o método OnModel(Creating da classe base para a criação das tabelas padrão
            base.OnModelCreating(modelBuilder);

            // Configurar a criação de tabelas adicionais aqui
        }
    }
}
