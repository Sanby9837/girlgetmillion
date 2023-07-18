using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P98
{
    /// <summary>
    /// 類
    /// </summary>
    public class Person
    {
        public string _name; //這三個都是變量/字段
        public int _age;
        public char _gender;

        
        public void Self()
        {
            Console.WriteLine($"我叫{this._name}，今年{this._age}歲，是個{this._gender}生");
            //加上this表示當前這個類的對象
        }

        /// <summary>
        /// _name的屬性
        /// </summary>
        public string Name
        {
            get { return _name; } 
            set { _name = value; }
        }
    }
}
