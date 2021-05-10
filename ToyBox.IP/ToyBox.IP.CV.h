//ToyBox.IP.CV.h
#pragma once
#include "NativeObject.h"
#include "../ToyBox.IP.CV/EntryPoint.h"
using namespace System;
namespace ToyBoxIP
{
	public ref class CVFunction : public NativeObject<CV::CVFunction>
	{
	public:
		CVFunction() : NativeObject(new CV::CVFunction()) {}
		int Add(int a, int b) { return _context->Add(a, b); };
		int Subtract(int a, int b) { return _context->Subtract(a, b); };
		float Multiply(float a, float b) { return _context->Multiply(a, b); };
		float Divide(float a, float b) { return _context->Divide(a, b); };
	};

	public ref class CVCore : public NativeObject<CV::CVCore>
	{
	public:
		CVCore() : NativeObject(new CV::CVCore()) {}

		CVData Inquire(CVData type) { return _context->Inquire(type); }

		CVData Commend(CVData type) { return _context->Commend(type); }

		CVData Commend(CVData type, String^ args) { return _context->Commend(type, StringToChars(args)); }

		CVData Commend(CVData type, String^ args, CVData id) { return _context->Commend(type, StringToChars(args), id); }
	};
}
