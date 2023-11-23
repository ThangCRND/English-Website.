namespace OngQuan
{
    partial class frmOngQuan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOngQuan));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tậpTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bànMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.kếtThúcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tùyChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSoLinhO = new System.Windows.Forms.ToolStripComboBox();
            this.imgDoublee = new System.Windows.Forms.ImageList(this.components);
            this.ImgSingle = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.lsvMessage = new System.Windows.Forms.ListView();
            this.process1 = new System.Diagnostics.Process();
            this.prcbCoolDown = new System.Windows.Forms.ProgressBar();
            this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tậpTinToolStripMenuItem,
            this.tùyChọnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1555, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tậpTinToolStripMenuItem
            // 
            this.tậpTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bànMớiToolStripMenuItem,
            this.toolStripMenuItem3,
            this.kếtThúcToolStripMenuItem});
            this.tậpTinToolStripMenuItem.Name = "tậpTinToolStripMenuItem";
            this.tậpTinToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.tậpTinToolStripMenuItem.Text = "Tập tin";
            // 
            // bànMớiToolStripMenuItem
            // 
            this.bànMớiToolStripMenuItem.Name = "bànMớiToolStripMenuItem";
            this.bànMớiToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.bànMớiToolStripMenuItem.Text = "Bàn mới ";
            this.bànMớiToolStripMenuItem.Click += new System.EventHandler(this.mnuBanMoi_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(148, 6);
            // 
            // kếtThúcToolStripMenuItem
            // 
            this.kếtThúcToolStripMenuItem.Name = "kếtThúcToolStripMenuItem";
            this.kếtThúcToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.kếtThúcToolStripMenuItem.Text = "Kết thúc";
            this.kếtThúcToolStripMenuItem.Click += new System.EventHandler(this.kếtThúcToolStripMenuItem_Click);
            // 
            // tùyChọnToolStripMenuItem
            // 
            this.tùyChọnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSoLinhO});
            this.tùyChọnToolStripMenuItem.Name = "tùyChọnToolStripMenuItem";
            this.tùyChọnToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.tùyChọnToolStripMenuItem.Text = "Tùy chọn";
            // 
            // mnuSoLinhO
            // 
            this.mnuSoLinhO.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.mnuSoLinhO.Name = "mnuSoLinhO";
            this.mnuSoLinhO.Size = new System.Drawing.Size(121, 28);
            this.mnuSoLinhO.Text = "5";
            this.mnuSoLinhO.TextChanged += new System.EventHandler(this.mnuSoLinhO_TextChanged);
            // 
            // imgDoublee
            // 
            this.imgDoublee.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgDoublee.ImageStream")));
            this.imgDoublee.TransparentColor = System.Drawing.Color.Transparent;
            this.imgDoublee.Images.SetKeyName(0, "BanNguyetPhai000.bmp");
            this.imgDoublee.Images.SetKeyName(1, "BanNguyetPhai001.bmp");
            this.imgDoublee.Images.SetKeyName(2, "BanNguyetPhai002.bmp");
            this.imgDoublee.Images.SetKeyName(3, "BanNguyetPhai003.bmp");
            this.imgDoublee.Images.SetKeyName(4, "BanNguyetPhai004.bmp");
            this.imgDoublee.Images.SetKeyName(5, "BanNguyetPhai005.bmp");
            this.imgDoublee.Images.SetKeyName(6, "BanNguyetPhai006.bmp");
            this.imgDoublee.Images.SetKeyName(7, "BanNguyetPhai007.bmp");
            this.imgDoublee.Images.SetKeyName(8, "BanNguyetPhai008.bmp");
            this.imgDoublee.Images.SetKeyName(9, "BanNguyetPhai009.bmp");
            this.imgDoublee.Images.SetKeyName(10, "BanNguyetPhai010.bmp");
            this.imgDoublee.Images.SetKeyName(11, "BanNguyetPhai011.bmp");
            this.imgDoublee.Images.SetKeyName(12, "BanNguyetPhai012.bmp");
            this.imgDoublee.Images.SetKeyName(13, "BanNguyetPhai013.bmp");
            this.imgDoublee.Images.SetKeyName(14, "BanNguyetPhai014.bmp");
            this.imgDoublee.Images.SetKeyName(15, "BanNguyetPhai015.bmp");
            this.imgDoublee.Images.SetKeyName(16, "BanNguyetPhai016.bmp");
            this.imgDoublee.Images.SetKeyName(17, "BanNguyetPhai017.bmp");
            this.imgDoublee.Images.SetKeyName(18, "BanNguyetPhai018.bmp");
            this.imgDoublee.Images.SetKeyName(19, "BanNguyetPhai019.bmp");
            this.imgDoublee.Images.SetKeyName(20, "BanNguyetPhai020.bmp");
            this.imgDoublee.Images.SetKeyName(21, "BanNguyetPhai021.bmp");
            this.imgDoublee.Images.SetKeyName(22, "BanNguyetPhai022.bmp");
            this.imgDoublee.Images.SetKeyName(23, "BanNguyetPhai023.bmp");
            this.imgDoublee.Images.SetKeyName(24, "BanNguyetPhai024.bmp");
            this.imgDoublee.Images.SetKeyName(25, "BanNguyetPhai025.bmp");
            this.imgDoublee.Images.SetKeyName(26, "BanNguyetPhai026.bmp");
            this.imgDoublee.Images.SetKeyName(27, "BanNguyetPhai027.bmp");
            this.imgDoublee.Images.SetKeyName(28, "BanNguyetPhai028.bmp");
            this.imgDoublee.Images.SetKeyName(29, "BanNguyetPhai029.bmp");
            this.imgDoublee.Images.SetKeyName(30, "BanNguyetPhai030.bmp");
            this.imgDoublee.Images.SetKeyName(31, "BanNguyetPhai031.bmp");
            this.imgDoublee.Images.SetKeyName(32, "BanNguyetPhai032.bmp");
            this.imgDoublee.Images.SetKeyName(33, "BanNguyetPhai033.bmp");
            this.imgDoublee.Images.SetKeyName(34, "BanNguyetPhai034.bmp");
            this.imgDoublee.Images.SetKeyName(35, "BanNguyetPhai035.bmp");
            this.imgDoublee.Images.SetKeyName(36, "BanNguyetPhai100.bmp");
            this.imgDoublee.Images.SetKeyName(37, "BanNguyetPhai101.bmp");
            this.imgDoublee.Images.SetKeyName(38, "BanNguyetPhai102.bmp");
            this.imgDoublee.Images.SetKeyName(39, "BanNguyetPhai103.bmp");
            this.imgDoublee.Images.SetKeyName(40, "BanNguyetPhai104.bmp");
            this.imgDoublee.Images.SetKeyName(41, "BanNguyetPhai105.bmp");
            this.imgDoublee.Images.SetKeyName(42, "BanNguyetPhai106.bmp");
            this.imgDoublee.Images.SetKeyName(43, "BanNguyetPhai107.bmp");
            this.imgDoublee.Images.SetKeyName(44, "BanNguyetPhai108.bmp");
            this.imgDoublee.Images.SetKeyName(45, "BanNguyetPhai109.bmp");
            this.imgDoublee.Images.SetKeyName(46, "BanNguyetPhai110.bmp");
            this.imgDoublee.Images.SetKeyName(47, "BanNguyetPhai111.bmp");
            this.imgDoublee.Images.SetKeyName(48, "BanNguyetPhai112.bmp");
            this.imgDoublee.Images.SetKeyName(49, "BanNguyetPhai113.bmp");
            this.imgDoublee.Images.SetKeyName(50, "BanNguyetPhai114.bmp");
            this.imgDoublee.Images.SetKeyName(51, "BanNguyetPhai115.bmp");
            this.imgDoublee.Images.SetKeyName(52, "BanNguyetPhai116.bmp");
            this.imgDoublee.Images.SetKeyName(53, "BanNguyetPhai117.bmp");
            this.imgDoublee.Images.SetKeyName(54, "BanNguyetPhai118.bmp");
            this.imgDoublee.Images.SetKeyName(55, "BanNguyetPhai119.bmp");
            this.imgDoublee.Images.SetKeyName(56, "BanNguyetPhai120.bmp");
            this.imgDoublee.Images.SetKeyName(57, "BanNguyetPhai121.bmp");
            this.imgDoublee.Images.SetKeyName(58, "BanNguyetPhai122.bmp");
            this.imgDoublee.Images.SetKeyName(59, "BanNguyetPhai123.bmp");
            this.imgDoublee.Images.SetKeyName(60, "BanNguyetPhai124.bmp");
            this.imgDoublee.Images.SetKeyName(61, "BanNguyetPhai125.bmp");
            this.imgDoublee.Images.SetKeyName(62, "BanNguyetPhai126.bmp");
            this.imgDoublee.Images.SetKeyName(63, "BanNguyetPhai127.bmp");
            this.imgDoublee.Images.SetKeyName(64, "BanNguyetPhai128.bmp");
            this.imgDoublee.Images.SetKeyName(65, "BanNguyetPhai129.bmp");
            this.imgDoublee.Images.SetKeyName(66, "BanNguyetPhai130.bmp");
            this.imgDoublee.Images.SetKeyName(67, "BanNguyetPhai131.bmp");
            this.imgDoublee.Images.SetKeyName(68, "BanNguyetPhai132.bmp");
            this.imgDoublee.Images.SetKeyName(69, "BanNguyetPhai133.bmp");
            this.imgDoublee.Images.SetKeyName(70, "BanNguyetPhai134.bmp");
            this.imgDoublee.Images.SetKeyName(71, "BanNguyetPhai135.bmp");
            this.imgDoublee.Images.SetKeyName(72, "BanNguyetPhai136.bmp");
            this.imgDoublee.Images.SetKeyName(73, "BanNguyetPhai137.bmp");
            this.imgDoublee.Images.SetKeyName(74, "BanNguyetPhai138.bmp");
            this.imgDoublee.Images.SetKeyName(75, "BanNguyetPhai139.bmp");
            this.imgDoublee.Images.SetKeyName(76, "BanNguyetPhai140.bmp");
            this.imgDoublee.Images.SetKeyName(77, "BanNguyetTrai000.bmp");
            this.imgDoublee.Images.SetKeyName(78, "BanNguyetTrai001.bmp");
            this.imgDoublee.Images.SetKeyName(79, "BanNguyetTrai002.bmp");
            this.imgDoublee.Images.SetKeyName(80, "BanNguyetTrai003.bmp");
            this.imgDoublee.Images.SetKeyName(81, "BanNguyetTrai004.bmp");
            this.imgDoublee.Images.SetKeyName(82, "BanNguyetTrai005.bmp");
            this.imgDoublee.Images.SetKeyName(83, "BanNguyetTrai006.bmp");
            this.imgDoublee.Images.SetKeyName(84, "BanNguyetTrai007.bmp");
            this.imgDoublee.Images.SetKeyName(85, "BanNguyetTrai008.bmp");
            this.imgDoublee.Images.SetKeyName(86, "BanNguyetTrai009.bmp");
            this.imgDoublee.Images.SetKeyName(87, "BanNguyetTrai010.bmp");
            this.imgDoublee.Images.SetKeyName(88, "BanNguyetTrai011.bmp");
            this.imgDoublee.Images.SetKeyName(89, "BanNguyetTrai012.bmp");
            this.imgDoublee.Images.SetKeyName(90, "BanNguyetTrai013.bmp");
            this.imgDoublee.Images.SetKeyName(91, "BanNguyetTrai014.bmp");
            this.imgDoublee.Images.SetKeyName(92, "BanNguyetTrai015.bmp");
            this.imgDoublee.Images.SetKeyName(93, "BanNguyetTrai016.bmp");
            this.imgDoublee.Images.SetKeyName(94, "BanNguyetTrai017.bmp");
            this.imgDoublee.Images.SetKeyName(95, "BanNguyetTrai018.bmp");
            this.imgDoublee.Images.SetKeyName(96, "BanNguyetTrai019.bmp");
            this.imgDoublee.Images.SetKeyName(97, "BanNguyetTrai020.bmp");
            this.imgDoublee.Images.SetKeyName(98, "BanNguyetTrai021.bmp");
            this.imgDoublee.Images.SetKeyName(99, "BanNguyetTrai022.bmp");
            this.imgDoublee.Images.SetKeyName(100, "BanNguyetTrai023.bmp");
            this.imgDoublee.Images.SetKeyName(101, "BanNguyetTrai024.bmp");
            this.imgDoublee.Images.SetKeyName(102, "BanNguyetTrai025.bmp");
            this.imgDoublee.Images.SetKeyName(103, "BanNguyetTrai026.bmp");
            this.imgDoublee.Images.SetKeyName(104, "BanNguyetTrai027.bmp");
            this.imgDoublee.Images.SetKeyName(105, "BanNguyetTrai028.bmp");
            this.imgDoublee.Images.SetKeyName(106, "BanNguyetTrai029.bmp");
            this.imgDoublee.Images.SetKeyName(107, "BanNguyetTrai030.bmp");
            this.imgDoublee.Images.SetKeyName(108, "BanNguyetTrai031.bmp");
            this.imgDoublee.Images.SetKeyName(109, "BanNguyetTrai032.bmp");
            this.imgDoublee.Images.SetKeyName(110, "BanNguyetTrai033.bmp");
            this.imgDoublee.Images.SetKeyName(111, "BanNguyetTrai034.bmp");
            this.imgDoublee.Images.SetKeyName(112, "BanNguyetTrai035.bmp");
            this.imgDoublee.Images.SetKeyName(113, "BanNguyetTrai100.bmp");
            this.imgDoublee.Images.SetKeyName(114, "BanNguyetTrai101.bmp");
            this.imgDoublee.Images.SetKeyName(115, "BanNguyetTrai102.bmp");
            this.imgDoublee.Images.SetKeyName(116, "BanNguyetTrai103.bmp");
            this.imgDoublee.Images.SetKeyName(117, "BanNguyetTrai104.bmp");
            this.imgDoublee.Images.SetKeyName(118, "BanNguyetTrai105.bmp");
            this.imgDoublee.Images.SetKeyName(119, "BanNguyetTrai106.bmp");
            this.imgDoublee.Images.SetKeyName(120, "BanNguyetTrai107.bmp");
            this.imgDoublee.Images.SetKeyName(121, "BanNguyetTrai108.bmp");
            this.imgDoublee.Images.SetKeyName(122, "BanNguyetTrai109.bmp");
            this.imgDoublee.Images.SetKeyName(123, "BanNguyetTrai110.bmp");
            this.imgDoublee.Images.SetKeyName(124, "BanNguyetTrai111.bmp");
            this.imgDoublee.Images.SetKeyName(125, "BanNguyetTrai112.bmp");
            this.imgDoublee.Images.SetKeyName(126, "BanNguyetTrai113.bmp");
            this.imgDoublee.Images.SetKeyName(127, "BanNguyetTrai114.bmp");
            this.imgDoublee.Images.SetKeyName(128, "BanNguyetTrai115.bmp");
            this.imgDoublee.Images.SetKeyName(129, "BanNguyetTrai116.bmp");
            this.imgDoublee.Images.SetKeyName(130, "BanNguyetTrai117.bmp");
            this.imgDoublee.Images.SetKeyName(131, "BanNguyetTrai118.bmp");
            this.imgDoublee.Images.SetKeyName(132, "BanNguyetTrai119.bmp");
            this.imgDoublee.Images.SetKeyName(133, "BanNguyetTrai120.bmp");
            this.imgDoublee.Images.SetKeyName(134, "BanNguyetTrai121.bmp");
            this.imgDoublee.Images.SetKeyName(135, "BanNguyetTrai122.bmp");
            this.imgDoublee.Images.SetKeyName(136, "BanNguyetTrai123.bmp");
            this.imgDoublee.Images.SetKeyName(137, "BanNguyetTrai124.bmp");
            this.imgDoublee.Images.SetKeyName(138, "BanNguyetTrai125.bmp");
            this.imgDoublee.Images.SetKeyName(139, "BanNguyetTrai126.bmp");
            this.imgDoublee.Images.SetKeyName(140, "BanNguyetTrai127.bmp");
            this.imgDoublee.Images.SetKeyName(141, "BanNguyetTrai128.bmp");
            this.imgDoublee.Images.SetKeyName(142, "BanNguyetTrai129.bmp");
            this.imgDoublee.Images.SetKeyName(143, "BanNguyetTrai130.bmp");
            this.imgDoublee.Images.SetKeyName(144, "BanNguyetTrai131.bmp");
            this.imgDoublee.Images.SetKeyName(145, "BanNguyetTrai132.bmp");
            this.imgDoublee.Images.SetKeyName(146, "BanNguyetTrai133.bmp");
            this.imgDoublee.Images.SetKeyName(147, "BanNguyetTrai134.bmp");
            this.imgDoublee.Images.SetKeyName(148, "BanNguyetTrai135.bmp");
            this.imgDoublee.Images.SetKeyName(149, "BanNguyetTrai136.bmp");
            this.imgDoublee.Images.SetKeyName(150, "BanNguyetTrai137.bmp");
            this.imgDoublee.Images.SetKeyName(151, "BanNguyetTrai138.bmp");
            this.imgDoublee.Images.SetKeyName(152, "BanNguyetTrai139.bmp");
            this.imgDoublee.Images.SetKeyName(153, "BanNguyetTrai140.bmp");
            // 
            // ImgSingle
            // 
            this.ImgSingle.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgSingle.ImageStream")));
            this.ImgSingle.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgSingle.Images.SetKeyName(0, "KhungLinh000.bmp");
            this.ImgSingle.Images.SetKeyName(1, "KhungLinh001.bmp");
            this.ImgSingle.Images.SetKeyName(2, "KhungLinh002.bmp");
            this.ImgSingle.Images.SetKeyName(3, "KhungLinh003.bmp");
            this.ImgSingle.Images.SetKeyName(4, "KhungLinh004.bmp");
            this.ImgSingle.Images.SetKeyName(5, "KhungLinh005.bmp");
            this.ImgSingle.Images.SetKeyName(6, "KhungLinh006.bmp");
            this.ImgSingle.Images.SetKeyName(7, "KhungLinh007.bmp");
            this.ImgSingle.Images.SetKeyName(8, "KhungLinh008.bmp");
            this.ImgSingle.Images.SetKeyName(9, "KhungLinh009.bmp");
            this.ImgSingle.Images.SetKeyName(10, "KhungLinh010.bmp");
            this.ImgSingle.Images.SetKeyName(11, "KhungLinh011.bmp");
            this.ImgSingle.Images.SetKeyName(12, "KhungLinh012.bmp");
            this.ImgSingle.Images.SetKeyName(13, "KhungLinh013.bmp");
            this.ImgSingle.Images.SetKeyName(14, "KhungLinh014.bmp");
            this.ImgSingle.Images.SetKeyName(15, "KhungLinh015.bmp");
            this.ImgSingle.Images.SetKeyName(16, "KhungLinh016.bmp");
            this.ImgSingle.Images.SetKeyName(17, "KhungLinh017.bmp");
            this.ImgSingle.Images.SetKeyName(18, "KhungLinh018.bmp");
            this.ImgSingle.Images.SetKeyName(19, "KhungLinh019.bmp");
            this.ImgSingle.Images.SetKeyName(20, "KhungLinh020.bmp");
            this.ImgSingle.Images.SetKeyName(21, "KhungLinh021.bmp");
            this.ImgSingle.Images.SetKeyName(22, "KhungLinh022.bmp");
            this.ImgSingle.Images.SetKeyName(23, "KhungLinh023.bmp");
            this.ImgSingle.Images.SetKeyName(24, "KhungLinh024.bmp");
            this.ImgSingle.Images.SetKeyName(25, "KhungLinh025.bmp");
            this.ImgSingle.Images.SetKeyName(26, "KhungLinh026.bmp");
            this.ImgSingle.Images.SetKeyName(27, "KhungLinh027.bmp");
            this.ImgSingle.Images.SetKeyName(28, "KhungLinh028.bmp");
            this.ImgSingle.Images.SetKeyName(29, "KhungLinh029.bmp");
            this.ImgSingle.Images.SetKeyName(30, "KhungLinh030.bmp");
            this.ImgSingle.Images.SetKeyName(31, "KhungLinh100.bmp");
            this.ImgSingle.Images.SetKeyName(32, "KhungLinh101.bmp");
            this.ImgSingle.Images.SetKeyName(33, "KhungLinh102.bmp");
            this.ImgSingle.Images.SetKeyName(34, "KhungLinh103.bmp");
            this.ImgSingle.Images.SetKeyName(35, "KhungLinh104.bmp");
            this.ImgSingle.Images.SetKeyName(36, "KhungLinh105.bmp");
            this.ImgSingle.Images.SetKeyName(37, "KhungLinh106.bmp");
            this.ImgSingle.Images.SetKeyName(38, "KhungLinh107.bmp");
            this.ImgSingle.Images.SetKeyName(39, "KhungLinh108.bmp");
            this.ImgSingle.Images.SetKeyName(40, "KhungLinh109.bmp");
            this.ImgSingle.Images.SetKeyName(41, "KhungLinh110.bmp");
            this.ImgSingle.Images.SetKeyName(42, "KhungLinh111.bmp");
            this.ImgSingle.Images.SetKeyName(43, "KhungLinh112.bmp");
            this.ImgSingle.Images.SetKeyName(44, "KhungLinh113.bmp");
            this.ImgSingle.Images.SetKeyName(45, "KhungLinh114.bmp");
            this.ImgSingle.Images.SetKeyName(46, "KhungLinh115.bmp");
            this.ImgSingle.Images.SetKeyName(47, "KhungLinh116.bmp");
            this.ImgSingle.Images.SetKeyName(48, "KhungLinh117.bmp");
            this.ImgSingle.Images.SetKeyName(49, "KhungLinh118.bmp");
            this.ImgSingle.Images.SetKeyName(50, "KhungLinh119.bmp");
            this.ImgSingle.Images.SetKeyName(51, "KhungLinh120.bmp");
            this.ImgSingle.Images.SetKeyName(52, "KhungLinh121.bmp");
            this.ImgSingle.Images.SetKeyName(53, "KhungLinh122.bmp");
            this.ImgSingle.Images.SetKeyName(54, "KhungLinh123.bmp");
            this.ImgSingle.Images.SetKeyName(55, "KhungLinh124.bmp");
            this.ImgSingle.Images.SetKeyName(56, "KhungLinh125.bmp");
            this.ImgSingle.Images.SetKeyName(57, "KhungLinh126.bmp");
            this.ImgSingle.Images.SetKeyName(58, "KhungLinh127.bmp");
            this.ImgSingle.Images.SetKeyName(59, "KhungLinh128.bmp");
            this.ImgSingle.Images.SetKeyName(60, "KhungLinh129.bmp");
            this.ImgSingle.Images.SetKeyName(61, "KhungLinh130.bmp");
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripSplitButton1,
            this.toolStripStatusLabel2,
            this.toolStripSplitButton2,
            this.toolStripStatusLabel3,
            this.toolStripSplitButton3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 709);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1555, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1363, 513);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nhập Tên Người Dùng";
            // 
            // txbName
            // 
            this.txbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(1363, 533);
            this.txbName.Margin = new System.Windows.Forms.Padding(4);
            this.txbName.Multiline = true;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(175, 46);
            this.txbName.TabIndex = 13;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(1363, 587);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(176, 31);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txbMessage
            // 
            this.txbMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMessage.Location = new System.Drawing.Point(991, 512);
            this.txbMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txbMessage.Multiline = true;
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(363, 105);
            this.txbMessage.TabIndex = 11;
            // 
            // lsvMessage
            // 
            this.lsvMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lsvMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvMessage.HideSelection = false;
            this.lsvMessage.Location = new System.Drawing.Point(991, 103);
            this.lsvMessage.Margin = new System.Windows.Forms.Padding(4);
            this.lsvMessage.Name = "lsvMessage";
            this.lsvMessage.Size = new System.Drawing.Size(547, 400);
            this.lsvMessage.TabIndex = 10;
            this.lsvMessage.UseCompatibleStateImageBehavior = false;
            this.lsvMessage.View = System.Windows.Forms.View.List;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // prcbCoolDown
            // 
            this.prcbCoolDown.Location = new System.Drawing.Point(12, 346);
            this.prcbCoolDown.Name = "prcbCoolDown";
            this.prcbCoolDown.Size = new System.Drawing.Size(189, 23);
            this.prcbCoolDown.TabIndex = 15;
            this.prcbCoolDown.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // tmCoolDown
            // 
            this.tmCoolDown.Tick += new System.EventHandler(this.tmCoolDown_Tick);
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(19, 24);
            this.toolStripSplitButton3.Text = "toolStripSplitButton3";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(60, 20);
            this.toolStripStatusLabel3.Text = "Bắt đầu";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(19, 24);
            this.toolStripSplitButton2.Text = "toolStripSplitButton2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(42, 20);
            this.toolStripStatusLabel2.Text = "Xanh";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(19, 24);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(29, 20);
            this.toolStripStatusLabel1.Text = "Đỏ";
            // 
            // frmOngQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 735);
            this.Controls.Add(this.prcbCoolDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txbMessage);
            this.Controls.Add(this.lsvMessage);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOngQuan";
            this.Text = "Bên Xanh";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tậpTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bànMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtThúcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tùyChọnToolStripMenuItem;
        private System.Windows.Forms.ImageList imgDoublee;
        private System.Windows.Forms.ImageList ImgSingle;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripComboBox mnuSoLinhO;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txbMessage;
        private System.Windows.Forms.ListView lsvMessage;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.ProgressBar prcbCoolDown;
        private System.Windows.Forms.Timer tmCoolDown;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
    }
}

