// меняем все пробелы на вертикальные черточки
// меняем т на Т
// меняем о на О
// сделать в одном цикле
string mStr = "Приветствую тебя, пустынный yгoлoк!";
Console.WriteLine(mStr + "- origin");
/*
string[] mCharOld={" ", "т", "o"};
string[] mCharNew={"|", "T", "O"};

// блок перебора заменяемых символов
    for (int j=0; j<3; j++){
    string newStr = Replacer(mStr, "mCharOld[j]", "mCharNew[j]");
    Console.WriteLine(newStr);
    Console.WriteLine();
    }
*/

string newStr = Replacer(mStr, ' ', '|');
    Console.WriteLine(newStr);
    // Console.WriteLine();
newStr = Replacer(newStr, 'т', 'T');
    Console.WriteLine(newStr);
    // Console.WriteLine();
newStr = Replacer(newStr, 'o', 'O');
    Console.WriteLine(newStr);
    // Console.WriteLine();
newStr = Replacer(mStr, '!', '?');
    Console.WriteLine(newStr);
    // Console.WriteLine();

string Replacer(string text, char oldVal, char newVal){
    string result = String.Empty;
    for(int i=0; i< text.Length; i++){
        if (text[i]==oldVal){
            result = result + $"{newVal}";
        }else{
            result = result + $"{text[i]}";
        }
    }
    return result;
}


