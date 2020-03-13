using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZChores.UI
{
    public partial class AddJobButton : UserControl
    {
        private Color colorHover = AppConstants.Colors.colorAccent;
        private Color colorIdle = AppConstants.Colors.colorPrimary;    
        public AddJobButton()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button Clicked!!");        
        }

        private void OnMouseEnter(object sender , EventArgs e)
        {
            Console.WriteLine("Mouse Entered");
        }

        private void onMouseExit(object sender, EventArgs e)
        {
            Console.WriteLine("Mouse Exit");
        }
    }
}
