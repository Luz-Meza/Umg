using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Usuario;

namespace Umg.Datos.Mapping.Usuarios
{
    public class RolMap : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.ToTable("Rol")
                   .HasKey(c => c.idrol);
            builder.Property(c => c.nombre)
                .HasMaxLength(50);
            builder.Property(c => c.direccion)
               .HasMaxLength(50);
          

        }


    }
}