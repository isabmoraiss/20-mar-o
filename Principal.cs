using System;

namespace Pessoa
{
    class Principal
    {
        static void Main(string[] args)
        {
            //método construtor
            //TIPO_DO_DADO | NOME DA INSTÂNCIA(OBJETO) | OPERADOR NEW | MÉTODO CONSTRUTOR
            Pessoa pessoal = new Pessoa();
            Pessoa pessoa2 = new Pessoa();



            //invocar o método provarExistencia pessoal. provarExistencia();
            //inserir dados no objeto
            pessoal.nome = "Elias";
            pessoal.email = "e@e";
            pessoal.login = "elias";
            pessoal.senha = "123";

            //inserir dados no objeto 
            pessoa2.nome = "José";
            pessoa2.email = "j@j";
            pessoa2.login = "jose";
            pessoa2.senha = "456";

            // recuperar os dados do objeto
            Console.WriteLine(pessoal.nome);
            Console.WriteLine(pessoal.email);
            Console.WriteLine(pessoal.login);
            Console.WriteLine(pessoal.senha);

            //recuperar os dados do objeto
            Console.WriteLine(pessoa2.nome);
            Console.WriteLine(pessoa2.email);
            Console.WriteLine(pessoa2.login);
            Console.WriteLine(pessoa2.senha);
        }
    }
    }
