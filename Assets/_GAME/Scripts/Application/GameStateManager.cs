using Game.Domain.GameStates;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Application
{
    public class GameStateManager
    {
        private IGameState _currentState;

        public GameStateManager(IGameState currentState) 
        {
            _currentState = currentState;
            SetState(_currentState);
        }

        public void SetState(IGameState state)
        {
            if(_currentState != null) 
            {
                _currentState.Exit();
            }

            _currentState.Enter();
        }
    }
}
