using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"../../src/forras.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] splitted = line.Split(';');
                new Versenyzo(splitted[0], splitted[1], int.Parse(splitted[2]), char.Parse(splitted[3]), splitted[4], splitted[5], splitted[6], splitted[7], splitted[8], splitted[9]);

            }

            sr.Close();

            int ElitJunior = Versenyzo.versenyzok.FindAll(x => x.Kategoria == "elitjunior").Count;
            Console.WriteLine($"A versenyzők száma elit junior kategóriában: {ElitJunior}");
        }
    }
}
