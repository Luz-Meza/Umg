using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Ventas;

namespace Umg.Datos.Mapping.Ventas
{
    public class detalle_ventaMap : IEntityTypeConfiguration<detalle_venta>
    {
        public void Configure(EntityTypeBuilder<detalle_venta> builder)
        {
            builder.ToTable("detalle_venta")
                   .HasKey(c => c.id_detalle_venta);
            builder.Property(c => c.cantidad_detalle_venta)
                .HasMaxLength(50);
            builder.Property(c => c.precio_detalle_venta)
               .HasMaxLength(50);
            builder.Property(c => c.descuento_detalle_venta)
               .HasMaxLength(50);
          
        }


    }
}
