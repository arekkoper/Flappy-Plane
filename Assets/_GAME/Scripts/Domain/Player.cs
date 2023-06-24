using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game.Domain
{
    public class Player
    {
        public int Score { get; set; }

        public Player()
        {
            Score = 0;
        }
    }
}
