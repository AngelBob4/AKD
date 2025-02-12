using Sources.Model;
using Sources.View.Cam;
using UnityEngine;

namespace InputSystem
{
    public class PlayerInputRouter : MonoBehaviour
    {
        [SerializeField] private CameraController _cameraController;

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

            if (moveDirection == Vector2.zero)
            {
                _cameraController.HandleLook();
            }

            _playerMovement.Move(moveDirection);
        }
    }
}