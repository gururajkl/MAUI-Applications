﻿namespace StylesInMAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DynamicView();
        }
    }
}