using Sources.View;
using UnityEngine;

namespace Sources.Model
{
    public class PlayerMovement : MonoBehaviour
    {
        private PlayerMovementView _playerMovementView;

        public PlayerMovement(PlayerMovementView playerMovementView)
        {
            _playerMovementView = playerMovementView;
        }

        public void Move(Vector2 direction)
        {
            _playerMovementView.Move(direction);
        }
    }
}