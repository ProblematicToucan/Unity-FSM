using UnityEngine;

namespace Script.Player.FSM
{
    public class DeadState : PlayerBaseState
    {
        public override void EnterState(PlayerStateManager playerState)
        {
            Debug.Log("Enter Dead State");
        }

        public override void UpdateState(PlayerStateManager playerState)
        {
            Debug.Log("Update Dead State");
        }
    }
}
