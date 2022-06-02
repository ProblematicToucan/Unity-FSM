using UnityEngine;

namespace Script.Player.FSM
{
    public class DeadState : PlayerBaseState
    {
        public DeadState(PlayerStateManager ctx, PlayerStateFactory factory) : base(ctx, factory)
        {
        }

        public override void EnterState()
        {
            Debug.Log("Enter Dead State");
        }

        public override void UpdateState()
        {
            Debug.Log("Update Dead State");
        }

        public override void ExitState()
        {
            Debug.Log("Exit Dead State");
        }
    }
}