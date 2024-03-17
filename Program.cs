using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD5_1302223061
{
    class DataGeneric<T>
    {
        T Data { get; set; }
        public DataGeneric(T data)
        {
            Data = data;
        }
        public void PrintData()
        {
            Console.WriteLine($"tersimpan data sebagai berikut: {Data}");
        }
    }
    class Program
    {


        static void Main(string[] args)
        {
            DataGeneric<string> stringData = new DataGeneric<string>("Y");
            stringData.PrintData();
            DataGeneric<string> nimData = new DataGeneric<string>("1302223061");
            nimData.PrintData();
            Console.ReadLine();
        }
    }
}