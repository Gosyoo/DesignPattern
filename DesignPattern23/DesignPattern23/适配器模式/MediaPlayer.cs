using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.适配器模式
{
    /// <summary>
    /// 媒体播放器接口
    /// </summary>
    public interface IMediaPlayer
    {
        public void Play(string Type,string Name);
    }
}
