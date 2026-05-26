using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using servicehub;
using System.Data;

namespace ServiceHubClass
{
    public class Categoria
    {

        //atributos(campos)
        private int id;
        private string nome;
        private string sigla;




        //propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }


        //construtores (metodos)

        public Categoria(int id, string nome, string sigla)
        {
            this.id = id;
            this.nome = nome;
            this.sigla = sigla;
        }

        //metodos (funcionalidades RFs) - inserir, atualizar, listar, obterPorId, excluirPorId

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            if (cmd.Connection.State == System.Data.ConnectionState.Open)
            {
                cmd.CommandType = cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_categoria_insert";
                cmd.Parameters.AddWithValue("spnome", Nome);
                cmd.Parameters.AddWithValue("spsigla", Sigla);
                id = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Connection.Close();
            }
        }
        public static Categoria ObterPorId(int id)
        {
            Categoria cat = new Categoria();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from categorias where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cat = new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
            }
            dr.Close();
            cmd.Connection.Close();
            return cat;
        }
    }
}
