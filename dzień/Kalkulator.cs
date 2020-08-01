using dzień.Klasy;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace dzień
{
    public partial class Kalkulator : Form
    {
        List<Dayy> workingPeriod = new List<Dayy>();
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void EditBTN_Click(object sender, EventArgs e)
        {
            DateTime startDate = FromDateDTP.Value.Date;
            DateTime endDate = ToDateDTP.Value.Date;
            List<DateTime> daysInRange = new List<DateTime>();
            workingPeriod = new List<Dayy>();
            for (DateTime day = startDate; day <= endDate; day = day.AddDays(1))
            {
                Dayy Day = new Dayy
                {
                    Date = day,
                    WeeksDay = day.DayOfWeek,
                    IsWorked = (SatCB.Checked && day.DayOfWeek == DayOfWeek.Saturday) || (SunCB.Checked && day.DayOfWeek == DayOfWeek.Sunday) ||
                                (day.DayOfWeek != DayOfWeek.Saturday && day.DayOfWeek != DayOfWeek.Sunday) ? true : false,
                    Hours = HoursPerDayNB.Value,
                    HourlyRate = MoneyPerHourNB.Value
                };
                workingPeriod.Add(Day);
            }
            PeriodDGV.DataSource = null;
            PeriodDGV.Rows.Clear();
            PeriodDGV.DataSource = workingPeriod;
            foreach (DataGridViewRow row in PeriodDGV.Rows)
            {
                if ((bool)row.Cells["IsWorked"].Value != true)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.DarkGray;
                        cell.Style.ForeColor = Color.DarkGray;
                    }
                }
            }
        }

        private void CountBTN_Click(object sender, EventArgs e)
        {
            decimal payOut = 0;
            decimal workedHours = 0;
            foreach (DataGridViewRow row in PeriodDGV.Rows)
            {
                decimal hours = (decimal)row.Cells["Hours"].Value;
                decimal hourlyRate = (decimal)row.Cells["HourlyRate"].Value;
                payOut += (bool)row.Cells["IsWorked"].Value == true ? hours * hourlyRate : 0;
                workedHours += (bool)row.Cells["IsWorked"].Value == true ? hours : 0;
            }
            WorkedHoursLAB.Text = String.Format("{0} GODZIN", workedHours);
            MoneyLAB.Text = String.Format("{0} ZŁ", payOut);
        }

        private void PeriodDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in PeriodDGV.Rows)
            {
                if ((bool)row.Cells["IsWorked"].Value != true)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.DarkGray;
                        cell.Style.ForeColor = Color.DarkGray;
                    }
                }
                else
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = default;
                    }
                }
            }
        }
    }
}
