using UnityEngine;
using UnityEngine.UI;
using Sources.Model;
using Zenject;

namespace Sources.View
{
    public class AmountOfBoxes : MonoBehaviour
    {
        [SerializeField] private Text _text;

        private Storage _storage;
        private int _currentAmount = 3;
        private int _startAmount = 3;

        [Inject]
        public void Inject(Storage storage)
        {
            _storage = storage;
            _storage.AmountOfBoxesChanched += ChangeText;
        }

        private void ChangeText()
        {
            _currentAmount--;
            string newText = _currentAmount.ToString() + "/" + _startAmount.ToString();
            _text.text = newText;
        }
    }
}