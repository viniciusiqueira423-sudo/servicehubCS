using System;
using System.Collections.Generic;
using System.Data;
using servicehub;

namespace ServiceHubClass
{
    public class Fornecedor
    {
        // Propriedades
        public int Id { get; set; }
        public string? RazaoSocial { get; set; }
        public string? Fantasia { get; set; }
        public string? Cnpj { get; set; }
        public string? Contato { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }

        // Construtores
        public Fornecedor()
        {

        }

        public Fornecedor(int id)
        {
            Id = id;
        }

        public Fornecedor(
            string? razaoSocial,
            string? fantasia,
            string? cnpj,
            string? contato,
            string? telefone,
            string? email)
        {
            RazaoSocial = razaoSocial;
            Fantasia = fantasia;
            Cnpj = cnpj;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }

        public Fornecedor(
            int id,
            string? razaoSocial,
            string? fantasia,
            string? cnpj,
            string? contato,
            string? telefone,
            string? email)
        {
            Id = id;
            RazaoSocial = razaoSocial;
            Fantasia = fantasia;
            Cnpj = cnpj;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }

        // Inserir
        public void Inserir()
        {
            var cmd = Banco.Abrir();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fornecedor_insert";

            cmd.Parameters.AddWithValue("sprazao_social", RazaoSocial);
            cmd.Parameters.AddWithValue("spfantasia", Fantasia);
            cmd.Parameters.AddWithValue("spcnpj", Cnpj);
            cmd.Parameters.AddWithValue("spcontato", Contato);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);

            Id = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Connection.Close();
        }

        // Atualizar
        public bool Atualizar()
        {
            bool atualizado = false;

            var cmd = Banco.Abrir();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fornecedor_update";

            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("sprazao_social", RazaoSocial);
            cmd.Parameters.AddWithValue("spfantasia", Fantasia);
            cmd.Parameters.AddWithValue("spcontato", Contato);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);

            if (cmd.ExecuteNonQuery() > 0)
            {
                atualizado = true;
            }

            cmd.Connection.Close();

            return atualizado;
        }

        // Excluir
        public bool Excluir()
        {
            bool excluido = false;

            var cmd = Banco.Abrir();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fornecedor_delete";

            cmd.Parameters.AddWithValue("spid", Id);

            if (cmd.ExecuteNonQuery() > 0)
            {
                excluido = true;
            }

            cmd.Connection.Close();

            return excluido;
        }

        // Obter por ID
        public static Fornecedor ObterPorId(int id)
        {
            Fornecedor fornecedor = new();

            var cmd = Banco.Abrir();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM fornecedores WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            var dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                fornecedor = new Fornecedor(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6)
                );
            }

            dr.Close();
            cmd.Connection.Close();

            return fornecedor;
        }

        // Obter Lista
        public static List<Fornecedor> ObterLista(string busca = "")
        {
            List<Fornecedor> fornecedores = new();

            var cmd = Banco.Abrir();

            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.CommandType = CommandType.Text;

                if (!string.IsNullOrEmpty(busca))
                {
                    cmd.CommandText =
                        "SELECT * FROM fornecedores " +
                        "WHERE fantasia LIKE @busca " +
                        "OR razao_social LIKE @busca " +
                        "ORDER BY fantasia";

                    cmd.Parameters.AddWithValue("@busca", "%" + busca + "%");
                }
                else
                {
                    cmd.CommandText =
                        "SELECT * FROM fornecedores ORDER BY fantasia";
                }

                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    fornecedores.Add(
                        new Fornecedor(
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(2),
                            dr.GetString(3),
                            dr.GetString(4),
                            dr.GetString(5),
                            dr.GetString(6)
                        )
                    );
                }

                dr.Close();
                cmd.Connection.Close();
            }

            return fornecedores;
        }

        // Validação
        public static string Cadastrar(Fornecedor fornecedor)
        {
            string msg = "";

            if (string.IsNullOrWhiteSpace(fornecedor.RazaoSocial))
                msg += "A razão social é obrigatória.\n";

            if (string.IsNullOrWhiteSpace(fornecedor.Fantasia))
                msg += "O nome fantasia é obrigatório.\n";

            if (string.IsNullOrWhiteSpace(fornecedor.Cnpj))
                msg += "O CNPJ é obrigatório.\n";

            if (string.IsNullOrWhiteSpace(fornecedor.Contato))
                msg += "O contato é obrigatório.\n";

            if (string.IsNullOrWhiteSpace(fornecedor.Telefone))
                msg += "O telefone é obrigatório.\n";

            if (string.IsNullOrWhiteSpace(fornecedor.Email))
                msg += "O email é obrigatório.\n";

            if (msg == "")
            {
                fornecedor.Inserir();
                msg = "Fornecedor cadastrado com sucesso!";
            }

            return msg;
        }

        public override string ToString()
        {
            return Fantasia ?? "";
        }
    }
}