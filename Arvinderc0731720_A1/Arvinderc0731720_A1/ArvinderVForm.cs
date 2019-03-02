using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arvinderc0731720_A1
{
    public partial class ArvinderVForm : Form
    {
        enum Position
        {
            Left, Right, Up, Down
        }
        private int _x;
        private int _y;
        private Position _objPosition;
        public ArvinderVForm()
        {
            InitializeComponent();
            _x = 10;
            _y = 13;
            _objPosition = Position.Right;
        }

        private void ArvinderVForm_Load(object sender, EventArgs e)
        {

        }

        private void ArvinderVForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Green, _x, _y, 50, 50);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_objPosition == Position.Right)
            {
                _x = _x + 10;
            }
            else if (_objPosition == Position.Left)
            {
                _x = _x - 10;
            }
            else if (_objPosition == Position.Up)
            {
                _y = _y - 10;
            }
            else if (_objPosition == Position.Down)
            {
                _y = _y + 10;
            }
            Invalidate();
        }

        private void ArvinderVForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                _objPosition = Position.Left;

            }
            else if (e.KeyCode == Keys.Right)
            {
                _objPosition = Position.Right;

            }
            else if (e.KeyCode == Keys.Up)
            {
                _objPosition = Position.Up;

            }
            else if (e.KeyCode == Keys.Down)
            {
                _objPosition = Position.Down;

            }
            else if (e.KeyCode == Keys.Escape)
            {
                timer1.Enabled = false;

            }
            else if (e.KeyCode == Keys.Enter)
            {
                timer1.Enabled = true;

            }
        }
    }
}
