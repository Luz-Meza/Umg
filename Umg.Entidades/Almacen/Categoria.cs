﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Umg.Entidades.Almacen
{
   public class Categoria
    {
        public int idcategoria { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Error")]
        public string nombre { get; set; }
        [StringLength(256)]
        public string descripcion { get; set; }
        public bool condicion { get; set; }

        //vinculamos la tabla articulos con categoria 

        public ICollection<Articulos> articulos { get; set; }

        public Articulos Articulos
        {
            get => default;
            set
            {
            }
        }

        public Articulos Articulos1
        {
            get => default;
            set
            {
            }
        }

        public Articulos Articulos2
        {
            get => default;
            set
            {
            }
        }
    }
}
