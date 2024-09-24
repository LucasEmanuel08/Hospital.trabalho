using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace working
{
    internal class Paciente
    {
        public string[] nome = new string[10];
        public int[] dataNasc = new int[10];
        public string[] email = new string[10];
        public string[] CPF = new string[10];
        public int[] prioridade = new int[10];
        public int[] genero = new int[10];

        public void cadastrarPaciente()
        {

            Console.WriteLine("\tCADASTRO");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\nDigite o nome do paciente:");
                nome[0] = Console.ReadLine();
                Console.WriteLine("\nDigite a data de nascimento do paciente(ddmmaaaa):");
                dataNasc[0] = int.Parse(Console.ReadLine());
                Console.WriteLine("\nDigite o e-mail do paciente:");
                email[0] = Console.ReadLine();
                Console.WriteLine("\nDigite o CPF do paciente:");
                CPF[0] = Console.ReadLine();
                Console.WriteLine("\n Qual a prioridade do paciente? Digite:\n '1' para 'Azul'\n '2' para 'Verde'\n '3' para 'Amarelo'\n '4' para 'Laranja'\n '5' para 'Vermelho'");
                prioridade[0] = int.Parse(Console.ReadLine());
                if (prioridade[0] < 1 || prioridade[0] > 5)
                {
                    switch (prioridade[0])
                    {

                        case 1:
                            Console.WriteLine("\nAzul - Não urgência");
                            break;

                        case 2:
                            Console.WriteLine("\nVerde - Pouca urgência");
                            break;

                        case 3:
                            Console.WriteLine("\nAmarelo - urgência");
                            break;

                        case 4:
                            Console.WriteLine("\nLaranja - Muita urgência");
                            break;

                        case 5:
                            Console.WriteLine("\nVermelho - Emergência");
                            break;
                    }
                }
                Console.WriteLine("\nQual o gênero do paciente? Digite:\n '1' para 'Masculino'\n '2' para 'Feminino'");
                genero[0] = int.Parse(Console.ReadLine());
                if (genero[0] < 1 || genero[0] > 2)
                {

                    switch (genero[0])
                    {

                        case 1:
                            Console.WriteLine("\nGênero Masculino");
                            break;

                        case 2:
                            Console.WriteLine("\nGênero Feminino");
                            break;
                    }
                }

                //EXIBIR PACIENTE
                Console.WriteLine("\nCLIENTE CADASTRADO!");
                Console.WriteLine("\n\t NOME: {0}\n\t DATA DE NASCIMENTO: {1}\n\t E-MAIL: {2}\n\t CPF: {3}\n\t PRIORIDADE: {4}\n\t GÊNERO: {5}", nome[0], dataNasc[0], email[0], CPF[0], prioridade[0], genero[0]);
            }

        }


    }
}
