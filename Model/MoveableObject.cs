namespace SokoBan.Model
{
    public abstract class MoveableObject
    {
        public Tile Tile { get; set; }

        public MoveableObject(Tile currentTile)
        {
            Tile = currentTile;
        }

        public abstract void Show();
    }
}
