namespace WinFormsApp6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            cmbx_So = new ComboBox();
            txt_ThongDiep = new TextBox();
            brn_Load = new Button();
            btn_ThongBao = new Button();
            btn_Doc = new Button();
            btn_Ghi = new Button();
            rtxt_NoiDung = new RichTextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbx_So);
            groupBox1.Controls.Add(txt_ThongDiep);
            groupBox1.Controls.Add(brn_Load);
            groupBox1.Controls.Add(btn_ThongBao);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 187);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // cmbx_So
            // 
            cmbx_So.FormattingEnabled = true;
            cmbx_So.Location = new Point(24, 133);
            cmbx_So.Name = "cmbx_So";
            cmbx_So.Size = new Size(253, 23);
            cmbx_So.TabIndex = 3;
            // 
            // txt_ThongDiep
            // 
            txt_ThongDiep.Location = new Point(24, 70);
            txt_ThongDiep.Name = "txt_ThongDiep";
            txt_ThongDiep.Size = new Size(253, 23);
            txt_ThongDiep.TabIndex = 2;
            // 
            // brn_Load
            // 
            brn_Load.Location = new Point(202, 28);
            brn_Load.Name = "brn_Load";
            brn_Load.Size = new Size(75, 23);
            brn_Load.TabIndex = 1;
            brn_Load.Text = "Load";
            brn_Load.UseVisualStyleBackColor = true;
            brn_Load.Click += brn_Load_Click;
            // 
            // btn_ThongBao
            // 
            btn_ThongBao.Location = new Point(24, 28);
            btn_ThongBao.Name = "btn_ThongBao";
            btn_ThongBao.Size = new Size(75, 23);
            btn_ThongBao.TabIndex = 0;
            btn_ThongBao.Text = "Thông báo";
            btn_ThongBao.UseVisualStyleBackColor = true;
            btn_ThongBao.Click += btn_ThongBao_Click;
            // 
            // btn_Doc
            // 
            btn_Doc.Location = new Point(40, 253);
            btn_Doc.Name = "btn_Doc";
            btn_Doc.Size = new Size(75, 23);
            btn_Doc.TabIndex = 1;
            btn_Doc.Text = "Đọc";
            btn_Doc.UseVisualStyleBackColor = true;
            btn_Doc.Click += btn_Doc_Click;
            // 
            // btn_Ghi
            // 
            btn_Ghi.Location = new Point(209, 252);
            btn_Ghi.Name = "btn_Ghi";
            btn_Ghi.Size = new Size(75, 23);
            btn_Ghi.TabIndex = 2;
            btn_Ghi.Text = "Ghi";
            btn_Ghi.UseVisualStyleBackColor = true;
            btn_Ghi.Click += btn_Ghi_Click;
            // 
            // rtxt_NoiDung
            // 
            rtxt_NoiDung.Location = new Point(36, 311);
            rtxt_NoiDung.Name = "rtxt_NoiDung";
            rtxt_NoiDung.Size = new Size(248, 96);
            rtxt_NoiDung.TabIndex = 3;
            rtxt_NoiDung.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(444, 26);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(444, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(344, 150);
            dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(rtxt_NoiDung);
            Controls.Add(btn_Ghi);
            Controls.Add(btn_Doc);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_ThongBao;
        private ComboBox cmbx_So;
        private TextBox txt_ThongDiep;
        private Button brn_Load;
        private Button btn_Doc;
        private Button btn_Ghi;
        private RichTextBox rtxt_NoiDung;
        private Button button1;
        private DataGridView dataGridView1;
    }
}
