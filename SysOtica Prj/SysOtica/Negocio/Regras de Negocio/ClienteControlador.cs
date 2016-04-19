using SysOtica.Conexao;
using SysOtica.Negocio.Classes_Basicas;
using SysOtica.Negocio.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Regras_de_Negocio
{
    public class ClienteControlador
    {
        //string modelo_Email = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
        //string caracteres = "^[ a-zA-Z]+$";
        //string numeros = "^[ 0-9-]+$";
        //string LetraseNum = "^[ 0-9a-zA-Z.,-]+$";
        //string CidadeseBairros = "^[ a-zA-Z.-´^~]+$";

        ClienteDados cl = new ClienteDados();

        public Boolean verificaPreenchimento(Cliente cliente)
        {
            if (String.IsNullOrEmpty(cliente.Cl_nome))
            {
                throw new CampoVazioException("Nome Vazio!");
            }

            if (String.IsNullOrEmpty(Convert.ToDateTime((cliente.Cl_datanascimento)).ToString()))
            {
                throw new CampoVazioException("Campo Data está Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_cpf))
            {
                throw new CampoVazioException("CPF Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_rg))
            {
                throw new CampoVazioException("RG Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_telefone))
            {
                throw new CampoVazioException("Telefone Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_celular))
            {
                throw new CampoVazioException("Celular Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_telefone2))
            {
                throw new CampoVazioException("Telefone2 Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_cep))
            {
                throw new CampoVazioException("CEP Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_endereco))
            {
                throw new CampoVazioException("Endereço Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_numero))
            {
                throw new CampoVazioException("Número Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_bairro))
            {
                throw new CampoVazioException("Bairro Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_cidade))
            {
                throw new CampoVazioException("Cidade Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_email))
            {
                throw new CampoVazioException("Email Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_nomepai))
            {
                throw new CampoVazioException("Nome do Pai Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_nomemae))
            {
                throw new CampoVazioException("Nome da Mãe Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_profissao))
            {
                throw new CampoVazioException("Profissão Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_observacoes))
            {
                throw new CampoVazioException("Observação Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_uf))
            {
                throw new CampoVazioException("UF Vazio!");
            }
            return true;
        }


        //public void ValidaCliente(Cliente cliente)
        //{
        //    if (cliente.Cl_nome.Length > 3 || (!Regex.IsMatch(cliente.Cl_nome, caracteres)))
        //    {
        //        throw new CampoVazioException("Numero de caracteres inferior ou dados do Nome inválidos, favor tente novamente");
        //    }
        //    if (cliente.Cl_celular.Length < 11 || cliente.Cl_telefone.Length < 10 || cliente.Cl_telefone2.Length < 10)
        //    {
        //        throw new CampoVazioException("Numero de Celular ou Telefone inválidos, favor tente novamente");
        //    }
        //    if (cliente.Cl_rg.Length < 5 || (!Regex.IsMatch(cliente.Cl_rg, numeros)))
        //    {
        //        throw new CampoVazioException("Campo RG Invalido, favor tente novamente");
        //    }
        //    if (cliente.Cl_cep.Length < 8)
        //    {
        //        throw new CampoVazioException("Campo CEP Invalido, favor tente novamente");
        //    }
        //    if (cliente.Cl_endereco.Length < 7 || (!Regex.IsMatch(cliente.Cl_endereco, LetraseNum)))
        //    {
        //        throw new CampoVazioException("Campo Endereço Invalido, favor tente novamente");
        //    }
        //    if (cliente.Cl_numero.Length > 5 || cliente.Cl_numero.Equals("0") || (!Regex.IsMatch(cliente.Cl_numero, numeros)))
        //    {
        //        throw new CampoVazioException("Campo Numero Invalido, favor tente novamente");
        //    }
        //    if (cliente.Cl_bairro.Length < 4 || (!Regex.IsMatch(cliente.Cl_bairro, CidadeseBairros)))
        //    {
        //        throw new CampoVazioException("Campo Bairro Invalido, favor tente novamente");
        //    }
        //    if (cliente.Cl_cidade.Length < 4 || (!Regex.IsMatch(cliente.Cl_cidade, CidadeseBairros)))
        //    {
        //        throw new CampoVazioException("Campo Cidade Invalido, favor tente novamente");
        //    }
        //    if (cliente.Cl_uf.Length >= 2 )
        //    {
        //        throw new CampoVazioException("Campo UF Invalido, favor tente novamente");
        //    }
        //    if (cliente.Cl_nomepai.Length < 3 || (!Regex.IsMatch(cliente.Cl_nomepai, caracteres)))
        //    {
        //        throw new CampoVazioException("Campo Pai Invalido, favor tente novamente");
        //    }
        //    if (cliente.Cl_nomemae.Length < 3 || (!Regex.IsMatch(cliente.Cl_nomemae, caracteres)))
        //    {
        //        throw new CampoVazioException("Campo Mãe Invalido, favor tente novamente");
        //    }
        //    if (cliente.Cl_profissao.Length < 5 || (!Regex.IsMatch(cliente.Cl_profissao, caracteres)))
        //    {
        //        throw new CampoVazioException("Campo Profissão Invalido, favor tente novamente");
        //    }
        //    if (cliente.Cl_observacoes.Length < 5 || (!Regex.IsMatch(cliente.Cl_profissao, LetraseNum)))
        //    {
        //        throw new CampoVazioException("Campo Observação Invalido, favor tente novamente");
        //    }
        //    if (!Regex.IsMatch(cliente.Cl_email, modelo_Email))
        //    {
        //        throw new CampoVazioException("Campo Email Invalido, favor tente novamente");
        //    }

        //}



        public void Insert(Cliente cliente)
        {

            cl.Insert(cliente);

        }


    }
}
