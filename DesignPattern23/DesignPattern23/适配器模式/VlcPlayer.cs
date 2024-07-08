using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.适配器模式
{
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public void playMp4(string fileName) { }

        public void playVlc(string fileName)
        {
            Console.WriteLine("播放Vlc格式的文件，Name：" + fileName);
        }
    }
}
