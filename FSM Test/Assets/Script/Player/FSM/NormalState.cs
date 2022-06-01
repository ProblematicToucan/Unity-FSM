using UnityEngine;

namespace Script.Player.FSM
{
    public class NormalState : PlayerBaseState
    {
        public override void EnterState(PlayerStateManager playerState)
        {
            Debug.Log("Enter Normal State");
        }

        public override void UpdateState(PlayerStateManager playerState)
        {
            Debug.Log("Update Normal State");
        }
    }
}
