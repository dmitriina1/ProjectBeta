using ProjectBeta.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Xml.Linq;

namespace ProjectBeta.View
{
    /// <summary>
    /// Логика взаимодействия для TrainingLogPage.xaml
    /// </summary>
    public partial class TrainingLogPage : Page
    {
        private int countsOfDay;
        private object lbtx;

        public ObservableCollection<Days> DaysOfTreinee { get; set; } = new ObservableCollection<Days>();      

        public TrainingLogPage()
        {
            InitializeComponent();
        }

        private void AddTraining_Click(object sender, RoutedEventArgs e)
        {
            countsOfDay++;

            Days days = new Days();
            days.Num = countsOfDay;

            DaysOfTreinee.Add(days);
            ltbx.ItemsSource = DaysOfTreinee;

        }
        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            Exercise exercise = new Exercise();
            DaysOfTreinee.Last().Exercises.Add(exercise);
            
            ltbx.UpdateLayout();
            
        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            var stack = VisualTreeHelper.GetParent((DependencyObject)sender) as UIElement;
            var grid = VisualTreeHelper.GetParent((DependencyObject)stack) as UIElement;
            var st = VisualTreeHelper.GetParent((DependencyObject)grid) as UIElement;
            var goal = VisualTreeHelper.GetChild(st, 1) as UIElement;
            ListBox lb = goal as ListBox;

            //day.RemoveAt(day.Count - 1);
            //lb.ItemsSource = null;
            //lb.ItemsSource = day;
        }
    }
}
