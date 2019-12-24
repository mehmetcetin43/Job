using Job.Business.Abstract;
using Job.Business.Concrete;
using Job.Business.DependencyResolves.Ninject;
using Job.DataAccess.Abstract;
using Job.DataAccess.Concrete;
using Job.Entities.Entities;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job.WinUI
{
    public partial class Form1 : Form
    {
        private IDailyWorkService _dailyWorkService;

        [Obsolete]
        public Form1()
        {
            InitializeComponent();

            /// ---------- üçüncü kullanım ---------------///
            IKernel kernel = new StandardKernel(new BusinessModule());
            _dailyWorkService = kernel.Get<IDailyWorkService>();


            /// ---------- ikinci kullanım ---------------///
            //kernel.Bind<IDailyWorkService>().To<DailyWorkManager>().InSingletonScope();
            //kernel.Bind<IDailyWorkDal>().To<EfDailyWorkDal>().InSingletonScope();
            //_dailyWorkService = kernel.Get<IDailyWorkService>();


            /// ---------- ilk kullanım ---------------///
            //_dailyWorkService = new DailyWorkManager(new EfDailyWorkDal());
            //_musteriService = new MusteriManager(new EfMusteriDal());
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            var result = _dailyWorkService.GetByYearsMonth(year, month);
            LoadData(result);

            DataGridViewButtonColumn dgvBtnRemove = new DataGridViewButtonColumn();
            DataGridViewButtonColumn dgvBtnUpdate = new DataGridViewButtonColumn();
            dgvBtnRemove.Text = "Remove";
            dgvBtnRemove.Name = "dgvBtnRemove";
            dgvBtnRemove.UseColumnTextForButtonValue = true;
            dataGridView2.Columns.Add(dgvBtnRemove);
            dgvBtnUpdate.Text = "Updaate";
            dgvBtnUpdate.Name = "dgvBtnUpdate";
            dgvBtnUpdate.UseColumnTextForButtonValue = true;
            dataGridView2.Columns.Add(dgvBtnUpdate);


            //this.dailyWorkTableAdapter.FillBy(this.jOBDataSet.DailyWork);

            var years = _dailyWorkService.GetYears();
            foreach (var item in years)
            {
                cmbxYears.Items.Add(item);
            }

            TotalExtrAndMissgWorkingForTxtBx(year, month); // Datagridviewin üstündeki textbox lar mesai ve eksik saatleri yazdırma metodu.
        }

        private void LoadData(List<DailyWork> result)
        {
            dataGridView2.Rows.Clear();
            int i = 0;
            foreach (var item in result)
            {
                dataGridView2.Rows.Add();
                dataGridView2["ID", i].Value = item.ID;
                dataGridView2["Date2", i].Value = item.Date;
                dataGridView2["CheckInTime2", i].Value = item.CheckInTime;
                dataGridView2["CheckOutTime2", i].Value = item.CheckOutTime;
                dataGridView2["DailyWorkingHour2", i].Value = item.DailyWorkingHour;
                dataGridView2["ExtraWorkingHour2", i].Value = item.ExtraWorkingHour;
                dataGridView2["MissingWorkingHour2", i].Value = item.MissingWorkingHour;
                i++;
            }
            dataGridView2.Sort(dataGridView2.Columns["Date2"], ListSortDirection.Ascending);
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            int saatBaslangic = 9;
            int dakikaBaslangic = 0;
            int[] saatler = new int[15];
            int[] dakikalar = new int[60];
            //dgvWorking["Tarih", 0].Value = DateTime.Today.ToShortDateString();
            for (int i = 0; i < 15; i++)
            {
                saatler[i] = saatBaslangic;
                saatBaslangic++;
            }
            foreach (var item in saatler)
            {
                cmbxChckInHour.Items.Add(item);
                cmbxChckOutHour.Items.Add(item);
            }
            for (int i = 0; i < 60; i++)
            {
                dakikalar[i] = dakikaBaslangic;
                dakikaBaslangic++;
            }
            foreach (var item in dakikalar)
            {
                cmbxChckInMinute.Items.Add(item);
                cmbxChckOutMinute.Items.Add(item);
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = dtpDate.Value.Date;
            dgvWorking["Date", 0].Value = today.ToShortDateString();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (cmbxChckInHour.Text == "" || cmbxChckInMinute.Text == "")
            {
                MessageBox.Show("Check-in Time Can Not Be Null");
                return;
            }
            else
            {
                var checkInHour = cmbxChckInHour.SelectedItem;
                var checkInMinute = cmbxChckInMinute.SelectedItem;

                dgvWorking["CheckInTime", 0].Value = Convert.ToDateTime(string.Join(":", checkInHour, checkInMinute)).ToString("HH:mm");
                if (dgvWorking["Date", 0].Value == null)
                {
                    dgvWorking["Date", 0].Value = DateTime.Now.ToShortDateString();
                    MessageBox.Show("Tarihi Kontrol Ediniz");
                }
                cmbxChckOutHour.Enabled = true;
            }

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            var mustDailyWorkingHour =
                dtpDate.Value.DayOfWeek == DayOfWeek.Sunday ? "00:00"
                : dtpDate.Value.DayOfWeek == DayOfWeek.Saturday ? "05:00"
                : "08:00";
            var checkOutHour = Convert.ToInt32(cmbxChckOutHour.SelectedItem.ToString());
            var checkOutMinute = Convert.ToInt32(cmbxChckOutMinute.SelectedItem.ToString());
            var checkInHour = Convert.ToInt32(cmbxChckInHour.SelectedItem.ToString());
            var checkInMinute = Convert.ToInt32(cmbxChckInMinute.SelectedItem.ToString());
            var lunchBreakMinute =
                  dtpDate.Value.DayOfWeek == DayOfWeek.Sunday && checkOutHour > 12 ? 60
                : dtpDate.Value.DayOfWeek == DayOfWeek.Sunday && (checkOutHour == 12 && checkOutMinute > 0) ? checkOutMinute
                : dtpDate.Value.DayOfWeek == DayOfWeek.Sunday && checkOutHour <= 12 ? 0

                : dtpDate.Value.DayOfWeek == DayOfWeek.Saturday && checkOutHour > 12 ? 30
                : dtpDate.Value.DayOfWeek == DayOfWeek.Saturday && (checkOutHour == 12 && checkOutMinute > 0) ? checkOutMinute
                : dtpDate.Value.DayOfWeek == DayOfWeek.Saturday && checkOutHour <= 12 ? 0

                : checkOutHour > 12 ? 60
                : (checkOutHour == 12 && checkOutMinute > 0) ? checkOutMinute
                : checkOutHour <= 12 ? 0
                : 60;
            var dinnerBreakMinute = 30;
            dgvWorking["CheckOutTime", 0].Value = Convert.ToDateTime((string.Join(":", checkOutHour, checkOutMinute))).ToString("HH:mm");


            //**************************************************//
            try
            {
                if (checkOutHour == 18 && checkOutMinute > 30)
                {
                    var workingTimeHOUR = ((checkOutHour - checkInHour) * 60) + (checkOutMinute - checkInMinute) - (lunchBreakMinute + dinnerBreakMinute);
                    dgvWorking["DailyWorkingHour", 0].Value = Convert.ToDateTime(workingTimeHOUR / 60 + ":" + workingTimeHOUR % 60).ToString("HH:mm");
                    TimeSpan result = (Convert.ToDateTime(workingTimeHOUR / 60 + ":" + workingTimeHOUR % 60) - Convert.ToDateTime(mustDailyWorkingHour));
                    if (result.TotalMinutes < 0)
                    {
                        dgvWorking["MissingWorkingHour", 0].Value = -result;
                        dgvWorking["ExtraWorkingHour", 0].Value = -result + result;
                    }
                    else if (result.TotalMinutes > 0)
                    {
                        dgvWorking["ExtraWorkingHour", 0].Value = result;
                        dgvWorking["MissingWorkingHour", 0].Value = result - result;
                    }
                }
                else if (checkOutHour > 18)
                {
                    var workingTimeHOUR = ((checkOutHour - checkInHour) * 60) + (checkOutMinute - checkInMinute) - (lunchBreakMinute + dinnerBreakMinute);
                    dgvWorking["DailyWorkingHour", 0].Value = Convert.ToDateTime(workingTimeHOUR / 60 + ":" + workingTimeHOUR % 60).ToString("HH:mm");
                    TimeSpan result = (Convert.ToDateTime(workingTimeHOUR / 60 + ":" + workingTimeHOUR % 60) - Convert.ToDateTime(mustDailyWorkingHour));
                    if (result.TotalMinutes < 0)
                    {
                        dgvWorking["MissingWorkingHour", 0].Value = -result;
                        dgvWorking["ExtraWorkingHour", 0].Value = -result + result;
                    }
                    else if (result.TotalMinutes > 0)
                    {
                        dgvWorking["ExtraWorkingHour", 0].Value = result;
                        dgvWorking["MissingWorkingHour", 0].Value = result - result;
                    }
                }
                else if (checkOutHour == 18 && checkOutMinute <= 30)
                {
                    checkOutMinute = 0;
                    var workingTimeHOUR = ((checkOutHour - checkInHour) * 60) + (checkOutMinute - checkInMinute) - lunchBreakMinute;
                    dgvWorking["DailyWorkingHour", 0].Value = Convert.ToDateTime(workingTimeHOUR / 60 + ":" + workingTimeHOUR % 60).ToString("HH:mm");
                    TimeSpan result = (Convert.ToDateTime(workingTimeHOUR / 60 + ":" + workingTimeHOUR % 60)) - Convert.ToDateTime((mustDailyWorkingHour));
                    if (result.TotalMinutes < 0)
                    {
                        dgvWorking["MissingWorkingHour", 0].Value = -result;
                        dgvWorking["ExtraWorkingHour", 0].Value = -result + result;
                    }
                    else if (result.TotalMinutes >= 0)
                    {
                        dgvWorking["ExtraWorkingHour", 0].Value = result;
                        dgvWorking["MissingWorkingHour", 0].Value = result - result;
                    }
                }
                else
                {
                    var workingTimeHOUR = ((checkOutHour - checkInHour) * 60) + (checkOutMinute - checkInMinute) - lunchBreakMinute;
                    dgvWorking["DailyWorkingHour", 0].Value = Convert.ToDateTime(workingTimeHOUR / 60 + ":" + workingTimeHOUR % 60).ToString("HH:mm");
                    TimeSpan result = (Convert.ToDateTime(workingTimeHOUR / 60 + ":" + workingTimeHOUR % 60) - Convert.ToDateTime(mustDailyWorkingHour));
                    if (result.TotalMinutes < 0)
                    {
                        dgvWorking["MissingWorkingHour", 0].Value = -result;
                        dgvWorking["ExtraWorkingHour", 0].Value = -result + result;
                    }
                    else if (result.TotalMinutes >= 0)
                    {
                        dgvWorking["ExtraWorkingHour", 0].Value = result;
                        dgvWorking["MissingWorkingHour", 0].Value = result - result;
                    }
                }
                btnConfirm.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("There is problem!!!...");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = Convert.ToDateTime((dgvWorking["Date", 0].Value));
                var result = _dailyWorkService.GetDate(date);
                if (result == null)
                {
                    DailyWork dailyWork = new DailyWork();
                    dailyWork.Date = Convert.ToDateTime((dgvWorking["Date", 0].Value));
                    dailyWork.CheckInTime = (dgvWorking["CheckInTime", 0].Value).ToString();
                    dailyWork.CheckOutTime = (dgvWorking["CheckOutTime", 0].Value.ToString());
                    dailyWork.DailyWorkingHour = (dgvWorking["DailyWorkingHour", 0].Value).ToString();
                    dailyWork.ExtraWorkingHour = (dgvWorking["ExtraWorkingHour", 0].Value) as TimeSpan?;
                    dailyWork.MissingWorkingHour = (dgvWorking["MissingWorkingHour", 0].Value) as TimeSpan?;

                    _dailyWorkService.Add(dailyWork);
                    dgvWorking["Date", 0].Value = null;
                    dgvWorking["CheckInTime", 0].Value = null;
                    dgvWorking["CheckOutTime", 0].Value = null;
                    dgvWorking["DailyWorkingHour", 0].Value = null;
                    dgvWorking["ExtraWorkingHour", 0].Value = null;
                    dgvWorking["MissingWorkingHour", 0].Value = null;
                    cmbxChckOutHour.Enabled = false;
                    cmbxChckOutMinute.Enabled = false;
                    btnCheckOut.Enabled = false;
                    MessageBox.Show("Added");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("This date is already exist !.. If you would like to update click YES or you don't want click NO", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {

                        result.Date = Convert.ToDateTime((dgvWorking["Date", 0].Value));
                        result.CheckInTime = (dgvWorking["CheckInTime", 0].Value).ToString();
                        result.CheckOutTime = (dgvWorking["CheckOutTime", 0].Value.ToString());
                        result.DailyWorkingHour = (dgvWorking["DailyWorkingHour", 0].Value).ToString();
                        result.ExtraWorkingHour = (dgvWorking["ExtraWorkingHour", 0].Value) as TimeSpan?;
                        result.MissingWorkingHour = (dgvWorking["MissingWorkingHour", 0].Value) as TimeSpan?;

                        _dailyWorkService.Update(result);
                        dgvWorking["Date", 0].Value = null;
                        dgvWorking["CheckInTime", 0].Value = null;
                        dgvWorking["CheckOutTime", 0].Value = null;
                        dgvWorking["DailyWorkingHour", 0].Value = null;
                        dgvWorking["ExtraWorkingHour", 0].Value = null;
                        dgvWorking["MissingWorkingHour", 0].Value = null;
                        cmbxChckOutHour.Enabled = false;
                        cmbxChckOutMinute.Enabled = false;
                        btnCheckOut.Enabled = false;
                        MessageBox.Show("Updated");

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbxChckOutMinute_SelectedValueChanged(object sender, EventArgs e)
        {
            btnCheckOut.Enabled = true;
        }

        private void cmbxChckOutHour_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbxChckOutMinute.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvWorking["Date", 0].Value = null;
            dgvWorking["CheckInTime", 0].Value = null;
            dgvWorking["CheckOutTime", 0].Value = null;
            dgvWorking["DailyWorkingHour", 0].Value = null;
            dgvWorking["ExtraWorkingHour", 0].Value = null;
            dgvWorking["MissingWorkingHour", 0].Value = null;
            cmbxChckInHour.SelectedItem = null;
            cmbxChckInMinute.SelectedItem = null;
            cmbxChckOutHour.SelectedItem = null;
            cmbxChckOutMinute.SelectedItem = null;
            cmbxChckOutHour.Enabled = false;
            cmbxChckOutMinute.Enabled = false;
            btnCheckOut.Enabled = false;
        }

        private void btnReflesh_Click(object sender, EventArgs e)
        {
            //this.dailyWorkTableAdapter.FillBy(this.jOBDataSet.DailyWork);
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            var result = _dailyWorkService.GetByYearsMonth(year, month);
            LoadData(result);
            TotalExtrAndMissgWorkingForTxtBx(year, month);
        }


        private void cmbxYears_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbxMonths.Text = null;
            cmbxMonths.Items.Clear();
            int year = Convert.ToInt32(cmbxYears.SelectedItem);
            var monthsName = _dailyWorkService.GetMonthsByName(year);

            foreach (var item in monthsName)
            {
                cmbxMonths.Items.Add(item);
            }
        }

        private void btnGetAllData_Click(object sender, EventArgs e)
        {
            //this.dailyWorkTableAdapter.Fill(this.jOBDataSet.DailyWork);
            var result = _dailyWorkService.GetAll();
            LoadData(result);
        }

        private void btnGetSelectedDateData_Click(object sender, EventArgs e)
        {
            if (cmbxMonths.SelectedItem == null || cmbxYears.SelectedItem == null)
            {
                MessageBox.Show("Choose year and month...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int year = Convert.ToInt32(cmbxYears.SelectedItem);
                int month =
                   (cmbxMonths.SelectedItem.ToString() == "January") ? 1 :
                   (cmbxMonths.SelectedItem.ToString() == "February") ? 2 :
                   (cmbxMonths.SelectedItem.ToString() == "March") ? 3 :
                   (cmbxMonths.SelectedItem.ToString() == "April") ? 4 :
                   (cmbxMonths.SelectedItem.ToString() == "May") ? 5 :
                   (cmbxMonths.SelectedItem.ToString() == "June") ? 6 :
                   (cmbxMonths.SelectedItem.ToString() == "July") ? 7 :
                   (cmbxMonths.SelectedItem.ToString() == "August") ? 8 :
                   (cmbxMonths.SelectedItem.ToString() == "September") ? 9 :
                   (cmbxMonths.SelectedItem.ToString() == "October") ? 10 :
                   (cmbxMonths.SelectedItem.ToString() == "November") ? 11 :
                   (cmbxMonths.SelectedItem.ToString() == "December") ? 12 : 0;
                var result = _dailyWorkService.GetByYearsMonth(year, month);
                LoadData(result);
                cmbxMonths.SelectedItem = null;
                cmbxYears.SelectedItem = null;
                TotalExtrAndMissgWorkingForTxtBx(year, month);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to remove this", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    var result = Convert.ToInt32(dataGridView2["ID", Convert.ToInt32(e.RowIndex)].Value);
                    if (result > 0)
                    {
                        var entity = _dailyWorkService.GetByID(result);
                        _dailyWorkService.Delete(entity);
                        MessageBox.Show("Removed..");
                        var data = _dailyWorkService.GetAll();
                        LoadData(data);
                    }
                }
            }
            else if (e.ColumnIndex == 8)
            {
                MessageBox.Show("Update button is coding still..!");
            }
        }

        private void TotalExtrAndMissgWorkingForTxtBx(int year, int month)
        {
            var totalExtraWrk = _dailyWorkService.TotalExtraWork(year, month);
            var totalMisngWork = _dailyWorkService.TotalMissingWork(year, month);
            txtTotalExtrWrking.Text = Convert.ToDateTime((totalExtraWrk / 60).ToString() + ":" + (totalExtraWrk % 60)).ToString("HH:mm");
            txtTotalMissWrking.Text = Convert.ToDateTime((totalMisngWork / 60).ToString() + ":" + (totalMisngWork % 60)).ToString("HH:mm");
            if (totalExtraWrk >= totalMisngWork)
            {
                var result = totalExtraWrk - totalMisngWork;
                txtTotal.Text = Convert.ToDateTime((result / 60).ToString() + ":" + (result % 60)).ToString("HH:mm");
            }
            else if (totalExtraWrk < totalMisngWork)
            {
                var result = totalExtraWrk - totalMisngWork;
                txtTotal.Text = "-" + Convert.ToDateTime((-result / 60).ToString() + ":" + (-result % 60)).ToString("HH:mm");

            }
        }

        private void btnCalculateSalary_Click(object sender, EventArgs e)
        {
            int salary = Convert.ToInt32(txtSalary.Text);
            var wage = _dailyWorkService.HourlyWage(DateTime.Now.Month, salary);
            var result = _dailyWorkService.CalculateSalary(DateTime.Now.Year, DateTime.Now.Month, salary, wage);

            txtTotalSalary.Text = decimal.Round(result).ToString();
        }
    }
}
