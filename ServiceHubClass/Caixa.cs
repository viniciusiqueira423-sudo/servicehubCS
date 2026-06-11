using servicehub;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHubClass

{

    public class Caixa

    {

        //Getters e Setters

        public int id { get; set; }

        public int usuario_id { get; set; }

        public DateTime? dataAbertura { get; set; }

        public decimal? saldoInicial { get; set; }

        public char? status { get; set; }



        public Caixa()

        {

        }

        public Caixa(int id, int usuario_id, DateTime dataAbertura, decimal saldoInicial, char status)

        {

            this.id = id;

            this.usuario_id = usuario_id;

            this.dataAbertura = dataAbertura;

            this.saldoInicial = saldoInicial;

            this.status = status;

        }

        public Caixa(int usuario_id, DateTime dataAbertura, decimal saldoInicial, char status)

        {

            this.usuario_id = usuario_id;

            this.dataAbertura = dataAbertura;

            this.saldoInicial = saldoInicial;

            this.status = status;

        }


        public bool Inserir()

        {

            var cmd = Banco.Abrir();

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "sp_caixa_insert";

            cmd.Parameters.AddWithValue("spusuario_id", usuario_id);

            cmd.Parameters.AddWithValue("spsaldo_inicial", saldoInicial);

            id = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Connection.Close();

            return id > 0;

        }

        public bool Atualizar()

        {

            bool atualizado = false;

            var cmd = Banco.Abrir();

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "sp_caixa_update";

            cmd.Parameters.AddWithValue("spid", id);

            cmd.Parameters.AddWithValue("spstatus", status);

            if (cmd.ExecuteNonQuery() > 0)

            {

                atualizado = true;

            }

            cmd.Connection.Close();

            return atualizado;

        }

        public static Caixa ObterPorId(int id)

        {

            Caixa caixa = new Caixa();

            var cmd = Banco.Abrir();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = $"select * from caixas where id = {id}";

            var dr = cmd.ExecuteReader();

            if (dr.Read())

            {

                caixa = new Caixa

                {

                    id = dr.GetInt32(0),

                    usuario_id = dr.GetInt32(1),

                    dataAbertura = dr.GetDateTime(2),

                    saldoInicial = dr.GetDecimal(3),

                    status = dr.GetChar(4),

                };

            }

            return caixa;

        }

        public static List<Caixa> ObterLista()

        {

            List<Caixa> caixas = new();

            var cmd = Banco.Abrir();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = $"select * from caixas order by id";

            var dr = cmd.ExecuteReader();

            while (dr.Read())

            {

                caixas.Add(new Caixa

                {

                    id = dr.GetInt32(0),

                    usuario_id = dr.GetInt32(1),

                    dataAbertura = dr.GetDateTime(2),

                    saldoInicial = dr.GetDecimal(3),

                    status = dr.GetChar(4),

                });

            }

            dr.Close();

            cmd.Connection.Close();

            return caixas;

        }

        public bool AbrirCaixa()

        {

            bool aberto = false;

            var cmd = Banco.Abrir();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = $"update caixas set status = 'A' where id = {id}";

            if (cmd.ExecuteNonQuery() > 0)

            {

                status = 'A';

                aberto = true;

            }

            cmd.Connection.Close();

            return aberto;

        }

        public bool FecharCaixa()

        {

            bool fechado = false;

            var cmd = Banco.Abrir();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = $"update caixas set status = 'f' where id = {id}";

            if (cmd.ExecuteNonQuery() > 0)

            {

                status = 'F';

                fechado = true;

            }

            cmd.Connection.Close();

            return fechado;

        }

        public decimal CalcularSaldo()

        {

            return saldoInicial ?? 0;

        }





    }

}

