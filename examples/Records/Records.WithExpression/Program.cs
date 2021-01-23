using Records.ValueSemantics;
using static System.Console;

namespace TheWhyAndHowOfCSharp90
{
    partial class Program
    {
        static void Main(string[] args)
        {
            DisplayDemoStep("Cloning Mona Lisas");

            var original = new Portrait
            {
                Id = 1,
                Name = "Mona Lisa",
                CanvasHeight = 77,
                CanvasWidth = 53,
                Nose = "beautiful",
                Lips = "charming",
                Eyes = "mystical",
                WearsGlasses = false,
                Smiles = true
            };

            var identical = original with { };
            var withGlasses = original with { WearsGlasses = true };
            var seriousWithGlasses = original with { WearsGlasses = true, Smiles = false };

            WriteLine();

            WriteLine(original);

            WriteLine();

            WriteLine(identical);

            WriteLine();

            WriteLine(withGlasses);

            WriteLine();

            WriteLine(seriousWithGlasses);
        }
    }
}
