using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Game.Domain.GameStates
{
    public class StartGameState : IGameState
    {
        public void Enter()
        {
            Debug.Log("Enter state StartGame");
        }

        public void Exit()
        {
            Debug.Log("Exit state StartGame");
        }
    }
}
