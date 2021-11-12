using Facturacion.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Facturacion.Repository.Contexts.Configuration
{


    public class ProductoModelBuilder : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.HasKey(s => s.ProductoId);
            builder.Property(s => s.Nombre).IsRequired(true);
            builder.Property(s => s.Descripcion).IsRequired(true);
            builder.Property(s => s.UnidadMedida).IsRequired(true);
            builder.Property(s => s.Descripcion).IsRequired(false);
            builder.Property(s => s.Cantidad).IsRequired(true);
            builder.Property(s => s.UsuarioCreador).IsRequired(true);
            builder.Property(s => s.FechaCreacion).IsRequired(true);
            builder.Property(s => s.FechaActulizacion).IsRequired(true);
            builder.HasOne(s => s.Bodega)
                   .WithMany(s => s.Productos)
                   .HasForeignKey(fk => fk.BodegaId);
        }
    }
}
