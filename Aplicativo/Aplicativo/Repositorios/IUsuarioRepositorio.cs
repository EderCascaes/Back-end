using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicativo.Entidades;

namespace Aplicativo.Repositorios
{
    public interface IUsuarioRepositorio
    {
        Task PostUsuarioAsync(Usuario usuario);
        Task<int> ObterCodigo();
        Task<string> GetVerificaLoginAsync(string login);
    }
}
