using System;
using System.Collections.Generic;
using System.Text;
namespace Program2
{
    interface IDataProvider
    {
        string GetData();
    }
    interface IDataProcessor
    {
        void ProcessorData(IDataProvider dataProvider);
    }

    class ConsoleDataProcessor : IDataProcessor
    {
        public void ProcessorData(IDataProvider dataProvider)
        {
            Console.WriteLine(dataProvider.GetData());
        }
    }
    class DbDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из ДБ";
        }
    }
    class FileDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из Файла";
        }
    }
    class APIDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из АПИ";
        }
    }

    interface IRussia
    {
        string GoTo();
    }
    interface IBelarus
    {
        void Ychenia(IRussia Russia);
    }

    class Krim : IBelarus
    {
        public void Ychenia(IRussia Russia)
        {
            Console.WriteLine(Russia.GoTo());
        }
    }
    class Chaes : IRussia
    {
        public string GoTo()
        {
            return "ЧАЭС в учениях";
        }
    }
    class Kiev : IRussia
    {
        public string GoTo()
        {
            return "Киев в учениях";
        }
    }
    class Belarus : IRussia
    {
        public string GoTo()
        {
            return "Беларусь  в учениях";
        }
    }
}
