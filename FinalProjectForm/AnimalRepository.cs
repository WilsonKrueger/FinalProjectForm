using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectForm
{
    public class AnimalRepository : IAnimalRepository
    {
        //Database connection string
        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\AnimalTracker.mdf; Integrated Security = True; Connect Timeout = 30";

        //Use database connection to add animal to table
        public void addAnimal(IAnimal animal)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                String SQLtext = "INSERT INTO AnimalTable(Num, Id, Type, Gender, DOB) VALUES(@Num, @Id, @Type, @Gender, @DOB)";

                using (SqlCommand command = new SqlCommand(SQLtext, connection))
                {
                    command.Parameters.Add(new SqlParameter("Num", animal.Num));
                    command.Parameters.Add(new SqlParameter("Id", animal.Id));
                    command.Parameters.Add(new SqlParameter("Type", animal.Type));
                    command.Parameters.Add(new SqlParameter("Gender", animal.Gender));
                    command.Parameters.Add(new SqlParameter("DOB", animal.DateOfBirth));
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        //Use database connection to get all animals from table
        public List<IAnimal> getAllAnimal()
        {
            List<IAnimal> animalList = new List<IAnimal>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM AnimalTable", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Guid num = (Guid)reader["Num"];
                        int id = (int)reader["Id"];
                        String type = reader["Type"].ToString();
                        String gender = reader["Gender"].ToString();
                        DateTime dob = (DateTime)reader["DOB"];
                        animalList.Add(new Animal(num, id, type, gender, dob));
                    }
                }

            }
            
            return animalList;
        }

        //Use database connection to get one animal from table
        public IAnimal getOneAnimal(int index)
        {
            IAnimal animal = new Animal();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM AnimalTable WHERE (Num = @Num)", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    Guid num = (Guid)reader["Num"];
                    int id = (int)reader["Id"];
                    String type = reader["Type"].ToString();
                    String gender = reader["Gender"].ToString();
                    DateTime dob = (DateTime)reader["DOB"];
                    animal = new Animal(num, id, type, gender, dob);
                }
            }

            return animal;
        }

        //Use database connection to remove one animal from table
        public void removeAnimal(IAnimal animal)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("DELETE FROM AnimalTable WHERE (Num = @Num)", connection))
                {
                    command.Parameters.Add(new SqlParameter("Num", animal.Num));
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            
        }
    }
}
