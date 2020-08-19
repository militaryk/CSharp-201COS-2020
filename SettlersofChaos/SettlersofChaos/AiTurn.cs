using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersofChaos
{
    class AiTurn
    {
        public int AIAttack;
        public bool easy = true, medium = false, hard = false;
        public void AITurn(Random random)
        {
            AIAttack = random.Next(1, 100);
        }


    }
}
