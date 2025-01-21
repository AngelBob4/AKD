using UnityEngine;

namespace Sources.View
{
    public class PlayerMovementView : MonoBehaviour
    {
        [SerializeField] private CharacterController _characterController;

        private float speed = 5f;

        public void Move(Vector2 direction)
        {
            Vector3 motion = TransformJoystickVector(direction);
            motion = motion * Time.deltaTime * speed;
            _characterController.Move(motion);
        }

        private Vector3 TransformJoystickVector(Vector2 direction)
        {
            Vector3 forward = direction.y * transform.forward;
            Vector3 right = direction.x * transform.right;
            Vector3 finalDirection = forward + right;

            return finalDirection;
        }
    }
}