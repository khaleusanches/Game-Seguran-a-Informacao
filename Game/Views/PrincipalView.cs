using game.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game.Views
{
    public partial class PrincipalView : Form
    {
        Image teste2;
        int i = 0;
        public PrincipalView()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            lb_question.Text = "testqandotestqando 12344testqando 12344testqando 12344testqando 12344testqando 12344testqando 12344testqando 12344testqando 12344 12344";
            pb_central.Image = new Bitmap("C:/Users/khaleu/Desktop/Etec/DS/seguranca/Game-Seguranca-Informacao/Game/imgs/pessoas/reigns.png");
            teste2 = new PictureBoxController().RotateImage(pb_central.Image, -5);
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            teste();
            
        }
        public void teste()
        {
            if (i < 500)
            {
                i++;
                teste2 = new PictureBoxController().RotateImage(pb_central.Image, (float)-0.1);
                pb_central.Image = teste2;
                Thread.Sleep(100);
                teste();
            }
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            pb_central.Image = new Bitmap("C:/Users/khaleu/Desktop/Etec/DS/seguranca/Game-Seguranca-Informacao/Game/imgs/pessoas/3.jpg");
        }
    }
}
