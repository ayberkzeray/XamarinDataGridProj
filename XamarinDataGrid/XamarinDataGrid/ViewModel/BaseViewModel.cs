using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace XamarinDataGrid.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {      
       
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
