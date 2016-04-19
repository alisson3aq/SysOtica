using SysOtica.Negocio.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SysOtica.Conexao
{
    public class ClienteDados : ConexaoBD, IConexaoBD
    {
        public void Insert(Cliente cliente)
        {
            try
            {
                //abrir a conexão
                this.Conecta();
                string sql = "INSERT INTO cliente cl_nome, cl_datanascimento, cl_cpf, cl_rg, cl_telefone, cl_celular, cl_telefone2, cl_cep, cl_endereco, cl_numero, cl_bairro, cl_cidade, cl_email, cl_nomepai, cl_nomemae, cl_profissao, cl_observacoes, cl_uf";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cl_nome", SqlDbType.VarChar);
                cmd.Parameters["@cl_nome"].Value = cliente.Cl_nome;

                cmd.Parameters.Add("@cl_datanascimento", SqlDbType.Date);
                cmd.Parameters["@cl_datanascimento"].Value = cliente.Cl_datanascimento;

                cmd.Parameters.Add("@cl_cpf", SqlDbType.VarChar);
                cmd.Parameters["@cl_cpf"].Value = cliente.Cl_cpf;

                cmd.Parameters.Add("@cl_rg", SqlDbType.VarChar);
                cmd.Parameters["@cl_rg"].Value = cliente.Cl_rg;

                cmd.Parameters.Add("@cl_telefone", SqlDbType.VarChar);
                cmd.Parameters["@cl_telefone"].Value = cliente.Cl_telefone;

                cmd.Parameters.Add("@cl_celular", SqlDbType.VarChar);
                cmd.Parameters["@cl_celular"].Value = cliente.Cl_celular;

                cmd.Parameters.Add("@cl_telefone2", SqlDbType.VarChar);
                cmd.Parameters["@cl_telefone2"].Value = cliente.Cl_telefone2;

                cmd.Parameters.Add("@cl_cep", SqlDbType.VarChar);
                cmd.Parameters["@cl_cep"].Value = cliente.Cl_cep;

                cmd.Parameters.Add("@cl_endereco", SqlDbType.VarChar);
                cmd.Parameters["@cl_endereco"].Value = cliente.Cl_endereco;

                cmd.Parameters.Add("@cl_numero", SqlDbType.VarChar);
                cmd.Parameters["@cl_numero"].Value = cliente.Cl_numero;

                cmd.Parameters.Add("@cl_bairro", SqlDbType.VarChar);
                cmd.Parameters["@cl_bairro"].Value = cliente.Cl_bairro;

                cmd.Parameters.Add("@cl_cidade", SqlDbType.VarChar);
                cmd.Parameters["@cl_cidade"].Value = cliente.Cl_cidade;

                cmd.Parameters.Add("@cl_uf", SqlDbType.VarChar);
                cmd.Parameters["@cl_uf"].Value = cliente.Cl_uf;

                cmd.Parameters.Add("@cl_email", SqlDbType.VarChar);
                cmd.Parameters["@cl_email"].Value = cliente.Cl_email;

                cmd.Parameters.Add("@cl_nomepai", SqlDbType.VarChar);
                cmd.Parameters["@cl_nomepai"].Value = cliente.Cl_nomepai;

                cmd.Parameters.Add("@cl_nomemae", SqlDbType.VarChar);
                cmd.Parameters["@cl_nomemae"].Value = cliente.Cl_nomemae;

                cmd.Parameters.Add("@cl_profissao", SqlDbType.VarChar);
                cmd.Parameters["@cl_profissao"].Value = cliente.Cl_profissao;

                cmd.Parameters.Add("@cl_observacoes", SqlDbType.VarChar);
                cmd.Parameters["@cl_observacoes"].Value = cliente.Cl_observacoes;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.Desconecta();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Conectar e inserir " + ex.Message);
            }
        }

        public void update(Cliente cliente)
        {
            try
            {
                //abrir a conexão
                this.Conecta();
                string sql = "UPDATE cliente SET ( cl_nome = @cl_nome, cl_datanascimento = @cl_datanascimento, cl_cpf	= @cl_cpf, cl_rg = @cl_rg, cl_telefone = @cl_telefone, cl_celular = @cl_celular, cl_telefone2 = @cl_telefone2, cl_cep = @cl_cep, cl_endereco = @cl_endereco, cl_numero = @cl_numero, cl_bairro	= @cl_bairro, cl_cidade = @cl_cidade, cl_uf = @cl_uf, cl_email = @cl_email, cl_nomepai = @cl_nomepai, cl_nomemae = @cl_nomemae, cl_profissao = @cl_profissao, cl_observacoes = @cl_observacoes) WHERE cl_id = @cl_id;";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cl_id", SqlDbType.Int);
                cmd.Parameters["@cl_id"].Value = cliente.Cl_id;

                cmd.Parameters.Add("@cl_nome", SqlDbType.VarChar);
                cmd.Parameters["@cl_nome"].Value = cliente.Cl_nome;

                cmd.Parameters.Add("@cl_datanascimento", SqlDbType.Date);
                cmd.Parameters["@cl_datanascimento"].Value = cliente.Cl_datanascimento;

                cmd.Parameters.Add("@cl_cpf", SqlDbType.VarChar);
                cmd.Parameters["@cl_cpf"].Value = cliente.Cl_cpf;

                cmd.Parameters.Add("@cl_rg", SqlDbType.VarChar);
                cmd.Parameters["@cl_rg"].Value = cliente.Cl_rg;

                cmd.Parameters.Add("@cl_telefone", SqlDbType.VarChar);
                cmd.Parameters["@cl_telefone"].Value = cliente.Cl_telefone;

                cmd.Parameters.Add("@cl_celular", SqlDbType.VarChar);
                cmd.Parameters["@cl_celular"].Value = cliente.Cl_celular;

                cmd.Parameters.Add("@cl_telefone2", SqlDbType.VarChar);
                cmd.Parameters["@cl_telefone2"].Value = cliente.Cl_telefone2;

                cmd.Parameters.Add("@cl_cep", SqlDbType.VarChar);
                cmd.Parameters["@cl_cep"].Value = cliente.Cl_cep;

                cmd.Parameters.Add("@cl_endereco", SqlDbType.VarChar);
                cmd.Parameters["@cl_endereco"].Value = cliente.Cl_endereco;

                cmd.Parameters.Add("@cl_numero", SqlDbType.VarChar);
                cmd.Parameters["@cl_numero"].Value = cliente.Cl_numero;

                cmd.Parameters.Add("@cl_bairro", SqlDbType.VarChar);
                cmd.Parameters["@cl_bairro"].Value = cliente.Cl_bairro;

                cmd.Parameters.Add("@cl_cidade", SqlDbType.VarChar);
                cmd.Parameters["@cl_cidade"].Value = cliente.Cl_cidade;

                cmd.Parameters.Add("@cl_uf", SqlDbType.VarChar);
                cmd.Parameters["@cl_uf"].Value = cliente.Cl_uf;

                cmd.Parameters.Add("@cl_email", SqlDbType.VarChar);
                cmd.Parameters["@cl_email"].Value = cliente.Cl_email;

                cmd.Parameters.Add("@cl_nomepai", SqlDbType.VarChar);
                cmd.Parameters["@cl_nomepai"].Value = cliente.Cl_nomepai;

                cmd.Parameters.Add("@cl_nomemae", SqlDbType.VarChar);
                cmd.Parameters["@cl_nomemae"].Value = cliente.Cl_nomemae;

                cmd.Parameters.Add("@cl_profissao", SqlDbType.VarChar);
                cmd.Parameters["@cl_profissao"].Value = cliente.Cl_profissao;

                cmd.Parameters.Add("@cl_observacoes", SqlDbType.VarChar);
                cmd.Parameters["@cl_observacoes"].Value = cliente.Cl_observacoes;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.Desconecta();
            }
            catch (Exception ex)
            {
                throw new Exception("erro ao conectar e atualizar " + ex.Message);
            }
        }

        public void delete(Cliente cliente)
        {
            try
            {
                //abrir a conexão
                this.Conecta();
                string sql = "DELETE FROM cliente WHERE cl_id = @cl_id";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@cl_id", SqlDbType.Int);
                cmd.Parameters["@cl_id"].Value = cliente.Cl_id;
                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.Desconecta();
            }
            catch (Exception
                ex)
            {
                throw new Exception("erro ao conectar e remover " + ex.Message);
            }
        }

        public bool verificaduplicidade(Cliente cliente)
        {
            bool retorno = false;
            try
            {
                this.Conecta();
                //instrucao a ser executada
                string sql = "select * from cliente where cl_id = @cl_id";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.Add("@cl_id", SqlDbType.Int);
                cmd.Parameters["@cl_id"].Value = cliente.Cl_id;
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader dbreader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (dbreader.Read())
                {
                    retorno = true;
                    break;
                }
                //fechando o leitor de resultados
                dbreader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.Desconecta();
            }
            catch (Exception ex)
            {
                throw new Exception("erro ao conectar e selecionar " + ex.Message);
            }
            return retorno;
        }

        public List<Cliente> select(Cliente filtro)
        {
            List<Cliente> retorno = new List<Cliente>();
            try
            {
                this.Conecta();
                //instrucao a ser executada
                string sql = "select * from cliente where cl_id = @cl_id";
                //se foi passada uma matricula válida, esta matricula entrará como critério de filtro
                if (filtro.Cl_id > 0)
                {
                    sql += " and  cl_id = @cl_id";
                }
                //se foi passada um nome válido, este nome entrará como critério de filtro
                if (filtro.Cl_nome != null && filtro.Cl_nome.Trim().Equals("") == false)
                {
                    sql += " and nome like '%@Cl_nome%'";
                }
                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                //se foi passada uma matricula válida, esta matricula entrará como critério de filtro
                if ( filtro.Cl_id > 0)
                {
                    cmd.Parameters.Add("@cl_id", SqlDbType.Int);
                    cmd.Parameters["@cl_id"].Value = filtro.Cl_id;
                }
                //se foi passada um nome válido, este nome entrará como critério de filtro
                if (filtro.Cl_nome != null && filtro.Cl_nome.Trim().Equals("") == false)
                {
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                    cmd.Parameters["@nome"].Value = filtro.Cl_nome;

                }
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader dbreader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (dbreader.Read())
                {
                    Cliente cliente = new Cliente();
                    //acessando os valores das colunas do resultado
                    
                    cliente.Cl_id = dbreader.GetInt32(dbreader.GetOrdinal("@cl_id"));
                    cliente.Cl_nome = dbreader.GetString(dbreader.GetOrdinal("@cl_nome"));
                    cliente.Cl_datanascimento = dbreader.GetDateTime(dbreader.GetOrdinal("@cl_datanascimento"));
                    cliente.Cl_cpf = dbreader.GetString(dbreader.GetOrdinal("@cl_cpf"));
                    cliente.Cl_rg = dbreader.GetString(dbreader.GetOrdinal("@cl_rg"));
                    cliente.Cl_telefone = dbreader.GetString(dbreader.GetOrdinal("@cl_telefone"));
                    cliente.Cl_celular = dbreader.GetString(dbreader.GetOrdinal("@cl_celular"));
                    cliente.Cl_telefone2 = dbreader.GetString(dbreader.GetOrdinal("@cl_telefone2"));
                    cliente.Cl_cep = dbreader.GetString(dbreader.GetOrdinal("@cl_cep"));
                    cliente.Cl_endereco = dbreader.GetString(dbreader.GetOrdinal("@cl_endereco"));
                    cliente.Cl_numero = dbreader.GetString(dbreader.GetOrdinal("@cl_numero"));
                    cliente.Cl_bairro = dbreader.GetString(dbreader.GetOrdinal("@cl_bairro"));
                    cliente.Cl_cidade = dbreader.GetString(dbreader.GetOrdinal("@cl_cidade"));
                    cliente.Cl_email = dbreader.GetString(dbreader.GetOrdinal("@cl_email"));
                    cliente.Cl_nomepai = dbreader.GetString(dbreader.GetOrdinal("@cl_nomepai"));
                    cliente.Cl_nomemae = dbreader.GetString(dbreader.GetOrdinal("@cl_nomemae"));
                    cliente.Cl_profissao = dbreader.GetString(dbreader.GetOrdinal("@cl_profissao"));
                    cliente.Cl_observacoes = dbreader.GetString(dbreader.GetOrdinal("@cl_observacoes"));
                    cliente.Cl_uf = dbreader.GetString(dbreader.GetOrdinal("@cl_uf"));
                    retorno.Add(cliente);
                }
                //fechando o leitor de resultados
                dbreader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.Desconecta();
            }
            catch (Exception ex)
            {
                throw new Exception("erro ao conectar e selecionar " + ex.Message);
            }
            return retorno;
        }
    }
}
