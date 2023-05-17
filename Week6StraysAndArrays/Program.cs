string userName = "yavuz";

Console.WriteLine(userName.Length);
Console.WriteLine($"The last letter in your name is {userName[4]}");

//int counter = 0;

//for (int i = 0; i < userName.Length; i++)
//{
//    if (userName[i]== 'a')
//    {
//        counter++;
//    }
//}

//Console.WriteLine($"Your first name has {counter} a-letters ");


string updatedUserName = userName.Replace('a', '2').Replace('H', '1');
Console.WriteLine(updatedUserName);
