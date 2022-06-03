using UnityEngine;

namespace Script.Player.FSM.Normal
{
    public class NormalState : PlayerBaseState
    {
        public NormalState(PlayerStateManager ctx, PlayerStateFactory factory) : base(ctx, factory)
        {
            IsRootState = true;
        }

        public override void EnterState()
        {
            Debug.Log("Enter " + GetType().Name);
            InitializeSubState();
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
            //Grounded State
            SetSubState(Ctx.isGrounded ? Factory.Grounded() : Factory.Airborne());
        }

        public override void CheckTransitionToState()
        {
        }
    }
}