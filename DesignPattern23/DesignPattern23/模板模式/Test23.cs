using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.模板模式
{
    public class Test23
    {
        public static void Test()
        {
            Game game = new FootBall();
            Game game2 = new OtherGame();

            game.Play();
            game2.Play();
        }
    }
}
