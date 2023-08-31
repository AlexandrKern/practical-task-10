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

namespace practical_task_10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int i;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            comboBox.SelectedIndex = 0;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
            {
                ConsultantWindow consultantWindow = new ConsultantWindow();
                this.Close();
                consultantWindow.Show();
            }
            if (comboBox.SelectedIndex == 1)
            {
                ManagerWindow managerWindow = new ManagerWindow();
                this.Close();
                managerWindow.Show();
            }
        }
    }
}
