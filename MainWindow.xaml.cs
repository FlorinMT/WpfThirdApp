using System;
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

namespace WpfThirdApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetUpGame();
        }

        private void SetUpGame()
        {
            var animalEmoji = new List<string> { 
                "🦁", "🦁",
                "🐷", "🐷",
                "🐗", "🐗",
                "🦒", "🦒",
                "🐭", "🐭",
                "🐨", "🐨",
                "🐻", "🐻",
                "🐸", "🐸"
            };
            var random = new Random();
            foreach(TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                if(animalEmoji.Count > 0)
                {
                    int index = random.Next(animalEmoji.Count);
                    string text = animalEmoji[index];
                    textBlock.Text = text;
                    animalEmoji.RemoveAt(index);
                } else
                {
                    textBlock.Text = string.Empty;
                }
            }
        }
    }
}
