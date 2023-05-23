using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP
{ 
    public class Route
    {
        /// <summary>
        /// Номер маршрута
        /// </summary>
        private int _routeNumber;
        /// <summary>
        /// Название маршрута
        /// </summary>
        /// 
        private string _routeName;
        /// <summary>
        ///  Тип маршрута(городской, междугородний);
        /// </summary>
        private string _routeType;
        /// <summary>
        /// Километраж маршрута
        /// </summary>
        private int _routeKilometers;
        /// <summary>
        /// Связанный транспорт
        /// </summary>
        private List<string> _routeBuses;
        /// <summary>
        /// Среднее количество пассажиров
        /// </summary>
        private int _routeManCount;
        /// <summary>
        /// Цена билета за проезд;
        /// </summary>
        private int _routeTicketPrice;

        public Route() { }
   
        public Route(int routeNumber, string routeName, string routeType, int routeKilometers, int routeManCount, int routeTicketPrice)
        {
            _routeBuses = new List<string>();
            _routeNumber = routeNumber;
            _routeName = routeName;
            _routeType = routeType;
            _routeKilometers = routeKilometers;
            _routeManCount = routeManCount;
            _routeTicketPrice = routeTicketPrice;
        }

        public void addBus(string number)
        {
            if(_routeBuses == null)
            {
                _routeBuses = new List<string>();
            }
            _routeBuses.Add(number);
        }

        public void removeBus(string number)
        {
            _routeBuses.Remove(number);
        }

        public void removeAllBuses()
        {
            _routeBuses.Clear();
            _routeBuses = new List<string>();
        }

        public int RouteNumber { get => _routeNumber; set => _routeNumber = value; }
        public string RouteName { get => _routeName; set => _routeName = value; }
        public string RouteType { get => _routeType; set => _routeType = value; }
        public int RouteKilometers { get => _routeKilometers; set => _routeKilometers = value; }
        public int RouteManCount { get => _routeManCount; set => _routeManCount = value; }
        public int RouteTicketPrice { get => _routeTicketPrice; set => _routeTicketPrice = value; }
        public List<string> RouteBuses { get => _routeBuses; set => _routeBuses = value; }
    }
}
