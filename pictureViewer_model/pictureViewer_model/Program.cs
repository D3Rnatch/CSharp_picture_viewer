using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pictureViewer_model
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    /*
     *  Model Interface  
     * Contains all common functions used and implemented in all Model Classes     * 
     */
    private interface Model
    {

    }

    /*
     * Picture Class, implements Model
     * Contains all data referring to any picture stored 
     * by the application
     */
    [Serializable()]
    private class Picture : Model 
    {

    }

    /*
     * Album Class, implements Model
     * Contains all data referring to an album 
     */
    [Serializable()]
    public class Album : Model 
    {

    }

    /*
     * Exception definition of the Model implementation 
     */

    public class ModelException : Exception
    {

    }
}
