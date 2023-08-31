using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_task_10
{
    class Client
    {
        /// <summary>
        /// Путь к файлу
        /// </summary>
        public string path = @"Клиенты.txt";
        /// <summary>
        /// Фаимлия
        /// </summary>
        public string lastName { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string middleName { get; set; }
        /// <summary>
        /// Номер телефона
        /// </summary>
        public string phoneNumber { get; set; }
        /// <summary>
        /// Серия и номер паспотрта
        /// </summary>
        public string passport { get; set; }
    }
}
