using OOP_CP.DataBased;
using OOP_CP.Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP_CP.AppendManager
{
    public partial class AppendRoute : Form
    {
        private string _selectedRouteType = "";
        private OOPCollection<Route> _routeCollection;

        private bool _isEdit = false;
        private int _routeEditNumber;

        public AppendRoute()
        {
            InitializeComponent();
        }

        public AppendRoute(OOPCollection<Route> routeCollection)
        {
            InitializeComponent();
            _routeCollection = routeCollection;
        }

        public AppendRoute(int routeEditNumber, OOPCollection<Route> routeCollection)
        {
            InitializeComponent();
            _isEdit = true;
            _routeCollection = routeCollection;
            _routeEditNumber = routeEditNumber;
        }

        private void AppendRoute_Load(object sender, EventArgs e)
        {
            typeRouteBox.SelectedIndexChanged += typeRouteBox_SelectedIndexChanged;

            if (_isEdit)
            {
                this.Text = "Редактировать маршрут";
                addRouteButton.Text = "Редактировать маршрут";
                isEditText.Visible = true;

            }
        }

        private void addRouteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_isEdit)
                {
                    

                    Route editRoute = _routeCollection.GetList().FirstOrDefault(route_ => route_.RouteNumber == _routeEditNumber);

                    if (numberText.Text != "")
                    {
                        int routeNumber = MyException.isInteger(numberText.Text, "поле номер маршрута");
                        if (_routeCollection.GetList().Any(route_ => route_.RouteNumber == routeNumber)) throw new MyException("Такой номер уже существует");
                        editRoute.RouteNumber = routeNumber;

                        OOPCollection<Bus> buses = JsonDataBuses.ReadJson();
                        foreach (Bus bus in buses)
                        {
                            if (bus.BusRoute == _routeEditNumber)
                            {
                                bus.BusRoute = routeNumber;
                            }
                        }
                        JsonDataBuses.UpdateJson(buses);

                    }

                    if (nameText.Text != "")
                    {
                        editRoute.RouteName = MyException.isString(nameText.Text, "поле название маршрута");
                    }

                    if (_selectedRouteType != "")
                    {
                        editRoute.RouteType = MyException.isString(_selectedRouteType, "поле тип маршрута");
                    }

                    if (kmText.Text != "")
                    {
                        editRoute.RouteKilometers = MyException.isInteger(kmText.Text, "поле километраж");
                    }

                    if (passanger_countText.Text != "")
                    {
                        editRoute.RouteManCount = MyException.isInteger(passanger_countText.Text, "поле количество пассажиров");
                    }

                    if (ticketText.Text != "")
                    {
                        editRoute.RouteTicketPrice = MyException.isInteger(ticketText.Text, "поле стоимость билета");
                    }

                    MessageBox.Show("Маршрут успешно отредактирован", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateFields();
                }
                else
                {
                    
                    int routeNumber = MyException.isInteger(numberText.Text, "поле номер маршрута");
                    if(routeNumber < 1) throw new MyException("Номер маршрута не может быть неположительным");
                    if (_routeCollection.GetList().Any(route_ => route_.RouteNumber == routeNumber)) throw new MyException("Такой номер уже существует");
                    string routeName = MyException.isString(nameText.Text, "поле название маршрута");
                    string routeType = MyException.isString(_selectedRouteType, "поле тип маршрута");
                    int routeKilometers = MyException.isInteger(kmText.Text, "поле километраж");
                    int routeManCount = MyException.isInteger(passanger_countText.Text, "поле количество пассажиров");
                    int routeTicketPrice = MyException.isInteger(ticketText.Text, "поле стоимость билета");

                    Route route = new Route(routeNumber, routeName, routeType, routeKilometers, routeManCount, routeTicketPrice);
                    _routeCollection.Add(route);

                    MessageBox.Show("Маршрут успешно создан", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            AppendRoute.ActiveForm.Hide();
            Close();
        }

        private void typeRouteBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedRouteType = typeRouteBox.SelectedItem.ToString();
        }

        private void UpdateFields()
        {
            numberText.Text = "";
            nameText.Text = "";
            typeRouteBox.Items.Clear();
            typeRouteBox.Items.Add("Городской");
            typeRouteBox.Items.Add("Междугородний");
            kmText.Text = "";
            passanger_countText.Text = "";
            ticketText.Text = "";
        }


    }
}
