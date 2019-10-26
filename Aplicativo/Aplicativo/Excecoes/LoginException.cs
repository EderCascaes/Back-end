using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
 
namespace Aplicativo.Excecoes
{
    public class LoginException : Exception
    {
        public LoginException(string mensagem)
            : base(mensagem)
        {
        }
    }
}