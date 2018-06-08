

namespace myCookBook
{
    public class Ingredient
    {
        #region fields
        private string name;
        private string amount;
        private string unit;
        #endregion

        public Ingredient(string n, string a, string u)
        {
            name = n;
            amount = a;
            unit = u;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
    }
}
