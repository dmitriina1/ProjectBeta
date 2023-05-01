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

namespace ProjectBeta.View
{
    /// <summary>
    /// Логика взаимодействия для PullUpsPage.xaml
    /// </summary>
    public partial class PullUpsPage : Page
    {
        List<int> IndexCheckBox;
        MainWindow mainWindow = (MainWindow)System.Windows.Application.Current.MainWindow;
        public PullUpsPage()
        {
            InitializeComponent();
            IndexCheckBox = new List<int>();
            IndexCheckBox.Clear();
            IndexCheckBox = mainWindow.GiveIndexListPullUps(IndexCheckBox);
            if (IndexCheckBox.Count == 0)
            {
                for (int i = 0; i < 30; i++)
                {
                    IndexCheckBox.Add(0);
                }
            }
            else
            {
                for (int i = 0; i < IndexCheckBox.Count; i++)
                {
                    var element = FindName("lvl" + (i + 1).ToString()) as CheckBox;
                    if (element != null)
                    {
                        if (IndexCheckBox[i] == 1)
                        {
                            element.IsChecked = true;
                        }
                        else
                        {
                            element.IsChecked = false;
                        }
                    }
                }
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            var btn = (CheckBox)sender;
            if (btn.IsChecked == true)
            {
                btn.Background = Brushes.Green;
                string btnname = btn.Name;
                btnname = btnname.Trim(new char[] { 'l', 'v' });
                IndexCheckBox[Int32.Parse(btnname) - 1] = 1;
            }
            else
            {
                btn.Background = Brushes.White;
                string btnname = btn.Name;
                btnname = btnname.Trim(new char[] { 'l', 'v' });
                IndexCheckBox[Int32.Parse(btnname) - 1] = 0;
            }
            mainWindow.TakeIndexListPullUps(IndexCheckBox);
        }
    }
}
