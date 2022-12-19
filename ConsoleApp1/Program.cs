
//int a = 1, b = 2;
//bool x = (a == b);
//Console.WriteLine($"is a ({a}) = b ({b}) ? answer is {x} ");
//char x;
//Console.WriteLine(x);
//string firstName = "Ivan"; string lastName = "Ivanov";
//Console.WriteLine($"Hello,	{firstName}!\n");

//string fullName = $"{firstName} {lastName}";
//Console.WriteLine($"Your	full name is {fullName}."
//);
//int a, A;
//a= 5;
//A=6;
//Console.WriteLine(A+ a);
//int a = 5;


//int b = new int();
//Console.WriteLine(b);
//The following	variables	are
//	initialized	with	the	same	value:
//int numberInHex = -0x10;
//int numberInDec = -16;

////	The	following	causes	an	error,  because		234u	is	of	type	uint
//uint unsignedInt = 234u;

////	The	following	causes	an	error,  because		234L	is	of	type	long
//long longInt = 234L;
//Console.WriteLine(numberInHex +""+ numberInDec);
//The following	causes	an	error
//	because	12.5	is	double	by	default
//float	realNumber	=	12.5F;
//char symbol = '\u006F';

//Console.WriteLine(symbol);
////	Here	is	a	string	literal	using	escape	sequences  string	
//string quotation = "\"Hello,	Jude\",	he	said.";
//string path = "C:\\WINNT\\Darts\\Darts.exe";

////	Here	is		an	example	of	the	usage	of		@
//quotation   =   @"""Hello,	Jimmy!"",	she	answered.";
//path   =   @"C:\WINNT\Darts\Darts.exe";


//string str = @"some
//text";
//byte t = 58;
//sbyte c = 4;
//short
//  ushort
// int
// uint
// long
// ulong
//bool result = false;
//Console.WriteLine("enter first number");
//double firstNumber = double.Parse(Console.ReadLine());
//Console.WriteLine("enter second number");
//double secondNumber = double.Parse(Console.ReadLine());
//double deduction = firstNumber - secondNumber;
//Console.WriteLine(deduction);
//if (deduction < 0.000001)
//{
//    result = true;
//}
//Console.WriteLine($"({firstNumber} ; {secondNumber}) ==> {result}");
//int number = 0xFE;
//Console.WriteLine(number);
//char x = '\u8548';
//Console.WriteLine(x);
//bool IsFemale = false;
//Console.WriteLine(IsFemale);
//string a = "hello";
//string b = "world";
//object c = a +" "+ b;
//string d = (string)c;
//Console.WriteLine(c);
//string a = "the \"use\" of the quotations cuases difficulty";
//string b = @"the ""use"" of the quotations cuases difficulty";
//Console.WriteLine(a+"\n"+b);
//Console.WriteLine("   \u00A9   ");
//Console.WriteLine("  \u00A9 \u00A9  ");
//Console.WriteLine(" \u00A9   \u00A9 ");
//Console.WriteLine("\u00A9 \u00A9 \u00A9 \u00A9");
//string FirstName;
//string familyName;
//byte age;
//char gender;
//string IDNumber;
//uint UnicemployNumber;
//FirstName = "ahmed";
//familyName = "ibrahim";
//age = 22;
//gender = 'm';
//IDNumber = "00164888";
//UnicemployNumber = 27560004;
//Console.WriteLine($"{FirstName} \n {familyName} \n{age} \n{gender} \n{IDNumber} \n{UnicemployNumber} ");
//int a = 5;
//int b = 6;
//Console.WriteLine(a+"\n"+b+"\n");
//Console.WriteLine("before exchange");
//int c;
//c = a;
//a = b;
//b = c;
//Console.WriteLine("after exchange");
//Console.WriteLine(a+"\n"+b+"\n"+c+"\n");
//int x = 1;
//int y = 2;
//int b = 2;
//string g = x>b ? "x>b" : "x<b";
//Console.WriteLine();
//int a = 10;
//long A = a;
//long B = 20;
//int c = (int)B;

