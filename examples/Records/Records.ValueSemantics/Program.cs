using Records.ValueSemantics;
using static System.Console;

namespace TheWhyAndHowOfCSharp90
{
    partial class Program
    {
        static void Main(string[] args)
        {
            DisplayDemoStep("Comparing two Mona Lisas");

            var specifier = new MonaLisaSpecifier();

            var firstMonaLisa = specifier.Specify();
            var secondMonaLisa = specifier.Specify();

            WriteLine($"first:\t{firstMonaLisa}");
            WriteLine($"second:\t{secondMonaLisa}");

            WriteLine();

            WriteLine($"ReferenceEquals(first, second):\t{ReferenceEquals(firstMonaLisa, secondMonaLisa)}");
            WriteLine($"first == second:\t\t{firstMonaLisa == secondMonaLisa}");

            DisplayDemoStep("Creating portraits");

            var monaLisa = new Portrait
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

            WriteLine();

            WriteLine(monaLisa);
        }
    }
}
