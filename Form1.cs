using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BallisticCalcs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void accuracyTrackBar_Scroll(object sender, EventArgs e)
        {
            string value = this.accuracyTrackBar.Value.ToString();

            this.accuracyText.Text = value;
        }

        private void accuracyText_TextChanged(object sender, EventArgs e)
        {
            int value = Int32.Parse(this.accuracyText.Text);

            this.accuracyTrackBar.Value = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double startSpeed = Double.Parse(this.textBox1.Text);

            double throwAngle = Double.Parse(this.textBox2.Text);
            
            double gravityAcceleration = Double.Parse(this.textBox3.Text);

            Ballistic ballistic = new Ballistic();

            ballistic.GravityAcceleration = gravityAcceleration;

            ballistic.StartSpeed = startSpeed;

            ballistic.ThrowAngle = throwAngle;

            ballistic.calculate();

            this.labelS.Text = Math.Round(ballistic.flightRange, Int32.Parse(this.accuracyText.Text)).ToString();

            this.labelA.Text = Math.Round(ballistic.throwAngle, Int32.Parse(this.accuracyText.Text)).ToString();

            this.labelH.Text = Math.Round(ballistic.maxHeight, Int32.Parse(this.accuracyText.Text)).ToString();

            this.labelV.Text = Math.Round(ballistic.startSpeed, Int32.Parse(this.accuracyText.Text)).ToString();

            this.labelT.Text = Math.Round(ballistic.flightTime, Int32.Parse(this.accuracyText.Text)).ToString();
        }
    }
}
