﻿using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WpfPrismSample.ViewModel
{
    public class MainViewModel : BindableBase
    {
        private string _title = "hi";
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
        private string _longText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
        public string LongText
        {
            get => _longText;
            set => SetProperty(ref _longText, value);
        }
        private string _alertText = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
        public string AlertText
        {
            get => _alertText;
            set => SetProperty(ref _alertText, value);
        }
        public MainViewModel()
        {
            Title = "WPF Style Samples";
        }
    }
}