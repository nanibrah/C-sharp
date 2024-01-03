using ColorText;
using System.Diagnostics;
using System.Text;

namespace mainProgram
{
    class Program
    {
        private static void Scam()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("\n\nStarting AimHead Program, please wait...");
            Thread.Sleep(3000);
            Console.WriteLine("CÓ CÁI CON CẶC HAHAHAHAHA\nPAY MÀU NÈ...");
            Thread.Sleep(1500);
            Process.Start("RUNDLL32.EXE", "powrprof.dll,SetSuspendState 0,1,0");
            Console.Clear();
            Console.WriteLine("CHỪA NHÉ. Tin t là dở r kkkkkkkkkkkkkkk.\n\n");
            Console.WriteLine(" .-----------------. .----------------.  .----------------.  .-----------------.\r\n| .--------------. || .--------------. || .--------------. || .--------------. |\r\n| | ____  _____  | || |    ______    | || |     ____     | || | ____  _____  | |\r\n| ||_   \\|_   _| | || |  .' ___  |   | || |   .'    `.   | || ||_   \\|_   _| | |\r\n| |  |   \\ | |   | || | / .'   \\_|   | || |  /  .--.  \\  | || |  |   \\ | |   | |\r\n| |  | |\\ \\| |   | || | | |    ____  | || |  | |    | |  | || |  | |\\ \\| |   | |\r\n| | _| |_\\   |_  | || | \\ `.___]  _| | || |  \\  `--'  /  | || | _| |_\\   |_  | |\r\n| ||_____|\\____| | || |  `._____.'   | || |   `.____.'   | || ||_____|\\____| | |\r\n| |              | || |              | || |              | || |              | |\r\n| '--------------' || '--------------' || '--------------' || '--------------' |\r\n '----------------'  '----------------'  '----------------'  '----------------' ");
            Console.Write("Source code: https://github.com/nanibrah/C-sharp\nWriter: Pham Loi ( nanibrah )");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            string CurrentTime = DateTime.Now.ToString("hh:mm:ss tt");
            int CurrentHeight = Console.WindowHeight;
            int CurrentWidth = Console.WindowWidth;
            Console.SetWindowSize(102, 25);
            if (Console.WindowWidth != 102 || Console.WindowHeight != 25)
            {
                string logTxtFile = $"Error different window size\nHeight: {CurrentHeight} / 25 - Width: {CurrentWidth} / 102\n{CurrentTime}\n----------------------------------\n";
                string logTxtFilePath = "log.txt";
                WriteColorText.WriteColor("[[Error different window size, read log file to know more]", ConsoleColor.Red);
                if (File.Exists(logTxtFilePath))
                {
                    File.AppendAllText(logTxtFilePath, logTxtFile);
                } 
                else
                {
                    File.WriteAllText("log.txt", logTxtFile);
                }
                Environment.Exit(0);
            }
            Console.WriteLine("         ______             _               _____ _                _     ______ ______ \r\n        |  ____|           (_)             / ____| |              | |   |  ____|  ____|\r\n        | |__   _ __   __ _ _ _ __   ___  | |    | |__   ___  __ _| |_  | |__  | |__   \r\n        |  __| | '_ \\ / _` | | '_ \\ / _ \\ | |    | '_ \\ / _ \\/ _` | __| |  __| |  __|  \r\n        | |____| | | | (_| | | | | |  __/ | |____| | | |  __/ (_| | |_  | |    | |     \r\n        |______|_| |_|\\__, |_|_| |_|\\___|  \\_____|_| |_|\\___|\\__,_|\\__| |_|    |_|     \r\n                       __/ |                                                           \r\n                      |___/");

            WriteColorText.WriteColor($"[[{CurrentTime}] Developer: Pham Loi \n[[{CurrentTime}] Version: 0.0.0\n[[{CurrentTime}] Support emulator: BlueStack 5\n\n", ConsoleColor.Cyan);
            Console.WriteLine("\t\t[ 1 ] Aim Head  |  [ 2 ] Fix lag   |  [ 3 ] Crosshair |  [ 4 ] Esp line\n\n\t\t\t");
            //                           ----------|--      ----------|--      ----------|--      ----------|--
            Console.Write("Choose to start program \n>>> ");
		    switch (Convert.ToInt32(Console.ReadLine()))
		    {
		    case 1:
                Scam();
			    break;
		    case 2:
			    Scam();
			    break;
		    case 3:
			    Scam();
			    break;
		    case 4:
			    Scam();
			    break;
		    default:
			    Console.WriteLine("Please choose a valid option above");
			    break;
		    }
        }
    }
}