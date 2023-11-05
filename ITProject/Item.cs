using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageRestaurant
{
    public partial class Item : UserControl
    {
        public Item()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public event EventHandler UserControlClicked;

        private void OnUserControlClicked()
        {
            EventHandler handler = UserControlClicked;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
        public void SetSelectionIndicator()
        {
            // Thực hiện các thay đổi để hiển thị dấu hiệu khi được chọn.
            // Ví dụ, thay đổi màu nền hoặc hiển thị dấu hiệu khác.
            this.BackColor = Color.LightBlue;
        }

        public void RemoveSelectionIndicator()
        {
            // Thực hiện các thay đổi để xóa dấu hiệu khi không được chọn.
            // Đặt lại màu nền hoặc ẩn dấu hiệu.
            this.BackColor = SystemColors.Control; // Màu nền mặc định của UserControl
        }

        private void Item_Click(object sender, EventArgs e)
        {
            OnUserControlClicked();
        }
    }
}
