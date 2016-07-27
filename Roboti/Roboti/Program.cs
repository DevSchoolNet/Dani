using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roboti
{
    public abstract class Robot
    {
        protected int idRobot;
        protected string numeRobot;
        protected string miscareRobot;

        public Robot(int id, string nume, string miscare)
        {
            idRobot = id;
            numeRobot = nume;
            miscareRobot = miscare;
        }
        public abstract string GetMovement();
        public abstract string GetName();
    }
    public class RobotTerestru : Robot
    {
        protected string meserieRT;
        protected string unealtaRT;
        public RobotTerestru(int id, string nume, string miscare, string meserie, string unealta) : base(id, nume, miscare)
        {
            meserieRT = meserie;
            unealtaRT = unealta;
        }
        public override string GetName()
        {
            return this.numeRobot;
        }
        public override string GetMovement()
        {
            return this.miscareRobot;
        }
        public string GetJob()
        {
            return this.meserieRT;
        }
        public string GetTool()
        {
            return this.unealtaRT;
        }

    }
    public class RobotSubteran : Robot
    {
        protected string meserieRS;
        protected string unealtaRS;
        public RobotSubteran(int id, string nume, string miscare, string meserie, string unealta) : base(id, nume, miscare)
        {
            meserieRS = meserie;
            unealtaRS = unealta;
        }

        public override string GetName()
        {
            return this.numeRobot;
        }
        public override string GetMovement()
        {
            return this.miscareRobot;
        }
        public string GetJob()
        {
            return this.meserieRS;
        }
        public string GetTool()
        {
            return this.unealtaRS;
        }

    }
    public class RobotAcvatic : Robot
    {
        protected string meserieRA;
        protected string unealtaRA;
        public RobotAcvatic(int id, string nume, string miscare, string meserie, string unealta) : base(id, nume, miscare)
        {
            meserieRA = meserie;
            unealtaRA = unealta;
        }
        public override string GetName()
        {
            return this.numeRobot;
        }
        public override string GetMovement()
        {
            return this.miscareRobot;
        }
        public string GetJob()
        {
            return this.meserieRA;
        }
        public string GetTool()
        {
            return this.unealtaRA;
        }
    }
    public class RobotZburator : Robot
    {
        protected string meserieRZ;
        protected string unealtaRZ;
        public RobotZburator(int id, string nume, string miscare, string meserie, string unealta) : base(id, nume, miscare)
        {
            meserieRZ = meserie;
            unealtaRZ = unealta;
        }
        public override string GetName()
        {
            return this.numeRobot;
        }
        public override string GetMovement()
        {
            return this.miscareRobot;
        }
        public string GetJob()
        {
            return this.meserieRZ;
        }
        public string GetTool()
        {
            return this.unealtaRZ;
        }
    }



    class Program
    {
        public static void Menu()
        {
            System.Console.WriteLine("\nSunteti seful robotilor./n Puteti efectua urmatoarele actiuni:");
            System.Console.WriteLine("Apasati tasta 1 pentru a pune robotii in miscare");
            System.Console.WriteLine("Apasati tasta 2 pentru a spune robotilor sa se pregateasca ");
            System.Console.WriteLine("Apasati tasta 3 pentru a spune robotilor sa munceasca ");
            System.Console.WriteLine("Apasati tasta 0 pentru a iesi.\n ");

        }
        static void Main(string[] args)
        {
            string alege = "0";
            bool iesire = false;
            //oare cat de mare trebie sa fie turma
            RobotTerestru ciberT1 = new RobotTerestru(1, "CiberT1", "merge in stanga", "lucru", "lopata");
            RobotSubteran ciberS1 = new RobotSubteran(2, "CiberS1", "merge inainte", "lucru", "burgiu");
            RobotAcvatic ciberA1 = new RobotAcvatic(3, "CiberA1", "merge in dreapta", "razboi", "arc");
            RobotZburator ciberZ1 = new RobotZburator(4, "CiberZ1", "merge drept", "razboi", "B43");
            while (!iesire)
            {
                Menu();
                alege = Console.ReadLine();
                switch (alege)
                {
                    case "1":
                        Console.WriteLine($"{ciberT1.GetName()}: {ciberT1.GetMovement()}");
                        Console.WriteLine($"{ciberS1.GetName()}: {ciberS1.GetMovement()}");
                        Console.WriteLine($"{ciberA1.GetName()}: {ciberA1.GetMovement()}");
                        Console.WriteLine($"{ciberZ1.GetName()}: {ciberZ1.GetMovement()}");
                        break;
                    case "2":
                        Console.WriteLine($"{ciberT1.GetName()}: {ciberT1.GetTool()}");
                        Console.WriteLine($"{ciberS1.GetName()}: {ciberS1.GetTool()}");
                        Console.WriteLine($"{ciberA1.GetName()}: {ciberA1.GetTool()}");
                        Console.WriteLine($"{ciberZ1.GetName()}: {ciberZ1.GetTool()}");
                        break;
                    case "3":
                        Console.WriteLine($"{ciberT1.GetName()}  ia pamant cu {ciberT1.GetTool()}");
                        Console.WriteLine($"{ciberS1.GetName()}  sapa cu {ciberS1.GetTool()}");
                        Console.WriteLine($"{ciberA1.GetName()}  trage cu {ciberA1.GetTool()}");
                        Console.WriteLine($"{ciberZ1.GetName()}  impusca cu {ciberZ1.GetTool()}"); break;
                    case "0":
                        iesire = true;
                        break;
                    default:
                        Console.WriteLine("Taasta invalida");
                        break;


                }
            }
        }
    }
}
