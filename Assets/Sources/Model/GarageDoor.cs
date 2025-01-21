using Sources.View;

namespace Sources.Model
{
    public class GarageDoor
    {
        private GarageDoorView _garageDoorView;

        public GarageDoor(GarageDoorView garageDoorView)
        {
            _garageDoorView = garageDoorView;

            _garageDoorView.Open();
        }
    }
}