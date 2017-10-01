using SokoBan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SokoBan
{
    public class Floor : Tile
    {
        public Floor()
        {
        }

        internal void draw()
        {
            throw new NotImplementedException();
        }

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

                if (requestObject.Tile == LowerTile)
                {
                    UpperTile.MoveTo(requestObject);
                }
                else if (requestObject.Tile == LeftTile)
                {
                    RightTile.MoveTo(requestObject);
                }
                else if (requestObject.Tile == UpperTile)
                {
                    LowerTile.MoveTo(requestObject);
                }
                else if (requestObject.Tile == RightTile)
                {
                    LeftTile.MoveTo(requestObject);
                } else
                {
                    Console.WriteLine("ERROR: This is not right!");
                    return false;
                }
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