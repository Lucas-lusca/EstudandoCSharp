using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_EstudosFinaisCSharp
{
    public class Player
    {
        public String userName;

        public Player(String userName)
        {
            this.userName = userName;
        }

        public override String ToString()
        {
            return userName;
        }
    }
}
