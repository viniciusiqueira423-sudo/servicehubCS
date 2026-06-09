using servicehub;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHubClass
{
    public class Usuario
    {
        public Usuario()
        {
            
        }

        public Usuario(int id, string? nome, string? email, Nivel? nivel, string? senha, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            this.nivel = nivel;
            Senha = senha;
            Ativo = ativo;
        }

        public Usuario(string? nome, string? email, Nivel nivel, string? senha, bool ativo)
        {
            Nome = nome;
            Email = email;
            this.nivel = nivel;
            Senha = senha;
            Ativo = ativo;
        }

        //metodos
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public Nivel nivel { get; set; }
        public string? Senha { get; set; }
        public bool Ativo { get; set; }


        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spnivel", nivel.Id);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();

        }

        public bool Atualizar()
        {
            bool atualizado = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_altera";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", nivel.Id);
            if (cmd.ExecuteNonQuery() > 0)
            {
                atualizado = true;
            }
            cmd.Connection.Close();
            return atualizado;
        }

        public static Usuario obterPorId(int id)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario = new(
                    dr.GetInt32(0),                 // id
                    dr.GetString(1),                // nome
                    dr.GetString(2),                // email
                    Nivel.ObterPorId(dr.GetInt32(5)), // nivel_id
                    dr.GetString(3),                // senha
                    dr.GetBoolean(4)                // ativo
                );

            }
            dr.Close();
            cmd.Connection.Close();
            return usuario;
        }

        public static List<Usuario> ObterLista(string busca = "")
        {
            List<Usuario> usuarios = new();

            var cmd = Banco.Abrir();

            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.CommandType = CommandType.Text;

                if (!string.IsNullOrEmpty(busca))
                {
                    cmd.CommandText = "select * from clientes where nome like @busca order by nome";
                    cmd.Parameters.AddWithValue("@busca", $"%{busca}%");
                }
                else
                {
                    cmd.CommandText = "select * from clientes order by nome";
                }

                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    usuarios.Add(new Usuario(
                    dr.GetInt32(0),                 // id
                    dr.GetString(1),                // nome
                    dr.GetString(2),                // email
                    Nivel.ObterPorId(dr.GetInt32(5)), // nivel_id (CORRETO)
                    dr.GetString(3),                // senha
                    dr.GetBoolean(4)                // ativo
                    ));
                }

                dr.Close();
                cmd.Connection.Close();
            }

            return usuarios;
        }

        public static bool Excluir(int id)
        {
            bool excluido = false;

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "DELETE FROM usuarios WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            if (cmd.ExecuteNonQuery() > 0)
            {
                excluido = true;
            }

            cmd.Connection.Close();

            return excluido;
        }
    }
}
