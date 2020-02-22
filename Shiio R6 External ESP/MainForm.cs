using SharpDX.Direct2D1;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shiio_External_R6_ESP
{ 
    public partial class MainForm : Form
    {
        private Point mouseLocation = new Point();
        public static MemoryHelper Mem = new MemoryHelper();
        private Overlay Over;
        private bool ESP = false;
        public static bool Box = true;
        public static bool BoxChroma = false;
        public static bool Circle = true;
        public static bool CircleChroma = false;
        public static bool Chams = true;
        public static bool ChamsChroma = false;
        public static bool Distance = false;
        public static string NametagsText = "Terrorist";
        public static bool Healthbar = true;
        public static bool bRight = false;
        public static bool Nametags = true;
        public static bool Skeleton = true;
        public static bool SkeletonChroma = false;
        public static bool Snaplines = false;
        public static bool SnaplineChroma = false;
        public static bool Crosshair = false;
        public static bool TextChroma = false;

        //Colors
        public static Color BoxColor = new Color();
        public static Color CircleColor = new Color();
        public static Color ChamsColor = new Color();
        public static Color SkeletonColor = new Color();
        public static Color SnaplineColor = new Color();
        public static Color TextColor = new Color();

        //For Chroma
        double i = 0;

        public MainForm()
        {
            //Initialize GUI and Update Addresses
            InitializeComponent();
            Mem.UpdateAddresses();

            //GUI Organizer v
            if (Width < 162)
                Width = MainWindowTitle.Location.X + MainWindowTitle.Width + 12 + MinimizeButton1.Width + 2 + CloseButton1.Width;

            Panel2.Width = Width - 2;
            CloseButton1.Location = new Point(Width - 42, 10);
            MinimizeButton1.Location = new Point(Width - 76, 10);
            BoxColorButton1.Hide();
            BoxChromaCheckBox1.Hide();
            ChamsColorButton1.Hide();
            ChamsChromaCheckBox1.Hide();
            CircleColorButton1.Hide();
            CircleChromaCheckBox1.Hide();
            SkeletonColorButton1.Hide();
            SkeletonChromaCheckBox1.Hide();
            TextColorButton1.Hide();
            TextChromaCheckBox1.Hide();
            SnaplineColorButton1.Hide();
            SnaplineChromaCheckBox1.Hide();
            ResetButton1.Hide();

            BoxColorButton1.Location = new Point(12, 67);
            BoxChromaCheckBox1.Location = new Point(29, 98);
            ChamsColorButton1.Location = new Point(105, 67);
            ChamsChromaCheckBox1.Location = new Point(122, 98);
            CircleColorButton1.Location = new Point(12, 129);
            CircleChromaCheckBox1.Location = new Point(29, 160);
            SkeletonColorButton1.Location = new Point(105, 129);
            SkeletonChromaCheckBox1.Location = new Point(122, 160);
            SnaplineColorButton1.Location = new Point(105, 191);
            SnaplineChromaCheckBox1.Location = new Point(122, 222);
            TextColorButton1.Location = new Point(12, 191);
            TextChromaCheckBox1.Location = new Point(29, 222);
            ResetButton1.Location = new Point(12, 253);
            //GUI Organizer ^

            //Set colors
            BoxColor = Color.FromArgb(255, 255, 255);
            ChamsColor = Color.FromArgb(128, 255, 0);
            CircleColor = Color.FromArgb(128, 255, 0);
            SkeletonColor = Color.FromArgb(128, 255, 0);
            SnaplineColor = Color.FromArgb(0, 148, 255);
            TextColor = Color.FromArgb(255, 255, 255);
        }

        private void ESPButton1_Click(object sender, EventArgs e)
        {
            //ESP Manager
            if (ESP)
            {
                ESPButton1.BackColor = Color.Black;
                ESPButton1.ForeColor = Color.Teal;

                Over.Close();
                ESP = false;
            }

            else
            {
                ESPButton1.BackColor = Color.Teal;
                ESPButton1.ForeColor = Color.Black;

                Over = new Overlay();
                Over.Show();
                ESP = true;
            }
        }

        private void VariablesUpdaterTimer1_Tick(object sender, EventArgs e)
        {
            //Sync Variables with GUI
            Box = BoxCheckBox1.Checked;
            BoxChroma = BoxChromaCheckBox1.Checked;
            Chams = ChamsCheckBox1.Checked;
            ChamsChroma = ChamsChromaCheckBox1.Checked;
            Circle = CircleCheckBox1.Checked;
            CircleChroma = CircleChromaCheckBox1.Checked;
            Distance = DistanceCheckBox1.Checked;
            Healthbar = HealthbarCheckBox1.Checked;
            bRight = RightCheckBox1.Checked;
            Nametags = NametagsCheckBox1.Checked;
            NametagsText = ESPTextRichTextBox1.Text;
            Skeleton = SkeletonCheckBox1.Checked;
            SkeletonChroma = SkeletonChromaCheckBox1.Checked;
            Snaplines = SnaplinesCheckBox1.Checked;
            SnaplineChroma = SnaplineChromaCheckBox1.Checked;
            Crosshair = CrosshairCheckBox1.Checked;
            TextChroma = TextChromaCheckBox1.Checked;
            if (i > 1) i = 0;
            Color color = HSL2RGB(i, 0.5, 0.5);
            i += 0.01;
            if (BoxChroma)
            {
                BoxColor = color;
            }
            if (ChamsChroma)
            {
                ChamsColor = color;
            }
            if (CircleChroma)
            {
                CircleColor = color;
            }
            if (SkeletonChroma)
            {
                SkeletonColor = color;
            }
            if (SnaplineChroma)
            {
                SnaplineColor = color;
            }
            if (TextChroma)
            {
                TextColor = color;
            }
            if (Chams)
            {
                Mem.Glow(ChamsColor.R, ChamsColor.G, ChamsColor.B);
            }
        }

        //Below Stuff is for animating GUI, like moving it, closing, minimizing, etc...
        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Teal, ButtonBorderStyle.Solid);
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X - 1, -e.Y - 1);
        }

        private void Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void pictureBoxIcon_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X - 10, -e.Y - 13);
        }

        private void pictureBoxIcon_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void MainWindowTitle_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X - 27, -e.Y - 13);
        }

        private void MainWindowTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void CloseButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimizeButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BoxColorButton1_Click(object sender, EventArgs e)
        {
            if (ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                BoxColor = ColorDialog1.Color;
            }
        }

        private void ChamsColorButton1_Click(object sender, EventArgs e)
        {
            if (ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                ChamsColor = ColorDialog1.Color;
            }
        }

        private void CircleColorButton1_Click(object sender, EventArgs e)
        {
            if (ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                CircleColor = ColorDialog1.Color;
            }
        }

        private void SkeletonColorButton1_Click(object sender, EventArgs e)
        {
            if (ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                SkeletonColor = ColorDialog1.Color;
            }
        }

        private void SnaplineColorButton1_Click(object sender, EventArgs e)
        {
            if (ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                SnaplineColor = ColorDialog1.Color;
            }
        }

        private void TextColorButton1_Click(object sender, EventArgs e)
        {
            if (ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                TextColor = ColorDialog1.Color;
            }
        }

        private void ResetButton1_Click(object sender, EventArgs e)
        {
            BoxColor = Color.FromArgb(255, 255, 255);
            CircleColor = Color.FromArgb(128, 255, 0);
            ChamsColor = Color.FromArgb(128, 255, 0);
            SkeletonColor = Color.FromArgb(128, 255, 0);
            SnaplineColor = Color.FromArgb(128, 255, 0);
            TextColor = Color.FromArgb(255, 255, 255);
        }

        private void VisualsButton1_Click(object sender, EventArgs e)
        {
            ColorsButton1.BackColor = Color.Black;
            ColorsButton1.ForeColor = Color.Teal;
            VisualsButton1.BackColor = Color.Teal;
            VisualsButton1.ForeColor = Color.Black;

            BoxColorButton1.Hide();
            BoxChromaCheckBox1.Hide();
            ChamsColorButton1.Hide();
            ChamsChromaCheckBox1.Hide();
            CircleColorButton1.Hide();
            CircleChromaCheckBox1.Hide();
            SkeletonColorButton1.Hide();
            SkeletonChromaCheckBox1.Hide();
            SnaplineColorButton1.Hide();
            SnaplineChromaCheckBox1.Hide();
            TextColorButton1.Hide();
            TextChromaCheckBox1.Hide();
            ResetButton1.Hide();

            ESPButton1.Show();
            BoxCheckBox1.Show();
            CircleCheckBox1.Show();
            ChamsCheckBox1.Show();
            DistanceCheckBox1.Show();
            HealthbarCheckBox1.Show();
            RightCheckBox1.Show();
            NametagsCheckBox1.Show();
            SkeletonCheckBox1.Show();
            SnaplinesCheckBox1.Show();
            CrosshairCheckBox1.Show();
            Panel3.Show();
        }

        private void ColorsButton1_Click(object sender, EventArgs e)
        {
            VisualsButton1.BackColor = Color.Black;
            VisualsButton1.ForeColor = Color.Teal;
            ColorsButton1.BackColor = Color.Teal;
            ColorsButton1.ForeColor = Color.Black;

            ESPButton1.Hide();
            BoxCheckBox1.Hide();
            CircleCheckBox1.Hide();
            ChamsCheckBox1.Hide();
            DistanceCheckBox1.Hide();
            HealthbarCheckBox1.Hide();
            RightCheckBox1.Hide();
            NametagsCheckBox1.Hide();
            SkeletonCheckBox1.Hide();
            SnaplinesCheckBox1.Hide();
            CrosshairCheckBox1.Hide();
            Panel3.Hide();

            BoxColorButton1.Show();
            BoxChromaCheckBox1.Show();
            ChamsColorButton1.Show();
            ChamsChromaCheckBox1.Show();
            CircleColorButton1.Show();
            CircleChromaCheckBox1.Show();
            SkeletonColorButton1.Show();
            SkeletonChromaCheckBox1.Show();
            SnaplineColorButton1.Show();
            SnaplineChromaCheckBox1.Show();
            TextColorButton1.Show();
            TextChromaCheckBox1.Show();
            ResetButton1.Show();
        }

        public static Color HSL2RGB(double h, double sl, double l)
        {
            double v;
            double r, g, b;

            r = l;   // default to gray
            g = l;
            b = l;

            v = (l <= 0.5) ? (l * (1.0 + sl)) : (l + sl - l * sl);

            if (v > 0)
            {
                double m;

                double sv;

                int sextant;

                double fract, vsf, mid1, mid2;



                m = l + l - v;

                sv = (v - m) / v;

                h *= 6.0;

                sextant = (int)h;

                fract = h - sextant;

                vsf = v * sv * fract;

                mid1 = m + vsf;

                mid2 = v - vsf;

                switch (sextant)

                {

                    case 0:

                        r = v;

                        g = mid1;

                        b = m;

                        break;

                    case 1:

                        r = mid2;

                        g = v;

                        b = m;

                        break;

                    case 2:

                        r = m;

                        g = v;

                        b = mid1;

                        break;

                    case 3:

                        r = m;

                        g = mid2;

                        b = v;

                        break;

                    case 4:

                        r = mid1;

                        g = m;

                        b = v;

                        break;

                    case 5:

                        r = v;

                        g = m;

                        b = mid2;

                        break;

                }

            }

            Color rgb = Color.FromArgb((int)(r * 255.0f), (int)(g * 255.0f), (int)(b * 255.0f));
            return rgb;

        }

        private void MainWindowTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
