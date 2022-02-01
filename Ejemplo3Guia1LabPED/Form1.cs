using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo3Guia1LabPED
{
    public partial class Form1 : Form
    {

        int x, y; //variables globales que permiten determinar ubicacion del click


        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point punto = new Point(e.X, e.Y);
            x = punto.X;
            y = punto.Y;
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics(); //establece zona para dibujo
            Pen lapiz = new Pen(Color.Black); //declaro color de pen a utilizar

            if(listBox1.SelectedIndex==0) //si selecciona circulo
            {
            SolidBrush sb = new SolidBrush(Color.Red); //brush en rojo
            g.DrawEllipse(lapiz, x - 50, y - 50, 100, 100); /*dibujara elipse utilizando ese pen,
            con la posiicion en X y Y menos 50 y dimensiones 100 */
                g.FillEllipse(sb, x - 50, y - 50, 100, 100); //rellena de color la elipse dada
            }

            if (listBox1.SelectedIndex == 1) //si selecciona rectangulo
            {
            SolidBrush sb = new SolidBrush(Color.Green); //brush en verde
            g.DrawRectangle(lapiz, x - 50, y - 50, 100, 100); /*dibujara rectangulo utilizando ese pen,
            con la posicion en X y Y menos 50 y dimensiones 100 */
            g.FillRectangle(sb, x - 50, y - 50, 100, 100); //rellena de color la elipse dada
            }
        }
    }
}
