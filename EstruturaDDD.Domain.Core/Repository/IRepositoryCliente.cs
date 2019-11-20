using EstruturaDDDCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDDCore.Domain.Core.Interfaces.Repository
{
    interface IRepositoryCliente : IRepository<Cliente>
    {
        Cliente ObterPorNome(String nome);

    }
}
