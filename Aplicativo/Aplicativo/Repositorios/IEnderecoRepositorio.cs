using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicativo.Entidades;

namespace Aplicativo.Repositorios
{
    public interface IEnderecoRepositorio
    {
        Task PostEnderecoAsync(Endereco endereco);
    }
}
