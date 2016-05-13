using System;
using System.Windows;
using Microsoft.Win32;
using Marvin.Domain.Entities;
using Marvin.Domain.Services;
using System.Threading;

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

            if (true == openFileDialog.ShowDialog())
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
                {
                    FileList.Items.Add(NewFile.ToString());
                }
                SelectedFiles = null;
                FilePath.Text = "";
            }
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
                FileList.Items.Remove(FileList.SelectedItem);
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            ServerService server = new ServerService("127.0.0.1", "12400"); // Isto deve ser feito numa thread
            Thread oThread = new Thread(new ThreadStart(ServerService.ListenConnection));
            //Server.start();
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
