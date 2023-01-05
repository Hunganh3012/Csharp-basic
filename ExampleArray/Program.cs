using System;

//int[] months = new int[12];

//for( int i=0; i < 12; i++)
//{
//    months[i] =i+ 1;
//}
//foreach(var a in months)
//{
//    Console.WriteLine(a);
//}
//Console.Read();


//Marng 2 chieu
//3 dofng 2 coojt
string[, ] name = new string[3, 2];
name[0, 0] = "A";
name[0, 1] = "B";
name[1, 0] = "C";
name[1, 1] = "D";
name[2, 0] = "E";
name[2, 1] = "F";
for (int i=0;i < 3; i++)
{
    for(int j = 0; i < 2; j++)
    {           
        Console.WriteLine(name[i, j]);
    }
}
Console.Read();

