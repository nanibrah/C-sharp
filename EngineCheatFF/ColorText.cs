using System.Text.RegularExpressions;
namespace ColorText;
class WriteColorText
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
}