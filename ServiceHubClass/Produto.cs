using servicehub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ServiceHubClass
{
    //Metodos construtores 
    public class Produto
    {
        public Produto()
        {

        }
        public Produto
            (
            int id,
            string? codBarras,
            string? descricao,
            double valorUnit,
            string? unidadeVenda,
            Categoria? categoria,
            double estoqueMin,
            double classeDesconto
            )
        {
            this.id = id;
            this.codBarras = codBarras;
            this.descricao = descricao;
            this.valorUnit = valorUnit;
            this.unidadeVenda = unidadeVenda;
            Categoria = categoria;
            this.estoqueMin = estoqueMin;
            ClasseDesconto = classeDesconto;
        }

        public Produto(int id,
            string? codBarras,
            string? descricao,
            double valorUnit,
            string? unidadeVenda,
            Categoria? categoria,
            double estoqueMin,
            double classeDesconto,
            byte[] imagem,
            DateTime dataCad,
            bool descotinuado)
        {
            this.id = id;
            this.codBarras = codBarras;
            this.descricao = descricao;
            this.valorUnit = valorUnit;
            this.unidadeVenda = unidadeVenda;
            Categoria = categoria;
            this.estoqueMin = estoqueMin;
            ClasseDesconto = classeDesconto;
            this.imagem = imagem;
            this.dataCad = dataCad;
            this.descotinuado = descotinuado;
        }

        public Produto
            (

            string? codBarras,
            string? descricao,
            double valorUnit,
            string? unidadeVenda,
            Categoria? categoria,
            double estoqueMin,
            double classeDesconto
            )
        {
            this.codBarras = codBarras;
            this.descricao = descricao;
            this.valorUnit = valorUnit;
            this.unidadeVenda = unidadeVenda;
            Categoria = categoria;
            this.estoqueMin = estoqueMin;
            ClasseDesconto = classeDesconto;
        }

        //propriedades
        public int id { get; set; }
        public string? codBarras { get; set; }
        public string? descricao { get; set; }
        public double valorUnit { get; set; }
        public string? unidadeVenda { get; set; }
        public Categoria? Categoria { get; set; }
        public double estoqueMin { get; set; }
        public double ClasseDesconto { get; set; }
        public byte[]? imagem { get; set; }
        public DateTime dataCad { get; set; }
        public bool descotinuado { get; set; }


        //metodos CRUD- menos o delete

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.AddWithValue("spcod_barras", codBarras);
            cmd.Parameters.AddWithValue("spdescricao", descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", valorUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", unidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", estoqueMin);
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesconto);
            id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();

        }
        public bool Atualizar()
        {
            bool atualizado = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_update";
            cmd.Parameters.AddWithValue("spid", id);
            cmd.Parameters.AddWithValue("spcod_barras", codBarras);
            cmd.Parameters.AddWithValue("spdescricao", descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", valorUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", unidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", estoqueMin);
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesconto);
            if (cmd.ExecuteNonQuery() > 0)
            {
                atualizado = true;
            }
            cmd.Connection.Close();
            return atualizado;

        }
        public static Produto obterPorId(int id)
        {
            Produto produto = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from produtos where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                produto = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    dr.GetString(4),
                    Categoria.ObterPorId(dr.GetInt32(5)),
                    dr.GetDouble(6),
                    dr.GetDouble(7),
                    null,
                    dr.GetDateTime(9),
                    dr.GetBoolean(10)
                    );

            }
            dr.Close();
            cmd.Connection.Close();
            return produto;
        }
        public static List<Produto> obterLista()
        {
            List<Produto> produtos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from produtos order by descricao";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produtos.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    dr.GetString(4),
                    Categoria.ObterPorId(dr.GetInt32(5)),
                    dr.GetDouble(6),
                    dr.GetDouble(7),
                    null,
                    dr.GetDateTime(9),
                    dr.GetBoolean(10)
                    ));

            }
            dr.Close();
            cmd.Connection.Close();
            return produtos;
        }








    }
}
