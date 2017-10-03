using SokoBan.Model;

namespace SokoBan
{
    public abstract class Tile
    {
        public MoveableObject MoveableObject { get; set; }

        public Tile UpperTile { get; set; }
        public Tile RightTile { get; set; }
        public Tile LowerTile { get; set; }
        public Tile LeftTile { get; set; }

        public abstract bool MoveTo(MoveableObject moveableObject);
    
        public abstract void Show();
    }
}
