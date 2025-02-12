using UnityEngine;

namespace Sources.View.Cam
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private Transform _playerCamera;
        [SerializeField] private Transform _player;

        private float lookSpeedX = 10f;
        private float lookSpeedY = 10f;

        public void HandleLook()
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                float touchX = touch.deltaPosition.x * lookSpeedX * Time.deltaTime;
                float touchY = touch.deltaPosition.y * lookSpeedY * Time.deltaTime;

                _player.Rotate(0, touchX, 0); 

                float currentRotationX = _playerCamera.localRotation.eulerAngles.x - touchY;
                _playerCamera.localRotation = Quaternion.Euler(currentRotationX, 0f, 0f);
            }
        }
    }
}