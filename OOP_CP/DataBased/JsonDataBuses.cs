using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP.DataBased
{
    internal class JsonDataBuses
    {
        static string DBFilePath = @"C:\Users\medve\source\repos\OOP_CP\OOP_CP\Data_Base\BusBase.json";
        static string DBFilePathFilter = @"C:\Users\medve\source\repos\OOP_CP\OOP_CP\Data_Base\BusBaseFilter.json";

        //OOPCollection<Bus> _buss;

        public static void UpdateJson(OOPCollection<Bus> buss)
        {
            string serializedBuss = JsonConvert.SerializeObject(buss);
            File.WriteAllText(DBFilePath, serializedBuss);
        }

        public static void UpdateJson(OOPCollection<Bus> buss, bool usingFilter)
        {
            string serializedFilterBuss = JsonConvert.SerializeObject(buss);
            File.WriteAllText(DBFilePathFilter, serializedFilterBuss);
        }


        public static bool DeleteFromJson(string busNumber)
        {
            OOPCollection<Bus> allCurrentBuss = ReadJson();

            Bus busForDeletion = allCurrentBuss.GetList().FirstOrDefault(bus => bus.BusNumber == busNumber);

            bool result = false;

            if (busForDeletion != null)
            {
                allCurrentBuss.GetList().Remove(busForDeletion);
                UpdateJson(allCurrentBuss);
                result = true;
            }

            return result;
        }

        public static OOPCollection<Bus> ReadJson()
        {
            if (File.Exists(DBFilePath) == false)
            {
                var file = File.Create(DBFilePath);
                file.Close();
            }

            string json = File.ReadAllText(DBFilePath);

            //читаем информацию из jsona
            List<Bus> bussList = JsonConvert.DeserializeObject<List<Bus>>(json);

            if (bussList == null) //если json пустой, передаем пустую коллекцию
                return new OOPCollection<Bus>();

            OOPCollection<Bus> currentBuss = new OOPCollection<Bus>();
            currentBuss.SetList(bussList);
            return currentBuss;
        }

        public static OOPCollection<Bus> ReadJsonFilter()
        {
            if (File.Exists(DBFilePathFilter) == false)
            {
                var file = File.Create(DBFilePathFilter);
                file.Close();
            }

            string json = File.ReadAllText(DBFilePathFilter);

            List<Bus> bussList = JsonConvert.DeserializeObject<List<Bus>>(json);

            if (bussList == null)
                return new OOPCollection<Bus>();

            OOPCollection<Bus> currentBuss = new OOPCollection<Bus>();
            currentBuss.SetList(bussList);
            return currentBuss;
        }
    }
}
