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
using System.Xml.Linq;

namespace ProjectBeta.View
{
    /// <summary>
    /// Логика взаимодействия для TrainingLogPage.xaml
    /// </summary>
    public partial class TrainingLogPage : Page
    {
        public List<List<Days>> dayslist = new List<List<Days>>();
        public List<Days> day = new List<Days>();
        private ContentPresenter myContentPresenterParent;

        // public List<Exercises> per = new List<Exercises>();
        public TrainingLogPage()
        {
            InitializeComponent();
        }
        private void AddTraining_Click(object sender, RoutedEventArgs e)
        {
            dayslist.Add(new List<Days>());
            int count = dayslist.Count;
            dayslist[count - 1].Add(new Days("День " + count.ToString()));
            ltbx.ItemsSource = null;
            ltbx.ItemsSource = dayslist;
        }
        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            var stack = VisualTreeHelper.GetParent((DependencyObject)sender) as UIElement;
            var grid = VisualTreeHelper.GetParent((DependencyObject)stack) as UIElement;
            var el = VisualTreeHelper.GetChild(grid, 1) as UIElement;
            Label lab = el as Label;
            string s = lab.Content.ToString();
            s = s.Remove(0, 4);
            var st = VisualTreeHelper.GetParent((DependencyObject)grid) as UIElement;
            var goal = VisualTreeHelper.GetChild(st, 1) as UIElement;
            ListBox lb = goal as ListBox;
            //          if (dayslist[Convert.ToInt32(s)].Count==1 && dayslist[Convert.ToInt32(s)][0].)
            int index = Convert.ToInt32(s) - 1;
            dayslist[index].Add(new Days(s.ToString(), 0, 0, 0, "")); 
            lb.ItemsSource = null;
            lb.ItemsSource = dayslist[index];

        }



        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            var stack = VisualTreeHelper.GetParent((DependencyObject)sender) as UIElement;
            var grid = VisualTreeHelper.GetParent((DependencyObject)stack) as UIElement;
            var st = VisualTreeHelper.GetParent((DependencyObject)grid) as UIElement;
            var goal = VisualTreeHelper.GetChild(st, 1) as UIElement;
            ListBox lb = goal as ListBox;
            day.RemoveAt(day.Count - 1);
            lb.ItemsSource = null;
            lb.ItemsSource = day;
        }
    }
    public class Days
    {
        public string Num { get; set; }
        public int Ex { get; set; }
        public int Round { get; set; }
        public int Reps { get; set; }
        public string Comment { get; set; }
        public Days(string num, int ex = 0, int round=0, int reps=0, string com="")
        {
            Num = num;
            Ex = ex;
            Round = round;
            Reps = reps;
            Comment = com;
        }
    }
    /* private void Button_Click(object sender, RoutedEventArgs e)
 {
     string num = (per.Count + 1).ToString();
//     per.Add(new Exercises("День " + num));
     ltbx.ItemsSource = null;
     ltbx.ItemsSource = per;
 }*/

    /*private void btnadd_Click(object sender, RoutedEventArgs e)
    {
        var stack = VisualTreeHelper.GetParent((DependencyObject)sender) as UIElement;
        var grid = VisualTreeHelper.GetParent((DependencyObject)stack) as UIElement;
        var st = VisualTreeHelper.GetParent((DependencyObject)grid) as UIElement;
        var goal = VisualTreeHelper.GetChild(st, 1) as UIElement;
        ListBox lb = goal as ListBox;
        day.Add(new Days(0, 0, 0, "qwe"));
        lb.ItemsSource = null;
        lb.ItemsSource = day;

    }*/
    /*<StackPanel.Style>
                                        <Style TargetType = "StackPanel" >
                                            < Setter Property="Opacity" Value="0"/>
                                            <Style.Triggers>
                                                <DataTrigger Binding = "{Binding Path=IsMouseOver,ElementName=Hidden}" Value="true">
                                                    <Setter Property = "Opacity" Value="1"/>
                                                </DataTrigger>
                                            </Style.Triggers>
                                        </Style>
                                    </StackPanel.Style>*/
    /*
        <ListBox.ItemTemplate>
                    <DataTemplate>
                        <Border Background = "White" CornerRadius="5" BorderBrush="White" BorderThickness="10" SnapsToDevicePixels="True" UseLayoutRounding="True" Margin="5, 10, 5, 0">
                            <StackPanel x:Name="Hidden"  Background = "White" HorizontalAlignment="Stretch">
                                <Grid>
                                    <Button x:Name="btnadd" VerticalAlignment="Center" FontSize="15" HorizontalAlignment="Right" Content="Добавить упражнение">
                                        <Button.Style>
                                            <Style TargetType = "Button" >
                                                < Setter Property="Opacity" Value="0"/>
                                                <Style.Triggers>
                                                    <DataTrigger Binding = "{Binding Path=IsMouseOver,ElementName=Hidden}" Value="true">
                                                        <Setter Property = "Opacity" Value="1"/>
                                                    </DataTrigger>
                                                </Style.Triggers>
                                            </Style>
                                        </Button.Style>
                                    </Button>
                                    <Button VerticalAlignment = "Center" FontSize="15" Margin="0,0,170,0" HorizontalAlignment="Right" Content="Удалить упражнение">
                                        <Button.Style>
                                            <Style TargetType = "Button" >
                                                < Setter Property="Opacity" Value="0"/>
                                                <Style.Triggers>
                                                    <DataTrigger Binding = "{Binding Path=IsMouseOver,ElementName=Hidden}" Value="true">
                                                        <Setter Property = "Opacity" Value="1"/>
                                                    </DataTrigger>
                                                </Style.Triggers>
                                            </Style>
                                        </Button.Style>
                                    </Button>

                                    <Button VerticalAlignment = "Center" FontSize="15" Margin="0,0,330,0" HorizontalAlignment="Right" Content="Удалить день">
                                        <Button.Style>
                                            <Style TargetType = "Button" >
                                                < Setter Property="Opacity" Value="0"/>
                                                <Style.Triggers>
                                                    <DataTrigger Binding = "{Binding Path=IsMouseOver,ElementName=Hidden}" Value="true">
                                                        <Setter Property = "Opacity" Value="1"/>
                                                    </DataTrigger>
                                                </Style.Triggers>
                                            </Style>
                                        </Button.Style>
                                    </Button>
                                    <Label Content = "{Binding Day}"  FontSize="20" Foreground="Black" FontWeight="Bold" />
                                </Grid>
                            </StackPanel>
                        </Border>
                    </DataTemplate>
                </ListBox.ItemTemplate>*/
}
