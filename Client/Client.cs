using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;



namespace OngQuan
{

    public enum enumBen
    {
        Do = 0,
        Xanh = 1
    }

    public enum enumHuong
    {
        CungChieuKimDongHo = 0,
        NguocChieuKimDongHo = 1
    }

    public struct KichCo
    {
        public const int Sodem = 2;
        public const int SoTuong = 2;
        public const int SoO = 5;
        public const int SoLinhTrenO = 5;
        public const int GiaTuong = 10;
        public const int GiaLinh = 1;
        public const int NLinh = 5;
        public const int ChuVi = 12;
    }

    public partial class frmOngQuan : Form
    {

        IPEndPoint IP;
        Socket client;
        int[] MangLinh = new int[12]; //Khởi tạo mảng lính
        int[] MangQuan = new int[2]; //Khởi tạo mảng Quan
        public string message;

        //Khai báo các biến cần thiết để set up thời gian
        public static int COOL_DOWN_STEP = 100;
        public static int COOL_DOWN_TIME = 10000;
        public static int COOL_DOWN_INTERVAL = 100;

        //Khai báo các dữ liệu tĩnh để tạo khung
        private static int CellLeft = 5;
        private static int CellTop = 30;
        private static int CellWidth = 105;
        private static int CellHeight = 125;
        private static int DoubleHeight = CellHeight * 2;
        private enumBen BenDi = enumBen.Do;
        private bool DaChonLinh = false;
        private int ViTriXuatPhat = 0;
        private int ViTriKeTiep = 0;
        private int SoLinhDangDi = 0;
        private enumHuong HuongDangDi = enumHuong.CungChieuKimDongHo;
        private int[] SoTuongDuoc = new int[2] { 0, 0 };
        private int[] SoLinhDuoc = new int[2] { 0, 0 };
        private int SoLinhMoiO = KichCo.SoLinhTrenO;


