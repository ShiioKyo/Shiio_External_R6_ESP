namespace Shiio_External_R6_ESP
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ESPButton1 = new System.Windows.Forms.Button();
            this.BoxCheckBox1 = new System.Windows.Forms.CheckBox();
            this.CircleCheckBox1 = new System.Windows.Forms.CheckBox();
            this.SkeletonCheckBox1 = new System.Windows.Forms.CheckBox();
            this.HealthbarCheckBox1 = new System.Windows.Forms.CheckBox();
            this.NametagsCheckBox1 = new System.Windows.Forms.CheckBox();
            this.SnaplinesCheckBox1 = new System.Windows.Forms.CheckBox();
            this.VariablesUpdaterTimer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel1 = new System.Windows.Forms.Panel();
            this.MainWindowTitle = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.CloseButton1 = new System.Windows.Forms.Button();
            this.MinimizeButton1 = new System.Windows.Forms.Button();
            this.ESPTextRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.RightCheckBox1 = new System.Windows.Forms.CheckBox();
            this.DistanceCheckBox1 = new System.Windows.Forms.CheckBox();
            this.BoxColorButton1 = new System.Windows.Forms.Button();
            this.CircleColorButton1 = new System.Windows.Forms.Button();
            this.TextColorButton1 = new System.Windows.Forms.Button();
            this.SkeletonColorButton1 = new System.Windows.Forms.Button();
            this.CrosshairCheckBox1 = new System.Windows.Forms.CheckBox();
            this.SnaplineColorButton1 = new System.Windows.Forms.Button();
            this.ColorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ResetButton1 = new System.Windows.Forms.Button();
            this.VisualsButton1 = new System.Windows.Forms.Button();
            this.ColorsButton1 = new System.Windows.Forms.Button();
            this.TextChromaCheckBox1 = new System.Windows.Forms.CheckBox();
            this.SnaplineChromaCheckBox1 = new System.Windows.Forms.CheckBox();
            this.ChamsChromaCheckBox1 = new System.Windows.Forms.CheckBox();
            this.SkeletonChromaCheckBox1 = new System.Windows.Forms.CheckBox();
            this.CircleChromaCheckBox1 = new System.Windows.Forms.CheckBox();
            this.BoxChromaCheckBox1 = new System.Windows.Forms.CheckBox();
            this.ChamsColorButton1 = new System.Windows.Forms.Button();
            this.ChamsCheckBox1 = new System.Windows.Forms.CheckBox();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ESPButton1
            // 
            this.ESPButton1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.ESPButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ESPButton1.Location = new System.Drawing.Point(12, 67);
            this.ESPButton1.Name = "ESPButton1";
            this.ESPButton1.Size = new System.Drawing.Size(76, 25);
            this.ESPButton1.TabIndex = 0;
            this.ESPButton1.Text = "ESP";
            this.ESPButton1.UseVisualStyleBackColor = true;
            this.ESPButton1.Click += new System.EventHandler(this.ESPButton1_Click);
            // 
            // BoxCheckBox1
            // 
            this.BoxCheckBox1.AutoSize = true;
            this.BoxCheckBox1.Checked = true;
            this.BoxCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BoxCheckBox1.Location = new System.Drawing.Point(12, 98);
            this.BoxCheckBox1.Name = "BoxCheckBox1";
            this.BoxCheckBox1.Size = new System.Drawing.Size(44, 17);
            this.BoxCheckBox1.TabIndex = 1;
            this.BoxCheckBox1.Text = "Box";
            this.BoxCheckBox1.UseVisualStyleBackColor = true;
            // 
            // CircleCheckBox1
            // 
            this.CircleCheckBox1.AutoSize = true;
            this.CircleCheckBox1.Checked = true;
            this.CircleCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CircleCheckBox1.Location = new System.Drawing.Point(12, 145);
            this.CircleCheckBox1.Name = "CircleCheckBox1";
            this.CircleCheckBox1.Size = new System.Drawing.Size(52, 17);
            this.CircleCheckBox1.TabIndex = 2;
            this.CircleCheckBox1.Text = "Circle";
            this.CircleCheckBox1.UseVisualStyleBackColor = true;
            // 
            // SkeletonCheckBox1
            // 
            this.SkeletonCheckBox1.AutoSize = true;
            this.SkeletonCheckBox1.Checked = true;
            this.SkeletonCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SkeletonCheckBox1.Location = new System.Drawing.Point(12, 260);
            this.SkeletonCheckBox1.Name = "SkeletonCheckBox1";
            this.SkeletonCheckBox1.Size = new System.Drawing.Size(68, 17);
            this.SkeletonCheckBox1.TabIndex = 3;
            this.SkeletonCheckBox1.Text = "Skeleton";
            this.SkeletonCheckBox1.UseVisualStyleBackColor = true;
            // 
            // HealthbarCheckBox1
            // 
            this.HealthbarCheckBox1.AutoSize = true;
            this.HealthbarCheckBox1.Checked = true;
            this.HealthbarCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HealthbarCheckBox1.Location = new System.Drawing.Point(12, 191);
            this.HealthbarCheckBox1.Name = "HealthbarCheckBox1";
            this.HealthbarCheckBox1.Size = new System.Drawing.Size(72, 17);
            this.HealthbarCheckBox1.TabIndex = 4;
            this.HealthbarCheckBox1.Text = "Healthbar";
            this.HealthbarCheckBox1.UseVisualStyleBackColor = true;
            // 
            // NametagsCheckBox1
            // 
            this.NametagsCheckBox1.AutoSize = true;
            this.NametagsCheckBox1.Checked = true;
            this.NametagsCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NametagsCheckBox1.Location = new System.Drawing.Point(12, 237);
            this.NametagsCheckBox1.Name = "NametagsCheckBox1";
            this.NametagsCheckBox1.Size = new System.Drawing.Size(74, 17);
            this.NametagsCheckBox1.TabIndex = 5;
            this.NametagsCheckBox1.Text = "Nametags";
            this.NametagsCheckBox1.UseVisualStyleBackColor = true;
            // 
            // SnaplinesCheckBox1
            // 
            this.SnaplinesCheckBox1.AutoSize = true;
            this.SnaplinesCheckBox1.Location = new System.Drawing.Point(12, 283);
            this.SnaplinesCheckBox1.Name = "SnaplinesCheckBox1";
            this.SnaplinesCheckBox1.Size = new System.Drawing.Size(72, 17);
            this.SnaplinesCheckBox1.TabIndex = 6;
            this.SnaplinesCheckBox1.Text = "Snaplines";
            this.SnaplinesCheckBox1.UseVisualStyleBackColor = true;
            // 
            // VariablesUpdaterTimer1
            // 
            this.VariablesUpdaterTimer1.Enabled = true;
            this.VariablesUpdaterTimer1.Interval = 5;
            this.VariablesUpdaterTimer1.Tick += new System.EventHandler(this.VariablesUpdaterTimer1_Tick);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Teal;
            this.Panel1.Controls.Add(this.MainWindowTitle);
            this.Panel1.Controls.Add(this.pictureBoxIcon);
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(305, 31);
            this.Panel1.TabIndex = 7;
            this.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            // 
            // MainWindowTitle
            // 
            this.MainWindowTitle.AutoSize = true;
            this.MainWindowTitle.BackColor = System.Drawing.Color.Black;
            this.MainWindowTitle.ForeColor = System.Drawing.Color.Teal;
            this.MainWindowTitle.Location = new System.Drawing.Point(27, 13);
            this.MainWindowTitle.Name = "MainWindowTitle";
            this.MainWindowTitle.Size = new System.Drawing.Size(156, 13);
            this.MainWindowTitle.TabIndex = 10;
            this.MainWindowTitle.Text = "Shiio\'s Rainbow Six: Siege ESP";
            this.MainWindowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainWindowTitle.Click += new System.EventHandler(this.MainWindowTitle_Click);
            this.MainWindowTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindowTitle_MouseDown);
            this.MainWindowTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindowTitle_MouseMove);
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.BackColor = System.Drawing.Color.Black;
            this.pictureBoxIcon.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.ErrorImage")));
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.InitialImage")));
            this.pictureBoxIcon.Location = new System.Drawing.Point(10, 13);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(14, 11);
            this.pictureBoxIcon.TabIndex = 9;
            this.pictureBoxIcon.TabStop = false;
            this.pictureBoxIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxIcon_MouseDown);
            this.pictureBoxIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxIcon_MouseMove);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Black;
            this.Panel2.ForeColor = System.Drawing.Color.Black;
            this.Panel2.Location = new System.Drawing.Point(1, 1);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(303, 29);
            this.Panel2.TabIndex = 8;
            this.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseDown);
            this.Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseMove);
            // 
            // CloseButton1
            // 
            this.CloseButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.CloseButton1.ForeColor = System.Drawing.Color.Teal;
            this.CloseButton1.Location = new System.Drawing.Point(206, 284);
            this.CloseButton1.Name = "CloseButton1";
            this.CloseButton1.Size = new System.Drawing.Size(32, 18);
            this.CloseButton1.TabIndex = 8;
            this.CloseButton1.Text = "ˣ";
            this.CloseButton1.UseVisualStyleBackColor = true;
            this.CloseButton1.Click += new System.EventHandler(this.CloseButton1_Click);
            // 
            // MinimizeButton1
            // 
            this.MinimizeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.MinimizeButton1.ForeColor = System.Drawing.Color.Teal;
            this.MinimizeButton1.Location = new System.Drawing.Point(244, 284);
            this.MinimizeButton1.Name = "MinimizeButton1";
            this.MinimizeButton1.Size = new System.Drawing.Size(32, 18);
            this.MinimizeButton1.TabIndex = 9;
            this.MinimizeButton1.Text = "⁻";
            this.MinimizeButton1.UseVisualStyleBackColor = true;
            this.MinimizeButton1.Click += new System.EventHandler(this.MinimizeButton1_Click);
            // 
            // ESPTextRichTextBox1
            // 
            this.ESPTextRichTextBox1.BackColor = System.Drawing.Color.Black;
            this.ESPTextRichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ESPTextRichTextBox1.ForeColor = System.Drawing.Color.Teal;
            this.ESPTextRichTextBox1.Location = new System.Drawing.Point(1, 1);
            this.ESPTextRichTextBox1.Name = "ESPTextRichTextBox1";
            this.ESPTextRichTextBox1.Size = new System.Drawing.Size(106, 23);
            this.ESPTextRichTextBox1.TabIndex = 10;
            this.ESPTextRichTextBox1.Text = "Terrorist";
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.Teal;
            this.Panel3.Controls.Add(this.ESPTextRichTextBox1);
            this.Panel3.Location = new System.Drawing.Point(93, 67);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(108, 25);
            this.Panel3.TabIndex = 11;
            // 
            // RightCheckBox1
            // 
            this.RightCheckBox1.AutoSize = true;
            this.RightCheckBox1.Location = new System.Drawing.Point(29, 214);
            this.RightCheckBox1.Name = "RightCheckBox1";
            this.RightCheckBox1.Size = new System.Drawing.Size(51, 17);
            this.RightCheckBox1.TabIndex = 12;
            this.RightCheckBox1.Text = "Right";
            this.RightCheckBox1.UseVisualStyleBackColor = true;
            // 
            // DistanceCheckBox1
            // 
            this.DistanceCheckBox1.AutoSize = true;
            this.DistanceCheckBox1.Location = new System.Drawing.Point(12, 168);
            this.DistanceCheckBox1.Name = "DistanceCheckBox1";
            this.DistanceCheckBox1.Size = new System.Drawing.Size(68, 17);
            this.DistanceCheckBox1.TabIndex = 14;
            this.DistanceCheckBox1.Text = "Distance";
            this.DistanceCheckBox1.UseVisualStyleBackColor = true;
            // 
            // BoxColorButton1
            // 
            this.BoxColorButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BoxColorButton1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.BoxColorButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxColorButton1.Location = new System.Drawing.Point(206, 67);
            this.BoxColorButton1.Name = "BoxColorButton1";
            this.BoxColorButton1.Size = new System.Drawing.Size(87, 25);
            this.BoxColorButton1.TabIndex = 15;
            this.BoxColorButton1.Text = "Box Color";
            this.BoxColorButton1.UseVisualStyleBackColor = true;
            this.BoxColorButton1.Click += new System.EventHandler(this.BoxColorButton1_Click);
            // 
            // CircleColorButton1
            // 
            this.CircleColorButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CircleColorButton1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.CircleColorButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CircleColorButton1.Location = new System.Drawing.Point(206, 129);
            this.CircleColorButton1.Name = "CircleColorButton1";
            this.CircleColorButton1.Size = new System.Drawing.Size(87, 25);
            this.CircleColorButton1.TabIndex = 16;
            this.CircleColorButton1.Text = "Circle Color";
            this.CircleColorButton1.UseVisualStyleBackColor = true;
            this.CircleColorButton1.Click += new System.EventHandler(this.CircleColorButton1_Click);
            // 
            // TextColorButton1
            // 
            this.TextColorButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TextColorButton1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.TextColorButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TextColorButton1.Location = new System.Drawing.Point(206, 222);
            this.TextColorButton1.Name = "TextColorButton1";
            this.TextColorButton1.Size = new System.Drawing.Size(87, 25);
            this.TextColorButton1.TabIndex = 17;
            this.TextColorButton1.Text = "Text Color";
            this.TextColorButton1.UseVisualStyleBackColor = true;
            this.TextColorButton1.Click += new System.EventHandler(this.TextColorButton1_Click);
            // 
            // SkeletonColorButton1
            // 
            this.SkeletonColorButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SkeletonColorButton1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.SkeletonColorButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SkeletonColorButton1.Location = new System.Drawing.Point(206, 160);
            this.SkeletonColorButton1.Name = "SkeletonColorButton1";
            this.SkeletonColorButton1.Size = new System.Drawing.Size(87, 25);
            this.SkeletonColorButton1.TabIndex = 18;
            this.SkeletonColorButton1.Text = "Skeleton Color";
            this.SkeletonColorButton1.UseVisualStyleBackColor = true;
            this.SkeletonColorButton1.Click += new System.EventHandler(this.SkeletonColorButton1_Click);
            // 
            // CrosshairCheckBox1
            // 
            this.CrosshairCheckBox1.AutoSize = true;
            this.CrosshairCheckBox1.Location = new System.Drawing.Point(29, 306);
            this.CrosshairCheckBox1.Name = "CrosshairCheckBox1";
            this.CrosshairCheckBox1.Size = new System.Drawing.Size(69, 17);
            this.CrosshairCheckBox1.TabIndex = 19;
            this.CrosshairCheckBox1.Text = "Crosshair";
            this.CrosshairCheckBox1.UseVisualStyleBackColor = true;
            // 
            // SnaplineColorButton1
            // 
            this.SnaplineColorButton1.AutoSize = true;
            this.SnaplineColorButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SnaplineColorButton1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.SnaplineColorButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SnaplineColorButton1.Location = new System.Drawing.Point(206, 191);
            this.SnaplineColorButton1.Name = "SnaplineColorButton1";
            this.SnaplineColorButton1.Size = new System.Drawing.Size(87, 25);
            this.SnaplineColorButton1.TabIndex = 20;
            this.SnaplineColorButton1.Text = "Snapline Color";
            this.SnaplineColorButton1.UseVisualStyleBackColor = true;
            this.SnaplineColorButton1.Click += new System.EventHandler(this.SnaplineColorButton1_Click);
            // 
            // ResetButton1
            // 
            this.ResetButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ResetButton1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.ResetButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton1.Location = new System.Drawing.Point(206, 253);
            this.ResetButton1.Name = "ResetButton1";
            this.ResetButton1.Size = new System.Drawing.Size(87, 25);
            this.ResetButton1.TabIndex = 21;
            this.ResetButton1.Text = "Reset to default";
            this.ResetButton1.UseVisualStyleBackColor = true;
            this.ResetButton1.Click += new System.EventHandler(this.ResetButton1_Click);
            // 
            // VisualsButton1
            // 
            this.VisualsButton1.BackColor = System.Drawing.Color.Teal;
            this.VisualsButton1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.VisualsButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisualsButton1.ForeColor = System.Drawing.Color.Black;
            this.VisualsButton1.Location = new System.Drawing.Point(0, 30);
            this.VisualsButton1.Name = "VisualsButton1";
            this.VisualsButton1.Size = new System.Drawing.Size(153, 25);
            this.VisualsButton1.TabIndex = 22;
            this.VisualsButton1.Text = "Visuals";
            this.VisualsButton1.UseVisualStyleBackColor = false;
            this.VisualsButton1.Click += new System.EventHandler(this.VisualsButton1_Click);
            // 
            // ColorsButton1
            // 
            this.ColorsButton1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.ColorsButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorsButton1.Location = new System.Drawing.Point(152, 30);
            this.ColorsButton1.Name = "ColorsButton1";
            this.ColorsButton1.Size = new System.Drawing.Size(153, 25);
            this.ColorsButton1.TabIndex = 23;
            this.ColorsButton1.Text = "Colors";
            this.ColorsButton1.UseVisualStyleBackColor = true;
            this.ColorsButton1.Click += new System.EventHandler(this.ColorsButton1_Click);
            // 
            // TextChromaCheckBox1
            // 
            this.TextChromaCheckBox1.AutoSize = true;
            this.TextChromaCheckBox1.Location = new System.Drawing.Point(94, 149);
            this.TextChromaCheckBox1.Name = "TextChromaCheckBox1";
            this.TextChromaCheckBox1.Size = new System.Drawing.Size(86, 17);
            this.TextChromaCheckBox1.TabIndex = 29;
            this.TextChromaCheckBox1.Text = "Text Chroma";
            this.TextChromaCheckBox1.UseVisualStyleBackColor = true;
            // 
            // SnaplineChromaCheckBox1
            // 
            this.SnaplineChromaCheckBox1.AutoSize = true;
            this.SnaplineChromaCheckBox1.Location = new System.Drawing.Point(94, 218);
            this.SnaplineChromaCheckBox1.Name = "SnaplineChromaCheckBox1";
            this.SnaplineChromaCheckBox1.Size = new System.Drawing.Size(106, 17);
            this.SnaplineChromaCheckBox1.TabIndex = 28;
            this.SnaplineChromaCheckBox1.Text = "Snapline Chroma";
            this.SnaplineChromaCheckBox1.UseVisualStyleBackColor = true;
            // 
            // ChamsChromaCheckBox1
            // 
            this.ChamsChromaCheckBox1.AutoSize = true;
            this.ChamsChromaCheckBox1.Location = new System.Drawing.Point(94, 172);
            this.ChamsChromaCheckBox1.Name = "ChamsChromaCheckBox1";
            this.ChamsChromaCheckBox1.Size = new System.Drawing.Size(97, 17);
            this.ChamsChromaCheckBox1.TabIndex = 27;
            this.ChamsChromaCheckBox1.Text = "Chams Chroma";
            this.ChamsChromaCheckBox1.UseVisualStyleBackColor = true;
            // 
            // SkeletonChromaCheckBox1
            // 
            this.SkeletonChromaCheckBox1.AutoSize = true;
            this.SkeletonChromaCheckBox1.Location = new System.Drawing.Point(94, 195);
            this.SkeletonChromaCheckBox1.Name = "SkeletonChromaCheckBox1";
            this.SkeletonChromaCheckBox1.Size = new System.Drawing.Size(107, 17);
            this.SkeletonChromaCheckBox1.TabIndex = 26;
            this.SkeletonChromaCheckBox1.Text = "Skeleton Chroma";
            this.SkeletonChromaCheckBox1.UseVisualStyleBackColor = true;
            // 
            // CircleChromaCheckBox1
            // 
            this.CircleChromaCheckBox1.AutoSize = true;
            this.CircleChromaCheckBox1.Location = new System.Drawing.Point(94, 126);
            this.CircleChromaCheckBox1.Name = "CircleChromaCheckBox1";
            this.CircleChromaCheckBox1.Size = new System.Drawing.Size(91, 17);
            this.CircleChromaCheckBox1.TabIndex = 25;
            this.CircleChromaCheckBox1.Text = "Circle Chroma";
            this.CircleChromaCheckBox1.UseVisualStyleBackColor = true;
            // 
            // BoxChromaCheckBox1
            // 
            this.BoxChromaCheckBox1.AutoSize = true;
            this.BoxChromaCheckBox1.Location = new System.Drawing.Point(94, 103);
            this.BoxChromaCheckBox1.Name = "BoxChromaCheckBox1";
            this.BoxChromaCheckBox1.Size = new System.Drawing.Size(83, 17);
            this.BoxChromaCheckBox1.TabIndex = 24;
            this.BoxChromaCheckBox1.Text = "Box Chroma";
            this.BoxChromaCheckBox1.UseVisualStyleBackColor = true;
            // 
            // ChamsColorButton1
            // 
            this.ChamsColorButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChamsColorButton1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.ChamsColorButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChamsColorButton1.Location = new System.Drawing.Point(206, 98);
            this.ChamsColorButton1.Name = "ChamsColorButton1";
            this.ChamsColorButton1.Size = new System.Drawing.Size(87, 25);
            this.ChamsColorButton1.TabIndex = 30;
            this.ChamsColorButton1.Text = "Chams Color";
            this.ChamsColorButton1.UseVisualStyleBackColor = true;
            this.ChamsColorButton1.Click += new System.EventHandler(this.ChamsColorButton1_Click);
            // 
            // ChamsCheckBox1
            // 
            this.ChamsCheckBox1.AutoSize = true;
            this.ChamsCheckBox1.Checked = true;
            this.ChamsCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChamsCheckBox1.Location = new System.Drawing.Point(12, 121);
            this.ChamsCheckBox1.Name = "ChamsCheckBox1";
            this.ChamsCheckBox1.Size = new System.Drawing.Size(58, 17);
            this.ChamsCheckBox1.TabIndex = 31;
            this.ChamsCheckBox1.Text = "Chams";
            this.ChamsCheckBox1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(305, 332);
            this.Controls.Add(this.ChamsCheckBox1);
            this.Controls.Add(this.ChamsColorButton1);
            this.Controls.Add(this.TextChromaCheckBox1);
            this.Controls.Add(this.SnaplineChromaCheckBox1);
            this.Controls.Add(this.ChamsChromaCheckBox1);
            this.Controls.Add(this.SkeletonChromaCheckBox1);
            this.Controls.Add(this.CircleChromaCheckBox1);
            this.Controls.Add(this.BoxChromaCheckBox1);
            this.Controls.Add(this.ColorsButton1);
            this.Controls.Add(this.VisualsButton1);
            this.Controls.Add(this.ResetButton1);
            this.Controls.Add(this.SnaplineColorButton1);
            this.Controls.Add(this.CrosshairCheckBox1);
            this.Controls.Add(this.SkeletonColorButton1);
            this.Controls.Add(this.TextColorButton1);
            this.Controls.Add(this.CircleColorButton1);
            this.Controls.Add(this.BoxColorButton1);
            this.Controls.Add(this.DistanceCheckBox1);
            this.Controls.Add(this.RightCheckBox1);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.MinimizeButton1);
            this.Controls.Add(this.CloseButton1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.SnaplinesCheckBox1);
            this.Controls.Add(this.NametagsCheckBox1);
            this.Controls.Add(this.HealthbarCheckBox1);
            this.Controls.Add(this.SkeletonCheckBox1);
            this.Controls.Add(this.CircleCheckBox1);
            this.Controls.Add(this.BoxCheckBox1);
            this.Controls.Add(this.ESPButton1);
            this.ForeColor = System.Drawing.Color.Teal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "BlackTeal Rainbow Six: Siege ESP";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.Panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ESPButton1;
        private System.Windows.Forms.CheckBox BoxCheckBox1;
        private System.Windows.Forms.CheckBox CircleCheckBox1;
        private System.Windows.Forms.CheckBox SkeletonCheckBox1;
        private System.Windows.Forms.CheckBox HealthbarCheckBox1;
        private System.Windows.Forms.CheckBox NametagsCheckBox1;
        private System.Windows.Forms.CheckBox SnaplinesCheckBox1;
        private System.Windows.Forms.Timer VariablesUpdaterTimer1;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Label MainWindowTitle;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Button CloseButton1;
        private System.Windows.Forms.Button MinimizeButton1;
        private System.Windows.Forms.RichTextBox ESPTextRichTextBox1;
        private System.Windows.Forms.Panel Panel3;
        private System.Windows.Forms.CheckBox RightCheckBox1;
        private System.Windows.Forms.CheckBox DistanceCheckBox1;
        private System.Windows.Forms.Button BoxColorButton1;
        private System.Windows.Forms.Button CircleColorButton1;
        private System.Windows.Forms.Button TextColorButton1;
        private System.Windows.Forms.Button SkeletonColorButton1;
        private System.Windows.Forms.CheckBox CrosshairCheckBox1;
        private System.Windows.Forms.Button SnaplineColorButton1;
        private System.Windows.Forms.ColorDialog ColorDialog1;
        private System.Windows.Forms.Button ResetButton1;
        private System.Windows.Forms.Button VisualsButton1;
        private System.Windows.Forms.Button ColorsButton1;
        private System.Windows.Forms.CheckBox TextChromaCheckBox1;
        private System.Windows.Forms.CheckBox SnaplineChromaCheckBox1;
        private System.Windows.Forms.CheckBox ChamsChromaCheckBox1;
        private System.Windows.Forms.CheckBox SkeletonChromaCheckBox1;
        private System.Windows.Forms.CheckBox CircleChromaCheckBox1;
        private System.Windows.Forms.CheckBox BoxChromaCheckBox1;
        private System.Windows.Forms.Button ChamsColorButton1;
        private System.Windows.Forms.CheckBox ChamsCheckBox1;
    }
}

