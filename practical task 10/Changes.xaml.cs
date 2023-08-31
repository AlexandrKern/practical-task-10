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
using System.Windows.Shapes;

namespace practical_task_10
{
    /// <summary>
    /// Логика взаимодействия для Changes.xaml
    /// </summary>
    public partial class Changes : Window
    {
        List<InformationAboutChanges> changes;
        InformationAboutChanges informationAboutChanges;
        public Changes()
        {
            InitializeComponent();
            changes = new List<InformationAboutChanges>();
            informationAboutChanges = new InformationAboutChanges();
            dataGridChanges.Columns[0].IsReadOnly = true;
            dataGridChanges.Columns[1].IsReadOnly = true;
            dataGridChanges.Columns[2].IsReadOnly = true;
            dataGridChanges.Columns[3].IsReadOnly = true;
            dataGridChanges.CanUserAddRows = false;
            changes = informationAboutChanges.AddChanges(changes);
            dataGridChanges.ItemsSource = changes;
        }
    }
}
