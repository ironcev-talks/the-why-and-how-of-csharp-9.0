namespace InitOnlySetters.MostCommonUsage
{
    // Do not change objects of this class once they are created.
    class MonaLisaImmutableWithInitOnlySetters
    {
        public string Nose { get; init; }
        public string Lips { get; init; }
        public string Eyes { get; init; }
        public bool WearsGlasses { get; init; }
        public bool Smiles { get; init; }
    }

    class MonaLisaImmutableWithInitOnlySettersSpecifier
    {
        public MonaLisaImmutableWithInitOnlySetters Specify()
        {
            var monaLisa = new MonaLisaImmutableWithInitOnlySetters
            {
                Nose = "beautiful",
                Lips = "charming",
                Eyes = "mystical",
                WearsGlasses = false,
                Smiles = true
            };

            // monaLisa.Nose = "broken";

            return monaLisa;
        }
    }
}
