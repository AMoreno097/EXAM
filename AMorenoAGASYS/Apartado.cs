using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMorenoAGASYS
{
    public class Apartado
    {
        public static void Edad()
        {
            int Edad = 0;
            int MayorEdad=0;
            int MenorEdad = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingresa la edad de la persona");
                Edad = int.Parse(Console.ReadLine());

                if (Edad < 18)
                {
                    MenorEdad++;
                }
                else
                {
                    
                    MayorEdad++;
                }
                Console.Clear();
            }   
            Console.WriteLine("El total de personas menores de edad son:" + MenorEdad );
            Console.WriteLine("El total de personas mayores de edad son:" + MayorEdad);
            Console.ReadKey();
        }

        public static void Candidatos()
        {
            int Perez = 0;
            int Peña = 0;
            int Gaviota = 0;
            int voto = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Elige para quien es tu voto");
                Console.WriteLine("1.-Perez, 2.-Peña, 3.-Gaviota");
                Console.WriteLine("Digite su opcion");
                voto = int.Parse(Console.ReadLine());

                switch (voto)
                {
                    case 1:
                        Perez++;
                        break;
                    case 2:
                        Peña++;
                        break;
                    case 3:
                        Gaviota++;
                        break;
                }
                Console.Clear();
            }
            if (Perez > Peña && Perez > Gaviota)
            {
                Console.WriteLine("El Candidato Perez tuvo mayor votos con " +Perez);
                if (Peña > Gaviota)
                {
                    Console.WriteLine("El candidato Peña quedo en segundo lugar con " +Peña+ " votos");
                    Console.WriteLine("El candidato Gaviota quedo en tercer lugar con " +Gaviota+ " votos");
                }
                else
                {
                    Console.WriteLine("El candidato Gaviota quedo en segundo lugar con " +Gaviota+ " votos");
                    Console.WriteLine("El candidato Peña quedo en tercer lugar con " +Peña+ " votos");
                }
            }
            else
            {
                if(Peña > Gaviota && Peña > Perez)
                {
                    Console.WriteLine("El Candidato Peña tuvo mayor votos con " + Peña);
                    if (Peña > Gaviota)
                    {
                        Console.WriteLine("El candidato Perez quedo en segundo lugar con " + Perez + " votos");
                        Console.WriteLine("El candidato Gaviota quedo en tercer lugar con " + Gaviota + " votos");
                    }
                    else
                    {
                        Console.WriteLine("El candidato Gaviota quedo en segundo lugar con " + Gaviota + " votos");
                        Console.WriteLine("El candidato Perez quedo en tercer lugar con " + Perez + " votos");
                    }

                }
                else
                {
                    if (Gaviota > Peña && Gaviota > Perez)
                    {
                        Console.WriteLine("El Candidato Gaviota tuvo mayor votos con " + Gaviota);
                        if (Peña > Perez)
                        {
                            Console.WriteLine("El candidato Peña quedo en segundo lugar con " + Peña + " votos");
                            Console.WriteLine("El candidato Perez quedo en tercer lugar con " + Perez + " votos");
                        }
                        else
                        {
                            Console.WriteLine("El candidato Perez quedo en segundo lugar con " + Perez + " votos");
                            Console.WriteLine("El candidato Peña quedo en tercer lugar con " + Peña + " votos");
                        }

                    }
                }
                  
            }
        }

        public static void CambioLetras()
        {
            Console.WriteLine("Escriba una palabra");
            string str = Console.ReadLine();
            char[] arr;

            arr = str.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                char l = arr[i];

                Console.Write("{0}", ++l);
            }
        }
        
    }
}
