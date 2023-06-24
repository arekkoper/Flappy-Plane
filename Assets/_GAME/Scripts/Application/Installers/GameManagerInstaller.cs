using Game.Domain;
using Game.Domain.GameStates;
using UnityEngine;
using Zenject;

namespace Game.Application.Installers
{
    public class GameManagerInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            var player = new Player();
            var gameManager = new GameManager(player);
            var gameStateManager = new GameStateManager(new StartGameState());

            Container.Bind<Player>().FromInstance(player).AsSingle();
            Container.Bind<GameManager>().FromInstance(gameManager).AsSingle();
            Container.BindInterfacesAndSelfTo<StartGameState>().AsSingle();
            Container.BindInterfacesAndSelfTo<MainGameState>().AsSingle();
            Container.BindInterfacesAndSelfTo<GameOverState>().AsSingle();
            Container.Bind<GameStateManager>().FromInstance(gameStateManager).AsSingle();
        }
    }
}

