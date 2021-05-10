#include "pch.h"
#include "CVFunction.h"

namespace CV
{
	int CVFunction::Add(int a, int b)
	{
		return a + b;
	}

	int CVFunction::Subtract(int a, int b)
	{
		return a - b;
	}

	float CVFunction::Multiply(float a, float b)
	{
		return a * b;
	}

	float CVFunction::Divide(float a, float b)
	{
		return a / b;
	}
}