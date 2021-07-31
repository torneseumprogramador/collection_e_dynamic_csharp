using System;
using System.Collections.Generic;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            básico para se tornar um super júnior
            Logica basica:
            https://www.torneseumprogramador.com.br/aula?id=G5Meca65XvM&aula=2&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=3kD3lFjGC_I&aula=3&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=AHNvqTHJA44&aula=4&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=qwM-8NQNlSU&aula=5&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=Vpakp9cEneg&aula=6&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=2H0OKTnXs0Q&aula=8&tipo=c-sharp&professor=Danilo

            Orientação a objetos basico:
            https://www.torneseumprogramador.com.br/aula?id=NcZPGJfYEx8&aula=10&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=zvZE0aFaCSI&aula=11&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=c1bvl_HqXKg&aula=12&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=WA6W0fRCddw&aula=13&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=IcATaBPJkis&aula=15&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=_V6i7i0ItHk&aula=18&tipo=c-sharp&professor=Danilo

            Aplicação Windows
            https://www.torneseumprogramador.com.br/aula?id=BNG-o96tH1s&aula=22&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=ClVlL2VIAAw&aula=23&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=C3Rm6KqoekE&aula=24&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=7GlgrnHFnGA&aula=26&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=debDTYe-m1U&aula=29&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=8UxrqaQFsZw&aula=32&tipo=c-sharp&professor=Danilo

            Webforms aspnet
            https://www.torneseumprogramador.com.br/aula?id=jXm_p2RSWjM&aula=45&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=sbCyjfRYSyo&aula=46&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=eVtLG0LiGD8&aula=47&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=l5Y_IXmmLDk&aula=50&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=mTkoFZBuajU&aula=54&tipo=c-sharp&professor=Danilo

            Aplicação 3 camadas arquitetura
            https://www.torneseumprogramador.com.br/aula?id=yeES4Bb60uY&aula=39&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=bdyEYA534MM&aula=40&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=EUTFkIX5ZEE&aula=41&tipo=c-sharp&professor=Danilo

            Aspnet MVC
            https://www.torneseumprogramador.com.br/aula?id=UpOVuM8dXKQ&aula=58&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=yJfTqnXeK44&aula=59&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=3czZtIQ5YkE&aula=60&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=Rpc2uEGbfgo&aula=61&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=Mz5I1H8DuYE&aula=62&tipo=c-sharp&professor=Danilo

            ORM Entity Framework
            https://www.torneseumprogramador.com.br/aula?id=QjetGzyyOHI&aula=67&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=OtLjyRoAkDA&aula=71&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=jmUCPsX9Ptg&aula=105&tipo=c-sharp&professor=Danilo

            DotnetCore API
            https://www.torneseumprogramador.com.br/aula?id=JdOWaQhriIU&aula=86&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=JeQyBUVq6Dk&aula=87&tipo=c-sharp&professor=Danilo
            https://www.torneseumprogramador.com.br/aula?id=1BGjnd82MAs&aula=89&tipo=c-sharp&professor=Danilo
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
