using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_task_10
{
    class Manager : Consultant
    {
        /// <summary>
        /// Сохраняет список
        /// </summary>
        /// <param name="clients"></param>
        /// <param name="i"></param>
        /// 
        public void savingAList(List<Client> clients)
        {
            int q = 0;
            if (File.Exists(path)) q = File.ReadAllLines(path).Length;
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                for (int i = q; i < clients.Count; i++)
                {
                    sw.WriteLine($"{clients[i].lastName}#" +
                    $"{clients[i].name}#" +
                    $"{clients[i].middleName}#" +
                    $"{clients[i].phoneNumber}#" +
                    $"{clients[i].passport}");
                }
            }
        }
        /// <summary>
        /// Изменяет данные
        /// </summary>
        /// <param name="clients"></param>
        /// <param name="flag"></param>
        public void savingAList(List<Client> clients, bool flag)
        {
            if (flag)
            {
                File.Delete(path);
                int q = 0;
                if (File.Exists(path)) q = File.ReadAllLines(path).Length;
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    for (int i = q; i < clients.Count; i++)
                    {
                        sw.WriteLine($"{clients[i].lastName}#" +
                        $"{clients[i].name}#" +
                        $"{clients[i].middleName}#" +
                        $"{clients[i].phoneNumber}#" +
                        $"{clients[i].passport}");
                    }
                }
            }
        }
    }
}