//string b;
//Console.WriteLine("again or stop");
//b=Console.ReadLine();
//b.ToLower();
//while (b=="again")
//{
//    int a;
//    Console.WriteLine("Enter ur number");
//    a= int.Parse(Console.ReadLine());
//    if (a%2==0)
//    {
//        Console.WriteLine($"numb {a} is even");
//    }
//    else
//    {
//        Console.WriteLine($"numb {a} is odd");
//    }

//    Console.WriteLine("again or stop");
//    b=Console.ReadLine();
//    b.ToLower();
//    if (b=="again")
//    {

//        Console.WriteLine("Enter ur number");
//        a= int.Parse(Console.ReadLine());
//        if (a%2==0)
//        {
//            Console.WriteLine($"numb {a} is even");
//        }
//        else
//        {
//            Console.WriteLine($"numb {a} is odd");
//        }
//    }
//    else
//    {
//        Console.WriteLine("ok bruhh");
//        Console.WriteLine();
//    }


//}
//string b;
//Console.WriteLine("again or stop");
//b=Console.ReadLine();
//b.ToLower();

//while (b=="again")
//{
//    int a;
//    Console.WriteLine("Enter ur number");
//    a= int.Parse(Console.ReadLine());
//    if (a%7==0 && a%5==0)
//    {
//        Console.WriteLine($"numb {a} can be divided (without remainder)");
//    }
//    else
//    {
//        Console.WriteLine($"numb {a} can't be divided (without remainder)");
//    }

//    Console.WriteLine("again or stop");
//    b=Console.ReadLine();
//    b.ToLower();


//    Console.WriteLine("Enter ur number");
//    a= int.Parse(Console.ReadLine());
//    if (a%2==0)
//    {
//        Console.WriteLine($"numb {a} is even");
//    }
//    else
//    {
//        Console.WriteLine($"numb {a} is odd");
//    }



//    Console.WriteLine("ok bruhh");
//    Console.WriteLine();
//}
//bool wannaStartAgain = false;
//do
//{
//    Console.WriteLine("hi");
//    bool check = false;
//    int number;
//    Console.WriteLine("ENTER UR FKN NUMBER BRUHH");
//    bool isInt = int.TryParse(Console.ReadLine(), out number);
//    if (isInt)
//    {
//        if (number % 7 == 0 && number %5==0)
//        {
//            check=true;
//            Console.WriteLine("the  given integer can be divided (without remainder) by 7 and 5 in the same time.");
//        }

//        else
//        {
//            Console.WriteLine("the  given integer  can't be divided (without remainder) by 7 and 5 in the same time.");
//        }
//    }
//    else { Console.WriteLine("invalid intry"); }
//    Console.WriteLine("wanna start again (y/n)");
//    string answer;
//    answer = Console.ReadLine();
//    if (answer == "y")
//    {
//        wannaStartAgain = true;
//    }
//    else
//    {
//        wannaStartAgain = false;
//    }
//} while (wannaStartAgain);
//double hieght, width, Area;
//Console.WriteLine("enter height");
//bool isValidHieght = double.TryParse(Console.ReadLine(), out hieght);
//Console.WriteLine("enter width");
//bool isValidWidth = double.TryParse(Console.ReadLine(), out width);
//if (isValidHieght && isValidWidth)
//{
//    Area = width*hieght;
//    Console.WriteLine($"Area is {Area}");
//}
//else
//{
//    Console.WriteLine("not valid Entry mannn");
//}

//bool check = false;
//int number;
//Console.WriteLine("Enter Your Number");
//bool intCheck = int.TryParse(Console.ReadLine(), out number);
//if (intCheck)
//{
//    if (number % 1000 > 699 && number % 1000 < 800)
//    {
//        check = true;

//    }
//    Console.WriteLine("Is the third digit equal to 7?:{0}", check);

