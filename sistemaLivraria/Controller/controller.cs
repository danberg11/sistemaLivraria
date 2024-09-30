using sistemaLivraria.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaLivraria.Controller
{
    internal class controller
    {
        public void P_AlterarporCodigoFun()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_AlterarporCodigoFun", cn);
            cmd.CommandType = System.Data .CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@codigoFun", Funcionarios.CodigoFun);
                cmd.Parameters.AddWithValue("@nomeFun", Funcionarios.NomeFun);
                cmd.Parameters.AddWithValue("@cpfFun", Funcionarios.CpfFun);
                cmd.Parameters.AddWithValue("@emailFun", Funcionarios.EmailFun);
                cmd.Parameters.AddWithValue("@cargoFun", Funcionarios.CargoFun);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros Alterados com Sucesso.");
            }
            catch
            {
                throw;
            }

        }
    }
}
