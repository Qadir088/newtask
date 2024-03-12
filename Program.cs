// 1.Verilmiş array-də tək ədədlərin sayını tapmaq və çap etmək.

//int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//int counter = 0;
//for(int i = 0; i < num.Length; i++)
//{
//    if (num[i] % 2 == 0)
//    {
//        counter++;
//    }
//}
//Console.WriteLine(counter);

//2.Verilmiş array-də ən kiçik və ən böyük ədədlərin cəmini tapmaq.

//int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//int Max = 0;
//int Min = 0;
//for(int i = 0; i < num.Length; i++)
//{
//    if (num[i] > Max)
//    {
//        Max = num[i];
//    }
//    if (Min > num[i])
//    {
//        Min = num[i];
//        Console.WriteLine(Min);

//    }
//}
//Console.WriteLine(Max- Min);

//3.Verilmiş array-dəki ədədlərin ən böyük və ən kiçik fərqlərini tapmaq. 


//int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//int max = 0;
//int min = 0;
//for (int i = 0; i < num.Length; i++)
//{
//    if (num[i]> max)
//    {
//        max = num[i];
//    }
//    else if (num[i]< min)
//    {
//        min  = num[i];
//    }
//}
//Console.WriteLine(max -min);

//4.Verilmiş array - dəki ədədlərin sırasını artan sıraya salmaq.

//int[] num = { 5, 3, 2, 1, 4 };
//bool check = true;
//int temp;
//do
//{
//    check = false;
//    for (int i = 0; i < num.Length; i++)
//    {
//        if (num[i] > num[i + 1])
//        {
//            check = true; ;
//            temp = num[i];
//            num[i] = num[i + 1];
//            num[i + 1] = temp;
//            check = false;
//        }
//    }
//} while (check);
//    for(int i =0; i < num.Length; i++)
//{
//    Console.WriteLine(num[i]); 
//}
//5.Verilmiş array-dəki tək və cüt ədədlərin cəmini ayrı-ayrı tapmaq. 

//int[] num = { 1, 2, 3, 4, 5, 6, 7, 8 };
//int single = 0;
//int even = 0;
//for(int i = 0; i < num.Length; i++)
//{
//    if (num[i] % 2 == 0)
//    {
//        single+= num[i];
//    }
//    else
//    {
//        even += num[i];
//    }
//}
//Console.WriteLine(single);
//Console.WriteLine(even);


int[] num = { 1, 2, 3, 4, 5, 6 };
int temp;
for(int i = 0; i < num.Length; i++)
{
    for(int j = 0; j < num[i]; j++)
    {
        temp = num[i];
        num[i] = num[j];
        num[j] = temp;
    }
}
Console.WriteLine(num);