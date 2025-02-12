using UnityEngine;
using UnityEngine.EventSystems;

namespace Sources.View.Cam
{
    public class CameraControllerPanel : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        private int _fingerId;

        public bool Pressed { get; private set; } = false;

        public void OnPointerDown(PointerEventData eventData)
        {
            if (eventData.pointerCurrentRaycast.gameObject == gameObject)
            {
                Pressed = true;
                _fingerId = eventData.pointerId;
            }
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            Pressed = false;
        }
    }
}