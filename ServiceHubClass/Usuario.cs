using servicehub;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHubClass
{
    internal class Usuario
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

        public Usuario(string? nome, string? email, Nivel? nivel, string? senha, bool ativo)
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
        public Nivel? nivel { get; set; }
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

        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_altera";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnivel", nivel.Id);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();

        }

        public static Usuario obterPorId(int id)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuario = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    Nivel.ObterPorId(dr.GetInt32(5)),
                    dr.GetString(4),
                    dr.GetBoolean(5)
                    );

            }
            dr.Close();
            cmd.Connection.Close();
            return usuario;
        }

        public static List<Usuario> obterLista()
        {
            List<Usuario> usuarios = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuarios.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    Nivel.ObterPorId(dr.GetInt32(5)),
                    dr.GetString(4),
                    dr.GetBoolean(5)
                    ));

            }
            dr.Close();
            cmd.Connection.Close();
            return usuarios;
        }
    }
}
