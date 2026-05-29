using Org.BouncyCastle.Tls;
using servicehub;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Google.Protobuf.WellKnownTypes;

namespace ServiceHubClass
{
    internal class Nivel
    {
        // Atributos
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }
        //construtores 
        public Nivel()
        {
            Id = 0;
        }
        public Nivel(string? nome, string? sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }
        public Nivel(int id, string? nome, string? sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }
        public Nivel(int id)
        {
            Id = id;
        }
        // Métodos 
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_nivel_insert";
                cmd.Parameters.AddWithValue("spnome", Nome);
                cmd.Parameters.AddWithValue("spsigla", Sigla);
                Id = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Connection.Close();
            }
        }
        public static Nivel  ObterPorId(int id)
        {
            Nivel nv = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from nivel where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                nv = new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
            }
            dr.Close();
            cmd.Connection.Close();
            return nv;
        }
        public static List<Nivel> ObterLista(string busca = "")
        {
            List<Nivel> niv = new List<Nivel>();
            var cmd = Banco.Abrir();
            if (cmd.Connection.State == ConnectionState.Open)
            {
                if (busca != "")
                {
                    cmd.CommandText = $"select * from niveis where nome like" +
                        $"'%" + busca + "%' order by nome";
                }
                else
                {
                    cmd.CommandText = $"select * from niveis order by nome";
                }
                cmd.CommandType = CommandType.Text;
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    niv.Add(new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2) ?? ""));
                }
                dr.Close();
                cmd.Connection.Close();
            }
            return niv;
        }


    }
}
