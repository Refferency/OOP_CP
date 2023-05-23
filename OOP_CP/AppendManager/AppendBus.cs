using OOP_CP.DataBased;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_CP.AppendManager
{
    public partial class AppendBus : Form
    {
        private string _selectedBusType = "";
        private OOPCollection<Bus> _busCollection;

        private bool _isEdit = false;
        private string _busEditNumber;

        public AppendBus()
        {
            InitializeComponent();
        }

        public AppendBus(OOPCollection<Bus> busCollection)
        {
            InitializeComponent();
            _busCollection = busCollection;
        }

        public AppendBus(string busEditNumber, OOPCollection<Bus> busCollection)
        {
            InitializeComponent();
            _isEdit = true;
            _busCollection = busCollection;
            _busEditNumber = busEditNumber;
        }

        private void AppendBus_Load(object sender, EventArgs e)
        {
            if (_isEdit)
            {
                this.Text = "Редактировать автобус";
                addBusButton.Text = "Редактировать автобус";
                isEditText.Visible = true;
            }
        }

        private void addBusButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_isEdit)
                {
                    Bus editBus = _busCollection.GetList().FirstOrDefault(bus_ => bus_.BusNumber == _busEditNumber);

                    if (numberText.Text != "")
                    {
                        int route = _busCollection.GetList().First(bus_ => bus_.BusNumber == _busEditNumber).BusRoute;

                        if (route == 0) //нет связанного маршрута
                        {
                            string busNumber = MyException.isString(numberText.Text, "поле транспортный номер");
                            if (_busCollection.GetList().Any(bus_ => bus_.BusNumber == busNumber)) throw new MyException("Такой номер уже существует");
                            editBus.BusNumber = busNumber;
                        }
                        else //есть такой маршрут
                        {
                            string busNumber = MyException.isString(numberText.Text, "поле транспортный номер");
                            if (_busCollection.GetList().Any(bus_ => bus_.BusNumber == busNumber)) throw new MyException("Такой номер уже существует");
                            editBus.BusNumber = busNumber;

                            OOPCollection<Route> routes = JsonData.ReadJson();
                            routes.GetList().First(routes_ => routes_.RouteNumber == route).removeBus(_busEditNumber);
                            routes.GetList().First(routes_ => routes_.RouteNumber == route).addBus(busNumber);
                            JsonData.UpdateJson(routes);
                        }
                    }

                    if (nameText.Text != "")
                    {
                        editBus.BusModel = MyException.isString(nameText.Text, "поле производитель и модель автобуса");
                    }

                    if (driverName.Text != "")
                    {
                        editBus.BusDriver = MyException.isString(_selectedBusType, "поле фио водителя");
                    }

                    if (routeText.Text != "")
                    {
                        //Нашли номер связанного роута
                        int route = _busCollection.GetList().First(bus_ => bus_.BusNumber == _busEditNumber).BusRoute;

                        if (route == 0) //нет связанного маршрута, но хоиим его добавить
                        {
                            int localRoute = MyException.isInteger(routeText.Text, "поле связанный маршрут");
                            OOPCollection<Route> routes = JsonData.ReadJson();
                            if(!routes.GetList().Any(routes_ => routes_.RouteNumber == localRoute)) throw new MyException("Такого маршрута не существует");
                            editBus.BusRoute = localRoute;
                            routes.GetList().First(routes_ => routes_.RouteNumber == localRoute).addBus(_busEditNumber);
                            JsonData.UpdateJson(routes);
                        }
                        else //есть такой маршрут
                        {
                            int localRoute = MyException.isInteger(routeText.Text, "поле связанный маршрут");
                            OOPCollection<Route> routes = JsonData.ReadJson();
                            editBus.BusRoute = localRoute;
                            routes.GetList().First(routes_ => routes_.RouteNumber == route).removeBus(_busEditNumber);
                            routes.GetList().First(routes_ => routes_.RouteNumber == localRoute).addBus(_busEditNumber);
                            JsonData.UpdateJson(routes);
                        }
                    }

                    if (remontText.Text != "")
                    {
                        editBus.BusService = MyException.isInteger(remontText.Text, "поле расходы на обслуживание");
                    }

                    if (fuelText.Text != "")
                    {
                        editBus.BusFuel = MyException.isInteger(fuelText.Text, "поле расход топлива");
                    }

                    MessageBox.Show("Информация об автобусе успешно отредактирована", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateFields();
                }
                else
                {
                    bool isRoute = true;

                    string busNumber = MyException.isString(numberText.Text, "поле транспортный номер");
                    //* регулярка на автомобильный номер?? /^[АВЕКМНОРСТУХ]\d{3}(?<!000)[АВЕКМНОРСТУХ]{2}\d{2,3}$/ui
                    if (_busCollection.GetList().Any(bus_ => bus_.BusNumber == busNumber)) throw new MyException("Такой номер уже существует");
                    string busModel = MyException.isString(nameText.Text, "поле производитель и модель автобуса");
                    string busDriver = MyException.isString(driverName.Text, "поле фио водителя");
                    int busRoute = 0;

                    if(routeText.Text != "")
                    {
                        busRoute = MyException.isInteger(routeText.Text, "поле связанный маршрут");
                        OOPCollection<Route> routes = JsonData.ReadJson();
                        if (!routes.GetList().Any(route_ => route_.RouteNumber == busRoute))
                        {
                            isRoute = false;
                            MessageBox.Show("Такого маршрута нету в базе, будет использоваться значение по умолчанию", "Отказ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            busRoute = 0;
                        }
                        else
                        {
                            routes.GetList().First(route_ => route_.RouteNumber == busRoute).addBus(busNumber);
                            JsonData.UpdateJson(routes);
                        }
                    }
                    int busFuel = MyException.isInteger(fuelText.Text, "поле расход топлива");
                    int busService = MyException.isInteger(remontText.Text, "поле расходы на обслуживание");

                    Bus bus;
                    if (isRoute)
                    {
                        bus = new Bus(busNumber, busModel, busDriver, busRoute, busFuel, busService);

                    }
                    else
                    {
                        bus = new Bus(busNumber, busModel, busDriver, busRoute, busFuel, busService);
                    }
                    _busCollection.Add(bus);
                    MessageBox.Show("Автобус успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateFields();
                }
            }
            catch (MyException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AppendBus.ActiveForm.Hide();
            Close();
        }

        private void UpdateFields()
        {
            numberText.Text = "";
            nameText.Text = "";
            driverName.Text = "";
            routeText.Text = "";
            fuelText.Text = "";
            remontText.Text = "";
        }
    }
}
