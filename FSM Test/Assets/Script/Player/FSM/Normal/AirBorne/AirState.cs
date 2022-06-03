using UnityEngine;

namespace Script.Player.FSM.Normal.AirBorne
{
    public class AirState : PlayerBaseState
    {
        public AirState(PlayerStateManager ctx, PlayerStateFactory factory) : base(ctx, factory)
        {
        }

        public override void EnterState()
        {
            Debug.Log("Enter " + GetType().Name);
        }

        public override void UpdateState()
        {
            CheckTransitionToState();
            Debug.Log("Update " + GetType().Name);
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
            if (Ctx.isGrounded) TransitionToState(Factory.Grounded());
        }
    }
}