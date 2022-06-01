using UnityEngine;

namespace Script.Player.FSM
{
    public abstract class PlayerBaseState
    {
        public abstract void EnterState(PlayerStateManager playerState);
        
        public abstract void UpdateState(PlayerStateManager playerState);
    }
}
