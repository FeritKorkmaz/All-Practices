// See https://aka.ms/new-console-template for more information
Console.WriteLine("");
byte b = 5;
sbyte c = 5;

short s = 5;
ushort us = 5;

Int16 i16 = 2;
int i = 2;
Int32 i32 = 2;
Int64 i64 = 2;

uint ui = 2;
long l = 4;
ulong ul = 4;

// reel sayılar
float f = 5;
double d = 5;
decimal de = 5;

// string
char ch = '2';  // 2 byte
string str = "Ferit"; // sinirsiz

bool b1 = true;
bool b2 = false;

DateTime dt = DateTime.Now;
Console.WriteLine(dt);

object o1 = "x";
object o2 = 'y';
object o3 = 4;
object o4 = 3.5;


// string ifadeler

string str1 = string.Empty;
str1 = "Ferit Korkmaz";
string ad = "Ferit";
string soyad = "Korkmaz";
string adSoyad = ad + " " + soyad;


// integer tanimlama sekilleri

int integer1 = 2;
int integer2 = 3;
int integer3 = integer1 * integer2;

// boolean 

bool bool1 = 10<2;

// degisken donusumleri 
string str20 = "20";
int int20 = 20;
string yeniDeger = str20 + int20.ToString();
Console.WriteLine(yeniDeger);

int int21 = int20 + Convert.ToInt32(str20);
Console.WriteLine(int21); // ciktisi 40 

int int22 = int20 + int.Parse(str20); // ciktisi 40

// dateTime

string dateTime = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(dateTime);


// saat
string dateTime2 = DateTime.Now.ToString("hh:mm");
Console.WriteLine(dateTime2);













