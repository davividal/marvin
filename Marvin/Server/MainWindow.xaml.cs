﻿using System;
using System.Collections.Generic;
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
using Microsoft.Win32;
using Marvin.Domain.Entities;
using System.Net.Sockets;
using System.Net;

namespace Marvin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Domain.Aggregates.FileList Files;
        private OpenFileDialog SelectedFiles;
        
        public MainWindow()
        {
            Files = Domain.Aggregates.FileList.getInstance();
            InitializeComponent();
        }

        private void SearchFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == true)
            {
                FilePath.Text = String.Join("; ", openFileDialog.FileNames);
                SelectedFiles = openFileDialog;
            }
            AddFile.Focus();
        }

        private void AddFile_Click(object sender, RoutedEventArgs e)
        {
            if (null == SelectedFiles)
            {
                SearchFile(sender, e);

                if (null == SelectedFiles) return;
            }

            foreach (String FileName in SelectedFiles.FileNames)
            {
                File NewFile = new File(
                    FileName,
                    (new System.IO.FileInfo(FileName)).Name
                );
                Files.AddFile(NewFile);
                if(!FileList.Items.Contains(NewFile.ToString()))
                FileList.Items.Add(NewFile.ToString());
                SelectedFiles = null;
                FilePath.Text = "";
            }
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
                FileList.Items.Remove(FileList.SelectedItem);
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Server.stop();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //Server.restart();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //Remover item
        }
    }
}
