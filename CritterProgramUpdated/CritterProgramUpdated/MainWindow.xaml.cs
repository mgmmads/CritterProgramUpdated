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

namespace CritterProgramUpdated
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UpdateState();
        }

        public void CheckIfBoxIsScrolled()
        {
            if (ScrollViewer.VerticalOffset == ScrollViewer.ScrollableHeight)
            {
                ScrollViewer.ScrollToEnd();
            }
        }

        public void UpdateState()
        {
            HungerStateLbl.Content = Controller.CritterHappiness();
            HappinessStateLbl.Content =  Controller.CritterHunger();
            if (Controller.CritterAliveCheck() == false)
            {
                CritterTalkingTextBlock.Text = "Your Critter is dead!";
                FeedCritterBtn.IsEnabled = false;
                PlayWithCritterBtn.IsEnabled = false;
            }
        }

        private void FeedCritterBtn_Click(object sender, RoutedEventArgs e)
        {
            CritterTalkingTextBlock.Text = CritterTalkingTextBlock.Text + Controller.CritterAction("FeedCritter") + "\n";
            CheckIfBoxIsScrolled();
            UpdateState();
        }

        private void PlayWithCritterBtn_Click(object sender, RoutedEventArgs e)
        {
            CritterTalkingTextBlock.Text = CritterTalkingTextBlock.Text + Controller.CritterAction("PlayWithCritter") + "\n";
            CheckIfBoxIsScrolled();
            UpdateState();
        }
    }
}
