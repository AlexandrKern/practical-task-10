using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace practical_task_10
{
    /// <summary>
    /// Информация об изменениях
    /// </summary>
    class InformationAboutChanges : Manager, Information
    {
        /// <summary>
        /// Путь к файлу содержащему инфо. об изменениях
        /// </summary>
        public string path1 = @"Измененные данные.txt";
        public string user { get; set; }
        public DateTime dateTime { get; set; }
        public string tеheChangeDataWas { get; set; }
        public string theChangedDataBecame { get; set; }
        public List<InformationAboutChanges> AddChanges(List<InformationAboutChanges> changes)
        {
            if (!File.Exists(path1) || File.ReadAllLines(path1).Length == 0)
            {
                return changes;
            }
            using (StreamReader sr = new StreamReader(path1))
            {
                int i = 0;
                string line;
                InformationAboutChanges[] changes1 = new InformationAboutChanges[File.ReadAllLines(path1).Length];
                while (true)
                {
                    line = sr.ReadLine();
                    changes1[i] = new InformationAboutChanges();
                    string[] data = line.Split('#');
                    changes1[i].dateTime = DateTime.Parse(data[0]);
                    changes1[i].tеheChangeDataWas = data[1];
                    changes1[i].theChangedDataBecame = data[2];
                    changes1[i].user = data[3];
                    changes.Add(changes1[i]);
                    i++;
                    if (i == File.ReadAllLines(path1).Length)
                    {
                        sr.Close();
                        return changes;
                    }
                }
            }
        }
        public void SaveChanges(InformationAboutChanges [] changes)
        {
            
            using (StreamWriter sw = new StreamWriter(path1, true))
            {
                    sw.WriteLine($"{changes[0].dateTime}#" +
                    $"{changes[0].tеheChangeDataWas}#" +
                    $"{changes[0].theChangedDataBecame}#" +
                    $"{changes[0].user}");
            }
        }
        public string ReadsTheModifiedClient(List<Client> clients, int index)
        {
            if (clients.Count == index) index--;
            string changedData1 = $"{clients[index].lastName} " +
               $"{clients[index].name} " +
               $"{clients[index].middleName} " +
               $"{clients[index].phoneNumber} " +
               $"{clients[index].passport}";
            return changedData1;
        }
        /// <summary>
        /// Обработка изменений
        /// </summary>
        /// <param name="client"></param>
        /// <param name="clients"></param>
        /// <param name="index"></param>
        public void ProcessingChanges(List<Client>client,List<Client> clients,int index,int i)
        {
            InformationAboutChanges[] arrayChanges;
            InformationAboutChanges InformationAbout = new InformationAboutChanges();
            arrayChanges = new InformationAboutChanges[1];
            arrayChanges[0] = new InformationAboutChanges();
            client = InformationAbout.addAList(client);
            arrayChanges[0].tеheChangeDataWas = $"{ReadsTheModifiedClient(client, index)}";
            arrayChanges[0].theChangedDataBecame = $"{ReadsTheModifiedClient(clients, index)}";
            arrayChanges[0].dateTime = DateTime.Now;
            if (i == 0)
                arrayChanges[0].user = "Консультант";
            if (i == 1)
                arrayChanges[0].user = "Менеджер";
            SaveChanges(arrayChanges);
        }
    }
}
