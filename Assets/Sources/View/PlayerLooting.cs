using UnityEngine;
using Sources.Model;

public class PlayerLooting : MonoBehaviour
{
    [SerializeField] private Transform _objectPosition;
    [SerializeField] private GameObject _actionButton;
    [SerializeField] private Transform _cameraTransform;

    private Box _takenObject;
    private Ray _ray;
    private float _maxDistance = 5f;

    private void FixedUpdate()
    {
        if (_takenObject != null && _takenObject.gameObject.activeSelf == false)
        {
            _takenObject = null;
        }

        _ray = new Ray(_cameraTransform.position, _cameraTransform.forward);

        RaycastHit[] RaycastHits = Physics.RaycastAll(_ray, _maxDistance);

        foreach (var hit in RaycastHits)
        {
            if (hit.collider.TryGetComponent(out Box box))
            {
                if (_takenObject == null)
                {
                    _takenObject = box;
                    _actionButton.SetActive(true);
                }
            }
        }
    }

    public void Take()
    {
        _takenObject.transform.SetParent(_objectPosition);
        _takenObject.gameObject.transform.localPosition = Vector3.zero;
        _actionButton.SetActive(false);
    }
}