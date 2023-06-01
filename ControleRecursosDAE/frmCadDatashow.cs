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
            int luminosidade, id;
            bool disponibilidade;
            Resultado resultado = null;

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
            if (txtID.Text == "")
            {
                resultado = datashowcontroller.SalvarDatashow(fabricante, modelo, luminosidade, disponibilidade);
            }
            else
            {
                id = Convert.ToInt32(txtID.Text);
                resultado = datashowcontroller.AtualizarDatashow(id, fabricante, modelo, luminosidade, disponibilidade);
            }
            if (resultado.Retorno > 0)
            {
                MessageBox.Show(resultado.Mensagem, "Salva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                PreencherDataGrid();
            }
            else
            {
                MessageBox.Show(resultado.Mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripBtnListar_Click(object sender, EventArgs e)
        {
            PreencherDataGrid();
        }

        private void PreencherDataGrid()
        {
            //Criacao do Vetor
            string[] dados = new string[5];

            //Evitar a geração de colunas ao preencher
            dgvDataShows.AutoGenerateColumns = false;
            //Limpeza do DataGrid antes de carregar dados
            dgvDataShows.Rows.Clear();
            datashowcontroller = new DatashowController();
            List<DatashowDTO> lista = datashowcontroller.ListarDataShow();
            foreach (DatashowDTO datashowdto in lista)
            {
                dados[0] = datashowdto.Id.ToString();
                dados[1] = datashowdto.Fabricante;
                dados[2] = datashowdto.Modelo;
                dados[3] = datashowdto.Luminosidade.ToString();
                dados[4] = datashowdto.Disponibilidade ? "SIM" : "NÃO";
                dgvDataShows.Rows.Add(dados);
            }
        }

        private void LimparCampos()
        {
            txtFabricante.Text = "";
            txtModelo.Text = "";
            txtLuminosidade.Text = "";
            rdSim.Checked = true;
            txtID.Text = "";
            txtFabricante.Focus();
        }

        private void toolStripBtnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void dgvDataShows_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = 0;

            index = e.RowIndex;
            txtID.Text = dgvDataShows.Rows[index].Cells[0].Value.ToString();
            txtFabricante.Text = dgvDataShows.Rows[index].Cells[1].Value.ToString();
            txtModelo.Text = dgvDataShows.Rows[index].Cells[2].Value.ToString();
            txtLuminosidade.Text = dgvDataShows.Rows[index].Cells[3].Value.ToString();
            string disponibilidade = dgvDataShows.Rows[index].Cells[4].Value.ToString();
            if (disponibilidade == "SIM")
            {
                rdSim.Checked = true;
            }
            else
            {
                rdNao.Checked = true;
            }

        }

        private void toolStripBtnDeletar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Para EXCLUIR selecione um item da lista.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int id = Convert.ToInt32(txtID.Text);
                datashowcontroller = new DatashowController();
                Resultado  resultado = datashowcontroller.ApagarDatashow(id);
                if (resultado.Retorno > 0)
                {
                    MessageBox.Show(resultado.Mensagem,"Salva",MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
                else
                {
                    MessageBox.Show(resultado.Mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LimparCampos();
                PreencherDataGrid();
            }
        }
    }
}
