using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Gongora
{
    class Desk
    {
        // Declare private members of the class
        public int width { get; set; }
        public int depth { get; set; }
        public int numberOfDrawers { get; set; }
        public String surfaceMaterial { get; set; }

        public Desk(int width, int depth, int numberOfDrawers, String surfaceMaterial) 
        {
            this.width = width;
            this.depth = depth;
            this.numberOfDrawers = numberOfDrawers;
            this.surfaceMaterial = surfaceMaterial;
        }

        public const int MIN_WIDTH = 24;
        public const int MAX_WIDTH = 96;
        public const int MIN_DEPTH = 12;
        public const int MAX_DEPTH = 48;
        public const int NO_DRAWERS_MIN = 0;
        public const int NO_DRAWERS_MAX = 7;
       
    }
    enum DesktopMaterial
    {
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Rosewood = 300,
        Veneer = 125
    }
}
