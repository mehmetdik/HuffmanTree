using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12253021HW3
{
    class Frekans
    {
        public void FrekansBul()
        {
            StreamReader dosyaOku;            string yazi;
            string temp=null;
            LinkedList list = new LinkedList();

            dosyaOku = File.OpenText("D:/letter.txt");



            while ((yazi = dosyaOku.ReadLine())!= null)
            {
                temp += yazi.ToString();
               
            }
            Console.WriteLine(temp);
          
            int j,count=1;
           
            for (int i = 0; i < temp.Length; i++)
            {
                

                for ( j = 1; j < temp.Length; j++)
                {
                    

                    if (temp[i].CompareTo(temp[j])==0)
                    {
                        count++;
                    }

                    
                }

                list.addToEnd(temp[i].ToString(),count);
                
                
                
            }

            list.display();

        }

        




    }
}
