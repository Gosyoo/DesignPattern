using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.解释器模式
{
    /// <summary>
    /// 终结符表达式
    /// </summary>
    public class TerminalExpression : Expression
    {

        /// <summary>
        /// 规则数据
        /// </summary>
        public string[] ruleList;

        public TerminalExpression(string[] ruleList)
        {
            this.ruleList = ruleList;
        }

        /// <summary>
        /// 判断是否满足规则
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool interpret(string context)
        {
            if (this.ruleList.Contains(context))
            {
                return true;
            }
            return false;
        }
    }
}
