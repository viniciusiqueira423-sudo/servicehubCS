using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using servicehub;

namespace ServiceHubClass
{
    public class Categoria
    {

        //atributos(campos)
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }

        // construtores (métodos)
        public Categoria()
        {
            Id = 0;
        }
        public Categoria(string? nome, string? sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }
        public Categoria(int id, string? nome, string? sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        // Métodos (Funcionalidades RFs)  - inserir, atualizar, obterLista, obterPorId(id), excluir(id)
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_categoria_insert";
                cmd.Parameters.AddWithValue("spnome", Nome);
                cmd.Parameters.AddWithValue("spsigla", Sigla);
                Id = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Connection.Close();
            }
        }
        public static Categoria ObterPorId(int id)
        {
            Categoria cat = new();
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

        public static List<Categoria> ObterLista(string busca = "")
        {

            List<Categoria> categorias = new List<Categoria>();
            var cmd = Banco.Abrir();// Abrir a conexão com o banco de dados usando o método Abrir da classe Banco
            if (cmd.Connection.State == ConnectionState.Open) // Verificar se a conexão foi aberta com sucesso
            {
                if (busca != "")
                {
                    cmd.CommandText = $"select * from categorias where nome like '%"+busca+"%' order by nome";
                }
                else
                {
                    cmd.CommandText = "select * from categorias order by nome";
                }
                cmd.CommandType = CommandType.Text;// Definir o tipo de comando como texto
                var dr = cmd.ExecuteReader();// Executar o comando e obter um DataReader para ler os resultados
                while (dr.Read())// Ler cada linha do resultado e criar um objeto Categoria para cada registro encontrado
                {
                    categorias.Add(new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2)??""));// Adicionar o objeto Categoria à lista de categorias
                }
                dr.Close();// Fechar o DataReader após a leitura dos resultados
                cmd.Connection.Close();// Fechar a conexão com o banco de dados
            
            }
            return categorias;// Retornar a lista de categorias obtida do banco de dados
        }
        public bool Atualizar()
        {
            //como este método não é estatico, precisamos considerar as propriedades
            //ja possuem valores atribuidos antes de chamar-lo.
            bool atualizada = false;
            if (Id < 1) return atualizada;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            if (cmd.ExecuteNonQuery() > 0) atualizada = true;
            cmd.Connection.Close();

            return atualizada;
        }

        public void Excluir(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_delete";
            cmd.Parameters.AddWithValue("spid", id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }


    }
}
