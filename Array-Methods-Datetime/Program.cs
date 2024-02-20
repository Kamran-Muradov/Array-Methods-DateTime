#region Classwork

using System.Text;

//string name = "reshad";

//name = "test";

//stringbuilder test = new("salam");

//test.append("sagol");

//string data = console.readline();

//int result = int.parse(data);

//console.writeline(result);

//Data: string data = Console.ReadLine();

//int response;

//bool isConvert = int.TryParse(data, out response);

//if (isConvert)
//{
//    Console.WriteLine("Response is --- " + response);
//}
//else
//{
//    Console.WriteLine("Format is wrong, please add input again: ");
//    goto Data;
//}


//string[] names = { "Hacixan", "Reshad", "Kamran", "Ilqar", "Fatime", "Afide", "Fexriyye" };

//string[] arr2 = new string[8];

//string[] arr3 = new string[3] { "Ismayil", "Nesir", "Ayxan" };

//Console.WriteLine(names[3]);

//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(i);
//}

//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(names[i]);
//}

//foreach (var item in names)
//{
//    Console.WriteLine(item);
//}

//int[,,] nums = { { { 3, 5 }, { 9, 0 }, { 150, 222 } }, { { 15044, 22 }, { 13, 21 }, { 1500, 22 } }, { { 150, 22 }, { 150, 22 }, { 150, 22 } } };

////Console.WriteLine(nums.Rank);

//Console.WriteLine(nums[1, 2, 0]);


//Console.WriteLine(names.Contains("Reshad"));

//var datas = names.Reverse().ToArray();

//Console.WriteLine(datas[datas.Length-1]);

//Array.Sort(names);

//foreach (var item in names)
//{
//    Console.WriteLine(item);
//}

//int[] nums = { 3, 5, 7, 8 };

//Array.Sort(nums);

//var datas =nums.Reverse().ToArray();

//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}


//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}



//int[] arr = { 1, 2, 3 };


//Array.Resize(ref arr, 5);

//arr[3] = 200;

//Console.WriteLine(arr[3]);

//string[] arr = { "sd", "sd" };

//Array.Resize(ref arr, 3);

//Console.WriteLine(arr[2]);

//int[] arr1 = { 1, 2, 3 };

//int[] arr2 = { 4, 5 };

//Array.Resize(ref arr2, 5);

//arr1.CopyTo(arr2, 2);

//foreach (var item in arr2)
//{
//    Console.WriteLine(item);
//}

//Array.Resize(ref arr1, 1);




//var data = Array.FindAll(names, m => m == "Reshad");

//var data = Array.FindIndex(names, m => m == "Kamran");

//var data = Array.FindLastIndex(names, m => m == "Kamran");

//var data = names.FirstOrDefault();

//var data = names.FirstOrDefault(m => m == "Kamran");

//var datas = names.All(m => m == "Reshad");

//var datas = names.Any(m => m == "Reshad");

//var data = Array.Exists(names, m => m == "Reshad");

//var datas = names.Where(m => m == "Reshad").ToArray();

//var datas = names.OrderByDescending(m => m);

//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}

//var datas = names.Any(m => m == "Reshad");

//foreach (var item in names)
//{
//    if (item == "Reshad")
//    {
//        Console.WriteLine(true);
//        break;
//    }
//}

//string[] names = { "Reshad", "Reshad", "Reshad" };

////var datas = names.All(m => m == "Reshad");



//bool CheckAllDatas(string[] datas, string str)
//{
//    int count = 0;

//    for (int i = 0; i < datas.Length; i++)
//    {
//        if (datas[i] == str)
//        {
//            count++;
//        }
//    }

//    if (count == datas.Length)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}

//Console.WriteLine(CheckAllDatas(names, "Kamran"));



//DateTime date = DateTime.Now.AddYears(10);

//Console.WriteLine(date);

//DateTime birthday = new DateTime(2002, 05, 25);

//Console.WriteLine(birthday);

//DateOnly date = new DateOnly(2002, 05, 25);

//Console.WriteLine(date);

//var currentYear = DateTime.Now.Year;
//DateTime birthday = new DateTime(2002, 05, 25);

//var birthdayYear = birthday.Year;


//Console.WriteLine(currentYear - birthdayYear);

#endregion

#region Homework
int CountCharsInArray(char c, params string[] words)
{
    int count = 0;

    foreach (var word in words)
    {
        foreach (var letter in word)
        {
            if (letter == c)
            {
                count++;
            }
        }
    }

    return count;
}

int result = CountCharsInArray('a', "Hacixan", "Reshad", "Kamran", "Ilqar", "Fatime", "Afide", "Fexriyye");
Console.WriteLine(result);

#endregion

