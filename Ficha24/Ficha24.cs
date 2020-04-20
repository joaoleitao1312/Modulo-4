using System;

namespace Ficha24
{

    #region Types
    /// <summary>
    /// Types of products you can buy
    /// </summary>
    public enum Types
    {
        Home,
        Fruit,
        Fish,
        Meat,
        Vegetables
    }

    #endregion

    #region Sponsor
    /// <summary>
    /// The sponsors you can choose for your player
    /// </summary>
    public enum Sponsor
    {
        Acliclas,
        Nyka,
        Tigre,
        AboveArmor,
    }

    #endregion

    #region Car1

    public class Car
    {
        /// <summary>
        /// Car Constructor
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        public Car(string brand, string model, int year)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
        }

        private string brand;
        /// <summary>
        /// Car's Brand
        /// </summary>
        /// <returns></returns>
        public string GetBrand()
        {
            return brand;
        }

        public void SetBrand(string brand)
        {
            this.brand = brand;
        }

        private string model;
        /// <summary>
        /// Car's Model
        /// </summary>
        /// <returns></returns>
        public string GetModel()
        {
            return model;
        }

        public void SetModel(string model)
        {
            this.model = model;
        }

        private int year;
        /// <summary>
        /// Car's year
        /// </summary>
        /// <returns></returns>
        public int GetYear()
        {
            return year;
        }

        public void SetYear(int year)
        {
            this.year = year;
        }

    }

    #endregion

    #region Car2

    public class Car1
    {
        /// <summary>
        /// Car2's Constructor
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        public Car1(string brand, string model, int year)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
        }
        /// <summary>
        /// Car2's Brand
        /// </summary>
        public string brand { get; set; }
        /// <summary>
        /// Car2's Model
        /// </summary>
        public string model { get; set; }
        /// <summary>
        /// Car2's Year
        /// </summary>
        public int year { get; set; }
    }

    #endregion

    #region Products1

    public class Products
    {
        /// <summary>
        /// Product's Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="type"></param>
        public Products(string name, double price, Types type)
        {
            this.name = name;
            this.price = price;
            this.type = type;
        }

        private string name;
        /// <summary>
        /// Product's Name
        /// </summary>
        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        private double price;
        /// <summary>
        /// Product's Price
        /// </summary>
        public double GetPrice()
        {
            return price;
        }

        public void SetBrand(double price)
        {
            if (price > 0) this.price = price;
        }

        private Types type;
        /// <summary>
        /// Product's Type
        /// </summary>
        public Types GetType()
        {
            return type;
        }

        public void SetType(Types type)
        {
            this.type = type;
        }

    }

    #endregion

    #region Products2

    public class Products1
    {
        /// <summary>
        /// Products1's Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="type"></param>
        public Products1(string name, double price, Types type)
        {
            this.name = name;
            this.price = price;
            this.type = type;
        }
        /// <summary>
        /// Product's Name
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Product's Price
        /// </summary>
        public double price { get; set; }
        /// <summary>
        /// Product's Type
        /// </summary>
        public Types type { get; set; }

    }

    #endregion

    #region Player1

    public class Player1
    {
        /// <summary>
        /// Player's Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="height"></param>
        /// <param name="weight"></param>
        /// <param name="sponsor"></param>
        public Player1(string name, int age, float height, float weight, Sponsor sponsor)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
            this.sponsor = sponsor;
        }

        private string name;
        /// <summary>
        /// Player's Name
        /// </summary>
        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        private int age;
        /// <summary>
        /// Player's Age
        /// </summary>
        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            if (age > 0) this.age = age;
        }

        private float height;
        /// <summary>
        /// Player's Height
        /// </summary>
        public float GetHeight()
        {
            return height;
        }

        public void SetHeight(float height)
        {
            if (height > 0) this.height = height;
        }

        private float weight;
        /// <summary>
        /// Player's Weight
        /// </summary>
        public float GetWeight()
        {
            return weight;
        }

        public void SetWight(float weight)
        {
            if (weight > 0) this.weight = weight;
        }

        private Sponsor sponsor;
        /// <summary>
        /// Player's Sponsor
        /// </summary>
        public Sponsor GetSponsor()
        {
            return sponsor;
        }

        public void SetSponsor(Sponsor sponsor)
        {
            this.sponsor = sponsor;
        }

        private double imc;
        /// <summary>
        /// Player's IMC
        /// </summary>
        public double GetIMC()
        {
            return Math.Round(weight / (height * height));
        }

        public void SetIMC(double imc)
        {
            this.imc = imc;
        }
    }

    #endregion

    #region Player2

    public class Player2
    {
        /// <summary>
        /// Player2's Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="height"></param>
        /// <param name="weight"></param>
        /// <param name="sponsor"></param>
        public Player2(string name, int age, float height, float weight, Sponsor sponsor)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
            this.sponsor = sponsor;
        }
        /// <summary>
        /// Player2's Name
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Player2's Age
        /// </summary>
        public int age { get; set; }
        /// <summary>
        /// Player2's Height
        /// </summary>
        public float height { get; set; }
        /// <summary>
        /// Player2's Weight
        /// </summary>
        public float weight { get; set; }
        /// <summary>
        /// Player2's Sponsor
        /// </summary>
        public Sponsor sponsor { get; set; }
        /// <summary>
        /// Player2's IMC
        /// </summary>
        public double imc
        {
            get { return Math.Round(weight / (height * height)); }
        }

    }

    #endregion

}
