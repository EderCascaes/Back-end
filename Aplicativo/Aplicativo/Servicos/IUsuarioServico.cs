using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicativo.Entidades;

namespace Aplicativo.Servicos
{
    public interface IUsuarioServico
    {
        Task<bool> PostUsuarioAsync(Requisicao requisicao);
        Task<bool> GetVerificaLoginAsync(string login);
    }
}
