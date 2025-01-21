using UnityEngine;
using InputSystem;
using Sources.Model;
using Sources.View;

namespace Sources.Infrastructure
{
    public class CompositeRoot : MonoBehaviour
    {
        [SerializeField] private GarageDoorView _garageDoorView;
        [SerializeField] private PlayerMovementView _playerMovementView;
        [SerializeField] private Joystick _joystick;
        [SerializeField] private PlayerInputRouter _playerInput;

        private GarageDoor _garageDoor;
        private PlayerMovement _playerMovement;

        private void Start()
        {
            _garageDoor = new GarageDoor(_garageDoorView);
            _playerMovement = new PlayerMovement(_playerMovementView);

            _playerInput.Init(_playerMovement, _joystick);
        }
    }
}