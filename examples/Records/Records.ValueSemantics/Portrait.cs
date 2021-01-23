namespace Records.ValueSemantics
{
    sealed record Portrait : Painting
    {
        public string Nose { get; init; }
        public string Lips { get; init; }
        public string Eyes { get; init; }
        public bool WearsGlasses { get; init; }
        public bool Smiles { get; init; }
    }
}
