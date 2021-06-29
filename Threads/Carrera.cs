using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threads
{
    class Carrera
    {
        Random r = new Random();
        public Carrera()
        {

        }
        public void Liebre()
        {
            int pos = 1;
            int probabilidad;

            while (pos != 70) {
                probabilidad = r.Next(1, 101);

                if (probabilidad >= 1 && probabilidad < 21)
                {
                    Console.WriteLine("Liebre: Duerme y no avanza, Posición: {0}", pos);
                }
                else if (probabilidad >= 21 && probabilidad < 41)
                {
                    pos += 9;
                    if (pos > 70) { pos = 70; }
                    Console.WriteLine("Liebre: Gran salto, avanza 9 casillas, Posición: {0}", pos);
                }

                else if (probabilidad >= 41 && probabilidad < 51)
                {
                    pos -= 12;
                    if (pos < 1) { pos = 1; }
                    Console.WriteLine("Liebre: Resbalón grande, retrocede 12 casillas, Posición: {0}", pos);
                }
                else if (probabilidad >= 51 && probabilidad < 81)
                {
                    pos += 1;
                    if (pos > 70) { pos = 70; }
                    Console.WriteLine("Liebre: Pequeño salto, avanza 1 casilla, Posición: {0}", pos);
                }
                else
                {
                    pos -= 2;
                    if (pos < 1) { pos = 1; }
                    Console.WriteLine("liebre: resbalón pequeño, retrocede 2 casillas, Posición: {0}", pos);
                }
                Thread.Sleep(1000);
            }
            Console.WriteLine("Liebre terminó la carrera");
        }


        public void Tortuga()
        {
            int pos = 1;
            int probabilidad;

            while (pos != 70)
            {
                probabilidad = r.Next(1, 101);

                if (probabilidad >= 1 && probabilidad < 51)
                {
                    pos += 3;
                    if (pos > 70) { pos = 70; }
                    Console.WriteLine("Tortuga: Avance rápido, avanza 3 casillas, Posición: {0}", pos);
                }
                else if (probabilidad >= 51 && probabilidad < 71)
                {
                    pos -= 6;
                    if (pos < 1) { pos = 1; }
                    Console.WriteLine("Tortuga: Resbalón de 6 casillas, Posición: {0}", pos);
                }
                else
                {
                    pos += 1;
                    if (pos > 70) { pos = 70; }
                    Console.WriteLine("Tortuga: Avance lento de 1 casilla, Posición: {0}", pos);
                }
                Thread.Sleep(1000);
            }
            Console.WriteLine("Tortuga terminó la carrera");
        }
    }

}
