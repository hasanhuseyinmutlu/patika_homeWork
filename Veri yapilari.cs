
byte b =3;
sbyte c = 5;

short s = 5;
ushort us = 5;

int i = 0;
Int16 i16 = 1;
Int32 i32 = 2;
Int64 i64 = 3; 

uint ui = 3;
long l = 4;
ulong ul = 5;

float f = 5;
double d = 2;
decimal dec = 7;

char ch = '2';
string str ="zaattiri";
bool b1 = true;

DateTime dt = DateTime.Now;
System.Console.WriteLine(dt);

String x ="x";
String y ="y";

object o1 = 1;
object o2 = x;
object o3 = y;

// string ifadeler
string str1 = string.Empty;
str1 = "zattiri zort";
string ad = "zattiri";
string soyad = "Zort";
string tamIsim = ad + " " + soyad;

//integer tanimlama sekilleri
 int integer1 = 5;
 int integer2 = 3;
 int integer3 = integer1 * integer2;
// boolean
bool booll = 10>2;
// Degisken Donusümleri
string str20 = "20";
int int20 = 20;
string yeniDeger = str20 + int20.ToString();
Console.WriteLine(yeniDeger); // equal to 2020
int int21 = int20 + Convert.ToInt32(str20);
Console.WriteLine(int21); // equals 40

int int22 = int20 + int.Parse(str20); //print40

// datetime
string datetime1 = DateTime.Now.ToString("dd.,WW.yyyy");
Console.WriteLine(datetime1);
string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(datetime2);

string hour = DateTime.Now. ToString("HH:mm");
Console.WriteLine(hour);