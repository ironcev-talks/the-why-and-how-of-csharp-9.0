namespace Records.ValueSemantics
{
    abstract record Painting : Artwork
    {
        public double CanvasWidth { get; init; }
        public double CanvasHeight { get; init; }
    }
}
