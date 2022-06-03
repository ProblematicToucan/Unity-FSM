using System.Threading.Tasks;
using Script.FSM;

namespace Script.Player.FSM
{
    public abstract class PlayerBaseState : BaseState
    {
        private PlayerBaseState _currentSubState;
        private PlayerBaseState _currentSuperState;
        protected PlayerStateManager Ctx;
        protected PlayerStateFactory Factory;
        protected bool IsRootState = false;

        protected PlayerBaseState(PlayerStateManager ctx, PlayerStateFactory factory)
        {
            Ctx = ctx;
            Factory = factory;
        }

        public async void TransitionToState(PlayerBaseState newState)
        {
            if (Ctx.CurrentState == newState) return;
            ExitStates();
            newState.EnterStates();
            if (IsRootState)
                Ctx.CurrentState = newState;
            else
                _currentSuperState?.SetSubState(newState);

            await Task.Yield();
        }

        private async void SetSuperState(PlayerBaseState newSuperState)
        {
            _currentSuperState = newSuperState;
            await Task.Yield();
        }

        protected async void SetSubState(PlayerBaseState newSubState)
        {
            _currentSubState = newSubState;
            newSubState.SetSuperState(this);
            await Task.Yield();
        }

        #region OnStates

        public async void EnterStates()
        {
            EnterState();
            _currentSubState?.EnterState();
            await Task.Yield();
        }

        public async void UpdateStates()
        {
            UpdateState();
            _currentSubState?.UpdateState();
            await Task.Yield();
        }

        public async void PhysicsUpdateStates()
        {
            PhysicsUpdateState();
            _currentSubState?.PhysicsUpdateState();
            await Task.Yield();
        }

        public async void ExitStates()
        {
            _currentSubState?.ExitState();
            ExitState();
            await Task.Yield();
        }

        #endregion
    }
}