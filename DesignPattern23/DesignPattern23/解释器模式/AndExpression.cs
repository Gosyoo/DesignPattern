using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.解释器模式
{
    /// <summary>
    /// 非终结符表达式  与表达式
    /// </summary>
    public class AndExpression : Expression
    {
        public Expression expression1;
        public Expression expression2;

        public AndExpression(Expression expression1, Expression expression2)
        {
            this.expression1 = expression1;
            this.expression2 = expression2;
        }

        /// <summary>
        /// 筛选解释
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool interpret(string context)
        {
            string[] strArr = context.Split('的');
            return expression1.interpret(strArr[0]) && expression2.interpret(strArr[1]);
        }
    }
}
