using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace mainProgram
{
    class Program
    {
        public static void WriteColor(string message, ConsoleColor color)
        {
            var pieces = Regex.Split(message, @"(\[[^\]]*\])");

            for (int i = 0; i < pieces.Length; i++)
            {
                string piece = pieces[i];

                if (piece.StartsWith("[") && piece.EndsWith("]"))
                {
                    Console.ForegroundColor = color;
                    piece = piece.Substring(1, piece.Length - 1);
                }

                Console.Write(piece);
                Console.ResetColor();
            }
            Console.WriteLine();
        }
        private static void Scam()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("\n\nStarting AimHead Program, please wait...");
            Thread.Sleep(3000);
            Console.WriteLine("CÓ CÁI CON CẶC HAHAHAHAHA\nPAY MÀU NÈ...");
            Thread.Sleep(1500);
            Process.Start("RUNDLL32.EXE", "powrprof.dll,SetSuspendState 0,1,0");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("CHỪA NHÉ. Tin t là dở r kkkkkkkkkkkkkkk.\n\n");
            Console.WriteLine(" .-----------------. .----------------.  .----------------.  .-----------------.\r\n| .--------------. || .--------------. || .--------------. || .--------------. |\r\n| | ____  _____  | || |    ______    | || |     ____     | || | ____  _____  | |\r\n| ||_   \\|_   _| | || |  .' ___  |   | || |   .'    `.   | || ||_   \\|_   _| | |\r\n| |  |   \\ | |   | || | / .'   \\_|   | || |  /  .--.  \\  | || |  |   \\ | |   | |\r\n| |  | |\\ \\| |   | || | | |    ____  | || |  | |    | |  | || |  | |\\ \\| |   | |\r\n| | _| |_\\   |_  | || | \\ `.___]  _| | || |  \\  `--'  /  | || | _| |_\\   |_  | |\r\n| ||_____|\\____| | || |  `._____.'   | || |   `.____.'   | || ||_____|\\____| | |\r\n| |              | || |              | || |              | || |              | |\r\n| '--------------' || '--------------' || '--------------' || '--------------' |\r\n '----------------'  '----------------'  '----------------'  '----------------' ");
            Console.Write("Source code: https://github.com/nanibrah/C-sharp\nWriter: Pham Loi ( nanibrah )");
            Console.ReadKey();
        }
        public static void logTime()
        {
            string logFilePath = @"log.txt";
            string CurrentTime = DateTime.Now.ToString("hh:mm:ss tt");
            string CurrentDay = DateTime.Now.ToString("dddd:MMMM:yyyy tt");
            string prettier = "-----------------------------------------------------";
            string fulltextopentime = $"{prettier}\n| Open at [{CurrentTime}] on [{CurrentDay}] |\n{prettier}";
            string openTime = $"\n| Open at [{CurrentTime}] on [{CurrentDay}] |\n{prettier}";

            if (File.Exists(logFilePath))
            {
                if (File.ReadLines(logFilePath).Count() >= 3)
                {
                    File.AppendAllText(logFilePath, openTime);
                }
                else
                {
                    File.AppendAllText(logFilePath, fulltextopentime);
                }
            }
            else
            {
                File.WriteAllText(logFilePath, fulltextopentime);
            }
        }
        static void Main(string[] args)
        {
            logTime();
            string CurrentTime = DateTime.Now.ToString("hh:mm:ss tt");
            int CurrentHeight = Console.WindowHeight;
            int CurrentWidth = Console.WindowWidth;
            Console.SetWindowSize(102, 25);
            if (Console.WindowWidth != 102 || Console.WindowHeight != 25)
            {
                string ErrorlogTxtFile = $"Error different window size\nHeight: {CurrentHeight} / 25 - Width: {CurrentWidth} / 102\n{CurrentTime}\n----------------------------------\n";
                string ErrorlogTxtFilePath = "Errorlog.txt";
                WriteColor("[[Error different window size, read Errorlog file to know more]", ConsoleColor.Red);
                if (File.Exists(ErrorlogTxtFilePath))
                {
                    File.AppendAllText(ErrorlogTxtFilePath, ErrorlogTxtFile);
                } 
                else
                {
                    File.WriteAllText(ErrorlogTxtFilePath, ErrorlogTxtFile);
                }
                Environment.Exit(0);
            }
            Console.WriteLine("         ______             _               _____ _                _     ______ ______ \r\n        |  ____|           (_)             / ____| |              | |   |  ____|  ____|\r\n        | |__   _ __   __ _ _ _ __   ___  | |    | |__   ___  __ _| |_  | |__  | |__   \r\n        |  __| | '_ \\ / _` | | '_ \\ / _ \\ | |    | '_ \\ / _ \\/ _` | __| |  __| |  __|  \r\n        | |____| | | | (_| | | | | |  __/ | |____| | | |  __/ (_| | |_  | |    | |     \r\n        |______|_| |_|\\__, |_|_| |_|\\___|  \\_____|_| |_|\\___|\\__,_|\\__| |_|    |_|     \r\n                       __/ |                                                           \r\n                      |___/");

            WriteColor($"[[{CurrentTime}] Developer: Pham Loi \n[[{CurrentTime}] Version: 0.0.0\n[[{CurrentTime}] Support emulator: BlueStack 5\n\n", ConsoleColor.Cyan);
            Console.WriteLine("\t\t[ 1 ] Aim Head  |  [ 2 ] Fix lag   |  [ 3 ] Crosshair |  [ 4 ] Esp line\n\n\t\t\t");
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