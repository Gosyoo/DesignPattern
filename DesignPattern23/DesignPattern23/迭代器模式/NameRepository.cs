using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.迭代器模式
{
    /// <summary>
    /// 名称存储库
    /// </summary>
    public class NameRepository : Container
    {

        public string[] names;

        public Iterator GetIterator()
        {
            return new NameIterator(this);
        }

        public NameRepository(string[] names)
        {
            this.names = names;
        }

        /// <summary>
        /// 实现迭代器接口的内部实现类
        /// </summary>
        private class NameIterator : Iterator
        {
            int index = 0;

            NameRepository nameRepository;

            public NameIterator(NameRepository repository)
            {
                this.nameRepository = repository;
            }
            public bool hasNext()
            {
                if (this.index < nameRepository.names.Length)
                {
                    return true;
                }
                return false;

            }

            public Object next()
            {
                if (hasNext())
                {
                    return nameRepository.names[this.index++];
                }
                return null;
            }
        }
    }
}
