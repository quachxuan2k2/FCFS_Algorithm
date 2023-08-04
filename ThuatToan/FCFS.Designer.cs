
namespace ThuatToan
{
    partial class FCFS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addButton = new System.Windows.Forms.Button();
            this.programTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.simulateButton = new System.Windows.Forms.Button();
            this.waitingGroupBox = new System.Windows.Forms.GroupBox();
            this.executionGroupBox = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.timeText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblTonTai = new System.Windows.Forms.Label();
            this.lblCho = new System.Windows.Forms.Label();
            this.dgvTinh = new System.Windows.Forms.DataGridView();
            this.tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgtt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHienThi = new System.Windows.Forms.DataGridView();
            this.st = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianThucHien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.GanttChartPanel = new System.Windows.Forms.Panel();
            this.lb = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
            this.GanttChartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(349, 83);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(84, 30);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "thêm";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // programTextBox
            // 
            this.programTextBox.BackColor = System.Drawing.Color.White;
            this.programTextBox.Location = new System.Drawing.Point(204, 85);
            this.programTextBox.Multiline = true;
            this.programTextBox.Name = "programTextBox";
            this.programTextBox.Size = new System.Drawing.Size(118, 25);
            this.programTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "nhập tên tiến trình:";
            // 
            // simulateButton
            // 
            this.simulateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simulateButton.Location = new System.Drawing.Point(458, 83);
            this.simulateButton.Name = "simulateButton";
            this.simulateButton.Size = new System.Drawing.Size(89, 32);
            this.simulateButton.TabIndex = 3;
            this.simulateButton.Text = "mô phỏng";
            this.simulateButton.UseVisualStyleBackColor = true;
            this.simulateButton.Click += new System.EventHandler(this.simulateButton_Click);
            // 
            // waitingGroupBox
            // 
            this.waitingGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.waitingGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitingGroupBox.Location = new System.Drawing.Point(80, 204);
            this.waitingGroupBox.Name = "waitingGroupBox";
            this.waitingGroupBox.Size = new System.Drawing.Size(177, 255);
            this.waitingGroupBox.TabIndex = 4;
            this.waitingGroupBox.TabStop = false;
            this.waitingGroupBox.Text = "Hàng đợi";
            // 
            // executionGroupBox
            // 
            this.executionGroupBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.executionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executionGroupBox.Location = new System.Drawing.Point(372, 204);
            this.executionGroupBox.Name = "executionGroupBox";
            this.executionGroupBox.Size = new System.Drawing.Size(172, 255);
            this.executionGroupBox.TabIndex = 5;
            this.executionGroupBox.TabStop = false;
            this.executionGroupBox.Text = "Thực hiện";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.ExecutionTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thời gian thực hiện:";
            // 
            // timeText
            // 
            this.timeText.Location = new System.Drawing.Point(204, 129);
            this.timeText.Multiline = true;
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(118, 28);
            this.timeText.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tính bằng giây (S)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(132, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(408, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "mô phỏng thuật toán First Come First Served (FCFS)";
            // 
            // Timer2
            // 
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(652, 428);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(184, 15);
            this.lbl1.TabIndex = 11;
            this.lbl1.Text = "Thời gian tồn tại trung bình:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(652, 457);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(167, 15);
            this.lbl2.TabIndex = 12;
            this.lbl2.Text = "Thời gian chờ trung bình:";
            // 
            // lblTonTai
            // 
            this.lblTonTai.AutoSize = true;
            this.lblTonTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTonTai.Location = new System.Drawing.Point(848, 430);
            this.lblTonTai.Name = "lblTonTai";
            this.lblTonTai.Size = new System.Drawing.Size(0, 15);
            this.lblTonTai.TabIndex = 13;
            // 
            // lblCho
            // 
            this.lblCho.AutoSize = true;
            this.lblCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCho.Location = new System.Drawing.Point(848, 457);
            this.lblCho.Name = "lblCho";
            this.lblCho.Size = new System.Drawing.Size(0, 15);
            this.lblCho.TabIndex = 14;
            // 
            // dgvTinh
            // 
            this.dgvTinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tt,
            this.tgc,
            this.tgtt});
            this.dgvTinh.Location = new System.Drawing.Point(655, 249);
            this.dgvTinh.Name = "dgvTinh";
            this.dgvTinh.Size = new System.Drawing.Size(335, 162);
            this.dgvTinh.TabIndex = 15;
            // 
            // tt
            // 
            this.tt.HeaderText = "Tiến trình";
            this.tt.Name = "tt";
            this.tt.Width = 92;
            // 
            // tgc
            // 
            this.tgc.HeaderText = "Thời gian chờ";
            this.tgc.Name = "tgc";
            // 
            // tgtt
            // 
            this.tgtt.HeaderText = "Thời gian tồn tại";
            this.tgtt.Name = "tgtt";
            // 
            // dgvHienThi
            // 
            this.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.st,
            this.TienTrinh,
            this.ThoiGianThucHien,
            this.ThoiDiem});
            this.dgvHienThi.Location = new System.Drawing.Point(655, 43);
            this.dgvHienThi.Name = "dgvHienThi";
            this.dgvHienThi.Size = new System.Drawing.Size(335, 182);
            this.dgvHienThi.TabIndex = 16;
            // 
            // st
            // 
            this.st.HeaderText = "STT";
            this.st.Name = "st";
            this.st.ReadOnly = true;
            this.st.Width = 50;
            // 
            // TienTrinh
            // 
            this.TienTrinh.HeaderText = "Tiến trình";
            this.TienTrinh.Name = "TienTrinh";
            this.TienTrinh.Width = 78;
            // 
            // ThoiGianThucHien
            // 
            this.ThoiGianThucHien.HeaderText = "Thời gian thực hiện";
            this.ThoiGianThucHien.Name = "ThoiGianThucHien";
            this.ThoiGianThucHien.Width = 80;
            // 
            // ThoiDiem
            // 
            this.ThoiDiem.HeaderText = "Thời điểm";
            this.ThoiDiem.Name = "ThoiDiem";
            this.ThoiDiem.ReadOnly = true;
            this.ThoiDiem.Width = 84;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(458, 127);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 32);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // GanttChartPanel
            // 
            this.GanttChartPanel.AutoScroll = true;
            this.GanttChartPanel.AutoScrollMargin = new System.Drawing.Size(4000, 0);
            this.GanttChartPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GanttChartPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.GanttChartPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GanttChartPanel.Controls.Add(this.lblTong);
            this.GanttChartPanel.Location = new System.Drawing.Point(80, 496);
            this.GanttChartPanel.Name = "GanttChartPanel";
            this.GanttChartPanel.Size = new System.Drawing.Size(910, 89);
            this.GanttChartPanel.TabIndex = 18;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(80, 476);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(65, 17);
            this.lb.TabIndex = 19;
            this.lb.Text = "Thể hiện";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(863, 46);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(0, 13);
            this.lblTong.TabIndex = 0;
            // 
            // FCFS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 616);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.GanttChartPanel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgvHienThi);
            this.Controls.Add(this.dgvTinh);
            this.Controls.Add(this.lblCho);
            this.Controls.Add(this.lblTonTai);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.executionGroupBox);
            this.Controls.Add(this.waitingGroupBox);
            this.Controls.Add(this.simulateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.programTextBox);
            this.Controls.Add(this.addButton);
            this.Name = "FCFS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quách Thị Thanh Xuân - 2000755 - CNT1";
            this.Load += new System.EventHandler(this.FCFS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
            this.GanttChartPanel.ResumeLayout(false);
            this.GanttChartPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox programTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button simulateButton;
        private System.Windows.Forms.GroupBox executionGroupBox;
        public System.Windows.Forms.GroupBox waitingGroupBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timeText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer Timer2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblTonTai;
        private System.Windows.Forms.Label lblCho;
        private System.Windows.Forms.DataGridView dgvTinh;
        private System.Windows.Forms.DataGridView dgvHienThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn st;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianThucHien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgtt;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel GanttChartPanel;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lblTong;
    }
}

