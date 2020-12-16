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

            //Put items into listBox1
            foreach(Animal animal in animalRepository.getAllAnimal())
            {
                listBox1.Items.Add(animal.ToString());
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //Close this form 
            this.Close();
        }
    }
}
