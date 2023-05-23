using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CP
{
    public class Bus
    {
        /// <summary>
        /// Тип транспортного средства
        /// </summary>
        private string _busNumber;
        /// <summary>
        /// Производитель
        /// </summary>
        private string _busModel;
        /// <summary>
        /// Водитель
        /// </summary>
        private string _busDriver;
        /// <summary>
        /// Связанный маршрут
        /// </summary>
        private int _busRoute;
        /// <summary>
        /// Расход топлива
        /// </summary>
        private int _busFuel;
        /// <summary>
        /// Расход на техобслуживание
        /// </summary>
        private int _busService;

        public Bus() { }

        public Bus(string busNumber, string busModel, string busDriver, int busRoute, int busFuel, int busService)
        {
            _busNumber = busNumber;
            _busModel = busModel;
            _busDriver = busDriver;
            _busRoute = busRoute;
            _busFuel = busFuel;
            _busService = busService;
        }

        public string BusNumber { get => _busNumber; set => _busNumber = value; }
        public string BusModel { get => _busModel; set => _busModel = value; }
        public string BusDriver { get => _busDriver; set => _busDriver = value; }
        public int BusRoute { get => _busRoute; set => _busRoute = value; }
        public int BusFuel { get => _busFuel; set => _busFuel = value; }
        public int BusService { get => _busService; set => _busService = value; }
    }
}
