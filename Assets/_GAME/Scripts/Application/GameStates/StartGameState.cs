using Game.Application.Signals;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Game.Application.GameStates
{
    public class StartGameState : IGameState
    {
        private SignalBus _signalBus;

        public StartGameState(SignalBus signalBus)
        {
            _signalBus = signalBus;
        }

        public void Enter()
        {
            _signalBus.Fire(new StartGameEnterSignal());
        }

        public void Exit()
        {
            Debug.Log("Exit state StartGame");
        }
    }
}
