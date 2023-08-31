using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_task_10
{
    interface Information
    {
        /// <summary>
        /// Время изменения
        /// </summary>
        DateTime dateTime { get; set; }
        /// <summary>
        /// Должность пользователя
        /// </summary>
        string user { get; set; }
        /// <summary>
        /// Данные до изменения
        /// </summary>
        string tеheChangeDataWas{ get; set; }
        /// <summary>
        /// Данные после изменения
        /// </summary>
        string theChangedDataBecame { get; set; }
        /// <summary>
        /// Сохраняет изменения
        /// </summary>
        void SaveChanges(InformationAboutChanges[] changes);
        /// <summary>
        /// Загружает измининия
        /// </summary>
        List<InformationAboutChanges> AddChanges(List<InformationAboutChanges> changes);
        /// <summary>
        /// Cчитывает измененного клиента
        /// </summary>
        /// <param name="clients"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        string ReadsTheModifiedClient(List<Client> clients, int index);
    }
}
