using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.适配器模式
{
    /// <summary>
    /// 媒体适配器
    /// </summary>
    public class MediaAdapter : IMediaPlayer
    {
        private IAdvancedMediaPlayer advancedMediaPlayer;


        public MediaAdapter(string Type)
        {
            if (Type == "Mp4")
            {
                advancedMediaPlayer = new Mp4Player();
            }
            else if (Type == "Vlc")
            {
                advancedMediaPlayer = new VlcPlayer();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public void Play(string Type, string Name)
        {
            if (Type == "Mp4")
            {
                advancedMediaPlayer.playMp4(Name);
            }
            else if (Type == "Vlc")
            {
                advancedMediaPlayer.playVlc(Name);
            }
        }
    }
}
