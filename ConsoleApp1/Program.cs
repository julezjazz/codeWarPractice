// See https://aka.ms/new-console-template for more information
// Changing phrases to camelCase
// practice with substrings and ToUpper
using System.Runtime.InteropServices;

string str = "the-stealth-warrior";

char[] delimiterChars = {'_', '-'};

string[] words = str.Split(delimiterChars);

str = words[0];

for (int i = 1; i < words.Length; i++) {
   string firstLetter = words[i].Substring(0, 1).ToUpper();
   string fullWord = firstLetter + words[i].Substring(1);
   str += fullWord;
}













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




