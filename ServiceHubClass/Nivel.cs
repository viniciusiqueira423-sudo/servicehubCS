using System;
using System.Collections.Generic;
using System.Data;
using servicehub;

namespace ServiceHubClass
{
    public class Nivel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public Nivel()
        {
            Id = 0;
            Nome = "";
            Sigla = "";
        }

        public Nivel(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }

        public Nivel(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_nivel_insert";

            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);

            Id = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Connection.Close();
        }

        public static Nivel ObterPorId(int id)
        {
            Nivel nivel = new Nivel();

            var cmd = Banco.Abrir();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM niveis WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            var dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                nivel.Id = dr.GetInt32(0);
                nivel.Nome = dr.GetString(1);

                if (!dr.IsDBNull(2))
                    nivel.Sigla = dr.GetString(2);
            }

            dr.Close();
            cmd.Connection.Close();

            return nivel;
        }

        public static List<Nivel> ObterLista(string busca = "")
        {
            List<Nivel> lista = new();

            var cmd = Banco.Abrir();

            cmd.CommandType = CommandType.Text;

            if (string.IsNullOrWhiteSpace(busca))
            {
                cmd.CommandText =
                    "SELECT * FROM niveis ORDER BY nome";
            }
            else
            {
                cmd.CommandText =
                    "SELECT * FROM niveis WHERE nome LIKE @busca ORDER BY nome";

                cmd.Parameters.AddWithValue(
                    "@busca",
                    "%" + busca + "%"
                );
            }

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Nivel nivel = new Nivel();

                nivel.Id = dr.GetInt32(0);
                nivel.Nome = dr.GetString(1);

                if (!dr.IsDBNull(2))
                    nivel.Sigla = dr.GetString(2);

                lista.Add(nivel);
            }

            dr.Close();
            cmd.Connection.Close();

            return lista;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}