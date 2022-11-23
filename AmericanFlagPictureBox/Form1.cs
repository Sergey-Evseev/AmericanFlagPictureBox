using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmericanFlagPictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {            
            InitializeComponent();
            Load += Form1_Load; //Load even handler - occurs before 
            //form loads for the first time
        }      

        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Size = new Size(210, 110);

            //позиционирование пикчербокса посреди клиентской области
            pictureBox1.Location =
                new Point((ClientSize.Width / 2 - pictureBox1.Width / 2),
                (ClientSize.Height / 2 - pictureBox1.Height / 2));

            //pictureBox1.Dock = DockStyle.Right;

            this.Controls.Add(pictureBox1); //добавление в контейнер (форму)

            Bitmap flag = new Bitmap(200, 100);
            Graphics flagGraphics = Graphics.FromImage(flag);
            int red = 0;
            int white = 11;
            while (white <= 100)
            {
                flagGraphics.FillRectangle(Brushes.Red, 0, red, 200, 10);
                flagGraphics.FillRectangle(Brushes.White, 0, white, 200, 10);
                red += 20;
                white += 20;
            }
            pictureBox1.Image = flag;
        }
    }
}
