using ControleRecursosDAE.DTO;
using ControleRecursosDAE.Util;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleRecursosDAE.DAO
{
    public class DatashowDAO : GenericDAO<DatashowDTO>
    {
        private MySqlConnection con;
        private MySqlCommand envelope;
        private MySqlDataReader cursor;
        private string sql;
        private List<DatashowDTO> lista;

        public DatashowDAO()
        {
            con = ConnectionFactory.Conexao();    
        }
        public int apagar(DatashowDTO entity)
        {
            throw new NotImplementedException();
        }

        public int atualizar(DatashowDTO entity)
        {
            throw new NotImplementedException();
        }

        public List<DatashowDTO> listar()
        {
            lista = new List<DatashowDTO>();
            try
            {
                con.Open();
                sql = "Select * from datashow";
                envelope = new MySqlCommand(sql, con);
                cursor = envelope.ExecuteReader();
                while (cursor.Read())
                {
                    DatashowDTO datashowDTO = new DatashowDTO(cursor.GetInt32("iddatashow"), cursor.GetString("fabricante"), cursor.GetString("modelo"), cursor.GetInt32("luminosidade"), cursor.GetBoolean("disponibilidade"));
                    lista.Add(datashowDTO);
                }    
            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
            
            return lista;
        }

        public int salvar(DatashowDTO datashow)
        {
            int resultado = 0;
            try
            {
                con.Open();
                sql = "Insert into datashow(fabricante,modelo,luminosidade,disponibilidade) values (@fab,@mod,@lum,@disp)";
                envelope = new MySqlCommand(sql, con);
                envelope.Parameters.AddWithValue("@fab", datashow.Fabricante);
                envelope.Parameters.AddWithValue("@mod", datashow.Modelo);
                envelope.Parameters.AddWithValue("@lum", datashow.Luminosidade);
                envelope.Parameters.AddWithValue("@disp", datashow.Disponibilidade);
                envelope.Prepare();
                resultado = envelope.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            return resultado;
        }
    }
}
