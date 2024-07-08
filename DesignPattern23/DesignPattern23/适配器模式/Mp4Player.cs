using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.适配器模式
{
    public class Mp4Player : IAdvancedMediaPlayer
    {
        public void playMp4(string fileName)
        {
            Console.WriteLine("播放Mp4格式的文件，Name：" + fileName);
        }

        public void playVlc(string fileName) { }
    }
}
