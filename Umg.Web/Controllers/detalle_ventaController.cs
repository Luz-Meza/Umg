using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Umg.Datos;
using Umg.Entidades.Ventas;


namespace Umg.Web.Controllers
{
   



    [Route("api/[controller]")]
    [ApiController]


    public class detalle_ventaController : ControllerBase
    {

        private readonly DbContexSistema _context;

        public detalle_ventaController(DbContexSistema context)
        {
            _context = context;
        }

        //GET api/detalle_venta
        [HttpGet]
        public async Task<ActionResult<IEnumerable<detalle_venta>>> Getdetalle_venta()
        {
            return await _context.detalle_ventas.ToListAsync();
        }


        //GET api/detalle_venta/2
        [HttpGet("{id_detalle_venta}")]

        public async Task<ActionResult<detalle_venta>> Getdetalle_venta(int id)
        {
            var detalle_venta = await _context.detalle_ventas.FindAsync(id);



            if (detalle_venta == null)
            {
                return NotFound();
            }

            return detalle_venta;
        }

        //Put api/detalle_venta/2
        [HttpPut("id_detalle_venta")]
        public async Task<IActionResult> PutCategoria(int id, detalle_venta detalle_venta)
        {
            if (id != detalle_venta.id_detalle_venta)
            {
                return BadRequest();
            }

            //MI ENTIDAD YA TIENE LAS PROPIEDADDES O INFO QUE VOY A GUARDAR EN MY DB
            _context.Entry(detalle_venta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!detalle_ventaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        //POst api/detalle_venta
        [HttpPost]
        public async Task<ActionResult<detalle_venta>> PostCategoria(detalle_venta detalle_venta)
        {
            _context.detalle_ventas.Add(detalle_venta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getdetalle_venta", new { id = detalle_venta.id_detalle_venta }, detalle_venta);
        }

        //Delete api/detalle_venta/2

        [HttpDelete("id_detalle_venta")]
        public async Task<ActionResult<detalle_venta>> Deletedetalle_venta(int id)
        {
            var detalle_venta = await _context.detalle_ventas.FindAsync(id);

            if (detalle_venta == null)
            {
                return NotFound();
            }

            _context.detalle_ventas.Remove(detalle_venta);
            await _context.SaveChangesAsync();

            return detalle_venta;
        }

        private bool detalle_ventaExists(int id)
        {
            return _context.detalle_ventas.Any(e => e.id_detalle_venta == id);
        }









    }
}