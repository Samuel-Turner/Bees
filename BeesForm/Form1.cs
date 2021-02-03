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
            button1.Text = "Subtract random";
            this.label31.Text = "Worker Bees;";
            this.label32.Text = "Queen Bees;";
            this.label33.Text = "Drone Bees;";
            WorkerBee workerBee1 = new WorkerBee();
            WorkerBee workerBee2 = new WorkerBee();
            WorkerBee workerBee3 = new WorkerBee();
            WorkerBee workerBee4 = new WorkerBee();
            WorkerBee workerBee5 = new WorkerBee();
            WorkerBee workerBee6 = new WorkerBee();
            WorkerBee workerBee7 = new WorkerBee();
            WorkerBee workerBee8 = new WorkerBee();
            WorkerBee workerBee9 = new WorkerBee();
            WorkerBee workerBee10 = new WorkerBee();
            QueenBee queenBee1 = new QueenBee();
            QueenBee queenBee2 = new QueenBee();
            QueenBee queenBee3 = new QueenBee();
            QueenBee queenBee4 = new QueenBee();
            QueenBee queenBee5 = new QueenBee();
            QueenBee queenBee6 = new QueenBee();
            QueenBee queenBee7 = new QueenBee();
            QueenBee queenBee8 = new QueenBee();
            QueenBee queenBee9 = new QueenBee();
            QueenBee queenBee10 = new QueenBee();
            DroneBee droneBee1 = new DroneBee();
            DroneBee droneBee2 = new DroneBee();
            DroneBee droneBee3 = new DroneBee();
            DroneBee droneBee4 = new DroneBee();
            DroneBee droneBee5 = new DroneBee();
            DroneBee droneBee6 = new DroneBee();
            DroneBee droneBee7 = new DroneBee();
            DroneBee droneBee8 = new DroneBee();
            DroneBee droneBee9 = new DroneBee();
            DroneBee droneBee10 = new DroneBee();
            BeeList.Add(workerBee1);
            BeeList.Add(workerBee2);
            BeeList.Add(workerBee3);
            BeeList.Add(workerBee4);
            BeeList.Add(workerBee5);
            BeeList.Add(workerBee6);
            BeeList.Add(workerBee7);
            BeeList.Add(workerBee8);
            BeeList.Add(workerBee9);
            BeeList.Add(workerBee10);
            BeeList.Add(queenBee1);
            BeeList.Add(queenBee2);
            BeeList.Add(queenBee3);
            BeeList.Add(queenBee4);
            BeeList.Add(queenBee5);
            BeeList.Add(queenBee6);
            BeeList.Add(queenBee7);
            BeeList.Add(queenBee8);
            BeeList.Add(queenBee9);
            BeeList.Add(queenBee10);
            BeeList.Add(droneBee1);
            BeeList.Add(droneBee2);
            BeeList.Add(droneBee3);
            BeeList.Add(droneBee4);
            BeeList.Add(droneBee5);
            BeeList.Add(droneBee6);
            BeeList.Add(droneBee7);
            BeeList.Add(droneBee8);
            BeeList.Add(droneBee9);
            BeeList.Add(droneBee10);
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
            for (int i = 0; i < BeeList.Count(); i++)
            {
                LabelList[i].Text = BeeList[i].Print();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Bee bee in BeeList)
            {
                bee.Damage(_random.Next(0, 79));
            }
            for(int i=0; i<BeeList.Count(); i++)
            {
                LabelList[i].Text = BeeList[i].Print();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
