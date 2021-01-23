namespace Records.ValueSemantics
{
    sealed record Portrait
    (
        int Id,
        string Name,
        double CanvasWidth,
        double CanvasHeight,
        string Nose,
        string Lips,
        string Eyes,
        bool WearsGlasses,
        bool Smiles
    ) : Painting(Id, Name, CanvasWidth, CanvasHeight)
    {
        public Portrait() : this(0, null, 0, 0, null, null, null, false, false) { }
    };
}
