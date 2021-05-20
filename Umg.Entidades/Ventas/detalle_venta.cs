﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Umg.Entidades.Ventas
{
    public class detalle_venta
    {
        public int id_detalle_venta { get; set; }
        [Required]


        public int cantidad_detalle_venta { get; set; }

        public decimal precio_detalle_venta { get; set; }

        public decimal descuento_detalle_venta { get; set; }

        public Usuario.Persona persona
        {
            get => default;
            set
            {
            }
        }

        public ingreso ingreso
        {
            get => default;
            set
            {
            }
        }

        public ingreso ingreso1
        {
            get => default;
            set
            {
            }
        }
    }
}