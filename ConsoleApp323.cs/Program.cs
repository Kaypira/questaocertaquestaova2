

namespace teste
{
    public class gg
    {
        public static void Main()

        {
            int opcao;
            do
            {
                Console.WriteLine("Digite a questão que você quer rodar");
                opcao = int.Parse(Console.ReadLine());
                classes classes = new classes();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine(classes.notas());

                        break;

                    case 2:
                        Console.WriteLine(classes.prof());

                        break;

                    case 3:
                        Console.WriteLine(classes.lanche());

                        break;

                    default:
                        Console.WriteLine("erro");
                        break;
                }

            } while (opcao != -1);


        }
    }
}