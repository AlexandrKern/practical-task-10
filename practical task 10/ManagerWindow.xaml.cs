using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace practical_task_10
{
    /// <summary>
    /// Логика взаимодействия для ManagerWindow.xaml
    /// </summary>
    public partial class ManagerWindow : Window
    {
        List<Client> clients { get; set; }
        List<Client> client;
        Manager manager;
        InformationAboutChanges InformationAboutChanges;
        bool q = true;
        int i;
        bool v = true;
        public ManagerWindow()
        {
            InitializeComponent();
            i = dataGrid.SelectedIndex;
            client = new List<Client>();
            InformationAboutChanges = new InformationAboutChanges();
            manager = new Manager();
            clients = new List<Client>();
            clients = manager.addAList(clients);
            dataGrid.ItemsSource = clients;
            dataGrid.CanUserAddRows = false;
        }
        /// <summary>
        /// Изменяет сведения о клиенте
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int z = 1;
            q = true;
            bool flag = true;
            client.Clear();
            if (v)if (i != -1) InformationAboutChanges.ProcessingChanges(client, clients, i,z);
            v = true;
            manager.savingAList(clients, flag);
            dataGrid.CanUserAddRows = false;
        }
        /// <summary>
        /// Сохраняет нового клиента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            v = false;
            q = true;
            manager.savingAList(clients);
            dataGrid.CanUserAddRows = true;
        }
        /// <summary>
        /// Инфо. об изменениях
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Changes changes = new Changes();
            changes.Show();
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
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            q = true;
            clients.Clear();
            dataGrid.ItemsSource = null;
            dataGrid.Items.Refresh();
            clients = manager.addAList(clients);
            dataGrid.ItemsSource = clients;
        }
    }
}
