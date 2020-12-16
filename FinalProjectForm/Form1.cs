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
        String type;
        int id;
        String gender;
        DateTime dob;
        AnimalRepository animalRepository;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create list of animals to be slected
            String[] animals = { "Cow", "Chicken", "Pig", "Guineafowl", "Sheep", "Goat", "Llama", "Alpaca", "Ostrich", "Emu", "Pigeon", "Dog", "Cat" };
            List<String> animalsList = new List<string>(animals);
            listBoxAnimal.DataSource = animalsList;

            //Create an animal repository
            animalRepository = new AnimalRepository();

            //Setting up dateTimePicker1 with proper format
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMM d, yyyy";
        }

        private void listBoxAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelType.Text = listBoxAnimal.SelectedItem.ToString();
        }

        private void buttonAddAnimal_Click(object sender, EventArgs e)
        {
            //Get values from form
            type = labelType.Text;
            int.TryParse(textBoxId.Text, out id);
            gender = comboBoxGender.Text;
            dob = dateTimePicker1.Value;

            //Create new animal object with data above
            IAnimal animal = new Animal();
            animal.Type = type;
            animal.Id = id;
            animal.Gender = gender;
            animal.DateOfBirth = dob;

            //Add animal to repository
            animalRepository.addAnimal(animal);

            //Confirm animal added
            labelConfirmAdd.Text = "Animal Added!";
        }

        private void buttonLOA_Click(object sender, EventArgs e)
        {
            //Minimize the current window
            this.WindowState = FormWindowState.Minimized;

            //Create new Form 2 and show it wait for Form 2 to close before continuing
            Form2 newForm = new Form2(animalRepository);
            newForm.ShowDialog();

            //Show window that was minimaize after Form 2 closes
            this.WindowState = FormWindowState.Normal;

            //Clear labelConfirmAdd
            labelConfirmAdd.Text = "";
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            //Clear labelConfirmAdd
            labelConfirmAdd.Text = "";
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clear labelConfirmAdd
            labelConfirmAdd.Text = "";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //Clear labelConfirmAdd
            labelConfirmAdd.Text = "";
        }
    }
}
