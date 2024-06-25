using System;
using System.Diagnostics;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string value;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string url = "http://1.117.76.68/gx.json";
            value = await GetJsonValue(url, "V");
            string value2 = await GetJsonValue(url, "gxnr");
            string value3 = await GetJsonValue(url, "ts");
            label5.Text = value;
            label6.Text = value2;
            label7.Text = value3;

        }

        private async Task<string> GetJsonValue(string url, string key)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // 解析JSON
                    JObject json = JObject.Parse(responseBody);
                    return json[key]?.ToString();
                }
                catch (HttpRequestException e)
                {
                    MessageBox.Show("请求错误：" + e.Message);
                    return null;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "http://1.117.76.68/" + "jqr-" + value + ".exe",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("无法打开浏览器：" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://github.com/fanbook-wangdage/fanbook_bot-kzq",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("无法打开浏览器：" + ex.Message);
            }
        }
    }
}
