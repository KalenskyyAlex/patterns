using IGumBallMachine;

namespace GumBallMachine
{
    class GumBallMachine : IGumBallMachine.IGumBallMachine
    {
        // Один з чотирьох станів машини
        public static State NO_COIN;
        public static State COIN_IN;
        public static State SOLD;
        public static State SOLD_OUT;

        private int gums;
        private string location;

        // Поточний стан
        public State state = SOLD_OUT; // за замовчуванням в автоматі немає жуйок

        public GumBallMachine(int gums, string location)
        {
            NO_COIN = new NO_COIN(this);
            COIN_IN = new COIN_IN(this);
            SOLD = new SOLD(this);
            SOLD_OUT = new SOLD_OUT(this);

            this.gums = gums;
            this.location = location;

            if(gums > 0)
            {
                state = NO_COIN;
            }
        }


        // Машина не переймається логікою і умовами, коли і що може виконуватися - це бере на себе стан
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

        public string getState()
        {
            if(state is NO_COIN)
            {
                return "NO COIN";
            }
            else if (state is COIN_IN)
            {
                return "COIN IN";
            }
            else if (state is SOLD)
            {
                return "SOLD";
            }
            else
            {
                return "SOLD OUT";
            }
        }

        public int getInventory()
        {
            return gums;
        }

        public string getLocation()
        {
            return location;
        }

        public void decrementGum()
        {
            gums--;
        }
    }
}
