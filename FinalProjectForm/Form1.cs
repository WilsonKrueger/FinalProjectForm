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
    public partial class Form1 : Form
    {
        int id;
        String gender;
        String type;
        AnimalRepository animalRepository;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] animals = { "Dog", "Cat", "Cow", "Chicken", "Pig" };
            List<String> animalsList = new List<string>(animals);
            listBoxAnimal.DataSource = animalsList;

            animalRepository = new AnimalRepository();
            //listBox1.DataSource = animalRepository.getAllAnimal();
        }

        private void listBoxAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelType.Text = listBoxAnimal.SelectedItem.ToString();
        }

        private void buttonAddAnimal_Click(object sender, EventArgs e)
        {
            type = labelType.Text;
            int.TryParse(textBoxId.Text, out id);
            gender = comboBoxGender.Text;
            IAnimal animal = new Animal();
            animal.Type = type;
            animal.Id = id;
            animal.Gender = gender;

            animalRepository.addAnimal(animal);


            label5.Text = animalRepository.getOneAnimal(0).ToString();

            listView1.Items.Add(animal.ToString());
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDOB_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
