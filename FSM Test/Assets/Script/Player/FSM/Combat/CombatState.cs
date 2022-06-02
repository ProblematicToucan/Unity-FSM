using UnityEngine;

namespace Script.Player.FSM
{
    public class CombatState : PlayerBaseState
    {
        public CombatState(PlayerStateManager ctx, PlayerStateFactory factory) : base(ctx, factory)
        {
        }

        public override void EnterState()
        {
            Debug.Log("Enter Combat State");
        }

        public override void UpdateState()
        {
            Debug.Log("Update Combat State");
        }

        public override void ExitState()
        {
            Debug.Log("Exit Combat State");
        }
    }
}