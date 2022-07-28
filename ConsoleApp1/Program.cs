using System;
using pizza;
using System.Linq;
using System.Text;
using System.Collections;


namespace ConsoleApp1
{

    public class items
    {

       

       public static void sayBoys()
        {
            itms boys = new itms("martins", 45);
            Console.WriteLine(boys.age +", "+ boys.name);
        }

    }
    public class Program
    {
        public static void Main()
        {
            Database dbConn = new Database();
           items.sayBoys();
            Pussy psy = new Pussy();
            int[] newArr = {};
            Console.WriteLine(psy.Users().ToString());
            for(int gg=0;gg<psy.Users().Length;gg++)
            {
                newArr.Append(psy.Users()[0, 0]);
                string sent = $"i am not available to {psy.Users()[0, 0]}";
                Console.WriteLine(sent);
            }

            Console.WriteLine("the time is {0} o clock", 2);
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("hello");

            Console.WriteLine(list.GetType());



        }
      

    }
}