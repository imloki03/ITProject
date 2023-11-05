using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Province
{
    public int code { get; set; }
    public string Name { get; set; }
}

public class District
{
    public int code { get; set; }
    public string Name { get; set; }
    public int ProvinceId { get; set; }
}

public class Ward
{
    public int code { get; set; }
    public string Name { get; set; }
    public int DistrictId { get; set; }
}

namespace WinFormsRestaurant
{
    public class Methods
    {
        private static string RemoveVietnameseSigns(string text)
        {
            // Thay thế các ký tự có dấu thành các ký tự không dấu
            string[] fromChars = new string[] { "à", "á", "ạ", "ả", "ã", "â", "ầ", "ấ", "ậ", "ẩ", "ẫ", "ă", "ằ", "ắ", "ặ", "ẳ", "ẵ", "è", "é", "ẹ", "ẻ", "ẽ", "ê", "ề", "ế", "ệ", "ể", "ễ", "ì", "í", "ị", "ỉ", "ĩ", "ò", "ó", "ọ", "ỏ", "õ", "ô", "ồ", "ố", "ộ", "ổ", "ỗ", "ơ", "ờ", "ớ", "ợ", "ở", "ỡ", "ù", "ú", "ụ", "ủ", "ũ", "ư", "ừ", "ứ", "ự", "ử", "ữ", "ỳ", "ý", "ỵ", "ỷ", "ỹ", "đ" };
            string[] toChars = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "i", "i", "i", "i", "i", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "u", "u", "u", "u", "u", "u", "u", "u", "u", "u", "u", "y", "y", "y", "y", "y", "d" };
            for (int i = 0; i < fromChars.Length; i++)
            {
                text = Regex.Replace(text, fromChars[i], toChars[i], RegexOptions.IgnoreCase);
            }
            for (int i = 1; i < text.Length; i++)
                if (text[i - 1] == ' ')
                    text = text.Substring(0, i) + Char.ToUpper(text[i]) + text.Substring(i + 1);
            return text;
        }
        static HttpClient client = new HttpClient();

        public void fillPanel(Panel panel, Form childform, int clear)
        {
            childform.Dock = DockStyle.Fill;
            if (clear == 1)
                panel.Controls.Clear();
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.TopLevel = false;
            panel.Controls.Add(childform);
            panel.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }       

        public void standardrizeDtgridview(DataGridView dataGridView)
        {
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.ReadOnly = true;
        }
    }
}