//}
//else
//{
//    Console.WriteLine("Entry Valid");
//}
//bool check = false;
//Console.Write("Enter x :");
//double x;
//bool checkx = double.TryParse(Console.ReadLine(), out x);
//Console.Write("Enter y :");
//double y;
//bool checky = double.TryParse(Console.ReadLine(), out y);
//if (checkx && checky)
//{
//    if (((x*x)+(y*y))<= 25)
//    {
//        check = true;
//    }
//    Console.WriteLine($"is the point ({x},{y}) withn the circuit? \n - { check} ");
//}
//else
//{
//    Console.WriteLine("Invalid Entery");
//}
//bool check = true;
//short number;
//Console.WriteLine("Enter Number :-");
//bool checkShort = short.TryParse(Console.ReadLine(), out number);
//if (checkShort)
//{
//    for (int i = 2; i < Math.Sqrt(number); i++)
//    {


//        if (number%i==0)
//        {
//            check = false;
//        }
//    }
//    Console.WriteLine($"is number : {number} prime ? {check}");

//}
//else
//{

//    Console.WriteLine("Entry not valid");
//}
//bool check = false;
//double x, y;
//Console.WriteLine(" Enter x ");
//bool checkx = double.TryParse(Console.ReadLine(), out x);
//Console.WriteLine(" Enter y ");
//bool checky = double.TryParse(Console.ReadLine(), out y);
//if (checkx&&checky)
//{
//    if (x>=-1&&y>=-1&& x<=5&& y<=1)
//    {

//        // do nothing
//    }
//    else
//    {
//        double displacedx = x-1;
//        double displacedy = y-1;
//        if ((displacedx*displacedx)+(displacedy*displacedy)<=9)
//        {
//            check = true;

//        }

//    }
//    Console.WriteLine($" point ({x},{y}) check is {check} ");
//}
//else
//{
//    Console.WriteLine("invalid Entry ");
//}
//bool isDigit1 = false;
//byte p;
//int v;
//Console.Write("Enter the position of the bit p:");
//bool ispByte = byte.TryParse(Console.ReadLine(), out p);
//Console.Write("Enter the integer number v:");
//bool isvInt = int.TryParse(Console.ReadLine(), out v);

//if (ispByte&&isvInt&&p<32)
//{
//    int mask = 1 << p;
//    if ((v & mask) == mask)
//    {
//        isDigit1 = true;
//    }
//    Console.WriteLine("Is bit{0} of intiger {1} equal to 1?:{2}", p, v, isDigit1);
//}
//else
//{
//    Console.WriteLine("Not a valid entry!");
//}
//int day;
//bool check_day = int.TryParse(Console.ReadLine(), out day);
//if (check_day)
//{
//    switch (day)
//    {
//        case 1: Console.WriteLine("Sunday"); break;
//        case 2:
//            Console.WriteLine(); break;
//            Console.WriteLine();
//        default: Console.WriteLine(); break;

//    }

//}
//else
//{
//    Console.WriteLine("invalid entry");
//}
//Console.WriteLine("hii");
//int a, b, c;
//Console.WriteLine("ENTER FRIST NUMBER");
//bool check_a = int.TryParse(Console.ReadLine(), out a);
//Console.WriteLine("ENTER second NUMBER");
//bool check_b = int.TryParse(Console.ReadLine(), out b);
//if (check_a&&check_b)
//{
//    if (a>b)
//    {
//        c=a;
//        a=b;
//        b=c;
//    }
//    Console.WriteLine($"frist number is {a} \n Second number is {b}");
//}
//else
//{
//    Console.WriteLine("sadapskodm");
//}
//using System.Globalization;
//Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
//double a, b, c;
//byte s = 0;
//Console.WriteLine("ENTER N 1");
//bool is_a_double = double.TryParse(Console.ReadLine(), out a);
//Console.WriteLine("ENTER N 1");
//bool is_b_double = double.TryParse(Console.ReadLine(), out b);
//Console.WriteLine("ENTER N 1");
//bool is_c_double = double.TryParse(Console.ReadLine(), out c);
//if (is_a_double&& is_b_double&& is_c_double)
//{
//    if (Math.Sign(a)==1)
//    {
//        s= (byte)(s +1);
//    }
//    if (Math.Sign(b)==1)

