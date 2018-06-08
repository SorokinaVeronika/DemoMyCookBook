using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace myCookBook
{
    public partial class Form : System.Windows.Forms.Form
    {

        public static cookBook cb = new cookBook();
        public Recipe current;

        public void update()
        {

           foreach (Recipe r in cb.Recipes)
           {
                if (!listBox.Items.Contains(r.Name.ToString()))
                 {
                        listBox.Items.Add(r.Name.ToString());
                 }
           }


            //if something is selected, update it. if not, no need
            if (listBox.SelectedItems.Count > 0)
            {

                recipeNameLabel.Text = current.Name;
                ingredientsList.Items.Clear();

                instructionsBox.Text = current.Instructions;

                foreach(Ingredient i in current.Ingredients)
                {
                    ingredientsList.Items.Add(i.Amount + " " + i.Unit + " " + i.Name);
                }


                ingredientsLabel.Visible = true;
                ingredientsList.Visible = true;
                recipeNameLabel.Visible = true;
                instructionsLabel.Visible = true;
                instructionsBox.Visible = true;

            }
        }

        public Form()
        {
            this.FormClosing += new FormClosingEventHandler(FormClosing_3);
            this.FormClosed += new FormClosedEventHandler(FormClosed_3);
            this.Load += new System.EventHandler(this.Form3_Load);
            
            InitializeComponent();

          
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            Stream stream = new FileStream("cookbook.xml", FileMode.Open, FileAccess.Read);
            cb.load(stream);
            stream.Close();
          
            update();

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Recipe r;

            //guard code to see if there is a valid index selected
            if (listBox.SelectedIndex != -1)
            {
                r = new Recipe(cb.findRecipe(listBox.SelectedItem.ToString())); //search through recipes in cookbook to find specific name;

                if (r != null)
                {
                    current = r;
                    update();
                }
                else
                {
                    update();
                }
            }


            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAdd newRecipe = new FormAdd(ref cb);
            DialogResult dr = DialogResult.None;
            while (dr!= DialogResult.OK && dr != DialogResult.Cancel) { dr = newRecipe.ShowDialog(); };
            if (newRecipe.Recipe != null)
            {
                cb.insertRecipe(newRecipe.Recipe);
                update();
                
            }
            newRecipe.Close();

        }

        private void FormClosing_3(object sender, FormClosingEventArgs e)
        {
            //Things while closing
            Stream stream = new FileStream("cookbook.xml", FileMode.OpenOrCreate, FileAccess.Write);
            cb.save(stream);
            Environment.Exit(0);

        }

        private void FormClosed_3(object sender, FormClosedEventArgs e)
        {
            //Things when closed
            Application.Exit();
        }
    }
}
