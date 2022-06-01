using UnityEngine;

namespace Script.Player.FSM
{
    public class CombatState : PlayerBaseState
    {
        public override void EnterState(PlayerStateManager playerState)
        {
            Debug.Log("Enter Combat State");
        }

        public override void UpdateState(PlayerStateManager playerState)
        {
            Debug.Log("Update Combat State");
        }
    }
}
