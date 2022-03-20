using System;
using System.Xml;

namespace LerXML
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start with XmlReader object  
            //here, we try to setup Stream between the XML file nad xmlReader  
            //using (XmlReader reader = XmlReader.Create(@"C:\Users\gimid\OneDrive\Documents\Csharp\product.xml"))
            //{
            //    while (reader.Read())
            //    {
            //        if (reader.IsStartElement())
            //        {
            //            //return only when you have START tag  
            //            switch (reader.Name.ToString())
            //            {

            //                case "Login":
            //                    //Console.WriteLine("The LOGIN is " + reader.ReadString());
            //                    textBox1.Text = reader.ReadString();
            //                    break;
            //                case "Password":
            //                    //Console.WriteLine("The PASSWORD is " + reader.ReadString());
            //                    textBox2.Text = reader.ReadString();
            //                    break;
            //                case "Product_id":
            //                    Console.WriteLine("The ID is " + reader.ReadString());
            //                    break;
            //                case "Product_name":
            //                    Console.WriteLine("The PRODUCT is " + reader.ReadString());
            //                    break;
            //                case "Product_price":
            //                    Console.WriteLine("The PRICE is " + reader.ReadString());
            //                    break;
            //            }
            //        }
            //        //Console.WriteLine("");
            //    }


            //}

            //vai pegar um elemento específico dentre outros e fazer a contagem dele
            //XmlDocument doc = new XmlDocument();
            //doc.Load(@"C:\Users\gimid\OneDrive\Documents\Csharp\product.xml");
            //int contagem = doc.SelectNodes("Table/Product").Count;          
            //Console.WriteLine("The COUNT is " + contagem);

            //vai pegar um elemento específico e fazer a contagem dele
            XmlDocument document = new XmlDocument();
            document.Load(@"C:\Users\gimid\OneDrive\Documents\Csharp\product.xml");
            XmlNodeList nodeList = document.GetElementsByTagName("Product");
            int count = nodeList.Count;
            Console.WriteLine("The COUNT is " + count);
        }
    }
}
