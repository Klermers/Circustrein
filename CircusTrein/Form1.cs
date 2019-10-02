using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircusTrein
{
    public partial class Form1 : Form
    {
        Train train;
        Animal animal;
        int cycle = 0;

        public Form1()
        {
            train = new Train();
            InitializeComponent();
        }

        private void AnimalAdd_Click(object sender, EventArgs e)
        {
            if(RecentAnimal() != null)
            {
                var result = train.TrainWagonCycleAdd(RecentAnimal());
                MessageBox.Show(result);
                AddToListbox1();
            }
            else
            {
                MessageBox.Show("You didn't put the correct data in.");
            }
        }
        
        public Animal RecentAnimal()
        {
            string name;
            int size;
            int type;

            name = NameBox.Text;


            if (Small.Checked == true)
            {
                size = 1;
            }
            else if (Medium.Checked == true)
            {
                size = 3;
            }
            else if (Big.Checked == true)
            {
                size = 5;
            }
            else
            {
                MessageBox.Show("Size isn't checked");
                return null;
            }

            if(Herbivour.Checked == true)
            {
                type = 1;
            }
            else if(Carnivour.Checked == true)
            {
                type = 2;
            }
            else
            {
                MessageBox.Show("Type isn't Checked");
                return null;
            }

            return animal = new Animal(name, size, type);
        }

        private void NextWagon_Click(object sender, EventArgs e)
        {
            if (cycle < train.Wagons.Count)
            {
                cycle++;
                AddToListbox1();
            }
            else
            {
                MessageBox.Show("There a no more wagons.");
            }
        }

        private void PrevWagon_Click(object sender, EventArgs e)
        {
            if(cycle >= 1)
            {
                cycle--;
                AddToListbox1();
            }
            else
            {
                MessageBox.Show("This is the first wagon");
            }
        }

        public void AddToListbox1()
        {
            foreach (var animal in train.Wagonanimals(cycle))
            {
                listBox1.Items.Add(animal.ToString());
            }
        }
    }
}
