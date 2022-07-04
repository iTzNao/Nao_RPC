using System.Runtime.InteropServices;

namespace Nao_RPC_Forms
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect, 
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        bool mouseDown;
        private Point offset;

        public Form1()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            this.flowLayoutPanel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void MouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void MouseMove_Event(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void MouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Close(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimise(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}