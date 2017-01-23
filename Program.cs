using System.Drawing;

namespace SimpleTrim
{
    public class Program
    {
        // SimpleTrim.exe <Original> <Output> <Left> <Top> <Width> <Height>
        public static void Main(string[] args)
        {
            Bitmap original = new Bitmap(args[0]);
            Bitmap clone = original.Clone(
                               new Rectangle(
                                   int.Parse(args[2]), // Left
                                   int.Parse(args[3]), // Top
                                   int.Parse(args[4]), // Width
                                   int.Parse(args[5])  // Height
                               ),
                               original.PixelFormat
                           );

            clone.Save(args[1]);

            clone.Dispose();
            original.Dispose();
        }
    }
}