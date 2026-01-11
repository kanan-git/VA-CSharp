using System;

namespace Untitled
{
    static class Something
    {
        static void Main(string[] args)
        {
            int[] TestArray = new int[] {99, 100, 1, 0, 25, 39, 9, 2, 4, 5, 3, 7, 11, 10, 6, 12, 8};
            Console.WriteLine(IDGenerator(TestArray)); // EXPECTED OUTPUT: 13
        }

        static int IDGenerator(int[] ExistIdsList)
        {
            if(ExistIdsList.Length > 0)
            {
                int NewID = 0;
                bool IsExist = true;
                for(int j=0; IsExist==true; j++)
                {
                    for(int i=0; i<ExistIdsList.Length; i++)
                    {
                        IsExist = false;
                        if(j == ExistIdsList[i])
                        {
                            IsExist = true;
                            break;
                        };
                        NewID = j;
                    };
                };
                return NewID;
            }
            else
            {
                return 0;
            };
        }
    };
};
