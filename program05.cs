using System;

namespace ConsoleApp5
{
    using System;

    namespace ex6
    {
        class Box
        {
            float width;
            float height;
            float length;
            public float volume
            {
                get { return width * height * length; }
            }
            public Box(float width, float height, float length)
            {
                this.width = width;
                this.height = height;
                this.length = length;

            }
            public static float operator +(Box box1, Box box2)
            {
                return box1.volume + box2.volume;

            }
            public override string ToString()
            {
                return "box with width" + width + ",height" + height + "and length" + length;

            }
        }
        class OperatorOverloading
        {
            public static void Main()
            {
                Box box1 = new Box(10, 20, 30);
                Box box2 = new Box(25, 32, 15);
                Console.WriteLine("Volume of {0} is:{1}", box1, box1.volume);
                Console.WriteLine("Volume of {0} is:{1}", box2, box2.volume);
                Console.WriteLine("Volume after adding boxes:{0}", box1 + box2);


            }

        }

    }

}
