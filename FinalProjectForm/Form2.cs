using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectForm
{
    public partial class Form2 : Form
    {
        AnimalRepository animalRepository;

        public Form2(AnimalRepository inAnimalRepository)
        {
            InitializeComponent();
            animalRepository = inAnimalRepository;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Set this form as the top form
            this.TopMost = true;

            //Clear listBox1
            listBox1.Items.Clear();

            //Set up listBox1
            listBox1.DisplayMember = "Display";
            listBox1.ValueMember = "Id";

            //Put items into listBox1
            foreach(Animal animal in animalRepository.getAllAnimal())
            {
                listBox1.Items.Add(animal);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //Close this form 
            this.Close();
        }

        private void buttonRemoveAnimal_Click(object sender, EventArgs e)
        {
            Animal animal = (Animal)listBox1.SelectedItem;
            int index = listBox1.SelectedIndex;

            //Display error message if no item is selected
            if(index == -1)
            {
                MessageBox.Show("Must select an animal to remove!");
            }

            //Remove from list 
            if(index > -1)
            {
                animalRepository.removeAnimal(animal);
                listBox1.Items.RemoveAt(index);
            }
        }
    }
}
