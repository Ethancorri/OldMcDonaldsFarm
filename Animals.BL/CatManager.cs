using Animals.DL;
using Animals.Enumerations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Animals.BL
{
    public static class CatManager
    {
        public static void Save(List<Cat> cats)
        {
            try
            {

                CFile oFile = new CFile();
                oFile.Delete("Cat.txt");

                foreach (Cat oCat in cats)
                {
                    oCat.Save();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Cat> SaveXML(List<Cat> cats)
        {
            try
            {
                CFile oFile = new CFile("Cat.xml");
                oFile.Delete("Cat.xml");
                oFile.SaveXML(cats, typeof(List<Cat>));

                return cats;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Cat> LoadXML(List<Cat> cats)
        {
            //List<Cat> cats = new List<Cat>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Cat>));
            TextReader textReader = new StreamReader("Cat.xml");
            cats.AddRange((List<Cat>)serializer.Deserialize(textReader));

            textReader.Close();
            textReader.Dispose();
            textReader = null;

            return cats;
        }

        public static List<Cat> Fill(List<Cat> cats)
        {
            //List<Cat> cats = new List<Cat>();

            Cat oCat = new Cat("Black", AnimalType.Cat, 25, "Tabby");
            cats.Add(oCat);

            oCat = new Cat("White", AnimalType.Tiger, 125, "Fluffy");
            cats.Add(oCat);
            return cats;

        }
    }
}
