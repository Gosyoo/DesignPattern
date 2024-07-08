using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.代理模式
{
    public class ProxyImage : Image
    {
        public RealImage realImage;
        public string fileName;

        public ProxyImage(string fileName)
        {
            this.fileName = fileName;
        }

        public void display()
        {
            if (realImage == null) {
                realImage = new RealImage(fileName);
            }
            realImage.display();
        }
    }
}
