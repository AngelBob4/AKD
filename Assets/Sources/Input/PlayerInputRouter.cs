using Sources.Model;
using UnityEngine;

namespace InputSystem
{
    public class PlayerInputRouter : MonoBehaviour
    {
        private PlayerMovement _playerMovement;
        private Joystick _joystick;

        public void Init(PlayerMovement playerMovement, Joystick joystick)
        {
            _joystick = joystick;
            _playerMovement = playerMovement;
        }

        public void Update()
        {
            Vector2 moveDirection;

            moveDirection = _joystick.Direction;
            moveDirection.Normalize();
            _playerMovement.Move(moveDirection);
        }
    }
}