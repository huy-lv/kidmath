using System;
using System.Drawing;
using System.Data;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmRandom : Form
    {
        public Setting Setting { get; set; }
        public Random RandomObj { get; set; }
        public bool IsRunning { get; set; } = false;
        public bool InitSucceeded { get; set; } = true;
        public int CurrentExpression { get; set; } = 0;
        public ResultObject ResultObject { get; set; }
        public frmRandom()
        {
            InitializeComponent();
            LoadDefault();
            RandomObj = new Random();
            ResultObject = new ResultObject();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtRandomTimes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidateTxtNumberNonNegative(e);
        }

        private void txtMinValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidateTxtNumberNegative(e);
        }

        private void TxtMaxValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidateTxtNumberNegative(e);
        }

        private void txtWaitingTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidateTxtNumberNonNegative(e);
        }

        private void txtWaitingForResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidateTxtNumberNonNegative(e);
        }

        private void rdbShow2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbShow2.Checked)
            {
                lblWaitingForResult.Visible = true;
                txtWaitingForResult.Visible = true;
                txtWaitingForResult.Text = "";
                txtWaitingForResult.Focus();
            }
        }

        private void rdbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbShow.Checked)
                HideWaitingForResult();
        }

        private void rdbShow3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbShow3.Checked)
                HideWaitingForResult();
        }
        #region Private method
        private bool ValidateTxtNumberNegative(KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return false;
            Regex reg = new Regex(@"^(-?\d*)$");
            if (!reg.IsMatch(e.KeyChar.ToString())) return true;
            return false;
        }
        private bool ValidateTxtNumberNonNegative(KeyPressEventArgs e)
           => (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));

        private void HideWaitingForResult()
        {
            lblWaitingForResult.Visible = false;
            txtWaitingForResult.Visible = false;
            txtWaitingForResult.Text = "0";
        }

        private void ClearValue()
        {
            rdbShow.Checked = true;
            txtRandomTimes.Text = "";
            txtExpressionNum.Text = "";
            txtMinValue.Text = "";
            txtMaxValue.Text = "";
            txtWaitingTime.Text = "";
            HideWaitingForResult();
            txtRandomTimes.Focus();
        }
        private void LoadDefault()
        {
            rdbShow.Checked = true;
            txtRandomTimes.Text = "12";
            txtMinValue.Text = "10";
            txtMaxValue.Text = "100";
            txtWaitingTime.Text = "1000";
            txtExpressionNum.Text = "5";
            cboOperator.Text = "+-";
            HideWaitingForResult();
            SaveSetting();

            btNext.BackColor = Color.LightGray;
            btNextExpression.BackColor = Color.LightGray;
        }

        private bool SaveSetting()
        {
            try
            {
                if (ValidateForm())
                {
                    Setting = new Setting
                    {
                        MaxValue = int.Parse(txtMaxValue.Text),
                        MinValue = int.Parse(txtMinValue.Text),
                        RandomTime = int.Parse(txtRandomTimes.Text) + 1,
                        WaitingForRandom = int.Parse(txtWaitingTime.Text),
                        WaitingForResult = int.Parse(txtWaitingForResult.Text),
                        ShowResultSetting = rdbShow.Checked ? 1 : (rdbShow2.Checked ? 2 : 3),
                        NumOfExpression = int.Parse(txtExpressionNum.Text),
                        Operator = cboOperator.Text
                    };
                    return true;
                }
                else
                {
                    ShowMessage("Invalid Input, check and save again!");
                    return false;
                }
            }
            catch (Exception)
            {
                InitSucceeded = false;
                ShowMessage("An Error Occured!");
                return false;
            }
        }
        private void ShowMessage(string msg)
        {
            MessageBox.Show(msg);
        }

        private void SetDisableSettingForm(bool isEnable)
        {
            //rdbShow.Enabled = isEnable;
            //txtRandomTimes.Enabled = isEnable;
            //txtExpressionNum.Enabled = isEnable;
            //txtMinValue.Enabled = isEnable;
            //txtMaxValue.Enabled = isEnable;
            //txtWaitingTime.Enabled = isEnable;
            //lblWaitingForResult.Enabled = isEnable;
            //txtWaitingForResult.Enabled = isEnable;
            //btnClear.Enabled = isEnable;
            //btnResetDefault.Enabled = isEnable;
            //btnSaveSetting.Enabled = isEnable;
            //cboOperator.Enabled = isEnable;
            //rdbShow2.Enabled = isEnable;
            //rdbShow3.Enabled = isEnable;
            txtRanDomLabel.Visible = !isEnable;
            //grbSetting.Enabled = isEnable;
        }
        private void SetIsRunning(bool yes)
        {
            btnStart.Enabled = !yes;
            btnStop.Enabled = yes;
            IsRunning = yes;
        }
        private bool ValidateForm()
        {
            try
            {
                var result = true;
                result = int.Parse(txtMaxValue.Text) > 0;
                result = int.Parse(txtMinValue.Text) > 0;
                result = int.Parse(txtRandomTimes.Text) > 0;
                result = int.Parse(txtWaitingTime.Text) > 0;
                result = int.Parse(txtWaitingForResult.Text) > 0;
                result = int.Parse(txtExpressionNum.Text) > 0;
                result = (rdbShow.Checked ? 1 : (rdbShow2.Checked ? 2 : 3)) > 0;
                if (int.Parse(txtMaxValue.Text) < (int.Parse(txtMinValue.Text)))
                    return false;
                return result;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private int GetRandom(int min, int max)
            => RandomObj.Next(min, max + 1);

        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearValue();
        }

        private void btnResetDefault_Click(object sender, EventArgs e)
        {
            LoadDefault();
        }

        private void btnSaveSetting_Click(object sender, EventArgs e)
        {
            if (SaveSetting())
                ShowMessage("Saved!");
        }

        private void chkShowCurrentExpression_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowCurrentExpression.Checked)
            {
                lblCurrentExpression.Visible = true;
            }
            else
            {
                lblCurrentExpression.Visible = false;
            }
        }
        private void ShowGroupBox(bool yes)
        {
            grbSetting.Visible = yes;
            grbUserResult.Visible = yes;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (Setting == null)
                    ShowMessage("Check your setting Value and Try Again!");
                if (ValidateForm())
                {
                    //ShowGroupBox(false);
                    SaveSetting();
                    SetDisableSettingForm(false);
                    SetIsRunning(true);
                    CurrentExpression = 0;
                    timer1.Interval = Setting.WaitingForRandom;
                    //for (int i = 0; i < Setting.NumOfExpression; i++)
                    //{
                    timer1.Start();
                    //}
                }
                SaveSetting();
            }
            catch (Exception ex)
            {
                ShowMessage("An Error Occured!" + ex.Message);
            }
        }
        private void RandomAndWaitingClick()
        {
            if (ResultObject.CurrentIndex == 0)
            {
                ResultObject = new ResultObject();
                txtRanDomLabel.Text = "Ready";
                           txtRanDomLabel.Font = new Font("Arial", 200);
                ResultObject.CurrentIndex = ResultObject.CurrentIndex + 1;
                CurrentExpression++;
            }
            else if (ResultObject.CurrentIndex < Setting.RandomTime)
            {
                //ngưng 100ms trước khi hiện số tiếp theo
                txtRanDomLabel.Text = "";
                System.Threading.Thread.Sleep(100);

                //sinh ra số random 
                var ranNumber = GetRandom(Setting.MinValue, Setting.MaxValue);
                txtRanDomLabel.Font = new Font("Arial", 250);


                if (ResultObject.CurrentIndex < Setting.RandomTime)
                {
                    string currentexp;
                    if (ResultObject.CurrentIndex == 1)
                    {
                        currentexp =  " " +ranNumber.ToString()  ;
                    }
                    else
                    {
                        string randomop;
                        string tempExp;
                        double result;
                        do
                        {
                        //kiểm tra với số hiện tại sử dụng thì có bị âm không 
                            randomop = getRamdomOperator();
                            ranNumber = GetRandom(Setting.MinValue, Setting.MaxValue);
                            tempExp = ResultObject.ValueRaned + " " +(Setting.Operator == "+-" ? randomop : Setting.Operator) + " " + ranNumber.ToString();
                            result = Double.Parse(new DataTable().Compute(tempExp, null).ToString());
                            Console.WriteLine(tempExp + " " + result);
                        } while (result < 0);
                        currentexp = " " + (Setting.Operator == "+-" ? randomop : Setting.Operator) + " " + ranNumber.ToString();
                    }
                    ResultObject.ValueRaned += currentexp;
                    //in ra số vừa được lấy random, nếu có dấu + đằng trước thì bỏ dấu + đi, dấu trừ thì để lại
                    txtRanDomLabel.Text = currentexp.Replace(" + ", " ").Replace(" - ","-");
                }
                else
                {
                    ResultObject.ValueRaned = ResultObject.ValueRaned + " = ";
                }

                //tính kết quả phép tính sau khi thêm random number
                //ResultObjetct.SumValue = GetSequenceValue(ResultObjetct.SumValue, ranNumber);
                //ResultObjetct.SumValue = Int32.Parse( new DataTable().Compute(ResultObjetct.ValueRaned, null).ToString());

                ResultObject.CurrentIndex = ResultObject.CurrentIndex + 1;
                lblCurrentExpression.Text = ResultObject.ValueRaned;
            }
            else if (ResultObject.CurrentIndex == Setting.RandomTime)
            {
                ResultObject.CurrentIndex = 0;
                //tinh gia tri cuoi cung
                string currentExpression = ResultObject.ValueRaned.Replace("=", "");
                ResultObject.SumValue = Double.Parse(new DataTable().Compute(currentExpression, null).ToString());
                ResultObject.ValueRaned += " = " + ResultObject.SumValue.ToString();
                txtRanDomLabel.Text = " = ";
                ResultObject.IsFinish = true;

                timer1.Stop();
                //hiện nút 'hiển thị kết quả'
                btNext.Enabled = true;
                btNext.BackColor = Color.DodgerBlue;
            }
        }

        private string getRamdomOperator()
        {
            //sinh 1 số random từ 1 đến 4, nếu bé hơn 2 thì là dấu -, tỉ lệ xuất hiện +/- là 75/25
            return RandomObj.Next(1, 5) < 2 ? "-" : "+";
        }

        private void RandomAndAutoShow()
        {
            if (ResultObject.CurrentIndex == 0)
            {
                ResultObject = new ResultObject();
                System.Threading.Thread.Sleep(Setting.WaitingForRandom);
                txtRanDomLabel.Text = "Ready";
                ResultObject.CurrentIndex = ResultObject.CurrentIndex + 1;
                CurrentExpression++;
                System.Threading.Thread.Sleep(Setting.WaitingForRandom);
            }
            else if (ResultObject.CurrentIndex < Setting.RandomTime)
            {
                var ranNumber = GetRandom(Setting.MinValue, Setting.MaxValue);
                txtRanDomLabel.Text = "";
                System.Threading.Thread.Sleep(100);
                txtRanDomLabel.Text = ranNumber.ToString();

                if (ResultObject.CurrentIndex < Setting.RandomTime - 1)
                {
                    ResultObject.ValueRaned = ResultObject.ValueRaned + ranNumber.ToString() + " " + Setting.Operator + " ";
                }
                else
                {
                    ResultObject.ValueRaned = ResultObject.ValueRaned + ranNumber.ToString() + " = ";
                }
                //ResultObject.SumValue = GetSequenceValue(ResultObject.SumValue, ranNumber);
                ResultObject.CurrentIndex = ResultObject.CurrentIndex + 1;
                lblCurrentExpression.Text = ResultObject.ValueRaned;
            }
            else if (ResultObject.CurrentIndex == Setting.RandomTime)
            {
                ResultObject.CurrentIndex = ResultObject.CurrentIndex + 1;
                ResultObject.ValueRaned = ResultObject.ValueRaned + ResultObject.SumValue.ToString();
                txtRanDomLabel.Text = " = ";

            }
            else if (ResultObject.CurrentIndex > Setting.RandomTime)
            {
                ResultObject.CurrentIndex = 0;
                System.Threading.Thread.Sleep(Setting.WaitingForResult);
                txtRanDomLabel.Text = " = " + ResultObject.SumValue.ToString();
                lblCurrentExpression.Text = ResultObject.ValueRaned;
            }

        }

        /// <summary>
        /// Dung de tinh toan ket qua cua phep tinh
        /// </summary>
        /// <returns></returns>
        private int GetSequenceValue(int currentSum, int ranNumber)
        {
            var result = currentSum;
            switch (Setting.Operator)
            {
                case "+":
                    result += ranNumber;
                    break;
                case "-":
                    result -= ranNumber;
                    break;
                case "--":
                //
                default: break;
            }
            return result;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Setting.ShowResultSetting == 1)
            {
                if (CurrentExpression != Setting.NumOfExpression)
                {
                    RandomAndWaitingClick();
                }
                else
                {
                    timer1.Stop();
                    btnStop.PerformClick();
                    btNext.Enabled = true;
                }
            }
            else if (Setting.ShowResultSetting == 2)
            {
                if (CurrentExpression != Setting.NumOfExpression)
                {
                    System.Threading.Thread.Sleep(Setting.WaitingForRandom);
                    RandomAndAutoShow();
                }
                else
                {
                    timer1.Stop(); btnStop.PerformClick();
                }
            }
            else if (Setting.ShowResultSetting == 3)
            {
                // RandomAndWaitInputResult();
                timer1.Stop();
                ShowMessage("Not implement yet!");

            }
        }
        private void frmRandom_DoubleClick(object sender, EventArgs e)
        {
            //if (ResultObjetct != null && ResultObjetct.CurrentIndex == 0 && ResultObjetct.IsFinish && this.IsRunning && Setting.ShowResultSetting == 1)
            //{
            //    txtRanDomLabel.Text = " = " + ResultObjetct.SumValue.ToString();
            //    lblCurrentExpression.Text = ResultObjetct.ValueRaned;
            //    if (CurrentExpression < Setting.NumOfExpression)
            //    {
            //        timer1.Start();
            //    }
            //    else
            //    {
            //        btnStop.PerformClick();
            //    }
            //}
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ShowGroupBox(true);
            timer1.Stop();
            SetIsRunning(false);
            SetDisableSettingForm(true);
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            //khi click nút 'hiển thị kết quả'
            if (ResultObject != null && ResultObject.CurrentIndex == 0 && ResultObject.IsFinish && this.IsRunning && Setting.ShowResultSetting == 1)
            {
                txtRanDomLabel.Text = "=" + ResultObject.SumValue.ToString();
                lblCurrentExpression.Text = ResultObject.ValueRaned;

                btNextExpression.Enabled = true;
                btNextExpression.BackColor = Color.DodgerBlue;

                btNext.Enabled = false;
                btNext.BackColor = Color.LightGray;
            }
        }

        private void btNextExpression_Click(object sender, EventArgs e)
        {
            //click nút phép tính tiếp theo
            if (CurrentExpression < Setting.NumOfExpression)
            {
                btNextExpression.Enabled = false;
                btNextExpression.BackColor = Color.LightGray;
                timer1.Start();

            }
        }
    }
}
