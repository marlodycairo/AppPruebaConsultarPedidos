using Infrastructure.Repositories.Context;
using Infrastructure.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories.Repository
{
    public class Clientes : IClientes
    {
        private readonly ApplicationDbContext context;

        public Clientes(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void CreateClientes(Entities.Clientes clientes)
        {
            try
            {
                context.Clientes.Add(clientes);
                context.SaveChanges();

                return Ok(clientes);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        public void DeleteClientes(int id)
        {
            var cliente = context.Clientes.FirstOrDefault(p => p.Identificacion == id);

            if (cliente != null)
            {
                context.Clientes.Remove(cliente);
                context.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }

        public IEnumerable<Clientes> GetClientes()
        {
            return context.Clientes.ToList();
        }

        public Clientes GetClientesById(int id)
        {
            var cliente = context.Clientes.Find(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return cliente;
        }

        public void UpdateClientes(int id, Entities.Clientes clientes)
        {
            if (clientes.Identificacion == id)
            {
                context.Entry(clientes).State = EntityState.Modified;
                context.SaveChanges();

                return Ok();
            }
            return BadRequest();
        }
    }
}
