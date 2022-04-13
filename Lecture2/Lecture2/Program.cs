// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8;


string greeting = "Hello, World my name is Jolanta";
int number = 7;
double decimalNumber = 9.99;
char simbol = '%';
bool answer = false;

Console.WriteLine(greeting);
Console.WriteLine(number);
Console.WriteLine(decimalNumber);
Console.WriteLine(simbol);
Console.WriteLine(answer);



Console.WriteLine();
Console.WriteLine("========================================================");
Console.WriteLine();


int num1 = 5;
int num2 = 2;

int sum = num1 + num2;
int diff = num1 - num2;
int multiply = num1 * num2;
double divide = num1 / (double)num2;
int leftAfter = num1 % num2;

// pilnais pieraksts num1 = num1 + 1;
num1++;
// pilnais pieraksts num2 = num2 - 1;
num2--;



Console.WriteLine(sum);
Console.WriteLine(diff);
Console.WriteLine(multiply);
Console.WriteLine(divide);
Console.WriteLine(leftAfter);
Console.WriteLine(num1);
Console.WriteLine(num2);

Console.WriteLine();
Console.WriteLine("========================================================");
Console.WriteLine();

int num3 = 4;
int num4 = 4;

bool isEqual = num3 == num4;
bool isNotEqual = num3 != num4;
bool isLarger = num3 > num4;
bool isSmaler = num3 < num4;
bool isLargerEqual = num3 >= num4;
bool isSmalerEqual = num3 <= num4;

Console.WriteLine(isEqual);
Console.WriteLine(isNotEqual);
Console.WriteLine(isLarger);
Console.WriteLine(isSmaler);
Console.WriteLine(isLargerEqual);
Console.WriteLine(isSmalerEqual);

Console.WriteLine();
Console.WriteLine("========================================================");
Console.WriteLine();

bool isTrue = true;
bool isFalse = false;

bool isBoth = isTrue && isFalse;
bool isEitherOne = isTrue || isFalse;
bool converted = !isTrue;

Console.WriteLine(isBoth);
Console.WriteLine(isEitherOne);
Console.WriteLine(converted);

Console.WriteLine();
Console.WriteLine("========================================================");
Console.WriteLine();


int num5 = 5;

num5 += 2; // pilnais pieraksts num5 = num5 + 2

Console.WriteLine(num5);

num5 -= 2; // pilnais pieraksts num5 = num5 - 2

Console.WriteLine(num5);

Console.WriteLine();
Console.WriteLine("========================================================");
Console.WriteLine();

// 1. Pajautāt lietotājam ievadīt savu vārdu
Console.WriteLine("Ievadi savu vārdu ?");

// 2. Sagaidīt lietotāja ievadi viņa vārdu
string userName = Console.ReadLine();

// 3. Sasveicināties ar lietotāju izmantojot viņa vārdu
string userGreeting = "Sveiks " + userName + "!";
Console.WriteLine(userGreeting);


Console.WriteLine();
Console.WriteLine("========================================================");
Console.WriteLine();

// 1. Pajautāt lietotājam ievadīt skaitli
Console.WriteLine("Lūdzu ievadi skaitli ?");

// 2. sagaidīt lietotāja skaiļa ievadi
string userNumberText = Console.ReadLine();
int userNumber = int.Parse(userNumberText);

// 3. Formatētā tekstā izvadīt lietotāja skaitli palielinātu par 2
int result = userNumber + 2;
Console.WriteLine("Tavs skaitlis palielināts par 2: " + result);

Console.WriteLine();
Console.WriteLine("========================================================");
Console.WriteLine();

int x = -4;
int y = 9;

int absoluteNumber = Math.Abs(x);
int largest = Math.Max(x, y);
int smallest = Math.Min(x, y);

double toRound = 45.856;
double rounded = Math.Round(toRound, 2);


Console.WriteLine(absoluteNumber);
Console.WriteLine(largest);
Console.WriteLine(smallest);
Console.WriteLine(rounded);


Console.WriteLine();
Console.WriteLine("========================================================");
Console.WriteLine();

string name = "Artis";
int age = 40;

Console.WriteLine("Sveiks " + name + "sveiciens dzimšanas dienā tavos" + age + "gados!");
Console.WriteLine($"Sveiks {name} sveiciens dzimšanas dienā tavos {age} gados!");

