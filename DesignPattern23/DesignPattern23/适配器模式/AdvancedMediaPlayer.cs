using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.适配器模式
{
    /// <summary>
    /// 高级媒体播放器接口
    /// </summary>
    public interface IAdvancedMediaPlayer
    {
        public void playVlc(string fileName);

        public void playMp4(string fileName);
    }
}
