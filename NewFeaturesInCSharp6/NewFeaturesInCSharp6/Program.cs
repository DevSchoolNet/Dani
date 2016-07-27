using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;

namespace NewFeaturesInCSharp6
{
    class Elev
    {
        public int nrMatricol { get; set; }
        public string nume { get; set; }
        public decimal alocatie { get; set; }
        public decimal? bursa { get; set; }
    }

    class Scoala
    {
        public List<Elev> elevi;
        public Scoala()
        {
            elevi = new List<Elev>()
            {
                new Elev { nrMatricol = 125, nume = "Mitrut", alocatie = 30, bursa = null },
                new Elev { nrMatricol = 126, nume = "Mitruta", alocatie = 30, bursa = null },
                new Elev { nrMatricol = 127, nume = "Ionci", alocatie = 30, bursa = 180 }
            };
        }

    }

    class Program
    {
        /*public static int add(int no1, int no2)
       {
           return no1 + no2;
       }*/
        public static int Add(int no1, int no2) => no1 + no2; //in C# 6
        static void Main(string[] args)
        {
            float nota1 = 10, nota2 = 6, nota3 = 7, medie;
            medie = (nota1 + nota2 + nota3) / 3;

            //usin static qualifier
            WriteLine("diagonala patratului de latura 4 este:{0}\n", 4 * Sqrt(2));

            //string interpoltion
            WriteLine($"media pentru notele {nota1}, {nota2}, {nota3} este {medie}\n");
            String nume = "Dani", curs = "ING", colega = "Bianca";
            String aboutMe = $"{nume} invata C# la {curs} si sta langa {colega}\n";
            WriteLine(aboutMe);

            //null conditional opersator
            Scoala scoala = new Scoala();
            decimal? venitTotal = 0;
            var unElev = scoala.elevi.SingleOrDefault(e => e.nrMatricol == 127);
            /*if (unElev != null)
                if (unElev.bursa != null)
                    venitTotal = unElev.alocatie + unElev.bursa;
                else
                    venitTotal = unElev.alocatie;
            WriteLine($"Venit Total : {venitTotal}\n");
            */
            venitTotal = unElev.alocatie + unElev?.bursa ?? unElev.alocatie;
            WriteLine($"Venit Total : {venitTotal}\n");

            //expression bodied function and properties
            int no1 = 7, no2 = 8, no3;
            no3 = Add(no1, no2);
            WriteLine($"{no1} + {no2} = {no3}\n");
        }
    }
}




