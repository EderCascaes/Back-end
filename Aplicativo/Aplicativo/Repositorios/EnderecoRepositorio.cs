using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicativo.Entidades;
using Dapper;

namespace Aplicativo.Repositorios
{
    public class EnderecoRepositorio : Conexao, IEnderecoRepositorio
    {
        public async Task PostEnderecoAsync(Endereco endereco)
        {

            var sSql = $@"INSERT INTO ENDERECO (LOGRADOURO, NUMERO, COMPLEMENTO, CEP, BAIRRO, CIDADE, ESTADO, IDUSUARIO)
                        VALUES (
                                '{endereco.Logradouro}',
                                 {endereco.Numero},   
                                '{endereco.Complemento}',
                                '{endereco.Cep}',
                                '{endereco.Bairro}',
                                '{endereco.Cidade}',
                                '{endereco.Estado}',
                                 {endereco.Idusuario} 
                                )";

            await _conexao.ExecuteAsync(sSql);
        }
    }
}
