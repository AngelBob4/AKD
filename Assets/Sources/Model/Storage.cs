using System;

namespace Sources.Model
{
    public class Storage
    {
        private int _maxObjects = 3;
        private int _currentObjects = 0;

        public event Action GameOver;
        public event Action AmountOfBoxesChanched;

        public void AddObject()
        {
            _currentObjects++;

            AmountOfBoxesChanched?.Invoke();

            if (_maxObjects == _currentObjects)
            {
                GameOver?.Invoke();
            }
        }
    }
}