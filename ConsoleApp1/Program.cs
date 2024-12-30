using System.Runtime.InteropServices;
using System.Linq;
using System.Linq.Expressions;

// int n = Int32.Parse(Console.ReadLine());

int n = 17;

List<int> list = new List<int>();
int max = n / 2;


for (int i = 2; i <= max; i++) {
    if (n % i == 0) 
    {
        list.Add(i);
        Console.WriteLine(list[^1]);
    }  
}

if (list.Count == 0) {
    Console.WriteLine(n + " is a prime number");
}

// Console.WriteLine(list[^1]);





// See https://aka.ms/new-console-template for more information
// Changing phrases to camelCase
// practice with substrings and ToUpper
// using System.Runtime.InteropServices;

// string str = "the-stealth-warrior";

// char[] delimiterChars = {'_', '-'};

// string[] words = str.Split(delimiterChars);

// str = words[0];

// for (int i = 1; i < words.Length; i++) {
//    string firstLetter = words[i].Substring(0, 1).ToUpper();
//    string fullWord = firstLetter + words[i].Substring(1);
//    str += fullWord;
// }





// string testMessage = "sorry, try again";
  
//   static string Maskify(string cc)
//   { if(cc.Length <= 4){
//       Console.WriteLine(cc);  
//       return "great";
//   }
//    else {
//      int maskLength = cc.Length - 4;
//      string maskedText = "";
//      for ( int i = 0; i < maskLength; i++) {
//         maskedText += "#";
//     }

//     maskedText += cc[^4];
//     maskedText += cc[^3];
//     maskedText += cc[^2];
//     maskedText += cc[^1];
    
//      Console.WriteLine(maskLength);
//      Console.WriteLine(maskedText);
//      return "wonderful";
     
//    }
//   }
//   Maskify("abcdefg");




