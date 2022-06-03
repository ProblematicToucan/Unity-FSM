namespace Script.FSM
{
    public abstract class BaseState
    {
        public abstract void EnterState();

        public abstract void UpdateState();

        public abstract void PhysicsUpdateState();

        public abstract void ExitState();

        public abstract void InitializeSubState();

        public abstract void CheckTransitionToState();
    }
}