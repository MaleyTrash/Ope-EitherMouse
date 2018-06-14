using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace EitherMouse
{
    class Display : INotifyPropertyChanged
    {
        private ObservableCollection<Profile> _profiles;
        private Profile _currentProfile;

        public ObservableCollection<Profile> Profiles { get => _profiles; }
        public Profile CurrentProfile { get => _currentProfile; set { _currentProfile = value; OnPropertyChanged("CurrentProfile"); } }

        public RelayCommand ApplyCommand { get; set; }
        public RelayCommand SaveCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public Display(List<Profile> profiles)
        {
            if (profiles.Count < 1) profiles.Add(new Profile("Default", 10, 1000, 3));
            _profiles = new ObservableCollection<Profile>(profiles);
            CurrentProfile = profiles[0];
            ApplyCommand = new RelayCommand(ApplyProfile);
            SaveCommand = new RelayCommand(SaveProfile);
        }

        private void ApplyProfile()
        {
            if (_currentProfile == null) return;
            _currentProfile.ApplySettings();
        }

        private void SaveProfile()
        {
            if (_currentProfile == null) return;
            Profile found = Profiles.Where(i => i.Name == _currentProfile.Name).FirstOrDefault();
            if(found == null)
            {
                Profiles.Add(_currentProfile);
            }
            else
            {
                found = _currentProfile;
            }
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
