using UnityEngine;

namespace Script.Player.FSM
{
    public class PlayerStateManager : MonoBehaviour
    {
        public bool isGrounded;
        private PlayerStateFactory _states;
        public PlayerBaseState CurrentState;

        private void Awake()
        {
            _states = new PlayerStateFactory(this);
        }

        private void Start()
        {
            CurrentState = _states.Normal();
            CurrentState.EnterStates();
        }

        private void Update()
        {
            CurrentState.UpdateStates();
        }

        private void FixedUpdate()
        {
            CurrentState.PhysicsUpdateStates();
        }

        private void OnDisable()
        {
            CurrentState.ExitStates();
        }

        #region Primitive Methods

        [ContextMenu("State Machine/Normal")]
        public void PlayNormalState()
        {
            CurrentState.TransitionToState(_states.Normal());
        }

        [ContextMenu("State Machine/Combat")]
        public void PlayCombatState()
        {
            CurrentState.TransitionToState(_states.Combat());
        }

        [ContextMenu("State Machine/Dead")]
        public void PlayDeadState()
        {
            CurrentState.TransitionToState(_states.Dead());
        }

        #endregion
    }
}