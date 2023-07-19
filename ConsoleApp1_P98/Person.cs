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

        /// <summary>
        /// 自我介紹方法，直接調用變量
        /// </summary>
        public void Self()
        {
            Console.WriteLine($"我叫{this._name}，今年{this._age}歲，是個{this._gender}生");
            //加上this表示當前這個類的對象
        }
        
        /// <summary>
        /// 自我介紹方法，調用屬性
        /// </summary>
        public void Self2()
        {
            Console.WriteLine($"我叫{this.Name}，今年{this.Age}歲，是個{this.Gender}生");
            //加上this表示當前這個類的對象
        }

        /// <summary>
        /// _name的屬性
        /// </summary>
        public string Name
        {
            //輸出屬性的時候，才會執行get方法
            get { return _name; }

            //賦值的時候，會執行set方法
            set { _name = value; }
        }

        /// <summary>
        /// Age屬性
        /// </summary>
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _age = value;
            }
        }

        /// <summary>
        /// Gender屬性
        /// </summary>
        public char Gender
        {
            get
            {
                if (this.Name == "舒華")
                {
                    return _gender = '女';
                }
                return _gender;
            }
            set { _gender = value; }
        }
    }
}
