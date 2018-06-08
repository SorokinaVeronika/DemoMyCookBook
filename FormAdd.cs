using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace myCookBook
{
    public partial class FormAdd : System.Windows.Forms.Form
    {
        string path = "";
        //create a new recipe, add it to the cookbook
        string name = "";
        List<Ingredient> ingredients = new List<Ingredient>();
        string instructions = "";
        
        int recipeID = 00000;
        
        Recipe r;

        public FormAdd(ref cookBook cb)
        {
            
            InitializeComponent();
        }

        //button to select an image for the recipe to be inserted
        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }



        private void button2_Click(object sender, EventArgs e)
        {
           if( openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.InitialDirectory + openFileDialog1.FileName;

            }
        }

        //FINISH button is pressed

        private void button3_Click(object sender, EventArgs e)
        {
            //set values based on form
            name = textBox1.Text;
            instructions = richTextBox1.Text.ToString();

            r = new Recipe(name, ingredients, instructions,  recipeID );

            //if any of the required boxes are empty, display a messagebox and a red label on the pieces that need updating
            if (textBox1.Text == "" || richTextBox1.Text.ToString() == "" || ingredients.Count == 0  )
            {
                MessageBox.Show("You need to fill in all boxes and add at least one ingredient before proceeding");

                if(textBox1.Text == "")//get name
                {
                    label2.ForeColor = Color.Red;
                    textBox1.ReadOnly = false;
                }
                if(richTextBox1.Text.ToString() == "")//get instructions
                {
                    label9.ForeColor = Color.Red;
                    richTextBox1.Enabled = true;
                    richTextBox1.ReadOnly = false;
                }
                if(ingredients.Count == 0)//need more ingredients
                {
                    label3.ForeColor = Color.Red;
                    button1.Enabled = true;
                    textBox2.ReadOnly = false;
                    textBox3.ReadOnly = false;
                    textBox4.ReadOnly = false;
                }

                   
                this.DialogResult = DialogResult.None;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Ingredient i = new Ingredient(textBox2.Text, textBox3.Text, textBox4.Text);
            ingredients.Add(i);
            textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
            this.DialogResult = DialogResult.None;

        }

        public Recipe Recipe
        {
            get { return r; }
        }

    }
}
