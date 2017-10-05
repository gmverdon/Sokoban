using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokoBan.Model
{
    class Trap : Floor
    {
        public int TimesWalkedOver { get; set; } = 0;

        public override void Show()
        {
            if (this.MoveableObject != null)
            {
                MoveableObject.Show();
            }
            else
            {
                if (TimesWalkedOver >= 3)
                {
                    Console.Write(" ");
                } else
                {
                    Console.Write("~");
                }
                
            }
        }

        public override bool MoveTo(MoveableObject requestObject)
        {
            if (this.MoveableObject != null)
            {
                // When their is an object on current tile
                bool result;
                Tile tempTile;

                if (requestObject.Tile == LowerTile)
                {
                    tempTile = UpperTile;
                }
                else if (requestObject.Tile == LeftTile)
                {
                    tempTile = RightTile;
                }
                else if (requestObject.Tile == UpperTile)
                {
                    tempTile = LowerTile;
                }
                else if (requestObject.Tile == RightTile)
                {
                    tempTile = LeftTile;
                }
                else
                {
                    return false;
                }

                if (!MoveableObject.CanMoveOtherObject && tempTile.MoveableObject != null && !tempTile.MoveableObject.CanMoveOtherObject)
                {
                    return false;
                }
                else
                {
                    result = tempTile.MoveTo(this.MoveableObject);
                }

                if (!result) { return false; }
            }

            // When requestObject should be placed on current tile

            // Remove moveableobject on old tile
            requestObject.Tile.MoveableObject = null;

            // Set requestObject on current tile
            this.MoveableObject = requestObject;

            // Set requestObject tile on current tile
            requestObject.Tile = this;

            if (TimesWalkedOver >= 3)
            {
                MoveableObject = null;
            }

            TimesWalkedOver += 1;

            return true;
        }

    }
}
