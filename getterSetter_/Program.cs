using System;

namespace getterSetter_
{
    class Program // property, getter setter에 관한 내용
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Age = 28;
            human.Height = 187;
            human.Weight = 80;
            Console.WriteLine("나이는 {0}, 키는 {1}, 몸무게는 {2} 입니다.",
                human.Age, human.Height, human.Weight);


        }
    }

    public class Human
    {
        private int age;
        private long height;
        private float weight;

        public int Age
        {
            set { age = value; }
            get { return age; }
        }
        public long Height
        {
            set { height = value; }
            get { return height; }
        }
        public float Weight
        {
            set { weight = value; }
            get { return weight; }
        }
    }
}
