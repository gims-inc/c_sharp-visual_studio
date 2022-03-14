using System;
///using System.Collections;
using System.Collections.Generic;


namespace udclassesStrings
{
    class Program
    {
        static string SumarizeText(string text,int maxlength=20 )
        {
            if (text.Length < maxlength)
                return text;

            var words = text.Split(' ');// break sentence into a string array of words

            var totalchar = 0;// initialise a character count.
            var sumarizedtxt = new List<string>();

            foreach (var word in words)
            {
                sumarizedtxt.Add(word);  //add each word to the list of the the summary text

                totalchar += word.Length + 1;// get each word's length and and add a 1 char for the whitespace
                if (totalchar > maxlength) // stop adding if its more than the defined lenth,
                    break;
            }

            return String.Join(" ",sumarizedtxt) + "...";// create another sentence by joining the list into a string


        }
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really long sentence";

            Console.WriteLine(SumarizeText(sentence)+"\n");


            /////////////////////////////////////////////////////////
            var name = "gab gimsinc ";
            //
            Console.WriteLine(" Trim:'{0}' \n ToUpper:{1}",name.Trim(),name.Trim().ToUpper());
            //
            var indx = name.IndexOf(' ');
            var fn = name.Substring(0,indx);
            var ln = name.Substring(indx + 1);
            Console.WriteLine("USING SUBSTRING \n First Name:{0} \n Last name:{1}", fn,ln );
            //
            var names = name.Split(' ');
            Console.WriteLine("USING SPLIT \n First Name:{0} \n Last name:{1}", names[0],names[1] );
            //
            Console.WriteLine("\nNew name is: "+name.Replace("gab","gabriel"));
            //validation
            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("\nInvalid Entry!");
            //
            var str = "29";
            Console.WriteLine("\nAge:"+ Convert.ToByte(str));
            //
            float price = 29.99f;
            Console.WriteLine("\nPrice:" + price.ToString("C0"));



        }
    }
}
