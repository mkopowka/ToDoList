﻿using System.Windows.Controls;
using TDListCore;

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for WorkTasksPage.xaml
    /// </summary>
    public partial class WorkTasksPage : Page
    {
        public WorkTasksPage()
        {
            InitializeComponent();
            DataContext = new WorkTasksPageViewModels();
        }
    }
}
