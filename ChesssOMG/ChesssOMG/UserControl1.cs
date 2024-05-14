using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChesssOMG
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int squareSize = Width / 8; // Assuming 8x8 chess board
            Color color1 = Color.White;
            Color color2 = Color.Black;

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Color squareColor = (row + col) % 2 == 0 ? color1 : color2;
                    Brush b = new SolidBrush(squareColor);

                    int x = col * squareSize;
                    int y = row * squareSize;

                    e.Graphics.FillRectangle(b, x, y, squareSize, squareSize);
                }
            }
        }
    }
}
