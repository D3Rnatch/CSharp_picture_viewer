using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml.Serialization;
using System.IO;

namespace pictureViewer_model
{
    class Program
    {
        static void Main(string[] args)
        {
            Album test = new Album();
            Picture n = new Picture();
            n.tags.Add("Prout !");
            test.content.Add(n);
            test.name = "TOTO";
            test.place = "Venise";
            Album.Serialize(test);
            Console.WriteLine("Seriaization done !");
            Console.WriteLine(test.name + " " + test.fname); 
            Album test2 =
            Album.Deserializer(test.fname);

            // Console.WriteLine(test2.ToString2());
            Console.WriteLine("Read :" + test2.name + " " + test2.fname);
            Console.ReadKey();

            test.place = "paris";

            Album.Serialize(test);
            Console.WriteLine("Seriaization done !");
            Console.WriteLine(test.name + " " + test.fname + " " + test.place);
            Album test3 = Album.Deserializer(test.fname);

            // Console.WriteLine(test2.ToString2());
            Console.WriteLine("Read :" + test3.name + " " + test3.fname + " " + test3.place);
            Console.ReadKey();
        }        
    }

    /*
     * Picture Class, implements Model
     * Contains all data referring to any picture stored 
     * by the application
     */
    [SerializableAttribute]
    public class Picture
    {
        [XmlElement("Picture Name")]
        public String name;

        [XmlElement("Picture fname")]
        public String fname;
        
        [XmlElement("Picture Place")]
        public String place;

        [XmlElement("Picture Comments")]
        public List<String> comments;

        [XmlElement("Picture Tags")]
        public List<String> tags;

        [XmlElement("TimeSatmp")]
        public DateTime timeStamp;

        public Picture()
        {
            this.name = "./img/default.jpg";
            this.fname = "";
            this.place = "";
            this.comments = new List<String>();
            this.tags = new List<String>();
            this.timeStamp = new DateTime();
        }
        
    }

    /*
     * Album Class, implements Model
     * Contains all data referring to an album 
     */
    public class Album 
    {
        [XmlElement("Album Name")]
        public String name;

        [XmlElement("Album Place")]
        public String place;

        [XmlElement("Album Fname")]
        public String fname;
         
        [XmlElement("Album Tags")]
        public List<String> tags;

        [XmlElement("Album Content")]
        public List<Picture> content;

        public Album()
        {
            this.name = "default";
            this.place = "";
            this.fname = "./Albums/" + this.name + ".xml";
            this.tags = new List<String>();
            this.content = new List<Picture>();
        }

        
        public String ToString2()
        {
            String ret = "Album :" + this.name + this.place + this.content.Count + this.tags;
            return ret;
        }

        static public void Serialize(Album details)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Album));
            using (TextWriter writer = new StreamWriter(@details.fname))
            {
                serializer.Serialize(writer, details);
            }
        }

        static public Album Deserializer(String file) 
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Album));
            TextReader reader = new StreamReader(@file);
            object obj = deserializer.Deserialize(reader);
            Album details = (Album)obj;
            reader.Close();
            return details;
        }
    }
}
