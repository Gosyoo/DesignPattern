using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.代理模式
{
    public class RealImage : Image
    {
        public string FileName;
        public RealImage(string fileName)
        {
            FileName = fileName;
            this.Loading();
        }
        public void display()
        {
            Console.WriteLine($"显示图片--Name:{FileName}");
        }

        public void Loading()
        {
            Console.WriteLine("Loading...");
        }
    }
}
