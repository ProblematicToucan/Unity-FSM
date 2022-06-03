using System.Collections.Generic;
using Script.Player.FSM.Combat;
using Script.Player.FSM.Dead;
using Script.Player.FSM.Normal;
using Script.Player.FSM.Normal.AirBorne;
using Script.Player.FSM.Normal.Grounded;
using Script.Player.FSM.Normal.Grounded.Moving;

namespace Script.Player.FSM
{
    public enum PlayerStates
    {
        Normal,
        Combat,
        Dead,
        Grounded,
        Airborne,
        Jumping
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
            _states[PlayerStates.Grounded] = new GroundedState(context, this);
            _states[PlayerStates.Airborne] = new AirState(context, this);
            _states[PlayerStates.Jumping] = new JumpState(context, this);
        }

        public PlayerBaseState Normal()
        {
            return _states[PlayerStates.Normal];
        }

        public PlayerBaseState Combat()
        {
            return _states[PlayerStates.Combat];
        }

        public PlayerBaseState Dead()
        {
            return _states[PlayerStates.Dead];
        }

        public PlayerBaseState Grounded()
        {
            return _states[PlayerStates.Grounded];
        }

        public PlayerBaseState Airborne()
        {
            return _states[PlayerStates.Airborne];
        }

        public PlayerBaseState Jumping()
        {
            return _states[PlayerStates.Jumping];
        }
    }
}