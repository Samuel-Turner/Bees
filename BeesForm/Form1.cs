using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bees;

namespace BeesForm
{
    public partial class Form1 : Form
    {

        List<Bee> BeeList = new List<Bee>();
        List<Label> LabelList = new List<Label>();
        private readonly Random _random = new Random();
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Subtract random %";
            this.label31.Text = "Worker Bees;";
            this.label32.Text = "Queen Bees;";
            this.label33.Text = "Drone Bees;";
            initialiseBeeList();
            initialiseLabelList();
            changeLabelTexts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Bee bee in BeeList)
            {
                bee.Damage(_random.Next(1, 79));
            }
            changeLabelTexts();
        }
        private void changeLabelTexts() {
            for (int i = 0; i < BeeList.Count(); i++)
            {
                LabelList[i].Text = BeeList[i].Print();
            }
        }
        private void initialiseBeeList()
        {
            for (int i = 0; i < 10; i++)
            {
                BeeList.Add(new WorkerBee());
            }
            for (int i = 0; i < 10; i++)
            {
                BeeList.Add(new QueenBee());
            }
            for (int i = 0; i < 10; i++)
            {
                BeeList.Add(new DroneBee());
            }
        }
        private void initialiseLabelList()
        {
            LabelList.Add(label1);
            LabelList.Add(label2);
            LabelList.Add(label3);
            LabelList.Add(label4);
            LabelList.Add(label5);
            LabelList.Add(label6);
            LabelList.Add(label7);
            LabelList.Add(label8);
            LabelList.Add(label9);
            LabelList.Add(label10);
            LabelList.Add(label11);
            LabelList.Add(label12);
            LabelList.Add(label13);
            LabelList.Add(label14);
            LabelList.Add(label15);
            LabelList.Add(label16);
            LabelList.Add(label17);
            LabelList.Add(label18);
            LabelList.Add(label19);
            LabelList.Add(label20);
            LabelList.Add(label21);
            LabelList.Add(label22);
            LabelList.Add(label23);
            LabelList.Add(label24);
            LabelList.Add(label25);
            LabelList.Add(label26);
            LabelList.Add(label27);
            LabelList.Add(label28);
            LabelList.Add(label29);
            LabelList.Add(label30);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
