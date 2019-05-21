using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.GameStatusInfo
{
    class DiceD6
    {
        Random rand = new Random();

        public int Roll()
        {
            return rand.Next(1, 7);
        }
    }
}
