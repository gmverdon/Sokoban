using System;

namespace SokoBan.Model
{
    public class Destination : Floor
    {
        public override void Show()
        {
            if (this.MoveableObject != null)
            {
                MoveableObject.Show();
            }
            else
            {
                Console.Write("x");
            }
            
        }
    }
}
