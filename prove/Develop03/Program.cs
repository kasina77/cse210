using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
    }
}

class Scripture
{
    static void Main(string[] args){
        Console.WriteLine('5 Trust in the Lord with all your heart and lean not on your own understanding; 6 in all your ways submit to him, and he will make your paths straight.')
    }

 const void Main(string[] args){
    string split = "5 Trust, in, the, Lord, with, all, your, heart, and, lean, not, on, your, own, understanding,; 6 in, all, your, ways, submit, to, him, and, he, will, make, your, paths, straight, Proverbs 3:5-6 .";
    list<string> list = new list<string>();
    list = split.Split(',').ToList();
    foreach (var l in list)
    {
        Console.WriteLine(l);
    }
 }  



}

// class Reference 
// { 

// }

// class Word 
// {
//     hideWord;

//     showWord;
// }