//    {
//        s= (byte)(s +1);
//    }
//    if (Math.Sign(c)==1)
//    {
//        s= (byte)(s +1);
//    }
//    if (s%2==0)
//    {
//        Console.WriteLine("sign is -");
//    }
//    else
//    {
//        Console.WriteLine("sign is +");
//    }

//}
//int a, b, c, biggest;
//Console.WriteLine("Enter a");
//bool check_a = int.TryParse(Console.ReadLine(), out a);
//Console.WriteLine("Enter b");
//bool check_b = int.TryParse(Console.ReadLine(), out b);
//Console.WriteLine("Enter c");
//bool check_c = int.TryParse(Console.ReadLine(), out c);
//biggest = 0;
//if (check_a&& check_b&&check_c)
//{
//    if (a>c && a>b)
//    {
//        biggest= a;

//    }
//    else
//    {
//        if (b>c && b>a)
//        {
//            biggest= b;

//        }
//        else
//        {
//            if (c>b && c>a)
//            {
//                biggest= c;

//            }
//        }
//    }




//    Console.WriteLine($"biggest number is {biggest}");
//}
//else
//{
//    Console.WriteLine("invalid Entry");

//}
//int a, b, c;
//for (int i = 0; i < 5; i++)
//{

//    Console.WriteLine("Enter a");
//    bool check_a = int.TryParse(Console.ReadLine(), out a);
//    Console.WriteLine("Enter b");
//    bool check_b = int.TryParse(Console.ReadLine(), out b);
//    Console.WriteLine("Enter c");
//    bool check_c = int.TryParse(Console.ReadLine(), out c);
//    //    if (a>b)
//    {
//        if (b>c)
//        {
//            Console.WriteLine($"The descending order is {a} , {b} , {c}");
//        }
//        else
//        {
//            Console.WriteLine($"The descending order is {a} , {c} , {b}");
//        }
//    }
//    else
//    {
//        if (b>a)
//        {
//            if (a>c)
//            {
//                Console.WriteLine($"The descending order is {b} , {a} , {c}");
//            }
//            else
//            {
//                Console.WriteLine($"The descending order is {b} , {c} , {a}");
//            }
//        }
//        else
//        {
//            if (a>b)
//            {
//                Console.WriteLine($"The descending order is {c} , {a} , {b}");
//            }
//            else { Console.WriteLine($"The descending order is {c} , {b} , {a}"); }
//        }

//    }

