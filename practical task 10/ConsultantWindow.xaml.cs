using System;
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
using System.Windows.Shapes;

namespace practical_task_10
{
    /// <summary>
    /// Логика взаимодействия для ConsultantWindow.xaml
    /// </summary>
    public partial class ConsultantWindow : Window
    {
        List<Client> clients { get; set; }
        Consultant consultant;
        List<Client> client;
        bool q = true;
        int index;
        int i;
        public ConsultantWindow()
        {
            InitializeComponent();
            client = new List<Client>();
            consultant = new Manager();
            consultant = new InformationAboutChanges();
            clients = new List<Client>();
            clients = consultant.addAList(clients);
            dataGrid.ItemsSource = clients;
            dataGrid.Columns[0].IsReadOnly = true;
            dataGrid.Columns[1].IsReadOnly = true;
            dataGrid.Columns[2].IsReadOnly = true;
            dataGrid.Columns[4].Visibility = Visibility.Collapsed;
            dataGrid.CanUserAddRows = false;
        }
        /// <summary>
        /// Изменяет номер телефона
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            int z = 0;
            q = true;
            client.Clear();
            bool flag = true;
            index = dataGrid.SelectedIndex;
            if (index != -1) (consultant as InformationAboutChanges).ProcessingChanges(client, clients, index, z);
            (consultant as Manager).savingAList(clients, flag);
        }
        private void dataGrid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (q)
            {
                i = dataGrid.SelectedIndex;
                dataGrid.Columns[3].IsReadOnly = false;
                q = false;
            }
            else
            {
                if (i == dataGrid.SelectedIndex)
                    dataGrid.Columns[3].IsReadOnly = false;
                else
                {
                    MessageBox.Show("Нажмите кнопку 'Сохранить изменения' или 'Отмена'");
                    dataGrid.Columns[3].IsReadOnly = true;
                }
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            q = true;
            clients.Clear();
            dataGrid.ItemsSource = null;
            dataGrid.Items.Refresh();
            clients = consultant.addAList(clients);
            dataGrid.ItemsSource = clients;
        }
    }
}
