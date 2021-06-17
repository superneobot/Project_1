using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace datas
{
    [Serializable]
    public class Account
    {
        [XmlAttribute("name")]
        public string Name;
        [XmlElement("Login")]
        public string Login;
        [XmlElement("Password")]
        public string Password;
    }
    [Serializable]
    public class Datas
    {
        private BindingList<Account> DataList = new BindingList<Account>();
        //количество запросов в нашем списке
        public int Count()
        {
            return DataList.Count;
        }
        //цепляем один конкретный запрос, если он нам нужен
        public Account ReturnDatas(int i)
        {
            return DataList.ElementAt(i);
        }
        //добавляем запрос в список
        public void AddData(Account data)
        {
            DataList.Add(data);
        }
        //удаляем запрос из списка
        public void RemoveData(Account data)
        {
            DataList.Remove(data);
        }
        //сохраняем с помощью сериализации
        public void SaveListOfDatas(string path)
        {
            FileStream filestream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            XmlSerializer xmls = new XmlSerializer(typeof(BindingList<Account>));
            xmls.Serialize(filestream, DataList);
            filestream.Close();
        }

        //загружаем с помощью сериализации
        public void LoadListOfDatas(string path)
        {
            FileStream filestream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            XmlSerializer xmls = new XmlSerializer(typeof(BindingList<Account>));
            DataList = (BindingList<Account>)xmls.Deserialize(filestream);
            filestream.Close();
        }
        //ищем конкретный запрос среди всех
        public Account FindDAtaInList(string name)
        {
            for (int i = 0; i < DataList.Count; i++)
            {
                if (DataList.ElementAt(i).Name == name)
                {
                    return DataList.ElementAt(i);
                }

                if (DataList.ElementAt(i).Login == name)
                {
                    return DataList.ElementAt(i);
                }
                if (DataList.ElementAt(i).Password == name)
                {
                    return DataList.ElementAt(i);
                }
            }
            return null;
        }
    }









}