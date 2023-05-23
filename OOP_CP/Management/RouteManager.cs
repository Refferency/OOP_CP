using OOP_CP.AppendManager;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace OOP_CP.Management
{
    public partial class RouteManager : Form
    {
        private string _selectedFiltreBox = "";

        //* кажется его нужно сделать статическим и добавить к класу jsondata, чтобы не обновлять каждый раз с помощью JsonRead
        private OOPCollection<Route> _routes = new OOPCollection<Route>();
        public RouteManager()
        {
            InitializeComponent();     
        }

        private void RouteManager_Load(object sender, EventArgs e)
        {
            selectFiltreBox.SelectedIndexChanged += selectFilteBox_SelectedIndexChanged;
            UpdateTable(false);
        }

        private void addRouteButton_Click(object sender, EventArgs e)
        {
            _routes = JsonData.ReadJson();
            AppendRoute ar = new AppendRoute(_routes);
            ar.ShowDialog();

            JsonData.UpdateJson(_routes);
            UpdateTable(false);
        }

        private void deleteRouteButton_Click(object sender, EventArgs e)
        {
            //* 0009 09 нужно удалять нули вначале
            try
            {
                if(selectRoute.Text == "") throw new MyException("Введите номер маршрута");

                int selectedRoute = MyException.isInteger(selectRoute.Text, "поле выбор номера");
                _routes = JsonData.ReadJson();
                if (!_routes.GetList().Any(route_ => route_.RouteNumber == selectedRoute))
                {
                    throw new MyException("Такого маршрута не существует");
                }
                else
                {
                    if (!JsonData.DeleteFromJson(selectedRoute)) throw new MyException("Ошибка удаления номера!");
                    selectRoute.Text = "";
                    OOPCollection<Bus> buses = JsonDataBuses.ReadJson();
                    foreach (Bus bus in buses)
                    {
                        if(bus.BusRoute == selectedRoute)
                        {
                            bus.BusRoute = 0;
                        }
                    }
                    JsonDataBuses.UpdateJson(buses);
                    MessageBox.Show("Маршрут успешно удален", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateTable(false);
                }
            }    
            catch (MyException ex)
            {
                selectRoute.Text = "";
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void findRouteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectRoute.Text == "") throw new MyException("Введите номер маршрута");

                int selectedRoute = MyException.isInteger(selectRoute.Text, "поле выбор номера");
                _routes = JsonData.ReadJson();

                if (!_routes.GetList().Any(route_ => route_.RouteNumber == selectedRoute))
                {
                    throw new MyException("Такого маршрута не существует");
                }
                else
                {
                    Route findedRoute = _routes.GetList().First(route_ => route_.RouteNumber == selectedRoute);
                    List<Route> newFindElement = new List<Route>() { findedRoute };
                    _routes.Remove(findedRoute);
                    _routes.SetList(newFindElement.Concat(_routes.GetList()).ToList());
                    JsonData.UpdateJson(_routes);

                    MessageBox.Show("Маршрут найден", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateTable(false);
                }
            }
            catch (MyException ex)
            {
                selectRoute.Text = "";
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editRouteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectRoute.Text == "") throw new MyException("Введите номер маршрута");

                int selectedRoute = MyException.isInteger(selectRoute.Text, "поле выбор номера");
                _routes = JsonData.ReadJson();

                if (!_routes.GetList().Any(route_ => route_.RouteNumber == selectedRoute))
                {
                    throw new MyException("Такого маршрута не существует");
                }
                else
                {
                    AppendRoute ar = new AppendRoute(selectedRoute, _routes);
                    ar.ShowDialog();
                    JsonData.UpdateJson(_routes);
                    UpdateTable(false);
                }
            }
            catch (MyException ex)
            {
                selectRoute.Text = "";
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addFilterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (filterValueText.Text == "") throw new MyException("Введите значение фильтра");
                _routes = JsonData.ReadJson();
                OOPCollection<Route> filterRoute = new OOPCollection<Route>();

                switch (_selectedFiltreBox)
                {
                    case "Номер":
                        int selectedNumberFilter = MyException.isInteger(filterValueText.Text, "поле номер для фильтра");
                        filterRoute.SetList(_routes.GetList().Where(route_ => route_.RouteNumber == selectedNumberFilter).ToList());
                        break;
                    case "Название":
                        string selectedNameFilter = MyException.isString(filterValueText.Text, "поле названия для фильтра").ToLower();
                        filterRoute.SetList(_routes.GetList().Where(route_ => route_.RouteName.ToLower().Contains(selectedNameFilter)).ToList());
                        break;
                    case "Цена":
                        int selectedTicketFilter = MyException.isInteger(filterValueText.Text, "поле цены для фильтра");
                        filterRoute.SetList(_routes.GetList().Where(route_ => route_.RouteTicketPrice == selectedTicketFilter).ToList());
                        break;
                    case "Тип":
                        string selectedTypeFilter = MyException.isString(filterValueText.Text, "поле тип маршрута для фильтра");
                        filterRoute.SetList(_routes.GetList().Where(route_ => route_.RouteType == selectedTypeFilter).ToList());
                        break;
                    case "Километраж":
                        int selectedKmFilter = MyException.isInteger(filterValueText.Text, "поле киллометраж для фильтра");
                        filterRoute.SetList(_routes.GetList().Where(route_ => route_.RouteKilometers == selectedKmFilter).ToList());
                        break;
                    case "Кол.во пассажиров":
                        int selectedPassangersFilter = MyException.isInteger(filterValueText.Text, "поле пассажиры для фильтра");
                        filterRoute.SetList(_routes.GetList().Where(route_ => route_.RouteManCount == selectedPassangersFilter).ToList());
                        break;
                    default:
                        throw new MyException("Тип фильтра не выбран");
                }
                if(filterRoute.GetList().Count < 1)
                {
                    MessageBox.Show($"Записей по данному фильтру: {filterRoute.GetList().Count}", "Отсуствуют", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show($"Записей по данному фильтру: {filterRoute.GetList().Count}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    JsonData.UpdateJson(filterRoute, true);
                    UpdateTable(true);
                }
                    

               
            }
            catch (MyException ex)
            {
                selectRoute.Text = "";
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sortRoutesButton_Click(object sender, EventArgs e)
        {
            //* messagebox - сортировка выбирается по типу фильтра
            try
            {
                _routes = JsonData.ReadJson();
                OOPCollection<Route> filterRoute = new OOPCollection<Route>();
                string columnType = _selectedFiltreBox.ToLower();
                switch (_selectedFiltreBox)
                {
                    case "Номер":
                        _routes.SetList(_routes.GetList().OrderBy(routes_ => routes_.RouteNumber).ToList());
                        break;
                    case "Название":
                        _routes.SetList(_routes.GetList().OrderBy(routes_ => routes_.RouteName).ToList());
                        break;
                    case "Цена":
                        _routes.SetList(_routes.GetList().OrderBy(routes_ => routes_.RouteTicketPrice).ToList());
                        break;
                    case "Тип":
                        _routes.SetList(_routes.GetList().OrderBy(routes_ => routes_.RouteType).ToList());
                        break;
                    case "Километраж":
                        _routes.SetList(_routes.GetList().OrderBy(routes_ => routes_.RouteKilometers).ToList());
                        break;
                    case "Кол.во пассажиров":
                        _routes.SetList(_routes.GetList().OrderBy(routes_ => routes_.RouteManCount).ToList());
                        break;
                    default:
                        throw new MyException("Сортировка записей по столбцам выбирается как тип фильтра");
                }
                MessageBox.Show($"Записи по столбцу {columnType} отсортированы", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                JsonData.UpdateJson(_routes);
                UpdateTable(false);
            }
            catch (MyException ex)
            {
                selectRoute.Text = "";
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sortRoutesDownButton_Click(object sender, EventArgs e)
        {
            //* messagebox - сортировка выбирается по типу фильтра
            try
            {
                _routes = JsonData.ReadJson();
                OOPCollection<Route> filterRoute = new OOPCollection<Route>();
                string columnType = _selectedFiltreBox.ToLower();
                switch (_selectedFiltreBox)
                {
                    case "Номер":
                        _routes.SetList(_routes.GetList().OrderByDescending(routes_ => routes_.RouteNumber).ToList());
                        break;
                    case "Название":
                        _routes.SetList(_routes.GetList().OrderByDescending(routes_ => routes_.RouteName).ToList());
                        break;
                    case "Цена":
                        _routes.SetList(_routes.GetList().OrderByDescending(routes_ => routes_.RouteTicketPrice).ToList());
                        break;
                    case "Тип":
                        _routes.SetList(_routes.GetList().OrderByDescending(routes_ => routes_.RouteType).ToList());
                        break;
                    case "Километраж":
                        _routes.SetList(_routes.GetList().OrderByDescending(routes_ => routes_.RouteKilometers).ToList());
                        break;
                    case "Кол.во пассажиров":
                        _routes.SetList(_routes.GetList().OrderByDescending(routes_ => routes_.RouteManCount).ToList());
                        break;
                    default:
                        throw new MyException("Сортировка записей по столбцам выбирается как тип фильтра");
                }
                MessageBox.Show($"Записи по столбцу {columnType} отсортированы", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                JsonData.UpdateJson(_routes);
                UpdateTable(false);
            }
            catch (MyException ex)
            {
                selectRoute.Text = "";
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetFilterButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Фильтр успешно сброшен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _routes = JsonData.ReadJson();
            UpdateTable(false);
        }
        private void UpdateTable(bool isReadFilter)
        {
           
            _routes = !isReadFilter ? JsonData.ReadJson() : JsonData.ReadJsonFilter();
            routeCount.Text = _routes.GetList().Count().ToString();

            routesGridView.Rows.Clear();
            
            foreach (Route route in _routes)
            {
                string routeBusesTable = "Отсутствует";
                if (route.RouteBuses != null && route.RouteBuses.Count != 0)
                {
                    routeBusesTable = string.Join(", ", route.RouteBuses);
                }

                routesGridView.Rows.Add(
                    route.RouteNumber,
                    route.RouteName,
                    route.RouteType,
                    route.RouteKilometers,
                    routeBusesTable,
                    route.RouteManCount,
                    route.RouteTicketPrice
                );
            }
        }

        private void toMainMenuButton_Click(object sender, EventArgs e)
        {
            RouteManager.ActiveForm.Hide();
            MainMenu mm = new MainMenu();
            mm.ShowDialog();
            Close();
        }

        private void selectFilteBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedFiltreBox = selectFiltreBox.SelectedItem.ToString();
        }

        private void deleteAllRouteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Удалить ли все маршруты?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    _routes = JsonData.ReadJson();
                    if (_routes.GetList().Count == 0)
                    {
                        throw new MyException("Невозможно удалить маршруты если их нет!");
                    }

                    OOPCollection<Bus> buses = JsonDataBuses.ReadJson();
                    foreach (Bus bus in buses)
                    {
                        bus.BusRoute = 0;

                    }
                    JsonDataBuses.UpdateJson(buses);
                    _routes.Clear();
                    JsonData.UpdateJson(_routes);
                    MessageBox.Show("Все маршруты успешно удалены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateTable(false);
                }
            }
            catch (MyException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void financialTurnoverButton_Click(object sender, EventArgs e)
        {
            FinancialTurnover ft = new FinancialTurnover();
            ft.ShowDialog();
        }
    }
}
