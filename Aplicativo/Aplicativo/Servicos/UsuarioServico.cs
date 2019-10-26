using Aplicativo.Entidades;
using Aplicativo.Excecoes;
using Aplicativo.Functions;
using Aplicativo.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicativo.Servicos
{
    public class UsuarioServico : IUsuarioServico
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IEnderecoRepositorio _enderecoRepositorio;
        Funcoes _func = new Funcoes();



        public UsuarioServico(IUsuarioRepositorio usuarioRepositorio, IEnderecoRepositorio enderecoRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _enderecoRepositorio = enderecoRepositorio;
        }

        public async Task<bool> GetVerificaLoginAsync(string login)
        {
            try
            {
                if (!String.IsNullOrEmpty(await _usuarioRepositorio.GetVerificaLoginAsync(login)))
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> PostUsuarioAsync(Requisicao requisicao)
        {
            try
            {

                var endereco = requisicao.endereco;
                var usuario = requisicao.usuario;

                if (_func.ValidaCPF(usuario.Cpf) == null)
                    return false;

                usuario.Cpf = _func.ValidaCPF(usuario.Cpf);
                endereco.Idusuario = usuario.IdCadastro = await _usuarioRepositorio.ObterCodigo();

                usuario.Senha = _func.GetMD5Hash(usuario.Senha);

                await _usuarioRepositorio.PostUsuarioAsync(usuario);
                await _enderecoRepositorio.PostEnderecoAsync(endereco);
                //    Commit();
                return true;
            }
            catch (Exception ex)
            {
                //  _conexao.RollBack();
                throw ex;
            }
        }


    }
}
