using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using ControleRecursosDAE.DTO;
using ControleRecursosDAE.DAO;
using ControleRecursosDAE.Controller;
using ControleRecursosDAE.Util;

namespace ControleRecursosDAE
{
    public partial class frmCadDatashow : Form
    {
        private DatashowController datashowcontroller;

        public frmCadDatashow()
        {
            InitializeComponent();
        }

        private void toolStripBtnSalvar_Click(object sender, EventArgs e)
        {
            string fabricante, modelo;
            int luminosidade;
            bool disponibilidade;

            //Captura dos Dados
            fabricante = txtFabricante.Text.Trim();
            modelo = txtModelo.Text.Trim();
            if (rdSim.Checked)
            {
                disponibilidade = true;
            }
            else
            {
                disponibilidade = false;
            }

            if (string.IsNullOrEmpty(txtLuminosidade.Text.Trim()))
            {
                luminosidade = 0;
            }
            else
            {
                luminosidade = Convert.ToInt32(txtLuminosidade.Text);
            }
            datashowcontroller = new DatashowController();
            Resultado resultado = datashowcontroller.SalvarDatashow(fabricante, modelo, luminosidade, disponibilidade);
            if (resultado.Retorno > 0)
            {
                MessageBox.Show(resultado.Mensagem, "Salva", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(resultado.Mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripBtnListar_Click(object sender, EventArgs e)
        {
            //Listagem de DataShows
            datashowcontroller = new DatashowController();
            List<DatashowDTO> lista = datashowcontroller.ListarDataShow();
            dgvDataShows.DataSource = lista;
            //foreach (DatashowDTO datashow in lista)
            //{
            //    MessageBox.Show("Fabricante:" + datashow.Fabricante);
            //}
        }
    }
}
