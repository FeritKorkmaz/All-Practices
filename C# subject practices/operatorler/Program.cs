// Atama ve İslemli Atama

int x = 3;
int y = 2;
y = y+2;
Console.WriteLine(y);

y += 2;
Console.WriteLine(y);

y/=1;
Console.WriteLine(y);

x*=2;
Console.WriteLine(x);


// mantiksal operatorler
// ||, && , !

bool isSuccsess = true;
bool isCompleted = false;

if(isSuccsess && isCompleted)
Console.WriteLine("Perfect");


if(isSuccsess || isCompleted)
Console.WriteLine("Great");

if(isSuccsess && !isCompleted)
Console.WriteLine("Fine");


// iliskisel operatorler
// <, >, <=, >=, ==, !=
int a = 1;
int b = 2;
bool sonuc = a<b;
Console.WriteLine(sonuc);

sonuc = a>b;
Console.WriteLine(sonuc);

sonuc = a>=b;
Console.WriteLine(sonuc);

sonuc = a<=b;
Console.WriteLine(sonuc);

sonuc = a==b;
Console.WriteLine(sonuc);

sonuc= a!=b;
Console.WriteLine(sonuc);


// aritmetik operatorler    
// +, -, *, /
int sayi1 = 10;
int sayi2 = 5;
int sonuc1 = sayi1/sayi2;
Console.WriteLine(sonuc1);

sonuc1 = sayi1+sayi2;
Console.WriteLine(sonuc1);

sonuc1 = sayi1*sayi2;
Console.WriteLine(sonuc1);

sonuc1 = sayi1++;
Console.WriteLine(sayi1);

// % mod alir
int sonuc2 = 20%3;
Console.WriteLine(sonuc2);











