using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP.DataBased
{
    public class JsonData
    {
        static string DBFilePath = @"C:\Users\medve\source\repos\OOP_CP\OOP_CP\Data_Base\RouteBase.json";
        static string DBFilePathFilter = @"C:\Users\medve\source\repos\OOP_CP\OOP_CP\Data_Base\RouteBaseFilter.json";
        public static void UpdateJson(OOPCollection<Route> routes)
        {
            string serializedRoutes = JsonConvert.SerializeObject(routes);
            File.WriteAllText(DBFilePath, serializedRoutes);
        }

        public static void UpdateJson(OOPCollection<Route> routes, bool usingFilter)
        {
            string serializedFilterRoutes = JsonConvert.SerializeObject(routes);
            File.WriteAllText(DBFilePathFilter, serializedFilterRoutes);
        }


        public static bool DeleteFromJson(int routeNumber)
        {
            OOPCollection<Route> allCurrentRoutes = ReadJson();

            Route routeForDeletion = allCurrentRoutes.GetList().FirstOrDefault(route => route.RouteNumber == routeNumber);

            bool result = false;

            if (routeForDeletion != null)
            {
                allCurrentRoutes.GetList().Remove(routeForDeletion);
                UpdateJson(allCurrentRoutes);
                result = true;
            }

            return result;
        }

        public static OOPCollection<Route> ReadJson()
        {
            if (File.Exists(DBFilePath) == false)
            {
                var file = File.Create(DBFilePath);
                file.Close();
            }

            string json = File.ReadAllText(DBFilePath);
            List<Route> routesList = JsonConvert.DeserializeObject<List<Route>>(json);
            if(routesList == null)
                return new OOPCollection<Route>();

            OOPCollection<Route> currentRoutes = new OOPCollection<Route>();
            currentRoutes.SetList(routesList);
            return currentRoutes; 
        }

        public static OOPCollection<Route> ReadJsonFilter()
        {
            if (File.Exists(DBFilePathFilter) == false)
            {
                var file = File.Create(DBFilePathFilter);
                file.Close();
            }

            string json = File.ReadAllText(DBFilePathFilter);

            List<Route> routesList = JsonConvert.DeserializeObject<List<Route>>(json);

            if (routesList == null) 
                return new OOPCollection<Route>();

            OOPCollection<Route> currentRoutes = new OOPCollection<Route>();
            currentRoutes.SetList(routesList);
            return currentRoutes;
        }
    }
}
