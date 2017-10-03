using SokoBan.Model;
using System;

namespace SokoBan
{
    public class Forklifttruck : MoveableObject
    {
        public Forklifttruck(Tile currentTile) : base(currentTile)
        {
        }

        public override void Show()
        {
            Console.Write("@");
        }

        public void Move(int direction)
        {
            switch (direction)
            {
                case 0:
                    // up
                    this.Tile.UpperTile.MoveTo(this);
                    break;
                case 1:
                    // right
                    this.Tile.RightTile.MoveTo(this);
                    break;
                case 2:
                    // down
                    this.Tile.LowerTile.MoveTo(this);
                    break;
                case 3:
                    // left
                    this.Tile.LeftTile.MoveTo(this);
                    break;
            }
        }
            
    }
}