﻿using System;

namespace cadastroPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            /*PessoaFisica pf = new PessoaFisica();
            PessoaFisica novaPf = new PessoaFisica();
            Endereco end = new Endereco();

            end.logradouro = "Av.Brasil";
            end.numero = 1384;
            end.complemento = "Proximo ao Senai";
            end.enderecoComercial = false;

            novaPf.endereco = end;
            novaPf.cpf = "123456789";
            novaPf.nome = "Pessoa fisica";
            novaPf.dataNascimento = new DateTime(2000, 06, 15);

            Console.WriteLine($"Rua: {novaPf.endereco.logradouro}, Numero: {novaPf.endereco.numero}");
            bool idadeValida = pf.validarDataNascimento(novaPf.dataNascimento);

            if (idadeValida == true)
            {
                Console.WriteLine($"Cadastro Aprovado!");
            }
            else
            {
                Console.WriteLine($"Cadastro Reprovado!");
            }*/


            PessoaJuridica pj = new PessoaJuridica();
            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco end = new Endereco();

            end.logradouro = "Av.Lisboa";
            end.numero = 1028;
            end.complemento = "Proximo ao Clube X";
            end.enderecoComercial = true;

            novaPj.endereco = end;
            novaPj.cnpj = "12345678900001";
            novaPj.razaoSocial = "Pessoa Juridica";

            if (pj.validarCNPJ(novaPj.cnpj))
            {
                Console.WriteLine($"CNPJ Valido!");
            }
            else
            {
                Console.WriteLine($"CNPJ Invalido!");
            }
        }
    }
}
