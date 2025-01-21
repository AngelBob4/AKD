using UnityEngine;
using Sources.View;

namespace Sources.Model
{
    public class GarageDoor : MonoBehaviour
    {
        private GarageDoorView _garageDoorView;

        public GarageDoor(GarageDoorView garageDoorView)
        {
            _garageDoorView = garageDoorView;

            _garageDoorView.Open();
        }
    }
}