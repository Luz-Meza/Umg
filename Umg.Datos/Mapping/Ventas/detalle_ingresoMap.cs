using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Ventas;

namespace Umg.Datos.Mapping.Ventas
{
      public class detalle_ingresoMap : IEntityTypeConfiguration<detalle_ingreso>
    {
        public void Configure(EntityTypeBuilder<detalle_ingreso> builder)
        {
            builder.ToTable("detalle_ingreso")
                   .HasKey(c => c.id_detalle_ingreso);
            builder.Property(c => c.cantidad_detalle_ingreso)
                .HasMaxLength(50);
             builder.Property(c => c.precio_detalle_ingreso)
                .HasMaxLength(50);
            builder.Property(c => c.ingreso_detalle_ingreso)
               .HasMaxLength(50);
            builder.Property(c => c.detalle_venta)
               .HasMaxLength(50);
           
        }


    }
}