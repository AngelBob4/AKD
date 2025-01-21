using Sources.Model;
using UnityEngine;
using Zenject;

namespace Sources.View
{
    public class VictoryMessage : MonoBehaviour
    {
        private Storage _storage;

        [Inject]
        public void Inject(Storage storage)
        {
            _storage = storage;
            _storage.GameOver += ShowMessage;
        }

        private void ShowMessage()
        {
            gameObject.SetActive(true);
        }
    }
}