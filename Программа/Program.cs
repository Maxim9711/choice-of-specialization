string [] stringArr = new string [] {"hello", "2", "world", ":-)"};
int lengthArr = 0;
int lengthStr = 3;

ShowArray(stringArr);

lengthArr = NumberOfStringsLLT(stringArr, lengthStr);

string [] newStringArr = new string [lengthArr];

CopyOfStringsLLT(stringArr, newStringArr, lengthStr);

ShowArray(newStringArr);

// Show array of string
void ShowArray(string [] str){

  for(int i=0; i < str.Length; i++)
    Console.Write($"{str[i]} ");
  Console.WriteLine();

}

// number of strings with length less than
int NumberOfStringsLLT(string [] str, int lengthStr){

  int numStrLLT = 0;

  for(int i=0; i < str.Length; i++)
    if (str[i].Length <= lengthStr)
      numStrLLT++;

  return numStrLLT;
}

// copy strings with length less than 5
void CopyOfStringsLLT(string [] firstArrStr, string [] secondArrStr, int lengthStr){

  int j = 0;

  for(int i=0; i < firstArrStr.Length && j < secondArrStr.Length; i++)
    if (firstArrStr[i].Length <= lengthStr)
      secondArrStr[j++] = firstArrStr[i];

}
