﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CounterTool.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CounterView : Grid
    {
        public CounterView()
        {
            InitializeComponent();
        }
    }
}