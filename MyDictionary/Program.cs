using System;

namespace MyDictionary
{
    class MyDictionary<Tkey,Tvalue>
    {


        Tkey[] keys = new Tkey[0];
        Tvalue[] values = new Tvalue[0];
        Tkey[] tempkeys = new Tkey[0];
        Tvalue[] tempvalues = new Tvalue[0];

        public void Add(Tkey key,Tvalue value)
        {
            tempkeys = keys;
            tempvalues = values;
            keys = new Tkey[tempkeys.Length + 1];
            values = new Tvalue[tempvalues.Length + 1];
            for (int i = 0; i < tempkeys.Length; i++)
            {
                keys[i] = tempkeys[i];
                values[i] = tempvalues[i];
            }

            keys[tempkeys.Length] = key;
            values[tempvalues.Length] = value;

           
        }

        public void Show()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Key="+keys[i]+" Value="+values[i]);
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> student = new MyDictionary<int, string>();

            student.Add(595, "Dinçer Dinç");
            student.Add(498, "Serdar Kılıçarslan");
            student.Add(687, "Zehra Balaban");
            student.Add(854, "Hakkı Dayı");

            student.Show();
            Console.ReadLine();
        }
    }
}
