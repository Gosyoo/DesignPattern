using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.解释器模式
{
    /// <summary>
    /// 解释器模式  用于定义一种文法规则 
    /// </summary>
    public class Test15
    {
        public static void Test()
        {
            /* 定义规则
             * 
             * 公交车 指定城市 指定人群 免费
             * 
             * 指定城市 ： 广州 深圳 佛山
             * 
             * 指定人群 ： 老人 学生 军人
             * 
             */

            //定义文法规则

            //城市
            string[] city = ["广州", "深圳", "佛山"];
            //人群
            string[] person = ["老人", "学生", "军人"];
            Context context = new Context(city, person);

            //规则解析
            context.FreeCheck("广州的老人");
            context.FreeCheck("深圳的学生");
            context.FreeCheck("佛山的军人");
            context.FreeCheck("广州的老板");
     
        }
    }
}
