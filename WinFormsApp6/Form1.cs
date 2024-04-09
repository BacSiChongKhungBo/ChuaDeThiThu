using BUS.Services;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        SinhvienService service;
        public Form1()
        {
            InitializeComponent();
            service = new SinhvienService();
        }

        private void btn_ThongBao_Click(object sender, EventArgs e)
        {
            //2 bước
            //B1: lất dữ liệu từ textbox
            //B2: hiển thị
            //b1:
            string thongdiep = txt_ThongDiep.Text;
            //b2:
            DialogResult traloi;
            traloi = MessageBox.Show("bạn chắc chưa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (traloi == DialogResult.Yes)
            {
                MessageBox.Show(thongdiep);
            }
            else
            {
                return;
            }

        }

        private void brn_Load_Click(object sender, EventArgs e)
        {
            //2 BƯỚC
            //B1: ADD DỮ LIỆU VÀO COMBOBOX
            //b2: SETTING HIỂN THỊ
            //B1:
            for (int i = 1; i <= 10; i++)
            {
                cmbx_So.Items.Add(i);
            }
            //b2:
            cmbx_So.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbx_So.SelectedIndex = 0;
        }

        private void btn_Ghi_Click(object sender, EventArgs e)
        {
            //4 bước
            //B1: Path
            string path = "data.txt"; //ko cần quan tâm file ở đâu
            //B2: FileStream : FileMode Create ít lỗi nhất
            FileStream fs = new FileStream(path, FileMode.Create);
            //B3: StreamWriter
            StreamWriter sw = new StreamWriter(fs);
            //B4: Ghi File
            sw.Write(rtxt_NoiDung.Text);
            //đóng luồng sw trước, fs sau
            sw.Close();
            fs.Close();
            MessageBox.Show("Ghi file thành công");
        }

        private void btn_Doc_Click(object sender, EventArgs e)
        {
            string path = "data.txt";
            //đọc thì fs có filemode là Open
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            rtxt_NoiDung.Text = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            MessageBox.Show("Đọc Thành Công");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        public void LoadGrid()
        {
            //tạo stt
            int stt = 1;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Tên";
            dataGridView1.Columns[2].Name = "Ngành";
            dataGridView1.Columns[3].Name = "Giới Tính";
            dataGridView1.Rows.Clear();
            foreach (var item in service.GetSinhviens())
            {
                dataGridView1.Rows.Add(stt++, item.Ten, item.Nganh, item.Gioitinh == true ? "Nam" : "Nữ");
            }
        }
    }
}
