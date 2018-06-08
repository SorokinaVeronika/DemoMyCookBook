using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace myCookBook
{
    public class Recipe
    {
        #region fields
        private string name;
        private List<Ingredient> ingredients;
        private string instructions;

        private int recipeID;
       
        #endregion

        #region constructors
        public Recipe(string n, List<Ingredient> i, string i2, int id )
        {
            name = n;
            ingredients = i;
            instructions = i2;  
            recipeID = id;
        }

        public Recipe()
        {
            name = "";
            ingredients = new List<Ingredient>();
            instructions = "";
            
            recipeID = 000000;

        }
        public Recipe(Recipe r)
        {
            name = r.Name;
            ingredients = r.Ingredients;
            instructions = r.Instructions;           
            recipeID = 0;
        }
        #endregion

        #region setters/getters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int ID
        {
            get { return recipeID; }
            set { recipeID = value; }
        }

        public string Instructions
        {
            get { return instructions; }
            set { instructions = value; }
        }

        public List<Ingredient> Ingredients
        {
            get { return ingredients; }
            set { ingredients = value.ToList(); }
        }
        #endregion

        #region methods
        public void save(XmlWriter writer)
        {
            writer.WriteStartElement("Recipe");

            writer.WriteElementString("Name",name);

            writer.WriteStartElement("Ingredients");

            foreach(Ingredient i in ingredients)
            {
                writer.WriteStartElement("Ingredient");
                writer.WriteElementString("IngredientName", i.Name);
                writer.WriteElementString("IngredientAmount", i.Amount);
                writer.WriteElementString("IngredientUnit", i.Unit);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();

            //rest of stuff needed to create recipe
            writer.WriteElementString("RecipeID", recipeID.ToString());
            writer.WriteElementString("Instructions", instructions);
            writer.WriteEndElement();
        }
        #endregion

    }
}
