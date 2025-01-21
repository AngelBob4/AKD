using UnityEngine;

namespace Sources.View.Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private CameraControllerPanel cameraControllerPanel;

        public float sensitivity = 2.0f;
        public float sensitivityPanelRotate = 1;
        public float maxYAngle = 80.0f;
        private float rotationX = 0.0f;

        private void Update()
        {
            float mouseX = 0;
            float mouseY = 0;

            if (!IsMobileDevice())
            {
                if (cameraControllerPanel.Pressed)
                {
                    foreach (Touch touch in Input.touches)
                    {
                        if (touch.phase == TouchPhase.Moved)
                        {
                            mouseY = touch.deltaPosition.y * sensitivityPanelRotate;
                            mouseX = touch.deltaPosition.x * sensitivityPanelRotate;
                        }

                        if (touch.phase == TouchPhase.Stationary)
                        {
                            mouseY = 0;
                            mouseX = 0;
                        }
                    }
                }
            }
            else
            {
                mouseX = Input.GetAxis("Mouse X") * sensitivity;
                mouseY = Input.GetAxis("Mouse Y") * sensitivity;
            }

            transform.parent.Rotate(Vector3.up * mouseX * sensitivity);
            rotationX -= mouseY * sensitivity;
            rotationX = Mathf.Clamp(rotationX, -maxYAngle, maxYAngle);
            transform.localRotation = Quaternion.Euler(rotationX, 0.0f, 0.0f);
        }

        private bool IsMobileDevice()
        {
            if (SystemInfo.deviceType == DeviceType.Handheld)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}