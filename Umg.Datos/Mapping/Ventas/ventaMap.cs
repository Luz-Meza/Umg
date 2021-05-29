using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Ventas;

namespace Umg.Datos.Mapping.Ventas
{
    public class ventaMap : IEntityTypeConfiguration<venta>
    {
        public void Configure(EntityTypeBuilder<venta> builder)
        {
            builder.ToTable("venta")
                   .HasKey(c => c.idventa);
            builder.Property(c => c.tipo_comprobante_venta)
                .HasMaxLength(50);
            builder.Property(c => c.serie_comprobante)
               .HasMaxLength(50);
            builder.Property(c => c.num_comprobante_venta)
               .HasMaxLength(50);
            builder.Property(c => c.fecha_hora_venta)
              .HasMaxLength(50);
            builder.Property(c => c.impuesto)
              .HasMaxLength(50);
            builder.Property(c => c.total)
              .HasMaxLength(50);
           
        }


    }
}