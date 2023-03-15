namespace RoboTupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int robo = 0;
            int posX , posY = 0;
            int limiteX = 5 , limiteY = 5;      //LIMITE DO MAPA DO JOGO
            char direcao = 'N';
            string comando;             

            for (int a = 0; a < 2; a++)
            {
                //POSIÇÕES
                Console.WriteLine("Insira a posição inicial X: ");
                posX = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Insira a posição inicial Y: ");
                posY = int.Parse(Console.ReadLine());

                Console.WriteLine();

                //DIREÇÃO
                Console.WriteLine("Digite a direção inicial:");
                direcao = char.Parse(Console.ReadLine());
                Console.WriteLine();

                //COMANDO
                Console.WriteLine("Digite o comando:");
                comando = Console.ReadLine();
                robo++;                                              //UTILIZADA PARA IDENTIFICAR SE É O ROBOÔ 1 OU 2

                Console.WriteLine();

                char[] comandos = comando.ToCharArray();

                for (int i = 0; i < comandos.Length; i++)
                {
                    if (comandos[i] == 'M') //MOVER ROBÔ
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

                    if (comandos[i] == 'D') //DIRETA
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

                    if (comandos[i] == 'E')  //ESQUERDA
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

                //VERIFICA SE O ROBÔ ESTÁ DENTRO DOS LIMITES DO PLANO

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

                //OUTPUT DA POSIÇÃO FINAL
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


        }
    }
}