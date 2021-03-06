using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Umg.Entidades.Usuario;


namespace Umg.Entidades.Ventas
{
    public class venta
    {

        public int idventa { get; set; }
        [Required]


        public String tipo_comprobante_venta { get; set; }

        public String serie_comprobante { get; set; }

        public String num_comprobante_venta { get; set; }

        public DateTime fecha_hora_venta { get; set; }

        public decimal impuesto { get; set; }

        public decimal total { get; set; }

        public int condicion_venta { get; set; }

        public detalle_venta detalle_venta
        {
            get => default;
            set
            {
            }
        }

        public detalle_venta detalle_venta1
        {
            get => default;
            set
            {
            }
        }

        public detalle_venta detalle_venta2
        {
            get => default;
            set
            {
            }
        }

        public detalle_venta detalle_venta3
        {
            get => default;
            set
            {
            }
        }
        List<Persona> Personas { get; set; }
        List<Usuario> Usuarios { get; set; }

        public detalle_venta detalle_venta4
        {
            get => default;
            set
            {
            }
        }

        public detalle_venta detalle_venta5
        {
            get => default;
            set
            {
            }
        }

        public detalle_venta detalle_venta6
        {
            get => default;
            set
            {
            }
        }
    }
}