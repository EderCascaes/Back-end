using Aplicativo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Globalization;
using Aplicativo.Functions;

namespace Aplicativo.Repositorios
{
    public class UsuarioRepositorio : Conexao, IUsuarioRepositorio
    {
        Funcoes _func = new Funcoes();
        //public UsuarioRepositorio(IConfiguration config) : base(config)
        //{
        //}
        //private readonly Funcoes _func;


        public async Task PostUsuarioAsync(Usuario usuario)
        {                   

            var sSql = $@"INSERT INTO USUARIO (CPF, NOME, TELEFONE, DATANASCIMENTO, DATACADASTRO, EMAIL, LOGIN, SENHA)
                        VALUES (
                                '{usuario.Cpf}',
                                '{usuario.Nome}',   
                                '{usuario.Telefone}',
                                '{_func.TO_DATE(usuario.DataNascimento)}',
                                '{_func.TO_DATE(DateTime.Now)}',
                                '{usuario.Email}',
                                '{usuario.Login}',
                                '{usuario.Senha}' 
                                )";

            await _conexao.ExecuteAsync(sSql);

        }

        public async Task<int> ObterCodigo()
        {
            var sSql = "SELECT COALESCE(MAX(IDCADASTRO) + 1, 1) AS CODIGO FROM USUARIO";

            return await _conexao.QueryFirstOrDefaultAsync<int>(sSql);
        }

        public async Task<string> GetVerificaLoginAsync(string login)
        {
            var sSql = $"SELECT LOGIN FROM USUARIO WHERE UPPER(LOGIN) LIKE  '{login.ToUpper()}' ";

            return await _conexao.QueryFirstOrDefaultAsync<string>(sSql);
        }
    }
   
}
