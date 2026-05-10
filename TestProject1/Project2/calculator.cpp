#include "calculator.h"

int Calculator::add(int a, int b)
{
    return a + b;
}

int Calculator::subtract(int a, int b)
{
    return a - b;
}

int Calculator::multiply(int a, int b)
{
    return a * b;
}

float Calculator::divide(int a, int b)
{
    if (b == 0)
    {
        return 0;
    }

    return (float)a / b;
}