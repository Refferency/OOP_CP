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

namespace OOP_CP.Management
{
    public partial class BusManager : Form
    {
        private string _selectedFiltreBox = "";

        public OOPCollection<Bus> _buses = new OOPCollection<Bus>();
        public BusManager()
        {
            InitializeComponent();
        }

        private void BusManager_Load(object sender, EventArgs e)
        {
            selectFiltreBox.SelectedIndexChanged += selectFilteBox_SelectedIndexChanged;
            UpdateTable(false);
        }

        private void addBusButton_Click(object sender, EventArgs e)
        {
            _buses = JsonDataBuses.ReadJson();
            AppendBus ar = new AppendBus(_buses);
            ar.ShowDialog();

            JsonDataBuses.UpdateJson(_buses);
            UpdateTable(false);
        }

        private void deleteBusButton_Click(object sender, EventArgs e)
        {
            //* try catch можно вынести в отдельную функцию
            //* 0009 09 нужно удалять нули вначале
            try
            {
                if (selectBus.Text == "") throw new MyException("Введите номер автобуса");

                string selectedBus = MyException.isString(selectBus.Text, "поле выбор номера");
                _buses = JsonDataBuses.ReadJson();
                if (!_buses.GetList().Any(bus_ => bus_.BusNumber == selectedBus))
                {
                    throw new MyException("Такого автобуса не существует");
                }
                else
                {
                    int route = _buses.GetList().First(bus_ => bus_.BusNumber == selectedBus).BusRoute;
                    selectBus.Text = "";
                    if (route == 0) 
                    {
                        if (!JsonDataBuses.DeleteFromJson(selectedBus)) throw new MyException("Ошибка удаления номера!");
                    }
                    else 
                    {
                        OOPCollection<Route> routes = JsonData.ReadJson();
                        routes.GetList().First(routes_ => routes_.RouteNumber == route).removeBus(selectedBus);
                        if (!JsonDataBuses.DeleteFromJson(selectedBus)) throw new MyException("Ошибка удаления номера!");
                        JsonData.UpdateJson(routes);
                    }
                    MessageBox.Show("Автобус успешно удален", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateTable(false);
                }
            }
            catch (MyException ex)
            {
                selectBus.Text = "";
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void findBusButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectBus.Text == "") throw new MyException("Введите номер автобуса");

                string selectedBus = MyException.isString(selectBus.Text, "поле выбор номера");
                _buses = JsonDataBuses.ReadJson();

                if (!_buses.GetList().Any(bus_ => bus_.BusNumber == selectedBus))
                {
                    throw new MyException("Такого автобуса не существует");
                }
                else
                {
                    Bus findedBus = _buses.GetList().First(bus_ => bus_.BusNumber == selectedBus);
                    List<Bus> newFindElement = new List<Bus>() { findedBus };
                    _buses.Remove(findedBus);
                    _buses.SetList(newFindElement.Concat(_buses.GetList()).ToList());
                    JsonDataBuses.UpdateJson(_buses);

                    MessageBox.Show("Автобус найден", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateTable(false);
                }
            }
            catch (MyException ex)
            {
                selectBus.Text = "";
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editBusButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectBus.Text == "") throw new MyException("Введите номер автобуса");

                string selectedBus = MyException.isString(selectBus.Text, "поле выбор номера");
                _buses = JsonDataBuses.ReadJson();

                if (!_buses.GetList().Any(bus_ => bus_.BusNumber == selectedBus))
                {
                    throw new MyException("Такого автобуса не существует");
                }
                else
                {
                    AppendBus ar = new AppendBus(selectedBus, _buses);
                    ar.ShowDialog();
                    JsonDataBuses.UpdateJson(_buses);
                    UpdateTable(false);
                }
            }
            catch (MyException ex)
            {
                selectBus.Text = "";
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addFilterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (filterValueText.Text == "") throw new MyException("Введите значение фильтра");
                _buses = JsonDataBuses.ReadJson();
                OOPCollection<Bus> filterBus = new OOPCollection<Bus>();

                switch (_selectedFiltreBox)
                {
                    case "Номер":
                        string selectedNumberFilter = MyException.isString(filterValueText.Text, "поле номер для фильтра");
                        filterBus.SetList(_buses.GetList().Where(bus_ => bus_.BusNumber == selectedNumberFilter).ToList());
                        break;
                    case "Модель и производитель":
                        string selectedNameFilter = MyException.isString(filterValueText.Text, "поле модель и производитель для фильтра").ToLower();
                        filterBus.SetList(_buses.GetList().Where(bus_ => bus_.BusModel.ToLower().Contains(selectedNameFilter)).ToList());
                        break;
                    case "ФИО Водителя":
                        string selectedDriverFilter = MyException.isString(filterValueText.Text, "поле фио водителя для фильтра");
                        filterBus.SetList(_buses.GetList().Where(bus_ => bus_.BusDriver == selectedDriverFilter).ToList());
                        break;
                    case "Маршрут":
                        int selectedRouteFilter = MyException.isInteger(filterValueText.Text, "поле маршрут для фильтра");
                        filterBus.SetList(_buses.GetList().Where(bus_ => bus_.BusRoute == selectedRouteFilter).ToList());
                        break;
                    case "Расход топлива":
                        int selectedFuelFilter = MyException.isInteger(filterValueText.Text, "поле расход топлива для фильтра");
                        filterBus.SetList(_buses.GetList().Where(bus_ => bus_.BusFuel == selectedFuelFilter).ToList());
                        break;
                    case "Расход на ослуживание":
                        int selectedServiceFilter = MyException.isInteger(filterValueText.Text, "поле расходы на обслуживание для фильтра");
                        filterBus.SetList(_buses.GetList().Where(bus_ => bus_.BusService == selectedServiceFilter).ToList());
                        break;
                    default:
                        throw new MyException("Тип фильтра не выбран");
                }
                if (filterBus.GetList().Count < 1)
                {
                    MessageBox.Show($"Записей по данному фильтру: {filterBus.GetList().Count}", "Отсуствуют", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show($"Записей по данному фильтру: {filterBus.GetList().Count}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    JsonDataBuses.UpdateJson(filterBus, true);
                    UpdateTable(true);
                }
            }
            catch (MyException ex)
            {
                selectBus.Text = "";
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sortBussButton_Click(object sender, EventArgs e)
        {
            //* messagebox - сортировка выбирается по типу фильтра
            try
            {
                _buses = JsonDataBuses.ReadJson();
                OOPCollection<Bus> filterBus = new OOPCollection<Bus>();
                string columnType = _selectedFiltreBox.ToLower();
                switch (_selectedFiltreBox)
                {
                    case "Номер":
                        _buses.SetList(_buses.GetList().OrderBy(buses_ => buses_.BusNumber).ToList());
                        break;
                    case "Модель и производитель":
                        _buses.SetList(_buses.GetList().OrderBy(buses_ => buses_.BusModel).ToList());
                        break;
                    case "ФИО Водителя":
                        _buses.SetList(_buses.GetList().OrderBy(buses_ => buses_.BusDriver).ToList());
                        break;
                    case "Маршрут":
                        _buses.SetList(_buses.GetList().OrderBy(buses_ => buses_.BusRoute).ToList());
                        break;
                    case "Расход топлива":
                        _buses.SetList(_buses.GetList().OrderBy(buses_ => buses_.BusFuel).ToList());
                        break;
                    case "Расход на ослуживание":
                        _buses.SetList(_buses.GetList().OrderBy(buses_ => buses_.BusService).ToList());
                        break;
                    default:
                        throw new MyException("Сортировка записей по столбцам выбирается как тип фильтра");
                }
                MessageBox.Show($"Записи по столбцу {columnType} отсортированы", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                JsonDataBuses.UpdateJson(_buses);
                UpdateTable(false);
            }
            catch (MyException ex)
            {
                selectBus.Text = "";
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sortBussDownButton_Click(object sender, EventArgs e)
        {
            try
            {
                _buses = JsonDataBuses.ReadJson();
                OOPCollection<Bus> filterBus = new OOPCollection<Bus>();
                string columnType = _selectedFiltreBox.ToLower();
                switch (_selectedFiltreBox)
                {
                    case "Номер":
                        _buses.SetList(_buses.GetList().OrderByDescending(buses_ => buses_.BusNumber).ToList());
                        break;
                    case "Модель и производитель":
                        _buses.SetList(_buses.GetList().OrderByDescending(buses_ => buses_.BusModel).ToList());
                        break;
                    case "ФИО Водителя":
                        _buses.SetList(_buses.GetList().OrderByDescending(buses_ => buses_.BusDriver).ToList());
                        break;
                    case "Маршрут":
                        _buses.SetList(_buses.GetList().OrderByDescending(buses_ => buses_.BusRoute).ToList());
                        break;
                    case "Расход топлива":
                        _buses.SetList(_buses.GetList().OrderByDescending(buses_ => buses_.BusFuel).ToList());
                        break;
                    case "Расход на ослуживание":
                        _buses.SetList(_buses.GetList().OrderByDescending(buses_ => buses_.BusService).ToList());
                        break;
                    default:
                        throw new MyException("Сортировка записей по столбцам выбирается как тип фильтра");
                }
                MessageBox.Show($"Записи по столбцу {columnType} отсортированы", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                JsonDataBuses.UpdateJson(_buses);
                UpdateTable(false);
            }
            catch (MyException ex)
            {
                selectBus.Text = "";
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetFilterButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Фильтр успешно сброшен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _buses = JsonDataBuses.ReadJson();
            UpdateTable(false);
        }
        private void UpdateTable(bool isReadFilter)
        {

            _buses = !isReadFilter ? JsonDataBuses.ReadJson() : JsonDataBuses.ReadJsonFilter();
            busCount.Text = _buses.GetList().Count().ToString();

            busesGridView.Rows.Clear();
            foreach (Bus bus in _buses)
            {
                if(bus.BusRoute == 0)
                {
                    busesGridView.Rows.Add(
                    bus.BusNumber,
                    bus.BusModel,
                    bus.BusDriver,
                    "Отсутствует",
                    bus.BusFuel,
                    bus.BusService
                );
                }
                else
                {
                    busesGridView.Rows.Add(
                    bus.BusNumber,
                    bus.BusModel,
                    bus.BusDriver,
                    bus.BusRoute,
                    bus.BusFuel,
                    bus.BusService
                );
                }
                
            }
        }

        private void toMainMenuButton_Click(object sender, EventArgs e)
        {
            BusManager.ActiveForm.Hide();
            MainMenu mm = new MainMenu();
            mm.ShowDialog();
            Close();
        }

        private void selectFilteBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedFiltreBox = selectFiltreBox.SelectedItem.ToString();
        }

        private void deleteAllBusButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Удалить ли все автобусы?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                _buses = JsonDataBuses.ReadJson();
                _buses.Clear();
                OOPCollection<Route> routes = JsonData.ReadJson();
                foreach (Route route in routes)
                {
                    if (route.RouteBuses != null)
                    {
                        route.removeAllBuses();
                    }
                }
                JsonData.UpdateJson(routes);
                JsonDataBuses.UpdateJson(_buses);
                MessageBox.Show("Все автобусы успешно удалены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateTable(false);
            }
        }
    }
}
