// See https://aka.ms/new-console-template for more information
/*
блок схема:
НачалО
ввести имя пользоателя
ЕСЛИ имя Маша, то особенное приветствие
ИНАЧЕ обычное приветствие
КонеЦ
*/
Console.WriteLine("Представьтесь, плз:");
string mUser = Console.ReadLine();
if (mUser.ToLower() == "маша"){
Console.WriteLine("Привет, Маша, давно не виделись!");
}else{
Console.WriteLine("Здравствуйте, " + mUser + "!");    
}
//Console.WriteLine("Hello, World!");
