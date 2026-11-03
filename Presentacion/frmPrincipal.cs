using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MetroFramework.Forms;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using System.Globalization;
namespace Presentacion
{
    public class frmPrincipal : MetroForm
    {
        public E_Usuario SESION_USUARIO {  get; set; }
        private MetroFramework.Controls.MetroLabel lblUsuario;
        private MetroFramework.Controls.MetroPanel menuVertical;
        private FontAwesome.Sharp.IconPictureBox imgUser;
        private MetroFramework.Controls.MetroPanel PanelContenedor;
        private FontAwesome.Sharp.IconPictureBox btnSlide;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconButton btnProductos;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnProveedores;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnVentas;
        private MetroFramework.Controls.MetroLabel lblUserT;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Label label2;
        private Label label1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private Label lblFechaHora;
        private Timer timerFechaHora;
        private System.ComponentModel.IContainer components;
        private MetroFramework.Controls.MetroLabel lblBienvenido;

        public frmPrincipal()
        {
            InitializeComponent();
        }
        #region Diseño
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblBienvenido = new MetroFramework.Controls.MetroLabel();
            this.lblUsuario = new MetroFramework.Controls.MetroLabel();
            this.menuVertical = new MetroFramework.Controls.MetroPanel();
            this.lblUserT = new MetroFramework.Controls.MetroLabel();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnProveedores = new FontAwesome.Sharp.IconButton();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.btnVentas = new FontAwesome.Sharp.IconButton();
            this.btnProductos = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.imgUser = new FontAwesome.Sharp.IconPictureBox();
            this.PanelContenedor = new MetroFramework.Controls.MetroPanel();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnSlide = new FontAwesome.Sharp.IconPictureBox();
            this.timerFechaHora = new System.Windows.Forms.Timer(this.components);
            this.menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            this.PanelContenedor.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblBienvenido.Location = new System.Drawing.Point(12, 542);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(87, 20);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblUsuario.Location = new System.Drawing.Point(124, 605);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(63, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuVertical.Controls.Add(this.lblUserT);
            this.menuVertical.Controls.Add(this.lblBienvenido);
            this.menuVertical.Controls.Add(this.btnSalir);
            this.menuVertical.Controls.Add(this.btnProveedores);
            this.menuVertical.Controls.Add(this.btnClientes);
            this.menuVertical.Controls.Add(this.btnVentas);
            this.menuVertical.Controls.Add(this.lblUsuario);
            this.menuVertical.Controls.Add(this.btnProductos);
            this.menuVertical.Controls.Add(this.iconPictureBox2);
            this.menuVertical.Controls.Add(this.imgUser);
            this.menuVertical.HorizontalScrollbarBarColor = true;
            this.menuVertical.HorizontalScrollbarHighlightOnWheel = false;
            this.menuVertical.HorizontalScrollbarSize = 10;
            this.menuVertical.Location = new System.Drawing.Point(-2, 3);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(216, 793);
            this.menuVertical.TabIndex = 2;
            this.menuVertical.UseCustomBackColor = true;
            this.menuVertical.VerticalScrollbarBarColor = true;
            this.menuVertical.VerticalScrollbarHighlightOnWheel = false;
            this.menuVertical.VerticalScrollbarSize = 10;
            this.menuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.menuVertical_Paint);
            // 
            // lblUserT
            // 
            this.lblUserT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserT.AutoSize = true;
            this.lblUserT.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblUserT.Location = new System.Drawing.Point(124, 573);
            this.lblUserT.Name = "lblUserT";
            this.lblUserT.Size = new System.Drawing.Size(63, 20);
            this.lblUserT.TabIndex = 9;
            this.lblUserT.Text = "Usuario";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 50;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 471);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(185, 53);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btnProveedores.IconColor = System.Drawing.Color.Black;
            this.btnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProveedores.IconSize = 50;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(-3, 414);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(185, 42);
            this.btnProveedores.TabIndex = 7;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnClientes.IconColor = System.Drawing.Color.Black;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.IconSize = 50;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 313);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(185, 56);
            this.btnClientes.TabIndex = 6;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.btnVentas.IconColor = System.Drawing.Color.Black;
            this.btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentas.IconSize = 50;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(3, 247);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(185, 42);
            this.btnVentas.TabIndex = 5;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.IconChar = FontAwesome.Sharp.IconChar.Computer;
            this.btnProductos.IconColor = System.Drawing.Color.Black;
            this.btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductos.IconSize = 50;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 162);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(185, 42);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.iconPictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconPictureBox2.BackgroundImage")));
            this.iconPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 85;
            this.iconPictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("iconPictureBox2.InitialImage")));
            this.iconPictureBox2.Location = new System.Drawing.Point(-3, 0);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(132, 85);
            this.iconPictureBox2.TabIndex = 4;
            this.iconPictureBox2.TabStop = false;
            // 
            // imgUser
            // 
            this.imgUser.BackColor = System.Drawing.Color.DodgerBlue;
            this.imgUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.imgUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.imgUser.IconColor = System.Drawing.SystemColors.ControlText;
            this.imgUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imgUser.IconSize = 91;
            this.imgUser.Location = new System.Drawing.Point(3, 573);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(91, 97);
            this.imgUser.TabIndex = 3;
            this.imgUser.TabStop = false;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContenedor.AutoSize = true;
            this.PanelContenedor.BackColor = System.Drawing.Color.Transparent;
            this.PanelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelContenedor.Controls.Add(this.menuVertical);
            this.PanelContenedor.Controls.Add(this.lblFechaHora);
            this.PanelContenedor.Controls.Add(this.metroPanel3);
            this.PanelContenedor.Controls.Add(this.metroPanel2);
            this.PanelContenedor.Controls.Add(this.label2);
            this.PanelContenedor.Controls.Add(this.label1);
            this.PanelContenedor.Controls.Add(this.metroPanel1);
            this.PanelContenedor.Controls.Add(this.btnSlide);
            this.PanelContenedor.HorizontalScrollbarBarColor = true;
            this.PanelContenedor.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelContenedor.HorizontalScrollbarSize = 10;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(940, 803);
            this.PanelContenedor.TabIndex = 3;
            this.PanelContenedor.UseCustomBackColor = true;
            this.PanelContenedor.VerticalScrollbarBarColor = true;
            this.PanelContenedor.VerticalScrollbarHighlightOnWheel = false;
            this.PanelContenedor.VerticalScrollbarSize = 10;
            this.PanelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel2_Paint);
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora.Location = new System.Drawing.Point(610, 258);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(80, 25);
            this.lblFechaHora.TabIndex = 9;
            this.lblFechaHora.Text = "FECHA";
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.metroLabel5);
            this.metroPanel3.Controls.Add(this.iconPictureBox4);
            this.metroPanel3.Controls.Add(this.metroLabel6);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(756, 86);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(177, 126);
            this.metroPanel3.TabIndex = 8;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(49, 99);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(71, 25);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "1750";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Computer;
            this.iconPictureBox4.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 67;
            this.iconPictureBox4.Location = new System.Drawing.Point(48, 29);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(72, 67);
            this.iconPictureBox4.TabIndex = 6;
            this.iconPictureBox4.TabStop = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.metroLabel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel6.Location = new System.Drawing.Point(0, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(177, 26);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Productos";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.iconPictureBox3);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(506, 86);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(177, 126);
            this.metroPanel2.TabIndex = 8;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(48, 99);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 25);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "500";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 67;
            this.iconPictureBox3.Location = new System.Drawing.Point(48, 29);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(72, 67);
            this.iconPictureBox3.TabIndex = 6;
            this.iconPictureBox3.TabStop = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.metroLabel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel4.Location = new System.Drawing.Point(0, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(177, 26);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Empleados";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.UseStyleColors = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Productos con bajo Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sumario del sistema";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.iconPictureBox1);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(253, 86);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(177, 126);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(49, 99);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 25);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "12 000";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 67;
            this.iconPictureBox1.Location = new System.Drawing.Point(48, 29);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(72, 67);
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.metroLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(177, 26);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Clientes";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // btnSlide
            // 
            this.btnSlide.BackColor = System.Drawing.Color.Snow;
            this.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSlide.IconChar = FontAwesome.Sharp.IconChar.BarsStaggered;
            this.btnSlide.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnSlide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSlide.IconSize = 35;
            this.btnSlide.Location = new System.Drawing.Point(220, 6);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(35, 35);
            this.btnSlide.TabIndex = 4;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // timerFechaHora
            // 
            this.timerFechaHora.Enabled = true;
            this.timerFechaHora.Interval = 1000;
            this.timerFechaHora.Tick += new System.EventHandler(this.timerFechaHora_Tick);
            // 
            // frmPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(936, 788);
            this.Controls.Add(this.PanelContenedor);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuVertical.ResumeLayout(false);
            this.menuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            this.PanelContenedor.ResumeLayout(false);
            this.PanelContenedor.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = SESION_USUARIO.dsUsuario;
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if(menuVertical.Width == 216)
            {
                menuVertical.Width = 71;
               
                btnClientes.Visible = false;
                btnProductos.Visible = false;
                btnVentas.Visible = false;
                btnSalir.Visible = false;
                btnProveedores.Visible = false;
                imgUser.Visible = false;
                lblBienvenido.Visible = false;
                lblUserT.Visible = false;
                lblUsuario.Visible = false;
            }
            else
            { menuVertical.Width = 216;
                btnClientes.Visible = true;
                btnProductos.Visible = true;
                btnVentas.Visible = true;
                btnSalir.Visible = true;
                btnProveedores.Visible= true;
                imgUser.Visible = true;
                lblBienvenido.Visible = true;
                lblUserT.Visible = true;
                lblUsuario.Visible = true;
            }
        }
       

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProducto ventana = new frmProducto();
            ventana.StartPosition = FormStartPosition.CenterScreen;
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
        }

        private void menuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString(
            "dddd, dd 'de' MMMM 'de' yyyy - hh:mm:ss tt",
             new CultureInfo("es-PA")
            );
        }
    }
}
