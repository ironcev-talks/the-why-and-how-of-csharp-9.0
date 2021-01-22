namespace InitOnlySetters.MostCommonUsage
{
    class MonaLisaImmutableGoodOldWay
    {
        public string Nose { get; }
        public string Lips { get; }
        public string Eyes { get; }
        public bool WearsGlasses { get; }
        public bool Smiles { get; }

        public MonaLisaImmutableGoodOldWay(string nose, string lips, string eyes, bool wearsGlasses, bool smiles)
        {
            Nose = nose;
            Lips = lips;
            Eyes = eyes;
            WearsGlasses = wearsGlasses;
            Smiles = smiles;
        }
    }

    class MonaLisaImmutableGoodOldWaySpecifier
    {
        public MonaLisaImmutableGoodOldWay Specify()
        {
            return new MonaLisaImmutableGoodOldWay("beautiful", "charming", "mystical", false, true);
        }

        public MonaLisaImmutableGoodOldWay SpecifyAgain()
        {
            return new MonaLisaImmutableGoodOldWay(nose : "beautiful", lips : "charming", eyes : "mystical", wearsGlasses : false, smiles : true);
        }

        public MonaLisaImmutableGoodOldWay SpecifyDifferently()
        {
            return new MonaLisaImmutableGoodOldWay
            (
                nose : "beautiful",
                lips : "charming",
                eyes : "mystical",
                wearsGlasses : false,
                smiles : true
            );
        }
    }
}
