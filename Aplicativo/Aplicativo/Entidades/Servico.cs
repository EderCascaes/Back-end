using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicativo.Entidades
{
    public class Servico
    {
        public int id { get; set; }
        public string CpfContratante { get; set; }
        public string CpfContratado { get; set; }
        public DateTime dataInicio{ get; set; }
        public DateTime dataFim { get; set; }
        public String discriminacao { get; set; }
        public double valor { get; set; }

        internal class UsuarioServico
        {
            internal ArrayList GetAllUser()
            {
                throw new NotImplementedException();
            }
        }
    }
}
