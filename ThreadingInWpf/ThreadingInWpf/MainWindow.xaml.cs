using System;
using System.Threading;

namespace ThreadingInWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            new Thread(Work).Start(); //worker thread
        }

        void Work()
        {
            Thread.Sleep(5000);
            Action action = () => TxtDisplay.Text = "-The Game-";

            Dispatcher.BeginInvoke(action); //enqueues the action to the message queue which handles UI threading
        }
    }
}