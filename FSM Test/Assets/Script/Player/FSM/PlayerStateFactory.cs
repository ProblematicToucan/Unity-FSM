using System.Collections.Generic;
using Script.StateMachine;

namespace Script.Player.FSM
{
    public enum PlayerStates
    {
        Normal,
        Combat,
        Dead
    }

    public class PlayerStateFactory
    {
        private readonly Dictionary<PlayerStates, PlayerBaseState> _states =
            new Dictionary<PlayerStates, PlayerBaseState>();
    
        public PlayerStateFactory(PlayerStateManager context)
        {
            _states[PlayerStates.Normal] = new NormalState(context, this);
            _states[PlayerStates.Combat] = new CombatState(context, this);
            _states[PlayerStates.Dead] = new DeadState(context, this);
        }
    
        public PlayerBaseState Normal() => _states[PlayerStates.Normal];
    
        public PlayerBaseState Combat() => _states[PlayerStates.Combat];
    
        public PlayerBaseState Dead() => _states[PlayerStates.Dead];
    }

}