using Game.Domain.GameStates;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Domain
{
    public class GameManager
    {
        public Player Player { get; private set; }
        public IGameState GameState { get; private set; }

        public GameManager(Player player)
        {
            Player = player;
            Debug.Log($"Player score is {Player.Score}");
        }
    }
}



