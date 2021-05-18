using Infrastructure.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories.IRepository
{
    public interface IClientes
    {
        void GetClientes();

        void GetClientesById(int id);

        void CreateClientes(Clientes clientes);

        void UpdateClientes(int id, Clientes clientes);

        void DeleteClientes(int id);
    }
}
