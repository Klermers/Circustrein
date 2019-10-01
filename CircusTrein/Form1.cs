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
        List<Wagon> Train;
        Animal animal;
        string name;
        int size;
        int type;

        public Form1()
        {
            Train = new List<Wagon>();
            InitializeComponent();
        }

        public void Createanimal()
        {
            name = NameBox.Text;

            if(Small.Checked == true)
            {
                size += 1;
            }
            else if(Medium.Checked == true)
            {
                size += 3;
            }
            else if(Big.Checked == true)
            {
                size += 5;
            }
            else
            {
                MessageBox.Show("No size input");
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
                MessageBox.Show("No Type input");
            }

            animal = new Animal(name,size,type);
        }

        private void AnimalAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
