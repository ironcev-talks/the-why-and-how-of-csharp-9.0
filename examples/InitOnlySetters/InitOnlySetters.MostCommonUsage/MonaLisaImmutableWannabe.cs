namespace InitOnlySetters.MostCommonUsage
{
    // Do not change objects of this class once they are created.
    class MonaLisaImmutableWannabe
    {
        public string Nose { get; set; }
        public string Lips { get; set; }
        public string Eyes { get; set; }
        public bool WearsGlasses { get; set; }
        public bool Smiles { get; set; }
    }

    class MonaLisaImmutableWannabeSpecifier
    {
        public MonaLisaImmutableWannabe Specify()
        {
            return new MonaLisaImmutableWannabe
            {
                Nose = "beautiful",
                Lips = "charming",
                Eyes = "mystical",
                WearsGlasses = false,
                Smiles = true
            };
        }
    }
}
