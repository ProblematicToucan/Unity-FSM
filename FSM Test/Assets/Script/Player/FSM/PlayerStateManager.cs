using UnityEngine;

namespace Script.Player.FSM
{
    public class PlayerStateManager : MonoBehaviour
    {
        private PlayerBaseState _currentState;
        private readonly NormalState _normalState = new NormalState();
        private readonly CombatState _combatState = new CombatState();
        private readonly DeadState _deadState = new DeadState();
        
        private void Start()
        {
            _currentState = _normalState;
            _currentState.EnterState(this);
        }
        
        private void Update()
        {
            _currentState.UpdateState(this);
        }
        
        public void SwitchState(PlayerBaseState newState)
        {
            _currentState = newState;
            newState.EnterState(this);
        }

        #region Primitive Methods

        [ContextMenu("State Machine/Normal")]
        public void PlayNormalState()
        {
            SwitchState(_normalState);
        }
        
        [ContextMenu("State Machine/Combat")]
        public void PlayCombatState()
        {
            SwitchState(_combatState);
        }
        
        [ContextMenu("State Machine/Dead")]
        public void PlayDeadState()
        {
            SwitchState(_deadState);
        }

        #endregion
    }
}
