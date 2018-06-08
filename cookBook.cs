using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace myCookBook
{
    public class cookBook
    {
        private List<Recipe> recipeList;
        private int id;
        public cookBook()
        {
            recipeList = new List<Recipe>();
            id = 0;
        }

        public bool save(Stream stream)
        {
            //no recipes, nothing to save, return.
            if (recipeList.Count <= 0)
                return false;

            XmlDocument doc = new XmlDocument();
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = Encoding.UTF8;
            settings.NewLineChars = "\r\n";
            settings.NewLineOnAttributes = true;
            settings.Indent = true;
            
            XmlWriter writer = XmlWriter.Create(stream, settings);


            if (writer != null)
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("CookBook");

                foreach (Recipe r in recipeList)
                {
                    r.save(writer);
                }
                
                writer.WriteEndElement();
                writer.Close();
                return true;
            }
            return false;
        }

        public bool load(Stream stream)
        {

            XDocument doc = null;
            try
            {
                doc = XDocument.Load(stream);
            }
            catch(Exception)
            {
                return false;
            }

            XElement root = doc.Root; //get the root of the xml doc

            foreach(XElement child in root.Elements("Recipe"))//for all recipes
            {
                
                //get the name
                var name = child.Element("Name").Value;

                //get the ingredients tag
                XElement ingredients = child.Element("Ingredients");

                //now get each individual ingredient
                List<Ingredient> temp = new List<Ingredient>();
                foreach (XElement ingredient in ingredients.Elements("Ingredient"))
                {
                    var ingredientName = ingredient.Element("IngredientName").Value;
                    var ingredientAmount = ingredient.Element("IngredientAmount").Value;
                    var ingredientUnit = ingredient.Element("IngredientUnit").Value;

                    Ingredient i = new Ingredient(ingredientName, ingredientAmount, ingredientUnit);
                    temp.Add(i);
                }

                //have all ingredients. now get rest of information.
                var instructions = child.Element("Instructions").Value;
                
                var recipeID = child.Element("RecipeID").Value;

                Recipe r = new Recipe(name, temp, instructions, Convert.ToInt32(recipeID));
                recipeList.Add(r);
            }
            return true;
        }

        public bool insertRecipe(Recipe r)
        {
            recipeList.Add(r);
            return true;
        }

        public List<Recipe> Recipes
        {
            get { return recipeList; }
            set { recipeList = value; }
        }

        public Recipe findRecipe(string rName)
        {
            foreach(Recipe r in recipeList)
            {
                if(r.Name == rName)
                {
                    return r;
                }
            }
            return null;
        }
    }
}
