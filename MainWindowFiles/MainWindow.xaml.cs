﻿using SearchEngine.API;
using SearchEngine.FileManagement;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace SearchEngine.MainWindowFiles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isTypedByUser;
        API.SearchEngine searchEngine;

        public MainWindow()
        {
            InitializeComponent();

            //initializing directories
            Logger logger = new Logger();

            AddMainLogo();

            searchEngine = new API.SearchEngine(contentFrame);
            isTypedByUser = false;
        }
    }
}
