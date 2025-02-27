﻿//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

#if USING_CSWINRT
using System.ComponentModel;
#else
using Microsoft.UI.Xaml.Data;
#endif

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AppUIBasics.ControlPages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CommandBarPage : Page, INotifyPropertyChanged
    {
        private bool multipleButtons = false;

        public bool MultipleButtons
        {
            get
            {
                return multipleButtons;
            }
            set
            {
                multipleButtons = value;
                OnPropertyChanged("MultipleButtons");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }

        public CommandBarPage()
        {
            this.InitializeComponent();
            AddKeyboardAccelerators();
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            PrimaryCommandBar.IsOpen = true;
            PrimaryCommandBar.IsSticky = true;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            PrimaryCommandBar.IsOpen = false;
            PrimaryCommandBar.IsSticky = false;
        }

        private void AddSecondaryCommands_Click(object sender, RoutedEventArgs e)
        {
            // Add compact button to the command bar. It provides functionality specific
            // to this page, and is removed when leaving the page.

            if (PrimaryCommandBar.SecondaryCommands.Count == 1)
            {
                var newButton = new AppBarButton();
                newButton.Icon = new SymbolIcon(Symbol.Add);
                newButton.Label = "Button 1";
                newButton.KeyboardAccelerators.Add(new Microsoft.UI.Xaml.Input.KeyboardAccelerator()
                {
                    Key = Windows.System.VirtualKey.N,
                    Modifiers = Windows.System.VirtualKeyModifiers.Control
                });
                PrimaryCommandBar.SecondaryCommands.Add(newButton);

                newButton = new AppBarButton();
                newButton.Icon = new SymbolIcon(Symbol.Delete);
                newButton.Label = "Button 2";
                PrimaryCommandBar.SecondaryCommands.Add(newButton);
                newButton.KeyboardAccelerators.Add(new Microsoft.UI.Xaml.Input.KeyboardAccelerator()
                {
                    Key = Windows.System.VirtualKey.Delete
                });
                PrimaryCommandBar.SecondaryCommands.Add(new AppBarSeparator());

                newButton = new AppBarButton();
                newButton.Icon = new SymbolIcon(Symbol.FontDecrease);
                newButton.Label = "Button 3";
                newButton.KeyboardAccelerators.Add(new Microsoft.UI.Xaml.Input.KeyboardAccelerator()
                {
                    Key = Windows.System.VirtualKey.Subtract,
                    Modifiers = Windows.System.VirtualKeyModifiers.Control
                });
                PrimaryCommandBar.SecondaryCommands.Add(newButton);

                newButton = new AppBarButton();
                newButton.Icon = new SymbolIcon(Symbol.FontIncrease);
                newButton.Label = "Button 4";
                newButton.KeyboardAccelerators.Add(new Microsoft.UI.Xaml.Input.KeyboardAccelerator()
                {
                    Key = Windows.System.VirtualKey.Add,
                    Modifiers = Windows.System.VirtualKeyModifiers.Control
                });
                PrimaryCommandBar.SecondaryCommands.Add(newButton);

            }
            MultipleButtons = true;
        }

        private void RemoveSecondaryCommands_Click(object sender, RoutedEventArgs e)
        {
            RemoveSecondaryCommands();
        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            RemoveSecondaryCommands();
            base.OnNavigatingFrom(e);
        }

        private void RemoveSecondaryCommands()
        {
            while (PrimaryCommandBar.SecondaryCommands.Count > 1)
            {
                PrimaryCommandBar.SecondaryCommands.RemoveAt(PrimaryCommandBar.SecondaryCommands.Count - 1);
            }                
            MultipleButtons = false;
        }


        private void AddKeyboardAccelerators()
        {
            editButton.KeyboardAccelerators.Add(new Microsoft.UI.Xaml.Input.KeyboardAccelerator()
            {
                Key = Windows.System.VirtualKey.E,
                Modifiers = Windows.System.VirtualKeyModifiers.Control
            });

            shareButton.KeyboardAccelerators.Add(new Microsoft.UI.Xaml.Input.KeyboardAccelerator()
            {
                Key = Windows.System.VirtualKey.F4
            });

            addButton.KeyboardAccelerators.Add(new Microsoft.UI.Xaml.Input.KeyboardAccelerator()
            {
                Key = Windows.System.VirtualKey.A,
                Modifiers = Windows.System.VirtualKeyModifiers.Control
            });

        }

    }
}
