using UnityEngine;

namespace Script.Player.FSM.Dead
{
    public class DeadState : PlayerBaseState
    {
        public DeadState(PlayerStateManager ctx, PlayerStateFactory factory) : base(ctx, factory)
        {
        }

        public override void EnterState()
        {
            Debug.Log("Enter " + GetType().Name);
        }

        public override void UpdateState()
        {
        }

        public override void PhysicsUpdateState()
        {
        }

        public override void ExitState()
        {
            Debug.Log("Exit " + GetType().Name);
        }

        public override void InitializeSubState()
        {
        }

        public override void CheckTransitionToState()
        {
        }
    }
}