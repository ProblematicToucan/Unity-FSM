using UnityEngine;

namespace Script.Player.FSM
{
    public class PlayerStateManager : MonoBehaviour
    {
        public PlayerBaseState CurrenState;
        private PlayerStateFactory _states;
        
        private void Awake()
        {
            _states = new PlayerStateFactory(this);
        }

        private void Start()
        {
            CurrenState = _states.Normal();
            CurrenState.EnterState();
        }

        private void Update()
        {
            CurrenState.UpdateState();
        }

        #region Primitive Methods

        [ContextMenu("State Machine/Normal")]
        public void PlayNormalState()
        {
            CurrenState.TransitionToState(_states.Normal());
        }

        [ContextMenu("State Machine/Combat")]
        public void PlayCombatState()
        {
            CurrenState.TransitionToState(_states.Combat());
        }

        [ContextMenu("State Machine/Dead")]
        public void PlayDeadState()
        {
            CurrenState.TransitionToState(_states.Dead());
        }

        #endregion

        private void OnDisable()
        {
            CurrenState.ExitState();
        }
    }
}