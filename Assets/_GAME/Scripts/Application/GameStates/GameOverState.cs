using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game.Application.GameStates
{
    public class GameOverState : IGameState
    {
        public void Enter()
        {
            Debug.Log("Enter GameOverState");
        }

        public void Exit()
        {
            Debug.Log("Exit GameOverState");
        }
    }
}
