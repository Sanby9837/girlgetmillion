using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_P98
{
    internal class Student
    {
        private string _name;
        private char _gender;
        private int _age;
        private int _score_chinese;
        private int _score_math;
        private int _score_english;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public char Gender
        {
            get { return _gender; }
            set
            {
                if (value != '男' && value != '女')
                {
                    value = '男';
                }
                _gender = value;
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value >= 100)
                {
                    value = 0;
                }
                _age = value;
            }
        }

        public int ScoreChinese
        {
            get { return _score_chinese; }
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _score_chinese = value;
            }
        }

        public int ScoreMath
        {
            get { return _score_math; }
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _score_math = value;
            }
        }

        public int ScoreEnglish
        {
            get { return _score_english; }
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _score_english = value;
            }
        }

        public void Self()
        {
            Console.WriteLine($"大家好，我叫{this.Name}，今年{this.Age}歲，是{this.Gender}同學");
        }

        public void Score()
        {
            int sum = this.ScoreChinese + this.ScoreMath + this.ScoreEnglish;
            Console.WriteLine($"{this.Name}的總成績是{sum}、平均成績{sum/3}");
        }

        /// <summary>
        /// new的時候，會被執行
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="chinese"></param>
        /// <param name="math"></param>
        /// <param name="english"></param>
        public Student(string name, int age, char gender, int chinese, int math, int english)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.ScoreChinese = chinese;
            this.ScoreMath = math;
            this.ScoreEnglish = english;
        }
    }
}
