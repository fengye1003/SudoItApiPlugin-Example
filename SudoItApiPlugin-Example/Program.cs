using System;
using System.IO;

namespace Example
{
	class Program
	{
		static void Main(string[] args)
		{
			switch(args[0])
            {
				case "--Initializate":
					File.Create("./Plugins/GET-Methods/Test.txt").Close();
					File.WriteAllText("./Plugins/GET-Methods/Test.txt", "Test.exe");
					File.Create("./Plugins/CommandProcessor/TestCommand.txt").Close();
					File.WriteAllText("./Plugins/CommandProcessor/TestCommand.txt", "Test.exe");
					break;
				case "--Method":
					switch(args[1])
                    {
						case "test":
							if(args[3]=="GET")
							{
								Console.WriteLine("GET Result\nGET succeed!");
							}
							if (args[3] == "None")
							{
								Console.WriteLine("Command result.Command executed!");
							}
							break;
						case "TestCommand":
							Console.WriteLine("Connected to server!");
							break;
						default:
							string argsText = "";
							foreach(string arg in args)
                            {
								argsText = argsText + arg + " ";
                            }
							Console.WriteLine("No such method exception:" + argsText + "\nNo such method exception.:" + argsText);
							break;
                    }
					break;
				default:
					Console.WriteLine("No such enter exception.\nNo such enter exception.");
					break;
			}
		}
	}
}