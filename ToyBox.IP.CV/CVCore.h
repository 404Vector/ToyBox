//CVFunction.h
#pragma once
#include <iostream>
#include <vector>
#define CVData long

using namespace std;
namespace CV
{
	class CVCore
	{
	private:
		vector<void*> AdressVector;
		CVData FFT(CVData id);
	protected:
	public:
		CVCore();
		CVData Inquire(CVData type);
		CVData Commend(CVData type, const char* args = nullptr, CVData id = -1);
		~CVCore();
	};
}
