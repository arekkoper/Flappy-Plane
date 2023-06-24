using Game.Domain;
using Game.Application.GameStates;
using UnityEngine;
using Zenject;
using Game.Application.Signals;

namespace Game.Application.Installers
{
    public class ApplicationInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Debug.Log("Application Installer");

            SignalBusInstaller.Install(Container);

            Container.DeclareSignal<StartGameEnterSignal>().OptionalSubscriber();

            var player = new Player();

            Container.Bind<Player>().FromInstance(player).AsSingle();
            Container.BindInterfacesAndSelfTo<StartGameState>().AsSingle();
            Container.BindInterfacesAndSelfTo<GameState>().AsSingle();
            Container.BindInterfacesAndSelfTo<GameOverState>().AsSingle();
            Container.BindInterfacesAndSelfTo<GameStateManager>().AsSingle();

        }
    }
}

