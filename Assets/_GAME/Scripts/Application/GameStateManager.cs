using Game.Application.GameStates;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Game.Application
{
    public class GameStateManager : IGameStateManager, IInitializable
    {
        private IGameState _currentState;
        private SignalBus _signalBus;

        public GameStateManager(SignalBus signalBus) 
        {
            _signalBus = signalBus;
        }

        public void Initialize()
        {
            SetState(new StartGameState(_signalBus));
        }

        public void SetState(IGameState state)
        {
            if(_currentState != null) 
            {
                _currentState.Exit();
            }

            _currentState = state;

            _currentState.Enter();
        }
    }
}
