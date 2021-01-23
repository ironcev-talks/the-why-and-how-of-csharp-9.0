namespace Records.ValueSemantics
{
    record MonaLisa
    {
        public string Nose { get; init; }
        public string Lips { get; init; }
        public string Eyes { get; init; }
        public bool WearsGlasses { get; init; }
        public bool Smiles { get; init; }
    }

    class MonaLisaSpecifier
    {
        public MonaLisa Specify()
        {
            var monaLisa = new MonaLisa
            {
                Nose = "beautiful",
                Lips = "charming",
                Eyes = "mystical",
                WearsGlasses = false,
                Smiles = true
            };

            return monaLisa;
        }
    }
}
