using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Datos.Mapping.Almacen;
using Umg.Datos.Mapping.Ventas;
using Umg.Datos.Mapping.Usuarios;
using Umg.Entidades.Almacen;
using Umg.Entidades.Usuario;
using Umg.Entidades.Ventas;

namespace Umg.Datos
{
   public class DbContexSistema : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Articulos> Articuloss { get; set; }

        public DbSet<Persona> Personas { get; set; }

        public DbSet<Rol> Rols { get; set; }

        public DbSet<Usuario> Usuarioss { get; set; }


        public DbSet<detalle_ingreso> detalle_ingresos { get; set; }

        public DbSet<detalle_venta> detalle_ventas { get; set; }

        public DbSet<ingreso> ingresos { get; set; }

        public DbSet<venta> ventas { get; set; }
        public object Articulos { get; set; }

        public DbContexSistema (DbContextOptions<DbContexSistema> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoriaMap());

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ArticuloMap());

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PersonaMap());

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RolMap());

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UsuarioMap());

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new detalle_ingresoMap());

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new detalle_ventaMap());

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ingresoMap());

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ventaMap());
        }



    }
}
