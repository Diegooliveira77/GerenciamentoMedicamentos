﻿using GerenciamentoMedicamentos.ModuloCompartilhado;
using GerenciamentoMedicamentosConsoleApp1.ModuloCompartilhado;

namespace GerenciamentoMedicamentos.ModuloFuncionario
{
    public class Funcionario : Entidade
    {
        static private int id = 0;

        public string Nome { get; set; }
        public string Cpf { get; set; }

        public string Login { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        public Funcionario()
        {
            ObterId(ref id);
        }

        public override string[] ObterAtributos()
        {
            string[] atributos = { (Id + ""), Nome, Cpf, Telefone, Endereco };
            return atributos;
        }

        public override void Atualizar(Entidade entidade)
        {
            Funcionario funcionario = (Funcionario)entidade;
            Nome = funcionario.Nome;
            Cpf = funcionario.Cpf;
            Login = funcionario.Login;
            Senha = funcionario.Senha;
            Telefone = funcionario.Telefone;
            Endereco = funcionario.Endereco;
        }

        public override Entidade ObterClasse()
        {
            return new Funcionario();
        }

    }
}