using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.适配器模式
{
    /// <summary>
    /// 适配器模式
    /// 它结合了两个独立接口的功能
    /// 例子：将内存卡插入读卡器，再将读卡器插入笔记本，这样就可以通过笔记本来读取内存卡
    /// </summary>
    public class Test5
    {
        public static void Test()
        {
            AudioPlayer player = new AudioPlayer();

            player.Play("Mp4", "xxxx.mp4");
            player.Play("Mp3", "xxxx.mp3");
            player.Play("Vlc", "xxxx.vlc");
            player.Play("avi", "xxxx.avi");

        }
    }
}
