﻿//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************
using AppUIBasics.Data;
using System.Linq;
using Microsoft.UI.Xaml.Navigation;
using System.Collections.Generic;

#if USING_CSWINRT
using System.Collections.ObjectModel;
#endif

namespace AppUIBasics
{
    public sealed partial class HomePage : ItemsPageBase
    {
        public HomePage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var menuItem = NavigationRootPage.Current.NavigationView.MenuItems.Cast<Microsoft.UI.Xaml.Controls.NavigationViewItem>().First();
            menuItem.IsSelected = true;
            NavigationRootPage.Current.NavigationView.Header = string.Empty;

            Items = ControlInfoDataSource.Instance.Groups.SelectMany(g => g.Items.Where(i => i.BadgeString != null)).OrderBy(i => i.Title).ToList();
            itemsCVS.Source = FormatData();
        }

        private ObservableCollection<GroupInfoList> FormatData()
        {
            var query = from item in this.Items
                        group item by item.BadgeString into g
                        orderby g.Key
                        select new GroupInfoList(g) { Key = g.Key };

            ObservableCollection<GroupInfoList> groupList = new ObservableCollection<GroupInfoList>(query);

            //Move Preview samples to the back of the list
            var previewGroup = groupList.ElementAt(1);
            if (previewGroup?.Key.ToString() == "Preview")
            {
                groupList.RemoveAt(1);
                groupList.Insert(groupList.Count, previewGroup);
            }

            foreach (var item in groupList)
            {
                switch (item.Key.ToString())
                {
                    case "New":
                        item.Title = "Recently Added Samples";
                        break;
                    case "Updated":
                        item.Title = "Recently Updated Samples";
                        break;
                    case "Preview":
                        item.Title = "Preview Samples";
                        break;
                }
            }

            return groupList;
        }

        protected override bool GetIsNarrowLayoutState()
        {
            return LayoutVisualStates.CurrentState == NarrowLayout;
        }
    }

}
 