using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace kkkkjhvdserbn
{
    internal class Converter
    {
        //array för konsonanter
        char[] charArray = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'z', 'x' };
        
        public string convert(string inData)
        {
            string newString = "";//skapa tom string för översatta språket
            inData = inData.ToLower();//omvandla till små bokstäver så att det kan kolla med charArray

            for (int i = 0; i<inData.Length; i++)//loopa för varje bokstav
            {
                if (Array.IndexOf(charArray, inData[i]) != -1)//om bokstäven är i charArray
                {
                    newString += inData[i] + "o" + inData[i];//"bokstäven" + o + "bokstäven"
                }
                else
                {
                    newString += inData[i];//spara bokstäven som vanligt
                }
            }
            return newString;//ge tillbaka ny string
        }
    }
}