using Game.Application.Signals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Game.Presentation
{
    public class UIManager : MonoBehaviour
    {
        private SignalBus _signalBus;
        private MainMenuView.Factory _mainMenuViewFactory;

        [Inject]
        public void Init(SignalBus signalBus, MainMenuView.Factory mainMenuViewFactory)
        {
            _signalBus = signalBus;
            _mainMenuViewFactory = mainMenuViewFactory;
        }

        private void OnEnable()
        {
            _signalBus.Subscribe<StartGameEnterSignal>(Perform);
        }

        private void OnDisable()
        {
            _signalBus.Unsubscribe<StartGameEnterSignal>(Perform);
        }

        private void Perform()
        {
            var factory = _mainMenuViewFactory.Create();
        }
    }
}
