using System;
using System.Collections.Generic;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            Dado que eu tenho uma escola de programação
            Faça um programa que capture o nome, a matricula e as notas (4 notas) dos alunos
            Os alunos serão aprovados com notas igual ou maior que 7
            A quantidade de alunos é dinamica, ou seja, o usuário do programa pode digitar quantos alunos ele quiser.
            Obs: temos que digitat os nomes, as matriculas as notas e o sistema calcular o resto
            No final do programa, mostre um relatório assim:

            Segue a lista dos alunos:
            ------------------------------------
            Nome: xxx
            Matrícula: yyyy
            Notas: 1,2,3,4
            Média: 5.6
            Status: Aprovado
            ------------------------------------
            Nome: xxx
            Matrícula: yyyy
            Notas: 1,2,3,4
            Média: 5.6
            Status: Aprovado
            ------------------------------------
            Nome: xxx
            Matrícula: yyyy
            Notas: 1,2,3,4
            Média: 5.6
            Status: Aprovado
            ------------------------------------

            */



            List<dynamic> itens = new List<dynamic>();
            itens.Add(new {
                Nome = "Danilo",
                Telefone = "(11) 88888-2222",
                Endereco = "Rua teste 1234",
                Valores = new List<int>(){ 1, 2, 3}
            });
            itens.Add(new {
                Nome = "Danilo2",
                Telefone = "(11) 88888-2222",
                Endereco = "Rua teste 1234",
                Valores = new List<int>(){ 1, 2, 3}
            });
            itens.Add(new {
                Nome = "Danilo3",
                Telefone = "(11) 88888-2222",
                Endereco = "Rua teste 1234",
                Valores = new List<int>(){ 1, 2, 3}
            });

            // for(int i=0; i<itens.Count; i++)
            // {
            //     Console.WriteLine(itens[i].Nome);
            //     Console.WriteLine(itens[i].Telefone);
            //     Console.WriteLine(itens[i].Endereco);
            // }

            foreach(var cliente in itens)
            {
                Console.WriteLine(cliente.Nome);
                Console.WriteLine(cliente.Telefone);
                Console.WriteLine(cliente.Endereco);

                foreach(var valor in cliente.Valores){
                    Console.WriteLine(valor);
                }
            }
            var x = "";
        }
    }
}
