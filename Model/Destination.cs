using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokoBan.Model
{
    public class Destination : Floor
    {
        public Destination()
        {
        }

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
