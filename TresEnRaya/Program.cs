using System;
using System.Media;

namespace TresEnRaya
{
    internal class Program
    {
        public static int jugador = 1;
        public static int ingreso = 0;
        public static char cambio;
        public static string jugador1;
        public static string jugador2;
        public static string jugador3;
        public static string cambioJugador;
        public static int turno;
        public static Boolean paso = false;


        static void Main(string[] args)
        {

            do
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Escribe el nombre del jugador 1");
                jugador1 = Console.ReadLine();
                Console.WriteLine("Escribe el nombre del jugador 2");
                jugador2 = Console.ReadLine();
                cambioJugador = jugador1;

                CrearTablero();
                SeguirJugando();

            } while (!paso);

          
        }

        static char[,] tabinicial =
            {
                {'1','2','3'},
                {'4','5','6'},
                {'7','8','9'},
            };


        static char[,] tableroJuego =
             {
                {'1','2','3'},
                {'4','5','6'},
                {'7','8','9'},
            };

       
        //Metodo crear Tablero
        public static void CrearTablero()
        {
            Console.Clear();
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", tableroJuego[0, 0], tableroJuego[0, 1], tableroJuego[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", tableroJuego[1, 0], tableroJuego[1, 1], tableroJuego[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", tableroJuego[2, 0], tableroJuego[2, 1], tableroJuego[2, 2]);
            Console.WriteLine("     |     |");
            //turno++;
        }



        public static void Comprobar()
        {
            if ((tableroJuego[0, 0]=='X' && tableroJuego[1, 0] == 'X' && tableroJuego[2, 0] == 'X') 
                || (tableroJuego[0, 0] == 'X' && tableroJuego[0, 1] == 'X' && tableroJuego[0, 2] == 'X') 
                || (tableroJuego[1, 0] == 'X' && tableroJuego[1, 1] == 'X' && tableroJuego[1, 2] == 'X') 
                || (tableroJuego[2, 0] == 'X' && tableroJuego[2, 1] == 'X' && tableroJuego[2, 2] == 'X') 
                || (tableroJuego[0, 1] == 'X' && tableroJuego[1, 1] == 'X' && tableroJuego[2, 1] == 'X') 
                || (tableroJuego[0, 2] == 'X' && tableroJuego[1, 2] == 'X' && tableroJuego[2, 2] == 'X') 
                || (tableroJuego[0, 0] == 'X' && tableroJuego[1, 1] == 'X' && tableroJuego[2, 2] == 'X') 
                || (tableroJuego[0, 2] == 'X' && tableroJuego[1, 1] == 'X' && tableroJuego[2, 0] == 'X')
                || (tableroJuego[0, 0] == 'O' && tableroJuego[0, 1] == 'O' && tableroJuego[0, 2] == 'O')
                || (tableroJuego[1, 0] == 'O' && tableroJuego[1, 1] == 'O' && tableroJuego[1, 2] == 'O')
                || (tableroJuego[2, 0] == 'O' && tableroJuego[2, 1] == 'O' && tableroJuego[2, 2] == 'O')
                || (tableroJuego[0, 1] == 'O' && tableroJuego[1, 1] == 'O' && tableroJuego[2, 1] == 'O')
                || (tableroJuego[0, 2] == 'O' && tableroJuego[1, 2] == 'O' && tableroJuego[2, 2] == 'O')
                || (tableroJuego[0, 0] == 'O' && tableroJuego[1, 1] == 'O' && tableroJuego[2, 2] == 'O')
                || (tableroJuego[0, 2] == 'O' && tableroJuego[1, 1] == 'O' && tableroJuego[2, 0] == 'O'))
            {


                Console.WriteLine("El Ganador del juego es {0}", cambioJugador);
                Console.WriteLine("Si quiere jugar otra partida pulse \"s\" si no cualquier otra tecla para salir.");

                                
                
                    if (Console.ReadLine() == "s")
                    {
                        CrearTableroInicial();

                        jugador3 = jugador1;
                        jugador1 = jugador2;
                        jugador2 = jugador3;                    
                    
                    }
                    else 
                    {
                    
                    Console.WriteLine("Saliendo del juego. Pulse Enter para salir");
                    Console.ReadKey();
                    paso = true;

                    }
            }
            else if (turno > 8)
            {
                Console.WriteLine("Juego en Tablas");
                Console.WriteLine("Si quiere jugar otra partida pulse \"s\" si no cualquier otra tecla para salir y elegir contrincantes distintos ");

                if (Console.ReadLine() == "s")
                {
                    CrearTableroInicial();


                }
                else
                {
                    Console.WriteLine("Saliendo del juego. Pulse Enter para salir");
                    Console.ReadKey();
                    paso = true;
                }
                
            }
            else
            {
                if (cambioJugador.Equals(jugador1))
                {
                    cambioJugador = jugador2;
                }
                else if (cambioJugador.Equals(jugador2))
                {
                    cambioJugador = jugador1;
                }
                SeguirJugando();
                
                
            }
        }

        
        public static void SeguirJugando()
        {
            

            Console.WriteLine("Jugador {0} escoja el número de su elección", cambioJugador);

            bool correcto = int.TryParse(Console.ReadLine(), out ingreso);

            if (correcto && (ingreso >= 1 && ingreso < 10))
            {

                if (jugador % 2 == 0)
                {
                    cambio = 'O';

                }
                else
                {
                    cambio = 'X';

                }


                switch (ingreso)
                {
                    case 1:
                        {
                            if (tableroJuego[0, 0] == '1')
                            {
                                tableroJuego[0, 0] = cambio;
                            }
                            CrearTablero();
                            Console.WriteLine(tableroJuego[0, 0]);
                            jugador++;
                            turno++;
                            Comprobar();
                            break;
                        }
                    case 4:
                        {
                            if (tableroJuego[1, 0] == '4')
                            {
                                tableroJuego[1, 0] = cambio;
                            }
                            CrearTablero();
                            Console.WriteLine(tableroJuego[1, 0]);
                            jugador++;
                            turno++;
                            Comprobar();
                            break;
                        }
                    case 7:
                        {
                            if (tableroJuego[2, 0] == '7')
                            {
                                tableroJuego[2, 0] = cambio;
                            }
                            CrearTablero();
                            Console.WriteLine(tableroJuego[2, 0]);
                            jugador++;
                            turno++;
                            Comprobar();
                            break;
                        }
                    case 2:
                        {
                            if (tableroJuego[0, 1] == '2')
                            {
                                tableroJuego[0, 1] = cambio;
                            }
                            CrearTablero();
                            Console.WriteLine(tableroJuego[0, 1]);
                            jugador++;
                            turno++;
                            Comprobar();
                            break;
                        }
                    case 3:
                        {
                            if (tableroJuego[0, 2] == '3')
                            {
                                tableroJuego[0, 2] = cambio;
                            }
                            CrearTablero();
                            Console.WriteLine(tableroJuego[0, 2]);
                            jugador++;
                            turno++;
                            Comprobar();
                            break;
                        }
                    case 5:
                        {
                            if (tableroJuego[1, 1] == '5')
                            {
                                tableroJuego[1, 1] = cambio;
                            }
                            CrearTablero();
                            Console.WriteLine(tableroJuego[1, 1]);
                            jugador++;
                            turno++;
                            Comprobar();
                            break;
                        }
                    case 6:
                        {
                            if (tableroJuego[1, 2] == '6')
                            {
                                tableroJuego[1, 2] = cambio;
                            }
                            CrearTablero();
                            Console.WriteLine(tableroJuego[1, 2]);
                            jugador++;
                            turno++;
                            Comprobar();
                            break;
                        }
                    case 8:
                        {
                            if (tableroJuego[2, 1] == '8')
                            {
                                tableroJuego[2, 1] = cambio;
                            }
                            CrearTablero();
                            Console.WriteLine(tableroJuego[2, 1]);
                            jugador++;
                            turno++;
                            Comprobar();
                            break;
                        }
                    case 9:
                        {
                            if (tableroJuego[2, 2] == '9')
                            {
                                tableroJuego[2, 2] = cambio;
                            }
                            CrearTablero();
                            Console.WriteLine(tableroJuego[2, 2]);
                            jugador++;
                            turno++;
                            Comprobar();
                            break;
                        }

                }

            }
            else
            {
                Console.WriteLine("Introduce un numero correcto");
                SeguirJugando();
            }

            
        }
        
        public static void CrearTableroInicial()
        {
            Array.Copy(tabinicial, tableroJuego, tabinicial.Length);
            //tableroJuego = tabinicial;
            
            
            CrearTablero();
            Console.WriteLine("Tablero creado");
            Console.WriteLine(tabinicial[0, 0]); //PRUEBAS
            turno = 0;
            jugador = 1;
            
            
            if (cambioJugador.Equals(jugador1))
            {
                cambioJugador = jugador2;
                
            }
            else if (cambioJugador.Equals(jugador2))
            {
                cambioJugador = jugador1;
            }
            
            
            SeguirJugando();

        }
    }

}
