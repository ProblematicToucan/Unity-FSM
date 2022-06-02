using UnityEngine;

namespace Script.Player.FSM
{
    public class NormalState : PlayerBaseState
    {
        public NormalState(PlayerStateManager ctx, PlayerStateFactory factory) : base(ctx, factory)
        {
        }

        public override void EnterState()
        {
            Debug.Log("Enter Normal State");
        }

        public override void UpdateState()
        {
            Debug.Log("Update Normal State");
        }

        public override void ExitState()
        {
            Debug.Log("Exit Normal State");
        }
    }
}