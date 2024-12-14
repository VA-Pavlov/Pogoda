using System.Windows;
using System;
using System.Windows.Controls;
using System.Windows.Media;

namespace Pogoda.Views.Home
{
    /// <summary>
    /// Логика взаимодействия для HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        private ScrollViewer scrollViewer;
        public HomeView()
        {
            InitializeComponent();
            scrollViewer = GetDescendantByType(WeatherDays_ListBox, typeof(ScrollViewer)) as ScrollViewer;
        }

        public void LeftScrolButton_Click(object sender, RoutedEventArgs e)
        {
            scrollViewer.LineLeft();
        }
        public void RightScrolButton_Click(object sender, RoutedEventArgs e)
        {
            scrollViewer.LineRight();
        }

        public static Visual GetDescendantByType(Visual element, Type type)
        {
            if (element == null)
            {
                return null;
            }
            if (element.GetType() == type)
            {
                return element;
            }
            Visual foundElement = null;
            if (element is FrameworkElement)
            {
                (element as FrameworkElement).ApplyTemplate();
            }
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(element); i++)
            {
                Visual visual = VisualTreeHelper.GetChild(element, i) as Visual;
                foundElement = GetDescendantByType(visual, type);
                if (foundElement != null)
                {
                    break;
                }
            }
            return foundElement;
        }
    }
}
