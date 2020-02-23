using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MonkeyFestAustralia2020
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        #region PropertyChangedNotification bits

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            RaisePropertyChangedExplicit(propertyName);
        }

        protected virtual void RaisePropertyChangedExplicit(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T property, T newValue, [CallerMemberName] string propertyName = null)
        {
            bool isSuccessful = false;

            if (!Equals(property, newValue))
            {
                property = newValue;
                RaisePropertyChangedExplicit(propertyName);
                isSuccessful = true;
            }

            return isSuccessful;
        }

        #endregion PropertyChangedNotification bits
    }
}
