using Pets;
using System.ComponentModel;
using System.IO;
using System.Media;
using System.Windows;

namespace VirtualPets
{
    /// <summary>
    /// Interaction logic for Lemmikki.xaml
    /// </summary>
    public partial class Pet : Window, INotifyPropertyChanged
    {
        //to play bark sound
        private SoundPlayer player;
        public UnmanagedMemoryStream Sound { get; set; }

        //autoimplemented property
        public Dog Lempis { get; set; }

        //Textblock content
        private string state = "Dog";
        public string State
        {
            get => state;
            set
            {
                state = value;
                OnPropertyChanged("state");//raises event
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

        public Pet()
        {
            InitializeComponent();
            DataContext = this;            
        }

        private void Eat_Button_Click(object sender, RoutedEventArgs e)
        {
            State = Lempis.Eat();
        }

        private void Sleep_Button_Click(object sender, RoutedEventArgs e)
        {
            State = Lempis.Sleep();
        }

        private void Run_Button_Click(object sender, RoutedEventArgs e)
        {
            State = Lempis.Run();
        }

        private void Bark_Button_Click(object sender, RoutedEventArgs e)
        {
            State = Lempis.Bark();
            if (player == null)
            {
                player = new SoundPlayer(Sound);
            }
            player.Stream.Position = 0;
            player.Play();
        }
    }
}
