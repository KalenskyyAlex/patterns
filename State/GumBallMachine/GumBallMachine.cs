using System;
using System.Collections.Generic;
using System.Text;

namespace GumBallMachine
{
    class GumBallMachine
    {
        public static State NO_COIN;
        public static State COIN_IN;
        public static State SOLD;
        public static State SOLD_OUT;

        public int gums;

        public State state = SOLD_OUT; // за замовчуванням в автоматі немає жуйок

        public GumBallMachine(int gum)
        {
            NO_COIN = new NO_COIN(this);
            COIN_IN = new COIN_IN(this);
            SOLD = new SOLD(this);
            SOLD_OUT = new SOLD_OUT(this);

            gums = gum;

            if(gum > 0)
            {
                state = NO_COIN;
            }
        }

        public void insert()
        {
            state.insert();
        }

        public void eject()
        {
            state.eject();
        }

        public void turn_crank()
        {
            state.turn_crank();
            state.throw_gum();
        }
    }
}
