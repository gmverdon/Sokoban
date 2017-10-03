using SokoBan.Model;
using System;

namespace SokoBan
{
    public class Floor : Tile
    {
        public int TimesWalkedOver { get; set; }

        public override void Show()
        {
            if (this.MoveableObject != null)
            {
                MoveableObject.Show();
            } else
            {
                Console.Write(".");
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
                } else
                {
                    return false;
                }

                if (this.MoveableObject is Box && tempTile.MoveableObject is Box)
                {
                    return false;
                } else
                {
                    result = tempTile.MoveTo(this.MoveableObject);
                }

                if (!result) {  return false; }
            }

            // When requestObject should be placed on current tile

            // Remove moveableobject on old tile
            requestObject.Tile.MoveableObject = null;

            // Set requestObject on current tile
            this.MoveableObject = requestObject;

            // Set requestObject tile on current tile
            requestObject.Tile = this;

            return true;
        }
    }
}