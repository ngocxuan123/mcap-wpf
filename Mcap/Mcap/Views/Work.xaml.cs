using Mcap.Helper;
using Mcap.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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

namespace Mcap.Views
{
    /// <summary>
    /// Interaction logic for Work.xaml
    /// </summary>
    public partial class Work : UserControl
    {
        ListBox dragSource = null;
        private Point _startPoint;
        public Work()
        {
            InitializeComponent();
            List<TodoItem> items = new List<TodoItem>();
            items.Add(new TodoItem() { Title = "Nguyễn Văn A", Completion = 45 });
            items.Add(new TodoItem() { Title = "Nguyễn Văn B", Completion = 80 });
            items.Add(new TodoItem() { Title = "Nguyễn Văn C", Completion = 80 });


            lbTodoList.ItemsSource = items;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WorkingViewModel context = (WorkingViewModel)DataContext;
            context.Loading = Visibility.Hidden;
        }

        private void lbTodoList_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //ListView parent = (ListView)sender;
            //dragSource = parent;
            //object data = GetDataFromListBox(dragSource, e.GetPosition(parent));

            //if (data != null)
            //{
            //    DragDrop.DoDragDrop(parent, data, DragDropEffects.Move);
            //}
            _startPoint = e.GetPosition(null);
        }
        private static object GetDataFromListBox(ListBox source, Point point)
        {
            UIElement element = source.InputHitTest(point) as UIElement;
            if (element != null)
            {
                object data = DependencyProperty.UnsetValue;
                while (data == DependencyProperty.UnsetValue)
                {
                    data = source.ItemContainerGenerator.ItemFromContainer(element);

                    if (data == DependencyProperty.UnsetValue)
                    {
                        element = VisualTreeHelper.GetParent(element) as UIElement;
                    }

                    if (element == source)
                    {
                        return null;
                    }
                }

                if (data != DependencyProperty.UnsetValue)
                {
                    return data;
                }
            }

            return null;
        }

        private void Border_DragEnter(object sender, DragEventArgs e)
        {
            e.Effects = DragDropEffects.Move;
        }

        private void Border_PreviewDrop(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(typeof(TodoItem));
            ((IList)lbTodoList.ItemsSource).Remove(data);
            Console.WriteLine(data);
        }

        private void lbTodoList_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            Point mousePos = e.GetPosition(null);
            Vector diff = _startPoint - mousePos;
            DragDrop.DoDragDrop(lbTodoList, "dasdda", DragDropEffects.Move);
            //if (e.LeftButton == MouseButtonState.Pressed &&
            //    Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
            //    Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance)
            //{
            //    // Get the dragged ListViewItem
            //    ListView parent = (ListView)sender;
            //    dragSource = parent;
            //    object data = GetDataFromListBox(dragSource, e.GetPosition(parent));

            //    if (data != null)
            //    {
            //        DragDrop.DoDragDrop(parent, data, DragDropEffects.Move);
            //    }
            //}
        }
    }

    public class TodoItem
    {
        public string Title { get; set; }
        public int Completion { get; set; }
    }
}
