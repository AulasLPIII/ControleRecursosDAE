using ControleRecursosDAE.DAO;
using ControleRecursosDAE.DTO;
using ControleRecursosDAE.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleRecursosDAE.Controller
{
    public class DatashowController
    {
        private DatashowDTO datashowdto;
        private DatashowDAO datashowdao;
        private Resultado resultado;
        public Resultado SalvarDatashow(string fabricante, string modelo, int luminosidade, bool disponibilidade)
        {
            string msg = "";
            msg = ValidarDadosDatashow(fabricante, modelo, luminosidade, disponibilidade);
            if (msg == "")
            {
                //Sucesso
                datashowdto = new DatashowDTO(fabricante, modelo, luminosidade, disponibilidade);
                datashowdao = new DatashowDAO();
                int resultadosalva = datashowdao.salvar(datashowdto);
                if (resultadosalva > 0) 
                {
                    msg = "Dados Salvos com Sucesso";
                    resultado = new Resultado(msg, 1);
                }
                else
                {
                    msg = "Erro ao Salvar!!!";
                    resultado = new Resultado(msg, 0);
                }
            }
            else
            {
                resultado = new Resultado(msg, 0);
            }
            return resultado;
        }

        private string ValidarDadosDatashow(string fabricante, string modelo, int luminosidade, bool disponibilidade)
        {
            string mensagem = "";
            if (string.IsNullOrEmpty(fabricante))
            {
                mensagem = mensagem + "Fabricante não informado.\n";
            }

            if (string.IsNullOrEmpty(modelo))
            {
                mensagem = mensagem + "Modelo não informado.\n";
            }

            if (luminosidade == 0)
            {
                mensagem = mensagem + "Luminosidade não informada ou valor não é maior que 0.\n";
            }
            return mensagem;
        }

        public List<DatashowDTO> ListarDataShow()
        {
            datashowdao = new DatashowDAO();
            List<DatashowDTO> lista = datashowdao.listar();
            return lista;
        }

    }
}
