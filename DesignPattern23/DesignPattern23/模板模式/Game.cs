using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.模板模式
{
    public abstract class Game
    {
        public abstract void InitGame();
        public abstract void StartGame();
        public abstract void EndGame();

        public void Play()
        {
            this.InitGame();
            
            this.StartGame();

            this.EndGame();
        }
    }
}
