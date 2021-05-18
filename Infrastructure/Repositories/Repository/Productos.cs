using Infrastructure.Repositories.Context;
using Infrastructure.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories.Repository
{
    public class Productos : IProductos
    {
        private readonly ApplicationDbContext context;

        public Productos(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void CreateProducto(Entities.Productos productos)
        {
            if (ModelState.IsValid)
            {
                context.Productos.Add(productos);
                context.SaveChanges();

                return Ok();
            }

            return BadRequest();
        }

        public void DeleteProductos(int id)
        {
            var producto = context.Productos.FirstOrDefault(p => p.IdProducto == id);

            if (producto != null)
            {
                context.Productos.Remove(producto);
                context.SaveChanges();

                return Ok();
            }

            return BadRequest();
        }

        public Productos GetProductoById(int id)
        {
            var producto = context.Productos.Find(id);
            if (id == null)
            {
                return NotFound();
            }

            return producto;
        }

        public IEnumerable<Productos> GetProductos()
        {
            return context.Productos;
        }

        public void UpdateProductos(int id, Entities.Productos productos)
        {
            if (productos.IdProducto == id)
            {
                context.Entry(productos).State = EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }

            return BadRequest();
        }
    }
}