//    if (a>b && b>c)
//    {
//        Console.WriteLine($"The descending order is {a} , {b} , {c}");
//    }
//    else if (a>b && c>b)
//    {
//        Console.WriteLine($"The descending order is {a} , {c} , {b}");
//    }
//    else
//    {
//        if (b>a&&a>c)
//        {
//            Console.WriteLine($"The descending order is {b} , {a} , {c}");
//        }
//        else if (b>a&&c>a)
//        {
//            Console.WriteLine($"The descending order is {b} , {c} , {a}");
//        }
//        else
//        {
//            if (c>a&&a>b)
//            {
//                Console.WriteLine($"The descending order is {c} , {a} , {b}");
//            }
//            else if (c>a&&b>a)
//            {
//                Console.WriteLine($"The descending order is {c} , {b} , {a}");
//            }
//        }
//    }
//}
//int x = 5; //x = 5(M)
//Console.WriteLine(x);
//++x;// x = 6(M)
//Console.WriteLine(x);
//Console.WriteLine(x++); //output x = 6, x = 7(M)
//Console.WriteLine(x);
//int y = --x; //x = 6(M), y = 6(M)
//Console.WriteLine("y ="+y);
//Console.WriteLine(y++); //output y = 6, y = 7(M)
//--x; //x = 5
//Console.WriteLine(x);
//Console.WriteLine(" hi ");
//Console.WriteLine("Enter ur grade");
//int grade;
//bool int_grade_check = int.TryParse(Console.ReadLine(), out grade);
//if (int_grade_check)
//{
//    if (grade< 101 && grade >0.5)
//    {
//        if (grade >=85)
//        {
//            Console.WriteLine("execelent");
//        }
//        else if (grade >= 65)
//        {
//            Console.WriteLine("good");
//        }
//        else if (grade >= 50)
//        {
//            Console.WriteLine("passed ");
//        }
//        else
//            Console.WriteLine("faild");
//    }
//    else Console.WriteLine("Enter bettwen 0 : 100");
//}
//Console.WriteLine("invalid Entry");
//Console.WriteLine("enter day name");
//string dayName;
//dayName = Console.ReadLine();
//switch (dayName)
//{
//    case "sunday": Console.WriteLine("day 1"); break;
//    case "monday": Console.WriteLine("day 2"); break;
//    case "tuesday": Console.WriteLine("day 3"); break;
//    case "thursday": Console.WriteLine("day 4"); break;
//    default: Console.WriteLine("invaild day"); break;
//}
//int anyDigit;
//Console.WriteLine("enter any Digit 0~9 ");
//anyDigit = int.Parse(Console.ReadLine());
//switch (anyDigit)
//{
//    case 0: Console.WriteLine("zero"); break;
//    case 1: Console.WriteLine("one"); break;
//    case 2: Console.WriteLine("two"); break;
//    case 3: Console.WriteLine("three"); break;
//    default: Console.WriteLine("invalid digit"); break;
//}
//int sum = 0;
//int n;
//Console.WriteLine("Enter n");
//n= int.Parse(Console.ReadLine());
//int number = 0;
//while (number < n)
//{
//    sum+=number;
//    number++;
//    Console.WriteLine($"Sum is {sum} \nn is {n} \nnumber is {number}\n_______________");
//}
//_____
//bool check = true;
//uint numb;
//Console.WriteLine(" ENTER THE NUMBER U WNA CHECK");
//bool check_uint_numb = uint.TryParse(Console.ReadLine(), out numb);
//uint count = 2;
//uint maxCount = (uint)Math.Sqrt(numb);
//if (check_uint_numb)
//{
//    if (numb ==1 || numb == 0)
//    {
//        Console.WriteLine("numb specfic as prim or not");
//    }
//    else
//    {
//        while (count<= maxCount&& check)
//        {
//            if (numb%count==0)
//            {
//                check = false;
//            }
//            count++;
//        }
//        Console.WriteLine($"is number prime ? - {check}");
//    }
//}

//else
//    Console.WriteLine("invalid entry");
//Console.WriteLine("Allah");
//Console.Write("Enter	a	positive	integer	number:	");
//uint number = uint.Parse(Console.ReadLine()); uint divider = 2;
//uint maxDivider = (uint)Math.Sqrt(number); bool prime = true;
//while (prime  &&  (divider    <=  maxDivider))
//{
//    if (number %   divider ==  0)
//    {
//        prime   =   false;
//    }
//    divider++;
//}
//Console.WriteLine("Prime?	{0}", prime);
//int n;
//int factorial;
//factorial=1;
//Console.WriteLine("Enter n");
//n=int.Parse(Console.ReadLine());
//do
//{
//    factorial*=n;
//    n--;
//}
//while (n>0);
//Console.WriteLine(factorial);
//هو عايز ضرب الاعداد من n اليm 
//int n, m, product, count;
//n= int.Parse(Console.ReadLine());
//m= int.Parse(Console.ReadLine());
//count = n;
//product =1;
//do
//{
//    product *= count;
//    count++;
//} while (count<=m);
//Console.WriteLine(product);
//int factoiral = 1;
//for (int i = 1; i <= 4; i++)
//{
//    factoiral *=i;
//}
//Console.WriteLine(factoiral);
//for (int i = 1, sum = 1; i<=128; i=i*2, sum+=i)
//{
//    Console.WriteLine("i={0},	sum={1}", i, sum);
//}
//int sum = 0;
//for (int i = 0; i <= 100; i+=2)
//{
//    sum +=i;

