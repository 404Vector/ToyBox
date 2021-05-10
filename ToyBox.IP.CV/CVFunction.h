//CVFunction.h
#pragma once
#include <iostream>
using namespace std;

namespace CV
{
	class CVFunction
	{
	public:
		int Add(int a, int b);
		int Subtract(int a, int b);
		float Multiply(float a, float b);
		float Divide(float a, float b);
	};
}