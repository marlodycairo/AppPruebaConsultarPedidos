using Infrastructure.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories.IRepository
{
    public interface IPedidos
    {
        void GetPedidos();

        void GetPedidoById(int id);

        void CreatePedido(Pedidos pedidos);

        void UpdatePedido(int id, Pedidos pedidos);

        void DeletePedidos(int id);
    }
}
