using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleRecursosDAE.Util
{
    public class Resultado
    {
        private string mensagem;
        private int retorno;

        public Resultado()
        {
               
        }

        public Resultado(string mensagem, int retorno)
        {
            this.mensagem = mensagem;
            this.retorno = retorno;
        }

        public string Mensagem { get => mensagem; set => mensagem = value; }
        public int Retorno { get => retorno; set => retorno = value; }
    }
}
