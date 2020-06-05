using Harvin.Models;
using System.Data.Entity.ModelConfiguration;

namespace Harvin.Configurations
{
    public class PedidoConfiguration : EntityTypeConfiguration<Pedido>
    {
        //CONSTRUTOR DA CONFIG
        public PedidoConfiguration()
        {
            ToTable("Pedido");
            HasKey(c => c.Id);

            HasRequired(p => p.Funcionario).WithMany().Map(m => m.MapKey("FuncionarioId"));
            HasOptional(p => p.Cliente).WithMany().Map(m => m.MapKey("ClienteId"));
        }
    }
}