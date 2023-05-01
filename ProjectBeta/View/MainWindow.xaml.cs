using ProjectBeta.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace ProjectBeta
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<int> CheckBoxIndexPushUps = new List<int>();
        public List<int> CheckBoxIndexSquats = new List<int>();
        public List<int> CheckBoxIndexPullUps = new List<int>();
        public List<int> CheckBoxIndexLegLifts = new List<int>();
        public List<int> CheckBoxIndexBridge = new List<int>();
        public List<int> CheckBoxIndexHandPushUps = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
            SlideMenu.Visibility = Visibility.Collapsed;
            /* PushUpsBtn.IsChecked = true;
             Training.IsChecked = true;
             this.Training.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));*/
        }

        private void Training_Click(object sender, RoutedEventArgs e)
        {
            Page trainings = new Training();
            frame.Navigate(trainings);
            SlideMenu.Visibility = Visibility.Visible;
            PushUpsBtn.IsChecked = true;
        }
        public void TakeIndexListPushUps(List<int> list)
        {
            CheckBoxIndexPushUps.Clear();
            foreach (int i in list)
            {
                CheckBoxIndexPushUps.Add(i);
            }
        }
        public List<int> GiveIndexListPushUps(List<int> list)
        {
            list.Clear();
            foreach (int i in CheckBoxIndexPushUps)
            {
                list.Add(i);
            }
            return list;
        }

        public void TakeIndexListSquats(List<int> list)
        {
            CheckBoxIndexSquats.Clear();
            foreach (int i in list)
            {
                CheckBoxIndexSquats.Add(i);
            }
        }
        public List<int> GiveIndexListSquats(List<int> list)
        {
            list.Clear();
            foreach (int i in CheckBoxIndexSquats)
            {
                list.Add(i);
            }
            return list;
        }
        public void TakeIndexListPullUps(List<int> list)
        {
            CheckBoxIndexPullUps.Clear();
            foreach (int i in list)
            {
                CheckBoxIndexPullUps.Add(i);
            }
        }
        public List<int> GiveIndexListPullUps(List<int> list)
        {
            list.Clear();
            foreach (int i in CheckBoxIndexPullUps)
            {
                list.Add(i);
            }
            return list;
        }

        public void TakeIndexListLegLifts(List<int> list)
        {
            CheckBoxIndexLegLifts.Clear();
            foreach (int i in list)
            {
                CheckBoxIndexLegLifts.Add(i);
            }
        }
        public List<int> GiveIndexListLegLifts(List<int> list)
        {
            list.Clear();
            foreach (int i in CheckBoxIndexLegLifts)
            {
                list.Add(i);
            }
            return list;
        }

        public void TakeIndexListBridge(List<int> list)
        {
            CheckBoxIndexBridge.Clear();
            foreach (int i in list)
            {
                CheckBoxIndexBridge.Add(i);
            }
        }
        public List<int> GiveIndexListBridge(List<int> list)
        {
            list.Clear();
            foreach (int i in CheckBoxIndexBridge)
            {
                list.Add(i);
            }
            return list;
        }

        public void TakeIndexListHandPushUps(List<int> list)
        {
            CheckBoxIndexHandPushUps.Clear();
            foreach (int i in list)
            {
                CheckBoxIndexHandPushUps.Add(i);
            }
        }
        public List<int> GiveIndexListHandPushUps(List<int> list)
        {
            list.Clear();
            foreach (int i in CheckBoxIndexHandPushUps)
            {
                list.Add(i);
            }
            return list;
        }

        private void SquatsBtn_Checked(object sender, RoutedEventArgs e)
        {
            Page squats = new SquatsPage();
            frame.Navigate(squats);
        }

        private void PushUpsBtn_Checked(object sender, RoutedEventArgs e)
        {
            Page trainings = new Training();
            frame.Navigate(trainings);
        }

        private void PullUpsBtn_Checked(object sender, RoutedEventArgs e)
        {
            Page pullups = new PullUpsPage();
            frame.Navigate(pullups);
        }

        private void LegLiftsBtn_Checked(object sender, RoutedEventArgs e)
        {
            Page leglifts = new LegLiftsPage();
            frame.Navigate(leglifts);
        }

        private void BridgeBtn_Checked(object sender, RoutedEventArgs e)
        {
            Page bridge = new BridgePage();
            frame.Navigate(bridge);
        }

        private void HandPushUpsBtn_Checked(object sender, RoutedEventArgs e)
        {
            Page handpushups = new HandPushUpsPage();
            frame.Navigate(handpushups);
        }

        private void TrainingLog_Checked(object sender, RoutedEventArgs e)
        {
            SlideMenu.Visibility = Visibility.Collapsed;
            Page traininglog = new TrainingLogPage();
            frame.Navigate(traininglog);
        }
    }
}
