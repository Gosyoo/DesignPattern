using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.适配器模式
{
    /// <summary>
    /// 音频播放器
    /// </summary>
    public class AudioPlayer : IMediaPlayer
    {
        private MediaAdapter mediaAdapter;

        public void Play(string Type, string Name)
        {
            //老旧格式的文件
            if (Type == "Mp3")
            {
                Console.WriteLine("播放Mp3格式的文件，Name：" + Name);
            }
            else if (Type == "Mp4" || Type == "Vlc")
            {
                mediaAdapter = new MediaAdapter(Type);
                mediaAdapter.Play(Type, Name);
            }
            else
            {
                Console.WriteLine("不支持该格式的文件，Name：" + Name);
            }
        }
    }
}
