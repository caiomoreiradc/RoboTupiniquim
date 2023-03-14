namespace RoboTupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int posicaoX , posicaoY = 0;
            int limiteX , limiteY = 0;
            char direcao = 'N';
            string comando;

            for (int a = 0; a < 2; a++)
            {
                //LIMITE
                Console.WriteLine("Insira o limite X do mapa: "); 
                limiteX = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Insira o limite Y do mapa: "); 
                limiteY = int.Parse(Console.ReadLine());

                Console.WriteLine();

                //POSIÇÕES
                Console.WriteLine("Insira a posição inicial X: ");
                posicaoX = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Insira a posição inicial Y: ");
                posicaoY = int.Parse(Console.ReadLine());

                Console.WriteLine();

                //DIREÇÃO
                Console.WriteLine("Digite a direção inicial:");
                direcao = char.Parse(Console.ReadLine());

                Console.WriteLine();

                //COMANDO
                Console.WriteLine("Digite o comando:");
                comando = Console.ReadLine();

                Console.WriteLine();

                char[] comandos = comando.ToCharArray();

                for (int i = 0; i < comandos.Length; i++)
                {
                    if (comandos[i] == 'M') //MOVER ROBÔ
                    {
                        if (direcao == 'N')
                        {
                            posicaoY = posicaoY + 1;
                        }
                        if (direcao == 'S')
                        {
                            posicaoY = posicaoY - 1;
                        }
                        if (direcao == 'L')
                        {
                            posicaoX = posicaoX + 1;
                        }
                        if (direcao == 'O')
                        {
                            posicaoX = posicaoX - 1;
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

                if (posicaoX < 0 || posicaoX > limiteX)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Robô fora dos limites dos equipamentos!!");
                        Console.WriteLine("Cuidado!");
                    }
                else if (posicaoY < 0 || posicaoY > limiteY)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Robô fora dos limites dos equipamentos!!");
                        Console.WriteLine("Cuidado!");
                    }

                //OUTPUT DA POSIÇÃO FINAL
                Console.WriteLine();
                Console.WriteLine("A posição final é: " + posicaoX + "," + posicaoY + "," + direcao + ".");
                Console.WriteLine();
            }


        }
    }
}