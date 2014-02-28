using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml.Serialization;
using System.IO;

namespace MyPictures
{

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

        //================ SERILIZER ZONE =================//
        #region serializer
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

        #endregion

        //======== FILE EXPLORER & RECENSORS =================//
        #region explorer
        static IEnumerable<string> EnumeratePaths(string root)
        {
            if (root == null)
                throw new ArgumentNullException("root");
            if (!Directory.Exists(root))
                throw new ArgumentException("Invalid root path", "root");

            if (root.Length > 3)
                root = Path.GetDirectoryName(root + "\\");

            Queue<string> queue = new Queue<string>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                string curr = queue.Dequeue();
                bool failed = false;
                try
                {
                    foreach (var path in Directory.GetDirectories(curr))
                        queue.Enqueue(path);
                }
                catch
                {
                    failed = true;
                }
                if (!failed)
                    yield return curr;
            }
        }

        static IEnumerable<string> EnumerateFiles(string root)
        {
            var paths = EnumeratePaths(root);
            foreach (var nxt in paths)
            {
                foreach (var filename in Directory.GetFiles(nxt))
                    yield return filename;
            }
        }
        #endregion
    }
}
