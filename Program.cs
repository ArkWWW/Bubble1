using System;
using System.Collections.Generic;
namespace 冒泡排序1
{
    class Program
    {
        static void Main(string[] args)
        {
            //不会真的有人刚刚百度完啥是冒泡排序就来写了吧？
            //              算法步骤
            //比较相邻的元素。如果第一个比第二个大，就交换他们两个。
            //对每一对相邻元素作同样的工作，从开始第一对到结尾的最后一对。
            //这步做完后，最后的元素会是最大的数。
            //针对所有的元素重复以上的步骤，除了最后一个。
            //持续每次对越来越少的元素重复上面的步骤，直到没有任何一对数字需要比较。

            List<int> list = CreateList(10, 0, 100);
            Bubble(list);
            //我好自豪啊！居然写好了！！！
            //懒得做扩展方法啦，泛型什么的
            
            //第三个其实就是检测的时候换一个方法而已
        }
        static List<int> CreateList(int many,int min,int max)
        {
            Random r = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < many; i++)
            {
                list.Add(r.Next(min, max));
            }
            return list;
        }
        static void  Bubble( List<int> list)
        {
            int smallPoint = 0;
            int bigPoint = 1;
            bool done = false;
            while (!done)
            {
                Print2(list);
                if (bigPoint>list.Count-1)
                {
                    done = true;
                    continue;
                }
                if (list[smallPoint]>list[bigPoint])//这一行换一下就变成第三个作业了
                {
                    Swap(list, smallPoint, bigPoint);
                }
                smallPoint++;
                bigPoint++;
            }
        }
        static void Swap(List<int> list,int Point1,int Point2)
        {
            int temp = list[Point1];
            list[Point1] = list[Point2];
            list[Point2] = temp;

        }
        static void Print1(List<int> list)
        {
            int a = 0;
            foreach (int item in list)
            {
                Console.Write($"数据{a}：");
                Console.WriteLine(item);
                a++;
            }
            Console.WriteLine();
        }
        static void Print2(List<int> list)
        {
            foreach (int item in list)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
}
