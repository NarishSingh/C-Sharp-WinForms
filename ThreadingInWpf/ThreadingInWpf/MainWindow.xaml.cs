using System;
using System.Threading;

namespace ThreadingInWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private SynchronizationContext _uiSyncContext;
        
        public MainWindow()
        {
            InitializeComponent();
            
            _uiSyncContext = SynchronizationContext.Current; //capture current UI thread

            new Thread(Work).Start(); //worker thread
        }

        void Work()
        {
            Thread.Sleep(5000);
            UpdateMsg("-The Game-");
        }

        private void UpdateMsg(string msg)
        {
            //using dispatcher
            // Action action = () => TxtDisplay.Text = msg;
            // Dispatcher.BeginInvoke(action); //enqueues the action to the message queue which handles UI threading
            
            //marshalling delegate to UI thread
            _uiSyncContext.Post( _ => TxtDisplay.Text = msg, null);
        }
    }
}