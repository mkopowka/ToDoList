﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TDListCore
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (s,e) => { };

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
