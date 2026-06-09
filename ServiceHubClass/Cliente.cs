using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using servicehub;
using System.Data;

namespace ServiceHubClass
{
    public class Cliente
    {
        //metodos
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public DateOnly DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public Pedido? Pedido { get; set; }
        public Endereco? Endereco { get; set; }

        //construtores
        public Cliente()
        {

        }
        public Cliente
            (
            int id,
            string? nome,
            string? cpf,
            string? email,
            string? telefone,
            DateOnly dataNascimento,
            DateTime DataCadastro,
            bool ativo,
            Pedido? pedido,
            Endereco? endereco
            )
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            DataNascimento = dataNascimento;
            this.DataCadastro = DataCadastro;
            Ativo = ativo;
            Pedido = pedido;
            Endereco = endereco;
        }
        public Cliente
            (
            string? nome,
            string? cpf,
            string? email,
            string? telefone,
            DateOnly dataNascimento,
            DateTime DataCadastro,
            bool ativo,
            Pedido? pedido,
            Endereco? endereco
            )
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            DataNascimento = dataNascimento;
            this.DataCadastro = DataCadastro;
            Ativo = ativo;
            Pedido = pedido;
            Endereco = endereco;
        }
        public Cliente
            (
            int id,
            string? nome,
            string? cpf,
            string? email,
            string? telefone,
            DateOnly dataNascimento,
            DateTime DataCadastro,
            bool ativo
            )
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            DataNascimento = dataNascimento;
            this.DataCadastro = DataCadastro;
            Ativo = ativo;
        }
        //metodos

        //inserir
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spdata_nascimento", DataNascimento.ToDateTime(new TimeOnly(0, 0)));
            cmd.Parameters.AddWithValue("spdata_cadastro", DataCadastro);
            cmd.Parameters.AddWithValue("spativo", Ativo);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }
        //atualizar
        public bool Atualizar()
        {
            bool atualizado = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spdata_nascimento", DataNascimento.ToDateTime(new TimeOnly(0, 0)));
            cmd.Parameters.AddWithValue("spdata_cadastro", DataCadastro);
            cmd.Parameters.AddWithValue("spativo", Ativo);
            if (cmd.ExecuteNonQuery() > 0)
                atualizado = true;
            cmd.Connection.Close();
            return atualizado;
        }
        //obter por id
        public static Cliente ObterPorId(int id)
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from clientes where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cliente.Id = dr.GetInt32(0);
                cliente.Nome = dr.GetString(1);
                cliente.Cpf = dr.GetString(2);
                cliente.Email = dr.GetString(3);
                cliente.Telefone = dr.GetString(4);
                cliente.DataNascimento = DateOnly.FromDateTime(dr.GetDateTime(5));
                cliente.DataCadastro = dr.GetDateTime(6);
                cliente.Ativo = dr.GetBoolean(7);
            }
            cmd.Connection.Close();
            return cliente;
        }
        //obter lista
        public static List<Cliente> ObterLista(string busca)
        {
            List<Cliente> clientes = new();
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
                    clientes.Add(new Cliente
                        (
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        DateOnly.FromDateTime(dr.GetDateTime(5)),
                        dr.GetDateTime(6),
                        dr.GetBoolean(7)
                        ));
                }
                dr.Close();
                cmd.Connection.Close();
            }
            return clientes;
        }
        //cadastrar, valida os dados para lançar o inserir
        public static string Cadastrar(Cliente cliente)
        {
            string msg = "";
            if (string.IsNullOrEmpty(cliente.Nome))
                msg += "O nome do cliente é obrigatório.\n";
            if (string.IsNullOrEmpty(cliente.Cpf))
                msg += "O CPF do cliente é obrigatório.\n";
            if (string.IsNullOrEmpty(cliente.Email))
                msg += "O email do cliente é obrigatório.\n";
            if (string.IsNullOrEmpty(cliente.Telefone))
                msg += "O telefone do cliente é obrigatório.\n";
            if (cliente.DataNascimento == DateOnly.MinValue)
                msg += "A data de nascimento do cliente é obrigatória.\n";
            if (cliente.DataCadastro == DateTime.MinValue)
                msg += "A data de cadastro do cliente é obrigatória.\n";
            if (string.IsNullOrEmpty(msg))
            {
                cliente.Inserir();
                msg = "Cliente cadastrado com sucesso!";
            }
            return msg;

        }

        public static bool Excluir(int id)
        {
            bool excluido = false;

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "DELETE FROM clientes WHERE id = @id";
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
