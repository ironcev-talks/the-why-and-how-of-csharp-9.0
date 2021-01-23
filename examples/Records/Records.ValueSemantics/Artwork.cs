namespace Records.ValueSemantics
{
    abstract record Artwork
    {
        public int Id { get; init; }
        public string Name { get; init; }
    }
}
