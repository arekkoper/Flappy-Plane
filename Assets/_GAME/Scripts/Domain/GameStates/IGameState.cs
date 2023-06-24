using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Domain.GameStates
{
    public interface IGameState
    {
        void Enter();
        void Exit();
    }
}
