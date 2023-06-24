using Game.Application.GameStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Application
{
    public interface IGameStateManager
    {
        void SetState(IGameState state);
    }
}
