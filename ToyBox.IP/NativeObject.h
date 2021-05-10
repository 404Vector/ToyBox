//NativeObejct.h
#pragma once

using namespace System;
using namespace System::Runtime::InteropServices;

namespace ToyBoxIP
{
	template<class T>
	public ref class NativeObject
	{
	private:
	protected:
		T* _context;
	public:
		NativeObject(T* nativeContext) :_context(nativeContext) {}
		virtual ~NativeObject()
		{
			if (_context != nullptr)
			{
				delete _context;
			}
		}
		!NativeObject()
		{
			if (_context != nullptr)
			{
				delete _context;
			}
		}
		T* GetContext() { return _context; }
		static const char* StringToChars(String^ string)
		{
			const char* str = (const char*)(Marshal::StringToHGlobalAnsi(string)).ToPointer();
			return str;
		}
	};
}