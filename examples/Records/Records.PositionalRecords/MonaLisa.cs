namespace Records.ValueSemantics
{
    record MonaLisa
    (
        string Nose,
        string Lips,
        string Eyes,
        bool WearsGlasses,
        bool Smiles
    )
    {
        public MonaLisa() : this(null, null, null, false, false) { }
    };

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
