using OOP_CP.AppendManager;
using OOP_CP.DataBased;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_CP.Management
{
    public partial class FinancialTurnover : Form
    {
        private string fileResult = "";
        private bool isResult = false;

        public FinancialTurnover()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FinancialTurnover.ActiveForm.Hide();
            Close();
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            if (isResult)
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Users\medve\source\repos\OOP_CP\OOP_CP\Data_Base\financial_result.txt", false))
                    writer.WriteLine(fileResult);
                MessageBox.Show("Отчет успешно сохранен!", "Файл", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else{
                MessageBox.Show("Сформируйте отчет для сохранения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                OOPCollection<Route> routes = JsonData.ReadJson();
                int routeNum = MyException.isInteger(routeNumber.Text, "поле выбор номера");
                if(!routes.GetList().Any(route_ => route_.RouteNumber == routeNum))
                    throw new MyException("Нет маршрута с таким номером");
                Route localRoute = routes.GetList().First(route_ => route_.RouteNumber == routeNum);
                OOPCollection<Bus> buses = JsonDataBuses.ReadJson();
                if(localRoute.RouteBuses.Count < 1)
                    throw new MyException("Невозможно посчитать фин. показатели маршута, у которого отсутствует транспорт");
                double expensesResult = 0;
                double incomeResult = localRoute.RouteTicketPrice * localRoute.RouteManCount * 31;
                foreach (string localBus in localRoute.RouteBuses)
                {
                    Bus bus = buses.GetList().First(bus_ => bus_.BusNumber == localBus);
                    expensesResult += (bus.BusFuel * 2.1) * MyException.isDouble(fuelPrice.Text, "поле цена за литр") + (210 * 31) / bus.BusService + MyException.isDouble(driverCost.Text, "ЗП водителя");
                    
                }
                printResult.Text = $"Финансовый отчет за один месяц на маршруте №{routeNum}:\n" +
                    $"Количество транспорта на маршруте: {localRoute.RouteBuses.Count}\n" +
                    $"Среднее количество пассажиров: {localRoute.RouteManCount}\n" +
                    $"Цена билета: {localRoute.RouteTicketPrice} руб.\n" +
                    $"Расход c cоставляет: {expensesResult} руб.\n" +
                    $"Доход составляет: {incomeResult} руб.\n\n" +
                    $"Чистая прибыль: {incomeResult - expensesResult} руб.";
                isResult = true;
                fileResult = printResult.Text;
            }
            catch (MyException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
