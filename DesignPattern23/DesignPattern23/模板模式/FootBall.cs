using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.模板模式
{
    public class FootBall : Game
    {
        public override void EndGame()
        {
            Console.WriteLine("FootBall EndGame");
        }

        public override void InitGame()
        {
            Console.WriteLine("FootBall InitGame");

        }

        public override void StartGame()
        {
            Console.WriteLine("FootBall StartGame");
        }
    }
}
