using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EitherMouse
{
    class Display
    {
        private ObservableCollection<Profile> _profiles;
        private Profile _currentProfile;

        public ObservableCollection<Profile> Profiles { get => _profiles; }
        private Profile CurrentProfile { get => _currentProfile; set => _currentProfile = value; }

        public Display(IEnumerable<Profile> profiles)
        {
            _profiles = new ObservableCollection<Profile>(profiles);
        }
    }
}
