using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class figure
    {
        private int xposition;

        public int XPosition
        {
            get { return xposition; }
            set { xposition = value; }
        }
        private int yposistion;

        public int YPosition
        {
            get { return yposistion; }
            set { yposistion = value; }
        }
        //private int move1 = 0;
        //private int move2 = 0;
        //private int move3 = 0;
        //private int move4 = 0;
        //private int move5 = 0;
        //private int move6 = 0;
        //private int move7 = 0;
        //private int move8 = 0;

        public figure(int xposition, int yposistion)
        {
            this.xposition = xposition;
            this.yposistion = yposistion;
            /*
             * Gehen wir davon aus, das die horizontale Achse X ist und die vertikale Y
             * |
             * |
             * |
             * Y
             *          X -----------
             * Sollte nun der Springer sich auf x3 y4 befinden dann errechnen sich folgene Positionen wie folgt
             * 
             *  Position 1 (Sprung 1) Y+2 X-1 Taste R 
             *  Position 2 (Sprung 2) Y+2 X+1 Taste T 
             *  Position 3 (Sprung 3) Y+1 X+2 Taste G 
             *  Position 4 (Sprung 4) Y-1 X+2 Taste B 
             *  Position 5 (Sprung 5) Y-2 X+1 Taste V 
             *  Position 6 (Sprung 6) Y-2 X-1 Taste C 
             *  Position 7 (Sprung 7) Y-1 X-2 Taste D 
             *  Position 8 (Sprung 8) Y+1 X-2 Taste E 
             *  
             */

        }
        public void move1()
        {
            YPosition = yposistion + 2;
            XPosition = xposition - 1;
        }

    }
}
