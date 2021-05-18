using Infrastructure.Repositories.Context;
using Infrastructure.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories.Repository
{
    public class Pedidos : IPedidos
    {
        private readonly ApplicationDbContext context;

        public Pedidos(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void CreatePedido(Entities.Pedidos pedidos)
        {
            if (ModelState.IsValid)
            {
                context.Pedido.Add(pedidos);
                context.SaveChanges();

                return Ok();
            }
            return BadRequest();
        }

        public void DeletePedidos(int id)
        {
            var pedido = context.Pedido.FirstOrDefault(p => p.IdPedido == id);

            if (pedido != null)
            {
                context.Remove(pedido);
                context.SaveChanges();

                return Ok();
            }
            return BadRequest();
        }

        public void GetPedidoById(int id)
        {
            var pedido = context.Pedido.Find(id);

            if (pedido != null)
            {
                return pedido;
            }
            return NotFound();
        }

        public IEnumerable<Pedidos> GetPedidos()
        {
            return context.Pedido.ToList();
        }

        public void UpdatePedido(int id, Entities.Pedidos pedidos)
        {
            if (pedidos.IdPedido == id)
            {
                context.Entry(pedidos).State = EntityState.Modified;
                context.SaveChanges();

                return Ok();
            }

            return BadRequest();
        }
    }
}
