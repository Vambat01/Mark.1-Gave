using System;

namespace TestSolution
{
    public class Cat
    {
        #region PropsAndFields
        private string color;

        public string Color
        {
            get { return color; }
            set
            {
                if (value.Length > 0)
                {
                    color = value;
                }
            }
        }



        /*
         * private int myProperty;
        
            public int MyProperty
            {
                get { return myProperty; }
                set { myProperty = value; }
            }
        */

        private string eyeColor;
        public string EyeColor
        {
            get
            {
                return eyeColor;
            }
            set
            {
                if (value.Equals("green") || value.Equals("yellow"))
                    eyeColor = value;
            }
        }


        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 3)
                    name = value;
            }
        }

        public int Age { get; set; }
        public double Weight { get; set; }
        #endregion

        public Cat()
        {

        }

        public Cat(string name, int age, double weight, string color, string eyeColor)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Color = color;
            EyeColor = eyeColor;
        }

        #region Methods
        public void Meow()
        {
            Console.WriteLine($"{Name}:{Age} said MEOW");
        }

        public int InHumanAge(int stressModifier)
        {
            return Age * 7 + stressModifier;
        }
        #endregion
    }
}
