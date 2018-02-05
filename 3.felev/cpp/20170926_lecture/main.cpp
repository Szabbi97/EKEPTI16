#include <iostream>
#include <iomanip>
#include <conio.h>

using namespace std;

int main()
{
    double a = 3.141592653;
    double b = 12356789456.123456533456789;
    cout << "Result: " << setw(14) << fixed << setprecision(8) << a << " , " << setw(30) << b << endl;
    cout << "Result: " << left << setw(14) << fixed << setprecision(8) << a << " , " << setw(30) << b << endl;
    getch();
    return 0;
}
