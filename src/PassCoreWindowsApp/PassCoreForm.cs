using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PassCoreWindowsApp.Properties;
using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace PassCoreWindowsApp
{
    public partial class PassCoreForm : Form
    {

        private HttpClient client;
        string username;
        string currPass;
        string newPass;
        string reNewPass;
        string recaptcha = "";

        public PassCoreForm()
        {
            // Bỏ qua kiểm tra certificate
            var handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ServerCertificateCustomValidationCallback =
                (httpRequestMessage, cert, cetChain, policyErrors) =>
                {
                    return true;
                };

            client = new HttpClient(handler);
            client.BaseAddress = new Uri(Resources.Host);
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            InitializeComponent();
        }

        /// <summary>
        /// Xử lý sự kiện nhập username
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            username = (sender as TextBox).Text;
            CheckNull();
            CheckEmail(username);
        }

        /// <summary>
        /// Xử lý sự kiện nhập mật khẩu hiện tại
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrPassTextBox_TextChanged(object sender, EventArgs e)
        {
            currPass = (sender as TextBox).Text;
            CheckNull();
        }

        /// <summary>
        /// Xử lý sự kiện nhập mật khẩu mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewPassTextBox_TextChanged(object sender, EventArgs e)
        {
            newPass = (sender as TextBox).Text;
            CheckNull();
            SetPassStrength(newPass);
            CheckReNewPass();
        }

        /// <summary>
        /// Xử lý sự kiện nhập lại mật khẩu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReNewPassTextBox_TextChanged(object sender, EventArgs e)
        {
            reNewPass = (sender as TextBox).Text;
            CheckNull();
            CheckReNewPass();
        }

        /// <summary>
        /// Xử lý sự kiện khi nhấn nút Change Password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangePassButton_Click(object sender, EventArgs e)
        {
            ChangePass();
        }

        /// <summary>
        /// Xử lý sự kiện nhấn Enter tại các textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PressEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && this.ChangePassButton.Enabled)
            {
                ChangePass();
            }
        }

        /// <summary>
        /// Hàm đổi mật khẩu
        /// </summary>
        private async void ChangePass()
        {
            try
            {
                var formData = new
                {
                    CurrentPassword = currPass,
                    NewPassword = newPass,
                    NewPasswordVerify = reNewPass,
                    Recaptcha = recaptcha,
                    Username = username
                };
                string json = JsonConvert.SerializeObject(formData);

                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(
                "api/password", httpContent);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Resources.SuccessContent, Resources.SuccessTiltle, MessageBoxButtons.OK);
                    SetNull();
                }
                else
                {
                    string reponseDataString = await response.Content.ReadAsStringAsync();
                    JObject reponseDataJson = JObject.Parse(reponseDataString);
                    ShowError(reponseDataJson);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Resources.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Kiểm tra trường trống trong form
        /// </summary>
        private void CheckNull()
        {
            this.ChangePassButton.Enabled =
                username != null && username != "" &&
                currPass != null && currPass != "" &&
                newPass != null && newPass != "" &&
                reNewPass != null && reNewPass != "";
        }

        /// <summary>
        /// Đặt các textbox thành rỗng sau khi đổi mật khẩu thành công
        /// </summary>
        private void SetNull()
        {
            username = null;
            currPass = null;
            newPass = null;
            reNewPass = null;
            this.UsernameTextBox.Text = null;
            this.CurrPassTextBox.Text = null;
            this.NewPassTextBox.Text = null;
            this.ReNewPassTextBox.Text = null;
            this.PassStrengthBar.Value = 0;
        }

        /// <summary>
        /// Kiểm tra độ mạnh của mật khẩu mới
        /// </summary>
        /// <param name="pass"></param>
        private void SetPassStrength(string pass)
        {
            if (pass != null && pass != "")
            {
                var result = Zxcvbn.Core.EvaluatePassword(pass);
                this.PassStrengthBar.Value = result.Score;
            }
            else this.PassStrengthBar.Value = 0;
        }

        /// <summary>
        /// Hiển thị cảnh báo lỗi
        /// </summary>
        /// <param name="errors"></param>
        private void ShowError(JObject errors)
        {
            string errorAlertMessage = "";
            foreach (var error in errors["errors"])
            {
                switch (error["errorCode"].ToObject<int>())
                {
                    case 0:
                        errorAlertMessage += error["message"];
                        break;
                    case 1:
                        errorAlertMessage += Resources.ErrorFieldRequired;
                        break;
                    case 2:
                        errorAlertMessage += Resources.ErrorFieldMismatch;
                        break;
                    case 3:
                        errorAlertMessage += Resources.ErrorInvalidUser;
                        break;
                    case 4:
                        errorAlertMessage += Resources.ErrorInvalidCredentials;
                        break;
                    case 5:
                        errorAlertMessage += Resources.ErrorCaptcha;
                        break;
                    case 6:
                        errorAlertMessage += Resources.ErrorPasswordChangeNotAllowed;
                        break;
                    case 7:
                        errorAlertMessage += Resources.ErrorInvalidDomain;
                        break;
                    case 8:
                        errorAlertMessage += Resources.ErrorConnectionLdap;
                        break;
                    case 9:
                        errorAlertMessage += Resources.ErrorComplexPassword;
                        break;
                    case 10:
                        errorAlertMessage += Resources.ErrorScorePassword;
                        break;
                    case 11:
                        errorAlertMessage += Resources.ErrorDistancePassword;
                        break;
                    case 12:
                        errorAlertMessage += Resources.ErrorPwnedPassword;
                        break;
                    case 13:
                        errorAlertMessage += Resources.ErrorShortPassword;
                        break;
                }
            }

            MessageBox.Show(errorAlertMessage, Resources.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Kiểm tra email hợp lệ
        /// </summary>
        /// <param name="email"></param>
        private void CheckEmail(string email)
        {
            if (email != null && email != "")
            {
                bool check = new EmailAddressAttribute().IsValid(email);
                if (!check)
                {
                    this.UsernameSubTitle.Text = Resources.CheckEmailLabel;
                    this.UsernameSubTitle.ForeColor = System.Drawing.Color.Red;
                    this.ChangePassButton.Enabled = this.ChangePassButton.Enabled && check;
                    return;
                }
            }
            this.UsernameSubTitle.Text = Resources.UsernameSubTitle;
            this.UsernameSubTitle.ForeColor = System.Drawing.Color.Black;
        }

        /// <summary>
        /// Kiểm tra nhập lại mật khẩu mới đúng không
        /// </summary>
        private void CheckReNewPass()
        {
            this.CheckPassLabel.Visible = newPass != reNewPass && reNewPass != null && reNewPass != "";
            this.ChangePassButton.Enabled = this.ChangePassButton.Enabled && reNewPass == newPass;
        }
    }
}
