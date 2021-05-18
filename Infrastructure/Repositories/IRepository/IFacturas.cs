using Infrastructure.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories.IRepository
{
    public interface IFacturas
    {
        void GetFacturas();

        void GetFacturaById(int id);

        void CreateFactura(Facturas facturas);

        void UpdateFactura(int id, Facturas facturas);

        void DeleteFacturas(int id);
    }
}
