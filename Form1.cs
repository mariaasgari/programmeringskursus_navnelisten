using System.Xml.Linq;

namespace Afleveringsopgave1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        // arrayet hvor navnene bliver gemt i
        string[] navne = new string[10];

        // index på navnet i listen
        int antal = 0;


        private void button1_Click(object sender, EventArgs e)
        {

            // tilføjer intastet navn i arrayet
            navne[antal] = textBox1.Text;

            //opdater index med en, til næste gang der bliver indtastet et navn.
            antal = antal + 1;


            // Opdater navne listen i textBox3
            UpdateTextBox();


            textBox1.Clear();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            int position = int.Parse(textBox2.Text);
            if (position >= 0 && position < antal)
            {
                // denne if statement bliver kun eksekveret hvis positionen findes i listen
                // hvis positionen ikke findes kommer der en fejlbesked længere ned.

                // forløkken overskriver navnet i positionen, med navnet som kommer efter, hvilket gentages i de efterfølgende navne.
                for (int i = position; i < antal; i++)

                {
                    navne[i] = navne[i + 1];

                }

                // reducere antallet med 1, efter der er blevet fjernet et navn

                antal = antal - 1;

                UpdateTextBox();

                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Ikke en gyldig position");
            }
        }

        private void UpdateTextBox()
        {
            // jeg har taget denne metode ud seperat, da den skal bruges flere steder.
            // så bliver metoderne ikke så lange og de er lettere at læse.
            textBox3.Clear();

            for (int i = 0; i < antal; i++)
            {
                textBox3.AppendText($"Pos. {i}: {navne[i]}" + Environment.NewLine);
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
