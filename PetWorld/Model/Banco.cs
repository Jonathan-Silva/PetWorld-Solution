using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace PetWorld.Model
{
    class Banco
    {
        public static SqlConnection Conexao = new SqlConnection(@"Data Source=JARVIS\HADES; Initial Catalog=Pet; User Id=Donnie; Password=darko; Integrated Security=false");

        public static void Abrir()
        {
            try
            {
                Conexao.Open();
            }
            catch (Exception)
            {


            }

        }
        public static void Fechar()
        {
            try
            {
                Conexao.Close();
            }
            catch (Exception)
            {

            }

        }

        public static int BuscarCodigo(string Tabela)
        {
            int Max = 0;
            string sqlstring = "";
            sqlstring = "select ID from " + Tabela + " order by Codigo desc";
            SqlCommand Comando = new SqlCommand(sqlstring, Banco.Conexao);
            SqlDataReader Ler = Comando.ExecuteReader();


            if (Ler.Read())
            {
                Max = Convert.ToInt32(Ler["Codigo"].ToString());
                Ler.Close();
            }


            return (Max);
        }


    }

}
