using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace VirtualPets
{
    /// <summary>
    /// Interaction logic for Tamagotchi.xaml
    /// </summary>
    public partial class Tamagotchi : Window, INotifyPropertyChanged
    { 
        //thread to ensure "independent" behaviour
        private DispatcherTimer dispatcherTimer;
        private int tickInMillis = 1000; //thread operation interval
        private uint count = 1000; //help variable  for selecting which action to perfom or not
        //autoimplemented property
        public Tamagotchis.Tamagotchi Tamppis { get; set; }

        //TextBlock content
        private string state = "Tamagotchi";     
        public string State
        {
            get => state;
            set
            {
                state = value;
                OnPropertyChanged("state"); //raise event
            }
        }
        //INotifyPropertyChanged's delegate
        public event PropertyChangedEventHandler PropertyChanged;
        //event handler
        private void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }

        public Tamagotchi()
        {
            InitializeComponent();
            DataContext = this;
            Init();
        }

        private void Init()
        {
            //timer's initial values
            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(Tick_Action);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, tickInMillis);
            dispatcherTimer.Start();
        }

        private void Tick_Action(object sender, EventArgs e)
        {
            //  System.Windows.Threading.DispatcherTimer.Tick handler
            if (dispatcherTimer != null)
            {
                if (count >= 0)
                {
                    if (count-- % Tamppis.Pace == 0)
                    {
                        State = Tamppis.Sleep();
                    }
                    else
                    {
                        State = Tamppis.Eat();
                    }
                }
                else
                {
                    count = 1000;

                    //  InvalidateRequerySuggested on the CommandManager to force 
                    //  the Command to raise the CanExecuteChanged event.
                    CommandManager.InvalidateRequerySuggested();
                }
            }
        }
    }
}
