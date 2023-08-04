using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace ThuatToan
{
    public partial class FCFS : Form
    {
        List<string> programList;
        Timer executionTimer;
        Timer blinkTimer;
        int executionIndex;
        string inputNumbers = @"^\d+$";
        public string ProcessName { get; set; }
        public int StartTime { get; set; }
        public int ExecutionTime { get; set; }
        public FCFS()
        {
            InitializeComponent();
            programList = new List<string>();
            executionTimer = new Timer();
            executionTimer.Interval = 2000; // Thời gian chờ giữa các bước mô phỏng (1 giây)
            executionTimer.Tick += ExecutionTimer_Tick;

            blinkTimer = new Timer();
            blinkTimer.Interval = 400; // Thời gian chuyển đổi giữa các trạng thái nhấp nháy (0.5 giây)
            blinkTimer.Tick += Timer2_Tick;
        }
        int check()
        {
            if (programTextBox.Text == "" || timeText.Text == "" || !Regex.IsMatch(timeText.Text, inputNumbers))
            {
                return 0;// không hợp lệ
            }
            else
            {
                return 1;
            }
        }
        int stt = 1;
        int td = 0;
        int s = 0;
        int s1 = 0;
        int thoigiantontai;
        int thoigiancho;
        float thoigiantontaitrungbinh = 0;
        float thoigianchotrungbinh = 0;
        int tontai(int thoigianthuchien)
        {
            int tgth = int.Parse(timeText.Text);
            s = s + tgth;
            thoigiantontai = s - td;
            return thoigiantontai;
        }
        int cho(int thoigianthuchien)
        {
            int tgth = int.Parse(timeText.Text);
            if (td == 0)
            {
                thoigiancho = 0;
                s1 = s1 + tgth;
            }
            else
            {
                thoigiancho = s1 - td;
                s1 = s1 + tgth;
            }
            return thoigiancho;
        }
        void addgvHienThi()
        {
            string tt = programTextBox.Text;
            string tgth = timeText.Text;
            dgvHienThi.Rows.Add(stt, tt, tgth, td);

            int tgcho = cho(int.Parse(tgth));
            int tgtontai = tontai(int.Parse(tgth));
            dgvTinh.Rows.Add(tt, tgcho, tgtontai);
            thoigiantontaitrungbinh = thoigiantontaitrungbinh + tgtontai;
            thoigianchotrungbinh = thoigianchotrungbinh + tgcho;
            lblCho.Text = (thoigianchotrungbinh / stt).ToString();
            lblTonTai.Text = (thoigiantontaitrungbinh / stt).ToString();
        }
        int tong = 0;
        private void addButton_Click(object sender, EventArgs e)
        {
            if (check() == 0)
            {
                DialogResult tb = MessageBox.Show("Chưa nhập đủ thông tin hoặc không hợp lệ, Nhập lại!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (tb == DialogResult.Yes)
                {
                    programTextBox.Focus();
                }
            }
            else
            {
                TextBox newTextBox = new TextBox();
                newTextBox.Text = programTextBox.Text + " (" + timeText.Text + "s)";
                newTextBox.Width = 100;
                waitingGroupBox.Controls.Add(newTextBox);
                // Bắt đầu nhấp nháy TextBox mới được thêm vào
                blinkTimer.Start();

                UpdateWaitingGroupBox();
                addgvHienThi();
                
                int i = int.Parse(timeText.Text);
                tong = tong + i;
                programTextBox.Text = "";
                timeText.Text = "";
                programTextBox.Focus();
                stt++;
                td++;
            }
        }
        private void simulateButton_Click(object sender, EventArgs e)
        {
            int s = 0;
            int maxXPosition = 0;
            int thoiGianThucHien = 0;
            int khoangCachX = 0; // Khoảng cách theo trục X
            int khoangCachY = 0; // Khoảng cách theo trục Y
            double pixelPerCm = 37.8;
            // Lặp qua từng dòng trong DataGridView
            foreach (DataGridViewRow row in dgvHienThi.Rows)
            {
                // Lấy thông tin từng cột trong dòng hiện tại
                if (row.Cells[1].Value != null)
                {
                        string tenTienTrinh = row.Cells["TienTrinh"].Value.ToString();
                        thoiGianThucHien = int.Parse(row.Cells["ThoiGianThucHien"].Value.ToString());
                        int thoiDiem = int.Parse(row.Cells["ThoiDiem"].Value.ToString());

                    // Tạo và cấu hình TextBox mới
                        TextBox textBox = new TextBox();
                        Font boldFont = new Font(textBox.Font, FontStyle.Bold);
                        textBox.Font = boldFont;
                        textBox.TextAlign = HorizontalAlignment.Center;
                        textBox.ReadOnly = true;
                        textBox.Dock = DockStyle.None;
                        textBox.Text = tenTienTrinh;
                        int textBoxWidth = (int)((thoiGianThucHien + thoiDiem) * pixelPerCm);
                        int textBoxHeight = 90;

                        textBox.Size = new Size(textBoxWidth, textBoxHeight);
                        textBox.BackColor = GetRandomColor();
                        textBox.Location = new Point(khoangCachX, khoangCachY);

                        khoangCachX += textBoxWidth + (int)(0.1 * pixelPerCm); // Khoảng cách giữa các TextBox
                        Label label1 = new Label();
                        label1.Text = s.ToString()+"s";
                        label1.AutoSize = true;
                        label1.Location = new Point(textBox.Left, textBox.Top + (textBoxHeight - label1.Height) / 2); // Đặt vị trí bên phải TextBox
                       
                        // Thêm TextBox vào Panel
                        GanttChartPanel.Controls.Add(textBox);
                        GanttChartPanel.Controls.Add(label1);

                        s += thoiGianThucHien;
                        int currentXPosition = textBox.Right;
                        if (currentXPosition > maxXPosition)
                        maxXPosition = currentXPosition;
                }

                khoangCachX += 1; // Khoảng cách theo trục Y giữa các hàng (25 là chiều cao dự định của TextBox)
                khoangCachY = 0;
            }
            lblTong.Text = tong.ToString()+ "s";
            lblTong.Location = new Point(maxXPosition - lblTong.Width, GanttChartPanel.Controls[GanttChartPanel.Controls.Count - 2].Bottom);

            // Đảm bảo label "lblTong" nằm trên đỉnh của TextBox cuối cùng
            GanttChartPanel.Controls.Add(lblTong);
            executionIndex = 0;
            executionTimer.Start();
           
            dgvTinh.Show();
            lblCho.Show();
            lblTonTai.Show();
            lbl1.Show();
            lbl2.Show();
        }
        Random random = new Random();
        private Color GetRandomColor()
        {
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
        private void UpdateWaitingGroupBox()
        {
            int yPos = 20;
            foreach (TextBox textBox in waitingGroupBox.Controls.OfType<TextBox>())
            {
                textBox.Location = new Point(20, yPos);
                yPos += 30;
            }
        }
        private void ExecutionTimer_Tick(object sender, EventArgs e)
        {
            if (waitingGroupBox.Controls.Count > 0)
            {
                TextBox programTextBox = (TextBox)waitingGroupBox.Controls[0];
                programTextBox.BackColor = Color.Aqua;

                executionGroupBox.Controls.Add(programTextBox);
                programTextBox.Location = new Point(20, executionGroupBox.Controls.Count * 30);

                waitingGroupBox.Controls.Remove(programTextBox);
            }
            else
            {
                executionTimer.Stop();
            }
        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (waitingGroupBox.Controls.Count > 0)
            {
                TextBox firstTextBox = (TextBox)waitingGroupBox.Controls[0];
                if (firstTextBox.BackColor == Color.Aqua)
                {
                    firstTextBox.BackColor = Color.White;
                }
                else
                {
                    firstTextBox.BackColor = Color.Aqua;
                }
            }
        }
        private void FCFS_Load(object sender, EventArgs e)
        {
            dgvTinh.Hide();
            lblCho.Hide();
            lblTonTai.Hide();
            lbl1.Hide();
            lbl2.Hide();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvHienThi.Rows.Clear();
            dgvTinh.Rows.Clear();
            GanttChartPanel.Controls.Clear();
            GanttChartPanel.Refresh();

            dgvTinh.Hide();
            lblCho.Text = "";
            lblTonTai.Text = "";
            lblCho.Hide();
            lblTonTai.Hide();
            lbl1.Hide();
            lbl2.Hide();

            List<TextBox> textBoxesToDelete = new List<TextBox>();
            foreach (Control control in executionGroupBox.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBoxesToDelete.Add(textBox);
                }
            }
            foreach (TextBox textBox in textBoxesToDelete)
            {
                executionGroupBox.Controls.Remove(textBox);
                textBox.Dispose(); 
            }
            List<TextBox> ToDelete = new List<TextBox>();
            foreach (Control control in waitingGroupBox.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBoxesToDelete.Add(textBox);
                }
            }
            foreach (TextBox textBox in textBoxesToDelete)
            {
                waitingGroupBox.Controls.Remove(textBox);
                textBox.Dispose();
            }
        }
    }
}

