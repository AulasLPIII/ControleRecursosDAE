using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleRecursosDAE.DTO
{
    public class DatashowDTO
    {
        private int id;
        private string fabricante;
        private string modelo;
        private int luminosidade;
        private bool disponibilidade;

        public DatashowDTO(string fabricante, string modelo, int luminosidade, bool disponibilidade)
        {
            this.fabricante = fabricante;
            this.modelo = modelo;
            this.luminosidade = luminosidade;
            this.disponibilidade = disponibilidade;
        }

        public DatashowDTO(int id, string fabricante, string modelo, int luminosidade, bool disponibilidade)
        {
            this.id = id;
            this.fabricante = fabricante;
            this.modelo = modelo;
            this.luminosidade = luminosidade;
            this.disponibilidade = disponibilidade;
        }

        public int Id { get => id; set => id = value; }
        public string Fabricante { get => fabricante; set => fabricante = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Luminosidade { get => luminosidade; set => luminosidade = value; }
        public bool Disponibilidade { get => disponibilidade; set => disponibilidade = value; }
    }
}
