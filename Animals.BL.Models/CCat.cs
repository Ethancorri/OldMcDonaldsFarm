using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Animals.Enumerations;

namespace Animals.BL
{
    public class Cat : CAnimal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private float cost;

        public float Cost
        {
            get { return cost; }
            set { cost = value; }
        }


        public Cat()
        {
        }

        public Cat(string _color, AnimalType _type,float _cost, string _name)
        {
            Color = _color;
            Animaltype = _type;
            cost = _cost;
            name = _name;
        }

    }
}
