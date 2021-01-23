namespace Records.ValueSemantics
{
    abstract record Painting
    (
        int Id,
        string Name,
        double CanvasWidth,
        double CanvasHeight
    ) : Artwork(Id, Name);
}
