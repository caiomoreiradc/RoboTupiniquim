namespace RoboTupiniquim
{
    internal class Program
    {
        private static int Menu(int robo, out int posX, out int posY, out char direcao, out string comando, out char[] comandos)
        {
            Console.WriteLine("Insira a posição inicial X: ");
            posX = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Insira a posição inicial Y: ");
            posY = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Digite a direção inicial:");
            direcao = char.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite o comando:");
            comando = Console.ReadLine();
            robo++;                                              //UTILIZADA PARA IDENTIFICAR SE É O ROBOÔ 1 OU 2

            Console.WriteLine();

            comandos = comando.ToCharArray();
            return robo;
        }
        private static void OutputFinal(int robo, int posX, int posY, char direcao)
        {
            if (robo == 1)
            {
                Console.WriteLine();
                Console.WriteLine("A posição final do robô 1 é: " + posX + "," + posY + "," + direcao + ".");
                Console.WriteLine();
            }
            else if (robo == 2)
            {
                Console.WriteLine();
                Console.WriteLine("A posição final do robô2 é: " + posX + "," + posY + "," + direcao + ".");
                Console.WriteLine();
                Console.ReadKey();
            }
        }
        private static void VerificarLimites(int posX, int posY, int limiteX, int limiteY)
        {
            if (posX < 0 || posX > limiteX)
            {
                Console.WriteLine();
                Console.WriteLine("Robô fora dos limites dos equipamentos!!");
                Console.WriteLine("Cuidado!");
            }
            else if (posY < 0 || posY > limiteY)
            {
                Console.WriteLine();
                Console.WriteLine("Robô fora dos limites dos equipamentos!!");
                Console.WriteLine("Cuidado!");
            }
        }
        private static void MoverRobo(ref int posX, ref int posY, ref char direcao, char[] comandos)
        {
            for (int i = 0; i < comandos.Length; i++)
            {
                if (comandos[i] == 'M')
                {
                    if (direcao == 'N')
                    {
                        posY = posY + 1;
                    }
                    if (direcao == 'S')
                    {
                        posY = posY - 1;
                    }
                    if (direcao == 'L')
                    {
                        posX = posX + 1;
                    }
                    if (direcao == 'O')
                    {
                        posX = posX - 1;
                    }
                }

                if (comandos[i] == 'D')
                {
                    if (direcao == 'N')
                    {
                        direcao = 'L';
                    }
                    else if (direcao == 'L')
                    {
                        direcao = 'S';
                    }
                    else if (direcao == 'S')
                    {
                        direcao = 'O';
                    }
                    else if (direcao == 'O')
                    {
                        direcao = 'N';
                    }
                }

                if (comandos[i] == 'E')
                {
                    if (direcao == 'N')
                    {
                        direcao = 'O';
                    }
                    else if (direcao == 'O')
                    {
                        direcao = 'S';
                    }
                    else if (direcao == 'S')
                    {
                        direcao = 'L';
                    }
                    else if (direcao == 'L')
                    {
                        direcao = 'N';
                    }
                }


            }
        }

        static void Main(string[] args)
        {
            int robo = 0;
            int posX , posY = 0;
            int limiteX = 5 , limiteY = 5;      //LIMITE DO MAPA DO JOGO
            char direcao = 'N';
            string comando;             

            for (int a = 0; a < 2; a++)
            {
                char[] comandos;
                robo = Menu(robo, out posX, out posY, out direcao, out comando, out comandos);

                MoverRobo(ref posX, ref posY, ref direcao, comandos);

                VerificarLimites(posX, posY, limiteX, limiteY);

                OutputFinal(robo, posX, posY, direcao);
            }


        }

    }
}