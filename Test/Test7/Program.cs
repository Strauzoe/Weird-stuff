Console.Clear();

//Console.SetCursorPosition(10,4);
// Console.WriteLine("*");

int xa = 1;
int ya = 1;
int xb = 1;
int yb = 20;
int xc = 30;
int yc = 20;
   
Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");

Console.SetCursorPosition(xb,yb);
Console.WriteLine("*");

Console.SetCursorPosition(xc,yc);
Console.WriteLine("*");

int count = 0;

while (count < 1000)
{
    int what = new Random().Next(0,3);
    if (what == 0)
    {
        x = (x = xa +xa)/2;
        ya = (ya = x + xa)


    }
}