//}
//Console.WriteLine(sum);
//long n = long.Parse(Console.ReadLine());
//long m = long.Parse(Console.ReadLine());
//long result = 1;
//for (int i = 0; i < m; i++)
//{
//    result*=n;
//}
//Console.WriteLine(result);
//int n = int.Parse(Console.ReadLine());
//for (int i = 1; i <= n; i++)
//{
//    for (int c = 1; c <= 5; c++)
//    {
//        Console.Write($"{c}");
//    }
//    Console.WriteLine("");
//}
//for (int a = 1; a   <=      9; a++)
//{
//    for (int b = 0; b   <=  9; b++)
//    {
//        for (int c=0 , d = 0; d   <=  9 ; c++, d++)
//        {
//            {
//                if (a  +   b   ==  c   +   d)
//                {
//                    Console.WriteLine("{0}{1}{2}{3}", a, b, c, d);

//                }

//            }
//        }
//    }

//}
//for (int a = 0; a <= 9; a++)
//{
//    for (int b = 0; b <= 9; b++)
//    {
//        for (int c = 0, d=0; c <= 9;d++, c++)
//        {
//            if (a+b == c+d)
//            {
//                Console.WriteLine($"{a}{b}{c}{d}");
//            }
//        }

//    }
//}
//int[] a;
// a = new int[5];
//int [] a = {1,2,3,4,5};

//for (int i = 0; i < 5; i++)
//{
//    for (int c = 0; c < i; c++)
//    {
//        Console.Write ("   *");
//    }
//    Console.WriteLine("         ");
//}
//static void main(String[] args)
//{
//    int[] a = { 1, 2, 3, 4, 5 };
//    int length = a.Length;
//    int[] revers = new int[length];
//    for (int i = 0; i < length; i++)
//    {
//        revers[length-i-1]=a[i];
//    }
//    foreach (int i in revers)
//    {
//        Console.WriteLine(revers[i]);
//    }
//    Console.WriteLine("_________");

//    foreach (int i in a)
//    {
//        Console.WriteLine(a[i]);
//    }
//}
//Console.WriteLine( " enter array length");
//int length;
//bool length_intCheck = int.TryParse(Console.ReadLine(), out length );
//if (length_intCheck)
//{
//    Console.WriteLine(" Enter array elements");
//    int[] a = new int[length];
//    for (int i = 0; i < length; i++)
//    {
//        a[i] = int.Parse(Console.ReadLine());
//    }
//    bool check_symitric = true;
//    for (int i = 0; i < length; i++)
//    {
//        if (a[i]!=a[length-i-1])
//        {
//            check_symitric = false;
//        }
//    }
//    Console.WriteLine($"is array symtric ? - {check_symitric} ");
//    for (int i = 0; i < length; i++)
//    {
//        Console.WriteLine($"a[{i}] = {a[i]}");
//    }
//}
//else
//{
//    Console.WriteLine("invlid Entry");
//}
//int length = int.Parse(Console.ReadLine());
//int[] a = new int[length];
//int[] squars = new int[length];
//Console.WriteLine("Enter array elemets");
//for (int i = 0; i < length; i++)
//{
//    a[i] = int.Parse(Console.ReadLine());

//}
//for (int i = 0; i < length; i++)
//{

//    squars[i]= a[i]*a[i];
//}
//for (int i = 0; i < length; i++)
//{


//    Console.WriteLine(squars[i]);

//}
//for (int i = length-1; i >= 0; i--)
//{
//    Console.WriteLine(squars[i]);
//}
//foreach (int i in squars)
//{
//    Console.WriteLine(i);
//}
//int[,] a;
//int[,] a = new int[3, 3];
//int[,] a = 
//{
//    { 1,2 ,3}, {4,5,6}
//};

