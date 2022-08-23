using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mixer
{
    public interface IController
    {
        void IncrementBPM();
        void DecrementBPM();

        void setBPM(int BPM);

        void on();
        void off();
    }
}
