using Pets;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Imaging;
using Tamagotchis;

namespace VirtualPets
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<IPet> pets = new List<IPet>();
        private List<Window> tamagotchis = new List<Window>();
        private List<Window> dogs = new List<Window>();
        private string polku = "pack://application:,,,/VirtualPets;component/img/";

        public MainWindow()
        {
            InitializeComponent();
            Top = 220; //in the middle
            Left = 230;
            Init();
        }

        private void Init()
        {
            //replace these with our own tamagotchis and dogs
            pets.Add(new Ilpo("Worm") { Pace = 3 });
            pets.Add(new Dino("Rex") { Pace = 2 });
            pets.Add(new Dino("Beast") { Pace = 6 });
            pets.Add(new Dog("Pippa", "Poodle"));
            pets.Add(new Dog("Noble", "Dachshund"));
            pets.Add(new Dog("Spark", "Bulldog"));
        }

        private void Tamagotchit_Button_Click(object sender, RoutedEventArgs e)
        {
            //remove previous objects
            Remove(tamagotchis);
            for (int i = 0; i < 3; i++)
            {
                Tamagotchi t = new Tamagotchi() { Tamppis = (Tamagotchis.Tamagotchi)pets[i] };
                tamagotchis.Add(t);
                //tamagotchi's information
                t.State = t.Tamppis.ToString();
                //standard picture as a placeholder
                t.Picture.Source = new BitmapImage(new Uri(String.Concat(polku, t.Tamppis.name + ".png")));
                //tamagotchi's window's location
                t.Left = 10 + tamagotchis.Count * 220; //200x200
                t.Top = 10;
                t.Show();

            }
        }

        private void Dogs_Button_Click(object sender, RoutedEventArgs e)
        {
            //remove previous objects
            Remove(dogs);
            for (int i = 0; i < 3; i++)
            {
                Pet t = new Pet() { Lempis = (Pets.Dog)pets[3 + i] };
                dogs.Add(t);
                //pet's information
                t.State = $"{t.Lempis.name}, {t.Lempis.breed}";
                //standard picture as a placeholder
                t.Picture.Source = new BitmapImage(new Uri(String.Concat(polku, t.Lempis.name + ".png")));
                //standard sound for barking
                t.Sound = Properties.Resources.bark;
                t.Left = 10 + dogs.Count * 220; //200x300
                t.Top = 330;
                t.Show();

            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Remove(tamagotchis);
            Remove(dogs);
        }

        private void Remove(List<Window> windows)
        {
            foreach (var v in windows)
            {
                v.Close();
            }
            windows.Clear();
        }
    }
}
