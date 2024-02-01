using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pente
{
    public partial class Form1 : Form
    {

        Color firstColor = Color.Blue;
        Color secondColor = Color.Red;
        int playerTurn = 1;


        public Form1()
        {
            InitializeComponent();
        }

        public void onPress (object sender, EventArgs e)
        {
            Button button = (Button)sender;
            checkIfValidSpot(button, e);
        }

        public void checkIfValidSpot (object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.BackColor == Color.White)
            {
                if (playerTurn == 1)
                {
                    button.BackColor = firstColor;
                    playerTurn = 2;
                }
                else
                {
                    button.BackColor = secondColor;
                    playerTurn = 1;
                }

            }
        }
    }
}
