using Infrastructure.Repositories.Context;
using Infrastructure.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories.Repository
{
    public class Facturas : IFacturas
    {
        private readonly ApplicationDbContext context;

        public Facturas(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void CreateFactura(Entities.Facturas facturas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            context.Facturas.Add(facturas);
            context.SaveChanges();

            return Ok();
        }

        public void DeleteFacturas(int id)
        {
            var factura = context.Facturas.FirstOrDefault(p => p.IdFactura == id);

            if (factura != null)
            {
                context.Remove(factura);
                context.SaveChanges();

                return Ok();
            }
            return BadRequest();
        }

        public Facturas GetFacturaById(int id)
        {
            var factura = context.Facturas.Find(id);

            if (factura != null)
            {
                return factura;
            }
            return NotFound();
        }

        public IEnumerable<Facturas> GetFacturas()
        {
            return context.Facturas.ToList();
        }

        public void UpdateFactura(int id, Entities.Facturas facturas)
        {
            if (facturas.IdFactura == id)
            {
                context.Entry(facturas).State = EntityState.Modified;
                context.SaveChanges();

                return Ok();
            }
            return BadRequest();
        }
    }
}
