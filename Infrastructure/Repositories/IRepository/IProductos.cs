using Infrastructure.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories.IRepository
{
    public interface IProductos
    {
        void GetProductos();

        void GetProductoById(int id);

        void CreateProducto(Productos productos);

        void UpdateProductos(int id, Productos productos);

        void DeleteProductos(int id);
    }
}
