using System.Threading.Tasks;

namespace Script.Player.FSM
{
    public abstract class PlayerBaseState
    {
        protected PlayerStateManager Ctx;
        protected PlayerStateFactory Factory;

        protected PlayerBaseState(PlayerStateManager ctx, PlayerStateFactory factory)
        {
            Ctx = ctx;
            Factory = factory;
        }

        public abstract void EnterState();

        public abstract void UpdateState();

        public abstract void ExitState();

        public /*protected*/ async void TransitionToState(PlayerBaseState newState)
        {
            if (Ctx.CurrenState == newState) return;
            ExitState();
            newState.EnterState();
            Ctx.CurrenState = newState;
            await Task.Yield();
        }
    }
}