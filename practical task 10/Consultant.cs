using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_task_10
{
    class Consultant : Client
    {
        /// <summary>
        /// Зашружает список
        /// </summary>
        /// <returns></returns>
        public List<Client> addAList(List<Client> clients)
        {
            if (!File.Exists(path) || File.ReadAllLines(path).Length == 0)
                return clients;
            using (StreamReader sr = new StreamReader(path))
            {
                int i = 0;
                string line;
                Consultant[] consultants = new Consultant[File.ReadAllLines(path).Length];
                while (true)
                {
                    line = sr.ReadLine();
                    consultants[i] = new Consultant();
                    string[] data = line.Split('#');
                    consultants[i].lastName = data[0];
                    consultants[i].name = data[1];
                    consultants[i].middleName = data[2];
                    consultants[i].phoneNumber = data[3];
                    consultants[i].passport = data[4];
                    clients.Add(consultants[i]);
                    i++;
                    if (i == File.ReadAllLines(path).Length)
                    {
                        sr.Close();
                        return clients;
                    }
                }
            }
        }
    }
}
