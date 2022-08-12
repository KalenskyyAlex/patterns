using System;
using System.Collections.Generic;
using System.Text;

namespace GumBallMachine
{
    interface State
    {
        void insert();

        void eject();

        void turn_crank();

        void throw_gum();
    }


    class NO_COIN : State
    {
        private GumBallMachine machine;
        public NO_COIN(GumBallMachine m)
        {
            machine = m;
        }

        public void insert()
        {
            Console.WriteLine("Coin inserted");
            machine.state = GumBallMachine.COIN_IN;
        }

        public void eject()
        {
            Console.WriteLine("Nothing to eject");
        }

        public void turn_crank()
        {
            Console.WriteLine("Insert the coin first");
        }

        public void throw_gum() { }
    }

    class COIN_IN : State
    {
        private GumBallMachine machine;
        public COIN_IN(GumBallMachine m)
        {
            machine = m;
        }

        public void insert()
        {
            Console.WriteLine("Coin is already in");
        }

        public void eject()
        {
            Console.WriteLine("Coin ejected");
            machine.state = GumBallMachine.NO_COIN;
        }

        public void turn_crank()
        {
            Console.WriteLine("Crank turned - wait for a gum");
            machine.state = GumBallMachine.SOLD;
        }

        public void throw_gum() { }
    }

    class SOLD : State
    {
        private GumBallMachine machine;

        public SOLD(GumBallMachine m)
        {
            machine = m;
        }

        public void insert()
        {
            Console.WriteLine("First pick up the gum");
        }

        public void eject()
        {
            Console.WriteLine("No coin to eject");
        }

        public void turn_crank()
        {
            Console.WriteLine("First pick up the gum");
        }

        public void throw_gum()
        {
            Console.WriteLine("Gum throwed");
            machine.gums--;
            if (machine.gums == 0)
            {
                machine.state = GumBallMachine.SOLD_OUT;
            }
            else
            {
                machine.state = GumBallMachine.NO_COIN;
            }
        }
    }

    class SOLD_OUT : State
    {
        public GumBallMachine machine;

        public SOLD_OUT(GumBallMachine m)
        {
            machine = m;
        }

        public void insert()
        {
            Console.WriteLine("NO GUM TO SOLD");
        }

        public void eject()
        {
            Console.WriteLine("NO GUM TO SOLD");
        }

        public void throw_gum()
        {
            Console.WriteLine("NO GUM TO SOLD");
        }

        public void turn_crank()
        {
            Console.WriteLine("NO GUM TO SOLD");
        }
    }
}
