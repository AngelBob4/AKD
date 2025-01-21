using UnityEngine;
using DG.Tweening;

namespace Sources.View
{
    public class GarageDoorView : MonoBehaviour
    {
        public void Open()
        {
            Vector3 openPosition = new Vector3(5, 5, 0);
            Vector3 openRotation = new Vector3(-70, 90, 0);
            float duration = 3;

            transform.DOLocalMove(openPosition, duration);
            transform.DOLocalRotate(openRotation, duration);
        }
    }
}