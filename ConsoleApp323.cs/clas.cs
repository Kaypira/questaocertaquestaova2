using System;

namespace teste
{
    public class classes
    {
        public string notas()
        {

            Console.WriteLine("questao 10");
            Console.WriteLine("escreva a nota do aluno 1");
            int nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("escreva a nota do aluno 2");
            int nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("escreva a nota do aluno 3");
            int nota3 = int.Parse(Console.ReadLine());
            Console.WriteLine("escreva a nota do aluno 4");
            int nota4 = int.Parse(Console.ReadLine());

            int soma1 = (nota1 + nota2 + nota3 + nota4) / 4;
            string vari = "";


            if (soma1 >= 6)
            {
                vari = ("voce esta aprovado a media é " + soma1);
            }
            else
            {
                vari = ("voce esta reprovado a media é" + soma1);

            }
            return vari;


        }
        public string prof()
        {
            Console.WriteLine("questao 11");
            Console.WriteLine("Professor nivel 1");
            Console.WriteLine("Professor nivel 2");
            Console.WriteLine("Professor nivel 3");
            Console.WriteLine("digite o nivel do professor");
            int nivelp = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de horas trabalhadas");
            int horastra = int.Parse(Console.ReadLine());
            double valortra = 0;

            switch (nivelp)
            {
                case 1:
                    valortra = 12.00;
                    break;

                case 2:
                    valortra = 17.00;
                    break;
                case 3:
                    valortra = 25.00;
                    break;

                default:
                    return("NIVEL INVALIDO");
                    
            }

            double salario = valortra * horastra;
            return ("o seu salario sera " + salario);

        }

       
        public string lanche()
        {
            Console.WriteLine("questao 12");

            Console.WriteLine("100 Cachorro quente = R$1,10");
            Console.WriteLine("101 Bauru simples = R$1,30");
            Console.WriteLine("102 bauru com ovo = R$1,50");
            Console.WriteLine("103 Hamburger = R$1,10");
            Console.WriteLine("104 CheeseBurger = R$1,30");
            Console.WriteLine("105 Refrigente = R$1,00");
            Console.WriteLine("Digite o codigo do item");
            int codigoitem = int.Parse(Console.ReadLine());
            Console.WriteLine("digite a quantidade");
            int quant = int.Parse(Console.ReadLine());
            double precouni = 0;
            string nomeproduto = "";


            switch (codigoitem)
            {


                case 100:
                    nomeproduto = "cachorro quente";
                    precouni = 1.10;
                    break;
                case 101:
                    nomeproduto = "bauru simples";
                    precouni = 1.30;
                    break;
                case 102:
                    nomeproduto = "bauru com ovo";
                    precouni = 1.50;
                    break;
                case 103:
                    nomeproduto = "hamburger";
                    precouni = 1.10;
                    break;
                case 104:
                    nomeproduto = "cheeseburger";
                    precouni = 1.30;
                    break;
                case 105:
                    nomeproduto = "refrigerante";
                    precouni = 1.00;
                    break;
                default:
                    return ("codigo invalido");
                   
            }
            double valortotal = precouni * quant;

            return ("nome produto" + nomeproduto + "\n" +
            "quantidade" + quant + "\n" +
            "preco unidade " + precouni + "\n" +
            "codigo do item " + codigoitem + "\n" +
            "valor a ser pago " + valortotal);
        }

    }
}