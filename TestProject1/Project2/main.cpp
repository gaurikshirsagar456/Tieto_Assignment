#include <iostream>
#include "calculator.h"

using namespace std;

int main()
{
    Calculator calc;

    int a, b;

    cout << "Enter first number: ";
    cin >> a;

    cout << "Enter second number: ";
    cin >> b;

    cout << "\nAddition = " << calc.add(a, b) << endl;
    cout << "Subtraction = " << calc.subtract(a, b) << endl;
    cout << "Multiplication = " << calc.multiply(a, b) << endl;

    if (b != 0)
        cout << "Division = " << calc.divide(a, b) << endl;
    else
        cout << "Division by zero not allowed!" << endl;

    return 0;
}