using UnityEngine;
using Sources.Model;
using Zenject;

namespace Sources.View
{
    public class CarStorage : MonoBehaviour
    {
        private Storage _storage;

        [Inject]
        public void Inject(Storage storage)
        {
            _storage = storage;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.TryGetComponent(out Box box))
            {
                _storage.AddObject();
                other.gameObject.SetActive(false);
            }
        }
    }
}