using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RadioPanel.Core
{
    public abstract class ObserveableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
