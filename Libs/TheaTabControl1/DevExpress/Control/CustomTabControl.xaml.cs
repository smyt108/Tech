﻿using DevExpress.Model;
using DevExpress.Mvvm.UI.Interactivity;
using DevExpress.Xpf.Editors;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DevExpress.Control
{
    /// <summary>
    /// Interaction logic for CustomTabControl.xaml
    /// </summary>
    public partial class CustomTabControl : UserControl
    {
        public CustomTabControl()
        {
            InitializeComponent();
        }

        public ObservableCollection<TabModel> ListTabItemSource
        {
            get { return (ObservableCollection<TabModel>)GetValue(ListTabItemSourceProperty); }
            set { SetValue(ListTabItemSourceProperty, value); }
        }

        public static readonly DependencyProperty ListTabItemSourceProperty =
            DependencyProperty.Register("ListTabItemSource", typeof(ObservableCollection<TabModel>), typeof(CustomTabControl));

    }
}