//int rows, colmns;
//Console.WriteLine("enter rows number");
//rows = int.Parse(Console.ReadLine());
//Console.WriteLine("enter colomns number");
//colmns = int.Parse(Console.ReadLine());
//int[,] matrix = new int[rows, colmns];
//for (int row = 0; row < rows; row++)
//{
//    for (int colmn = 0; colmn < colmns; colmn++)
//    {
//        Console.WriteLine($"Enter element matrix[{row},{colmn}]");
//        matrix[row, colmn] = int.Parse(Console.ReadLine());

//    }
//}
//for (int row = 0; row < matrix.GetLength(0); row++)
//{
//    for (int colmn = 0; colmn < matrix.GetLength(1); colmn++)
//    {
//        Console.Write($"{matrix[row, colmn]} ");

//    }
//    Console.WriteLine(" ");
//}
//int rows = int.Parse(Console.ReadLine());
//int columns = int.Parse(Console.ReadLine());
//int[,] matrix = new int[rows, columns];
//String inputNumber;
//for (int row = 0; row<rows; row++)
//{
//    for (int column = 0; column<columns; column++)
//    {
//        Console.Write("matrix[{0},{1}] = ", row, column);
//        inputNumber = Console.ReadLine(); matrix[row, column] = int.Parse(inputNumber);
//    }
//}
//for (int row = 0; row<matrix.GetLength(0); row++)
//{ for (int col = 0; col<matrix.GetLength(1); col++) 
//    { Console.Write("{0} ", matrix[row, col]); } 
//    Console.WriteLine(); }
/*int[,,] a = new int[2, 2, 2] { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } }; */// [p,r,c]
//int[,] a =  new int [3,6]{ { 7,1, 3, 3, 2, 1 }, { 1, 3, 9, 8, 5,6 }, { 4, 6, 7, 9, 1,0 } };
//int bestsum = int.MinValue;
//for (int row = 0; row < a.GetLength(0)-1; row++)
//{
//    for (int col = 0; col < a.GetLength(1)-1; col++)
//    {
//        int sum = a[row, col]+a[row, col+1]+a[row+1, col]+a[row+1, col+1];
//        if (sum > bestsum)
//        {
//            bestsum = sum;
//        }
//    }
//}
//Console.WriteLine(bestsum);
//List<int> ahmed= new List<int> ();
//for (int i = 0; i < 5; i++)
//{
//    ahmed.Add (i);
//}
//foreach (int i in ahmed)
//{
//    Console.WriteLine(i);
//}
//int[] array = new int[5];
//for (int i = 0; i < 5 ; i++)
//{
//    array[i]=i;
//}
// int [] array2 =new int[4];

//Array.Copy(array, array2, 3);
//foreach  (int i in array2)
//{
//    Console.WriteLine(i);
//}
//Write a program that allocates array of 20 integers 
//and initializes each element by its index multiplied by 5. Print the obtained array on the console.
//int[] a = new int[20];
//for (int i = 0; i<20; i++)
//{
//    a[i]=(i*5);
    
//}
//foreach (int item in a)
//{
//    Console.Write(" "+item);
//}
//int [] a1 = {1, 2, 3};
//int [] a2 = {1, 5, 3};
//bool checkMtach = true;
//for (int i = 0; i < 3; i++)
//{
    
//        if (a1[i]!=a2[i])
//        {
//        checkMtach = false;
//        }
   
//}
//Console.WriteLine($"is every elemnts match? -{checkMtach}");
// static void p(string x)
//{
//    Console.WriteLine(x);

//}
//p("ahmed");
//string x = "asd";
//int a7a(int a, int b) 
//{
//    int res = a+b;
//    return res;
//}
//Console.WriteLine(   a7a(5, 10));
//object[] a= {1,"skjan",false};