        public frmOngQuan()
        {
            CheckForIllegalCrossThreadCalls = false;
            Connect();
            InitializeComponent();
            Connectchat();

        }

        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
                MessageBox.Show("Kết nối thành công!");
            }
            catch
            {
                MessageBox.Show("Không thể kết nối server!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }
        public void Send(int[] SoTuong)
        {
            client.Send(Serialize(SoTuong));
        }
        //Nhận được dữ liệu và cập nhật button khi bên Server di chuyển
        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] dataLinh = new byte[1024 * 5000];
                    client.Receive(dataLinh);
                    MangLinh = (int[])Deserialize(dataLinh); //Nhận được dữ liệu mảng lính

                    byte[] dataQuan = new byte[1024 * 5000];
                    client.Receive(dataQuan);
                    MangQuan = (int[])Deserialize(dataQuan);  //Nhận được dữ liệu mảng Quan

                                VeQuan(MangLinh, MangQuan);  // Vẽ các button dựa vào mảng Lính và mảng quan theo số sỏi di chuyển 
                                DoiBen();  // Chơi giữa 2 tab và đổi lượt đi 2 bên
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        public void ThietLapLinh()
        {
            ToaDo td1 = new ToaDo(0, 0, 0); //Quan trái
            MangLinh[0] = SoLinhCoMat(td1);

            ToaDo td2 = new ToaDo(0, 1, 0); //Quan phải
            MangLinh[1] = SoLinhCoMat(td2);

            ToaDo td3 = new ToaDo(1, 0, 0); //Lính trên ô thứ nhất
            MangLinh[2] = SoLinhCoMat(td3);

            ToaDo td4 = new ToaDo(1, 0, 1); //Lính trên ô thứ hai
            MangLinh[3] = SoLinhCoMat(td4);

            ToaDo td5 = new ToaDo(1, 0, 2); //Lính trên ô thứ ba
            MangLinh[4] = SoLinhCoMat(td5);

            ToaDo td6 = new ToaDo(1, 0, 3); //Lính trên ô thứ bốn
            MangLinh[5] = SoLinhCoMat(td6);

            ToaDo td7 = new ToaDo(1, 0, 4); //Lính trên ô thứ năm
            MangLinh[6] = SoLinhCoMat(td7);

            ToaDo td8 = new ToaDo(1, 1, 4); //Lính dưới ô thứ nhất
            MangLinh[7] = SoLinhCoMat(td8);

            ToaDo td9 = new ToaDo(1, 1, 3); //Lính dưới ô thứ hai
            MangLinh[8] = SoLinhCoMat(td9);

            ToaDo td10 = new ToaDo(1, 1, 2); //Lính dưới ô thứ ba
            MangLinh[9] = SoLinhCoMat(td10);

            ToaDo td11 = new ToaDo(1, 1, 1); //Lính dưới ô thứ bốn
            MangLinh[10] = SoLinhCoMat(td11);

            ToaDo td12 = new ToaDo(1, 1, 0); //Lính dưới ô thứ năm
            MangLinh[11] = SoLinhCoMat(td12);
        }

        public void ThietLapQuan()
        {
            ToaDo td1 = new ToaDo(0, 0, 0); //Quan trái
            MangQuan[0] = SoTuongCoMat(td1);

            ToaDo td2 = new ToaDo(0, 1, 0); //Quan phải
            MangQuan[1] = SoTuongCoMat(td2);
        }
        public void VeQuan(int[] MangLinh, int[] MangQuan)
        {
            VeSoOTuong(enumBen.Do, MangQuan[0], MangLinh[0]); // Vẽ quan trái

            VeSoOTuong(enumBen.Xanh, MangQuan[1], MangLinh[1]); // Vẽ quan phải

            VeSoOLinh(enumBen.Do, 0, MangLinh[2]); //Vẽ lính trên ô thứ nhất

            VeSoOLinh(enumBen.Do, 1, MangLinh[3]); //Vẽ lính trên ô thứ hai

            VeSoOLinh(enumBen.Do, 2, MangLinh[4]); //Vẽ lính trên ô thứ ba

            VeSoOLinh(enumBen.Do, 3, MangLinh[5]); //Vẽ lính trên ô thứ bốn

            VeSoOLinh(enumBen.Do, 4, MangLinh[6]); //Vẽ lính trên ô thứ năm

            VeSoOLinh(enumBen.Xanh, 0, MangLinh[11]); //Vẽ lính dưới ô thứ nhất

            VeSoOLinh(enumBen.Xanh, 1, MangLinh[10]); //Vẽ lính trên ô thứ hai

            VeSoOLinh(enumBen.Xanh, 2, MangLinh[9]); //Vẽ lính trên ô thứ ba

            VeSoOLinh(enumBen.Xanh, 3, MangLinh[8]); //Vẽ lính trên ô thứ bốn

            VeSoOLinh(enumBen.Xanh, 4, MangLinh[7]); //Vẽ lính trên ô thứ năm
        }


        //Chuyển đổi định dạng dữ liệu để truyền
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }

        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }

        //Tạo khung bàn cờ
        private void Form1_Load(object sender, EventArgs e)
        {
            TaoKhungBanCo();
        }

        private string TenBen(enumBen ben)
        {
            if (ben == enumBen.Do)
                return "đỏ";
            else
                return "xanh";
        }

        private void TaoKhungTuong(enumBen ben)
        {
            Button btn = new Button();
            btn.Location = new Point(CellLeft + (int)ben * CellWidth * (KichCo.SoO + 1), CellTop); //Tọa độ của các btn ô quan
            btn.Size = new Size(CellWidth, DoubleHeight); //Tạo size ô quan
            btn.ImageList = imgDoublee;                    // Add image button theo từng trường hợp số sỏi trên mỗi ô
            btn.ImageKey = "BanNguyet" + ((ben == enumBen.Do) ? "Trai" : "Phai") + ".bmp";  // Trả về tên ảnh nếu Đỏ là khung quan bên trái  
            btn.Name = "BanNguyet" + ((int)ben).ToString("0");
            btn.Click += new EventHandler(btnTuong);    //Xử lí event
            Controls.Add(btn);     //Điều khiển tùy chọn click vào button

        }

        private void TaoKhungLinh(enumBen ben, int col)
        {
            Button btn = new Button();
            btn.Location = new Point(CellLeft + CellWidth * (col + 1), CellTop + (int)ben * CellHeight);//Tọa độ các btn ô lính 
            btn.Size = new Size(CellWidth, CellHeight);    // Tạo size ô lính
            btn.ImageList = ImgSingle;                 // Xem mỗi ô là 1 button để vẽ ảnh theo số sỏi mỗi ô
            btn.ImageKey = "KhungLinh" + ((int)ben).ToString("0") + "00.bmp";   //Trả về khung lính tên ảnh nếu 0 là Đỏ , 1 là Xanh
            btn.Name = "btn" + ((int)ben).ToString() + col.ToString("0");
            btn.Click += new EventHandler(btnLinh_Click);       //Xử lí event
            Controls.Add(btn);          //Điều khiển tùy chọn click vào button

        }

        private void VeSoOTuong(enumBen ben, int Sotuong, int Solinh)
        {
            //Add hình 2 ô quan đã vẽ tương ứng với 1 ô coi như là 1 button
            Button btn = (Button)Controls["BanNguyet" + ((int)ben).ToString()];
            btn.ImageKey = "BanNguyet" + ((ben == enumBen.Do) ? "Trai" : "Phai") + Sotuong.ToString("0") + Solinh.ToString("00") + ".bmp";
        }

        private void VeSoOLinh(enumBen ben, int col, int Solinh)
        {
            //Add hình các ô lính và cũng coi như là 1 button
            Button btn = (Button)Controls["btn" + ((int)ben).ToString() + col.ToString("0")];
            btn.ImageKey = "KhungLinh" + ((int)ben).ToString("0") + Solinh.ToString("00") + ".bmp";
        }

        private void TaoKhungBanCo()
        {
            //Tạo chiều dài và chiều rộng khung bàn cờ
            Width = CellLeft + CellWidth * (KichCo.SoO + 2) + 15 + 480;
            Height = CellTop + CellHeight * 2 + 30 + statusStrip1.Height + 150;
            foreach (enumBen ben in new enumBen[] { enumBen.Do, enumBen.Xanh })
            {
               // Vẽ ô quan cho mỗi bên xanh hoặc đỏ khởi tạo ban đầu có số quan 1 và số lính là 0
                TaoKhungTuong(ben);
                VeSoOTuong(ben, 1, 0);
                for (int col = 0; col <= KichCo.SoO - 1; col++)
                {
                    //Tạo khung lính theo 2 bên cho mỗi cột
                    TaoKhungLinh(ben, col);
                    //Vẽ số ô lính cho 2 bên
                    VeSoOLinh(ben, col, SoLinhMoiO);
                }
            }
            //Tạo trạng thái thanh thời gian của mỗi bên
            prcbCoolDown.Step = COOL_DOWN_STEP;
            prcbCoolDown.Maximum = COOL_DOWN_TIME;
            prcbCoolDown.Value = 0;
            tmCoolDown.Interval = COOL_DOWN_INTERVAL;
            tmCoolDown.Start();
            statusStrip1.Items[4].Text = "Bắt đầu";
        }

        //Set up mỗi tab có 1 lần di chuyển , nếu tab bên đỏ đi rồi sẽ đến lượt bên xanh đi và ngược lại
        private void DoiBen()
        {
            BenDi = ((BenDi == enumBen.Do) ? enumBen.Xanh : enumBen.Do);
            DaChonLinh = false;
            enumBen ben = new enumBen();
            if (KiemCon2Bien() == false) ThuHoiTanQuan(ben); KiemConLinh();
        }

        //Click button di chuyển sang trái hay sang phải sẽ rải sỏi thêm mỗi button 1 viên và đếm trong button đó có bao nhiêu
        private void TangLenMot(ToaDo td)
        {
            if (td.TuongLinh == 0)
            {
                Button btn = (Button)Controls["BanNguyet" + td.TrenDuoi.ToString("0")];
                int SoTuong = int.Parse(btn.ImageKey.Substring(13, 1));
                int SoLinh = int.Parse(btn.ImageKey.Substring(14, 2));
                btn.ImageKey = "BanNguyet" + ((td.TrenDuoi == 0) ? "Trai" : "Phai") + SoTuong.ToString("0") + (SoLinh + 1).ToString("00") + ".bmp";
            }
            else
            {
                Button btn = (Button)Controls["btn" + td.TrenDuoi.ToString("0") + td.Cot.ToString("0")];
                int SoLinh = int.Parse(btn.ImageKey.Substring(10, 2));
                btn.ImageKey = "KhungLinh" + td.TrenDuoi.ToString("0") + (SoLinh + 1).ToString("00") + ".bmp";
            }
        }

        //Hiển thị số sỏi Quan cho các hàm thiết lập và để tính điểm
        private int SoTuongCoMat(ToaDo td)
        {
            if (td.TuongLinh == 0)
            {
                Button btn = (Button)Controls["BanNguyet" + td.TrenDuoi.ToString("0")];
                return int.Parse(btn.ImageKey.Substring(13, 1));
            }
            else
                return 0;
        }

        //Hiển thị số sỏi Lính cho các hàm thiết lập và để tính điểm
        private int SoLinhCoMat(ToaDo td)
        {
            if (td.TuongLinh == 0)
            {
                Button btn = (Button)Controls["BanNguyet" + td.TrenDuoi.ToString("0")];
                return int.Parse(btn.ImageKey.Substring(14, 2));
            }
            else
            {
                Button btn = (Button)Controls["btn" + td.TrenDuoi.ToString("0") + td.Cot.ToString("0")];
                return int.Parse(btn.ImageKey.Substring(10, 2));
            }
        }

        private void VongLap()
        {
            //Chọn hướng đi bên trái hay bên phải tương ứng với cùng chiều hay ngược chiều kim đồng hồ
            HuongDangDi = (ViTriKeTiep == (ViTriXuatPhat + 1) % KichCo.ChuVi) ? enumHuong.CungChieuKimDongHo : enumHuong.NguocChieuKimDongHo;
            QuyDao qd = new QuyDao(ViTriXuatPhat, HuongDangDi);
            for (int i = 1; i <= SoLinhDangDi; i++)
            {
                //Khi di chuyển ra sẽ rải mỗi ô 1 viên và tăng lên một đơn vị
                TangLenMot(qd[i]);
            }
            ToaDo OTiepSuc = qd[SoLinhDangDi + 1];
            if (OTiepSuc.TuongLinh != 0)
            {
                int solinhtiep = SoLinhCoMat(OTiepSuc);
                if (solinhtiep > 0)
                {

                    //Kiểm tra hướng đi nếu đi bên phải tương ứng cùng chiều 
                    if (HuongDangDi == enumHuong.CungChieuKimDongHo)
                    {
                        ViTriXuatPhat = (ViTriXuatPhat + SoLinhDangDi + 1) % KichCo.ChuVi;
                        ViTriKeTiep = (ViTriKeTiep + SoLinhDangDi + 1) % KichCo.ChuVi;
                    }
                    //Ngược lại hướng đi nếu đi bêntrái tương ứng ngược chiều 
                    else
                    {
                        ViTriXuatPhat = (ViTriXuatPhat + KichCo.ChuVi - SoLinhDangDi - 1) % KichCo.ChuVi;
                        ViTriKeTiep = (ViTriKeTiep + KichCo.ChuVi - SoLinhDangDi - 1) % KichCo.ChuVi;
                    }
                    enumBen ben = (enumBen)qd[SoLinhDangDi + 1].TrenDuoi;
                    int col = qd[SoLinhDangDi + 1].Cot;
                    SoLinhDangDi = solinhtiep; // Tận thu chiến lợi phẩm
                    VeSoOLinh(ben, col, 0); //Vẽ lại ô lính sau khi tính dược ô kế tiếp tương ứng hình ảnh 
                    VongLap(); // Gọi đệ quy
                }

                else
                {
                    //Kiểm tra số sỏi Quan và số sỏi Lính có mặt để thực hiện các hàm tính toán
                    if (SoTuongCoMat(qd[SoLinhDangDi + 2]) > 0 || SoLinhCoMat(qd[SoLinhDangDi + 2]) > 0)
                    {
                        bool TiepTucThu = false;
                        do
                        {
                            // Hiển thị chiến lợi phẩm sau mỗi lần ăn được
                            statusStrip1.Items[4].Text = "Bên " + TenBen(BenDi) + " thu chiến lợi phẩm " + SoTuongCoMat(qd[SoLinhDangDi + 2]) + " tướng " + SoLinhCoMat(qd[SoLinhDangDi + 2]) + " lính";
                            SoTuongDuoc[(int)BenDi] += SoTuongCoMat(qd[SoLinhDangDi + 2]);
                            SoLinhDuoc[(int)BenDi] += SoLinhCoMat(qd[SoLinhDangDi + 2]);
                            // Hiển thị bên Xanh , bên Đỏ có số điểm Quan và điểm Lính 
                            statusStrip1.Items[(int)BenDi * 2].Text = TenBen(BenDi) + ": " + SoTuongDuoc[(int)BenDi].ToString() + ", " + SoLinhDuoc[(int)BenDi].ToString();
                            enumBen ben = (enumBen)qd[SoLinhDangDi + 2].TrenDuoi;
                            int col = qd[SoLinhDangDi + 2].Cot;
                            if (qd[SoLinhDangDi + 2].TuongLinh == 0) VeSoOTuong(ben, 0, 0); VeSoOLinh(ben, col, 0);
                            if (qd[SoLinhDangDi + 3].TuongLinh != 0 && SoLinhCoMat(qd[SoLinhDangDi + 3]) == 0 && (SoTuongCoMat(qd[SoLinhDangDi + 4]) > 0 || SoLinhCoMat(qd[SoLinhDangDi + 4]) > 0))
                            {
                                //Kiểm tra hướng đi nếu đi bên phải tương ứng cùng chiều 
                                if (HuongDangDi == enumHuong.CungChieuKimDongHo)
                                {
                                    ViTriXuatPhat = (ViTriXuatPhat + SoLinhDangDi + 2) % KichCo.ChuVi;
                                    ViTriKeTiep = (ViTriKeTiep + SoLinhDangDi + 2) % KichCo.ChuVi;
                                }
                                //Ngược lại hướng đi nếu đi bêntrái tương ứng ngược chiều 
                                else
                                {
                                    ViTriXuatPhat = (ViTriXuatPhat + KichCo.ChuVi - SoLinhDangDi - 2) %
                                    KichCo.ChuVi;
                                    ViTriKeTiep = (ViTriKeTiep + KichCo.ChuVi - SoLinhDangDi - 2) %
                                    KichCo.ChuVi;
                                }
                                HuongDangDi = (ViTriKeTiep == (ViTriXuatPhat + 1) % KichCo.ChuVi)
                                ? enumHuong.CungChieuKimDongHo : enumHuong.NguocChieuKimDongHo;
                                qd = new QuyDao(ViTriXuatPhat, HuongDangDi); //Khởi tạo và Thực hiện tiếp quỹ đạo di chuyển 
                                SoLinhDangDi = 0; // Tận thu chiến lợi phẩm
                            }
                            else TiepTucThu = false;
                        }
                        while (TiepTucThu);
                    }
                    DoiBen();
                }
            }
            else
            {
                SoLinhDangDi = 0;
                DoiBen();
            }
        }

        //Dựa vào button 2 ô quan để tính điểm 
        private bool KiemCon2Bien()
        {
            int TriGia = 0;
            for (int ben = 0; ben < 2; ben++)
            {
                Button btn = (Button)Controls["BanNguyet" + ben.ToString("0")];
                int SoTuong = int.Parse(btn.ImageKey.Substring(13, 1));
                int SoLinh = int.Parse(btn.ImageKey.Substring(14, 2));
                TriGia += SoTuong * GiaTuong() + SoLinh * KichCo.GiaLinh;
            }
            return (TriGia > 0);
        }

        //Tính điểm viên sỏi Quan
        private int GiaTuong()
        {
            return int.Parse(mnuSoLinhO.Text) * 2 * KichCo.GiaLinh;
        }

        //Tính toán trên mỗi ô Lính khi rải sỏi sẽ đếm số lượng sỏi trong ô 
        private void KiemConLinh()
        {
            foreach (enumBen ben in new enumBen[] { enumBen.Do, enumBen.Xanh })
            {
                int SoLinhBen = 0;
                for (int col = 0; col < KichCo.SoO; col++)
                    SoLinhBen += SoLinhCoMat(new ToaDo(1, (int)ben, col));
                if (SoLinhBen == 0)
                    RaMoiO1Linh(ben);
            }
        }
        //Nếu 2 ô quan vẫn còn sỏi mà ô lính hết thì người chơi đến lượt bên nào phải lấy sỏi của mình để rải ra button
        private void RaMoiO1Linh(enumBen ben)
        {
            for (int col = 0; col < KichCo.SoO; col++)
                VeSoOLinh(ben, col, 1);
            SoLinhDuoc[(int)ben] -= KichCo.SoO;
            statusStrip1.Items[4].Text = "Bên " + ben.ToString() + " phải ra " + KichCo.SoO + " lính";
        }

        //Tính điểm mỗi bên số quan , số lính ăn được
        private int SoDiem(enumBen ben)
        {
            return SoTuongDuoc[(int)ben] * GiaTuong() + SoLinhDuoc[(int)ben] * KichCo.GiaLinh;
        }

        //Kết quả tổng kết số điểm ăn được
        private void KetQuaThangThua()
        {
            string ThongBao = "Bên " + TenBen(enumBen.Do) + " có " + SoDiem(enumBen.Do).ToString() + " điểm\n" + "Bên " + TenBen(enumBen.Xanh) + " có " + SoDiem(enumBen.Xanh).ToString() + " điểm\n";
            if (SoDiem(enumBen.Do) != SoDiem(enumBen.Xanh))
                ThongBao += "Bên "
                + ((SoDiem(enumBen.Do) > SoDiem(enumBen.Xanh)) ? TenBen(enumBen.Do) : TenBen(enumBen.Xanh))
                + " thắng " + Math.Abs(SoDiem(enumBen.Do) - SoDiem(enumBen.Xanh)) + " điểm";
            else
                ThongBao += "Hai bên hòa nhau";
            MessageBox.Show(ThongBao, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            enumBen ben = new enumBen();
            DoiBanMoi(ben);
        }

        private void ThuHoiTanQuan(enumBen Ben)
        {
            int[] SoLinhBen = new int[2] { 0, 0 }; // Tạo mảng để thực hiện tính toán và vẽ ô lính 
            foreach (enumBen ben in new enumBen[] { enumBen.Do, enumBen.Xanh })
            {
                for (int col = 0; col < KichCo.SoO; col++)
                {
                    SoLinhBen[(int)ben] += SoLinhCoMat(new ToaDo(1, (int)ben, col));
                    //Vẽ lại ô lính sau khi cập nhật số lính có mặt
                    VeSoOLinh(ben, col, 0);
                }
                SoLinhDuoc[(int)ben] += SoLinhBen[(int)ben];
                statusStrip1.Items[(int)ben * 2].Text = TenBen(ben) + ": " + SoTuongDuoc[(int)ben].ToString()
                + ", " + SoLinhDuoc[(int)ben].ToString();
            }
            //Tổng kết kết quả 2 bên số điểm 
            statusStrip1.Items[4].Text = "Kết thúc bên "
            + TenBen(enumBen.Do) + " thu hồi " + SoLinhBen[(int)enumBen.Do] + " lính, "
            + TenBen(enumBen.Xanh) + " thu hồi " + SoLinhBen[(int)enumBen.Xanh] + " lính.";
            KetQuaThangThua();
        }

        //Khi có message thông báo kết thúc , tổng kết kết quả thì sẽ refresh lại bàn cờ và đổi bên đi trước
        private void DoiBanMoi(enumBen Ben)
        {
            foreach (enumBen ben in new enumBen[] { enumBen.Do, enumBen.Xanh })
            {
                for (int col = 0; col < KichCo.SoO; col++)
                    VeSoOLinh(ben, col, SoLinhMoiO);
                VeSoOTuong(ben, 1, 0);
                SoTuongDuoc[(int)ben] = 0;
                SoLinhDuoc[(int)ben] = 0;
                statusStrip1.Items[(int)ben * 2].Text = TenBen(ben);
            }
            statusStrip1.Items[4].Text = "Bên " + TenBen(BenDi) + " bắt đầu ...";
        }

        //Thực hiện các thao tác trên ô Lính ta coi như 1 button 
        private void btnLinh_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            enumBen ben = (enumBen)int.Parse(btn.Name.Substring(3, 1));
            if (ben == enumBen.Xanh)
                if (!DaChonLinh)
                { 
                    // Chọn ô xuất phát
                    DaChonLinh = true;
                    int col = int.Parse(btn.Name.Substring(4, 1));      
                    int SoLinh = int.Parse(btn.ImageKey.Substring(10, 2));
                    // Ta sẽ tính toán vị trí xuất phát dựa vào số cột chọn
                    ViTriXuatPhat = ben == enumBen.Do ? (1 + col) : (KichCo.ChuVi - 1 - col);
                    SoLinhDangDi = SoLinh;
                    VeSoOLinh(ben, col, 0);   //Vẽ lại ô lính sau khi tính dược ô kế tiếp tương ứng hình ảnh 
                }
                else
                {
                    //Khi đã chọn ô Lính ta sẽ cập nhật vẽ vào các ô tiếp theo và số lính trên ô
                    int col = int.Parse(btn.Name.Substring(4, 1));
                    int SoLinh = int.Parse(btn.ImageKey.Substring(10, 2));
                    if (SoLinhDangDi > 0)
                    {
                        //Tính vị trí kết tiếp dựa vào button đó thuộc cột nào
                        ViTriKeTiep = ben == enumBen.Do ? (1 + col) : (KichCo.ChuVi - 1 - col);
                        if (ViTriKeTiep == (ViTriXuatPhat + 1) % KichCo.ChuVi
                        || ViTriKeTiep == (ViTriXuatPhat - 1) % KichCo.ChuVi)
                            VongLap(); //  gọi đề quy
                    }
                    else
                    {
                        DoiBen();
                    }
                    //Gọi các hàm đã khai báo để gửi dữ liệu qua tab khác
                    ThietLapLinh();
                    ThietLapQuan();
                    Send(MangLinh);
                    Send(MangQuan);
                }
            tmCoolDown.Start();
            prcbCoolDown.Value = 0;
        }
        private void mnuBanMoi_Click(object sender, EventArgs e)
        {
            enumBen ben = new enumBen();
            DoiBanMoi(ben);
        }
        private void mnuAbout_Click(object sender, EventArgs e)
        {
            
        }
        private void mnuCachChoi_Click(object sender, EventArgs e)
        {
           
        }

        private void mnuSoLinhO_TextChanged(object sender, EventArgs e)
        {
            int SoLinh = 0;
            if (int.TryParse(mnuSoLinhO.Text, out SoLinh))
            {
                SoLinhMoiO = SoLinh;
                enumBen ben = new enumBen();
                DoiBanMoi(ben);
            }
        }
        void EndGame()
        {
            MessageBox.Show("Đổi bên");
        }

        private void btnTuong(object sender, EventArgs e)
        {

            if (DaChonLinh)
            { 
                // Chọn ô đích đến là tướng
                Button btn = (Button)sender;
                enumBen ben = (enumBen)int.Parse(btn.Name.Substring(9, 1));
                int SoTuong = int.Parse(btn.ImageKey.Substring(13, 1));
                int SoLinh = int.Parse(btn.ImageKey.Substring(14, 2));
                if (SoLinhDangDi > 0)
                {
                    //Tính vị trí kế tiếp và trả về kết quả
                    ViTriKeTiep = (ben == enumBen.Do) ? 0 : 6;
                    if (ViTriKeTiep == (ViTriXuatPhat + 1) % KichCo.ChuVi || ViTriKeTiep == ViTriXuatPhat - 1)
                        VongLap(); // sẽ gọi đệ quy
                }
                else
                    DoiBen();
                ThietLapLinh();
                ThietLapQuan();
                Send(MangLinh);
                Send(MangQuan); 
            }
            tmCoolDown.Start();
            prcbCoolDown.Value = 0;

        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        //Gửi chat
        private void btnSend_Click(object sender, EventArgs e)
        {
            Sendchat();
            txbMessage.Text = "";
        }

        //Part of chat with TCP
        IPEndPoint IPep;
        TcpClient TcpClient;
        Stream CLIENT;


        //Kết nối để chat
        void Connectchat()
        {
            IPAddress ipAdd = IPAddress.Parse("127.0.0.1");
            IPep = new IPEndPoint(ipAdd, 8080);

            TcpClient = new TcpClient();

            try
            {
                TcpClient.Connect(IPep);
                CLIENT = TcpClient.GetStream();
            }
            catch (SocketException e)
            {
                MessageBox.Show("Không thể kết nối server!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread listen = new Thread(Receivechat);
            listen.IsBackground = true;
            listen.Start();
        }

        void AddMessage(string s)
        {
            lsvMessage.Items.Add(new ListViewItem() { Text = s });
        }
        //Gửi tin nhắn
        void Sendchat()
        {
            string name = txbName.Text;
            if (txbMessage.Text != string.Empty)
            {
                byte[] data = Encoding.UTF8.GetBytes(name + ": " + txbMessage.Text);
                CLIENT.Write(data, 0, data.Length);
                AddMessage(txbName.Text + " : " + txbMessage.Text);
            }
        }

        //Nhận tin nhắn
        void Receivechat()
        {
            try //cố gắng nhận thông tin, nếu lỗi sẽ đóng lại 
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    CLIENT.Read(data, 0, data.Length);

                    string message = Encoding.UTF8.GetString(data);

                    AddMessage(message);
                }
            }
            catch
            {
                CLIENT.Close();
            } //đóng lại khi bị lỗi 
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        //Tính toán thời gian mỗi bên đi và tự reset lại thanh thời gian
        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            prcbCoolDown.PerformStep();
            if (prcbCoolDown.Value >= prcbCoolDown.Maximum)
            {
                tmCoolDown.Stop();
                EndGame(); //Chạy hết thanh thời gian mà bên nào chưa đi sẽ tự động đổi bên còn lại đi
            }
        }
    }
}
