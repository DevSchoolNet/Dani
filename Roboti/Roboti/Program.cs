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

		public string NumeRobot { get; protected set; }

		protected string miscareRobot;

		public Robot Padre { get; set; }

		public int BatteryLevel { get; set; }

		public int Autonomie { get; set; }

		public string Tip { get; private set; }

		public Robot( int id, string nume, string miscare, string tip )
		{
			idRobot = id;
			this.NumeRobot = nume;
			this.Tip = tip;
			miscareRobot = miscare;
		}
		public abstract string GetMovement();

	}
	public class RobotTerestru : Robot, IWarrior
	{
		protected string meserieRT;
		protected string unealtaRT;
		public RobotTerestru( int id, string nume, string miscare, string meserie, string unealta )
			: base( id, nume, miscare, "Terestru" )
		{
			meserieRT = meserie;
			unealtaRT = unealta;
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

		public string Weapon
		{
			get
			{
				return this.unealtaRT;
			}
		}
	}
	public class RobotSubteran : Robot, IWarrior
	{
		protected string meserieRS;
		protected string unealtaRS;
		public RobotSubteran( int id, string nume, string miscare, string meserie, string unealta ) : base( id, nume, miscare, "Subteran" )
		{
			meserieRS = meserie;
			unealtaRS = unealta;
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

		public string Weapon
		{
			get
			{
				return this.unealtaRS;
			}
		}
	}

	public class RobotAcvatic : Robot, IWarrior
	{
		protected string meserieRA;

		protected string unealtaRA;

		public RobotAcvatic( int id, string nume, string miscare, string meserie, string unealta )
			: base( id, nume, miscare, "Acvatic" )
		{
			meserieRA = meserie;
			unealtaRA = unealta;
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

		public string Weapon
		{
			get
			{
				return this.unealtaRA;
			}
		}
	}

	public class RobotZburator : Robot, IWarrior
	{
		protected string meserieRZ;

		protected string unealtaRZ;

		public RobotZburator( int id, string nume, string miscare, string meserie, string unealta )
			: base( id, nume, miscare, "Zburator" )
		{
			meserieRZ = meserie;
			unealtaRZ = unealta;

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

		public string Weapon
		{
			get
			{
				return unealtaRZ;
			}
		}
	}

	public interface IWarrior
	{
		string Weapon { get; }
	}

	class Program
	{


		public static void Menu()
		{
			System.Console.WriteLine( "\nSunteti seful robotilor./n Puteti efectua urmatoarele actiuni:" );
			System.Console.WriteLine( "Apasati tasta 1 pentru a pune robotii in miscare" );
			System.Console.WriteLine( "Apasati tasta 2 pentru a spune robotilor sa se pregateasca " );
			System.Console.WriteLine( "Apasati tasta 3 pentru a spune robotilor sa munceasca " );
			System.Console.WriteLine( "Apasati tasta 0 pentru a iesi.\n " );

		}

		static void Main( string[] args )
		{
			string alege = "0";
			bool iesire = false;
			//oare cat de mare trebie sa fie turma
			RobotTerestru ciberT1 = new RobotTerestru( 1, "CiberT1", "merge in stanga", "lucru", "lopata" );
			RobotSubteran ciberS1 = new RobotSubteran( 2, "CiberS1", "merge inainte", "lucru", "burgiu" );
			RobotAcvatic ciberA1 = new RobotAcvatic( 3, "CiberA1", "merge in dreapta", "razboi", "arc" );
			RobotZburator ciberZ1 = new RobotZburator( 4, "CiberZ1", "merge drept", "razboi", "B43" );
			RobotZburator costel = new RobotZburator( 4, "Costel", "zboara in zigzag", "razboi", "B43" );

			var listOfRobots =
				new List<Robot>() { ciberT1, ciberS1, ciberA1, ciberZ1, costel }.OrderBy( robot => robot.NumeRobot )
					;
			while ( !iesire )
			{
				Menu();
				alege = Console.ReadLine();
				switch ( alege )
				{
					case "1":
						foreach ( var robot in listOfRobots )
						{
							Console.WriteLine( $"Robotul {robot.NumeRobot}...{robot.GetMovement()}" );
						}

						break;
					case "2":
						//Console.WriteLine($"{ciberT1.NumeRobot}: {ciberT1.GetTool()}");
						//Console.WriteLine($"{ciberS1.NumeRobot}: {ciberS1.GetTool()}");
						//Console.WriteLine($"{ciberA1.NumeRobot}: {ciberA1.GetTool()}");
						//Console.WriteLine($"{ciberZ1.NumeRobot}: {ciberZ1.GetTool()}");
						break;
					case "3":
						Console.WriteLine( $"{ciberT1.NumeRobot}  ia pamant cu {ciberT1.GetTool()}" );
						Console.WriteLine( $"{ciberS1.NumeRobot}  sapa cu {ciberS1.GetTool()}" );
						Console.WriteLine( $"{ciberA1.NumeRobot}  trage cu {ciberA1.GetTool()}" );
						Console.WriteLine( $"{ciberZ1.NumeRobot}  impusca cu {ciberZ1.GetTool()}" );
						break;
					case "0":
						iesire = true;
						break;
					case "4":
						//DemoMapReduce();
						//demoAnonymous( listOfRobots );
						demoInterface(listOfRobots);
						break;
					default:
						Console.WriteLine( "Taasta invalida" );
						break;


				}
			}
		}

		private static void demoInterface(IOrderedEnumerable<Robot> listOfRobots)
		{
			foreach (var robot in listOfRobots)
			{
				var warrior = (IWarrior)robot;
				Console.WriteLine($"Robotul razboinic {robot.NumeRobot} da cu {warrior.Weapon}" );
			}
		}

		private static void demoAnonymous( IEnumerable<Robot> listOfRobots )
		{
			var partialProperties = listOfRobots.Select( robot => new { robot.NumeRobot, robot.Tip } ).ToList();

			partialProperties.ForEach(
				obj =>
					{
						Console.WriteLine( $"{obj.NumeRobot} este {obj.Tip}" );
					} );
		}

		private static void DemoMapReduce()
		{
			var listOfStrings = new List<string>() { "s1", "s2", "s3", "s4" };

			var result = listOfStrings.Select( s => s + "-mo" ).ToList();

			result.ForEach(
				stringu =>
					{
						stringu = stringu.ToUpper();
						Console.WriteLine( "stringu: {0}", stringu );
					} );

			Console.WriteLine( "Map:" );
			foreach ( var res in result )
			{
				Console.WriteLine( $"{res}" );
			}

			Console.WriteLine( "Reduce" );

			Console.WriteLine( $"Total: {result.Count()}" );
		}
	}

}
