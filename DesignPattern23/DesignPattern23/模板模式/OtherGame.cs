using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.模板模式
{
    public class OtherGame : Game
    {
        public override void EndGame()
        {
            Console.WriteLine("OtherGame EndGame");
        }

        public override void InitGame()
        {
            Console.WriteLine("OtherGame InitGame");

        }

        public override void StartGame()
        {
            Console.WriteLine("OtherGame StartGame");
        }
    }
}
