using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Conversions.UnityCrunch.Helpers;

internal static partial class IntrinsicFunctions
{
	private sealed partial class AssertExceptionInfo : ExceptionInfo
	{
		public string Message { get; }

		public AssertExceptionInfo(string message)
		{
			Message = message;
		}

		public override string? GetMessage()
		{
			return Message;
		}
	}

	[StructLayout(LayoutKind.Sequential, Size = 1)]
	private partial struct RttiTypeDescriptor
	{
	}

	private partial struct CatchableType
	{
		public int field_0;

		public int RttiTypeDescriptorIndex;

		public int field_2;

		public int field_3;

		public int field_4;

		public int field_5;

		public int ConstructorIndex;

		public unsafe readonly RttiTypeDescriptor* RttiTypeDescriptor => unchecked((RttiTypeDescriptor*)PointerIndices.GetPointer(RttiTypeDescriptorIndex));

		public unsafe readonly delegate*<void*, void*, void*> Constructor => unchecked((delegate*<void*, void*, void*>)PointerIndices.GetPointer(ConstructorIndex));
	}

	private partial struct CatchableTypeArray
	{
		public int Count;
	}

	private partial struct ThrowInfo
	{
		public int field_0;

		public int DestructorIndex;

		public int CatchableTypeArrayIndex;

		public unsafe readonly delegate*<void*, void> Destructor => unchecked((delegate*<void*, void>)PointerIndices.GetPointer(DestructorIndex));

		public unsafe readonly ReadOnlySpan<CatchableType> CatchableTypeArray
		{
			get
			{
				unchecked
				{
					CatchableTypeArray* pointer = (CatchableTypeArray*)PointerIndices.GetPointer(CatchableTypeArrayIndex);
					if (pointer == null || pointer->Count <= 0)
					{
						return default(ReadOnlySpan<CatchableType>);
					}
					return new ReadOnlySpan<CatchableType>((void*)checked(unchecked((nuint)pointer) + (nuint)4u), pointer->Count);
				}
			}
		}
	}

	private sealed partial class NativeExceptionInfo : ExceptionInfo
	{
		public unsafe void* ExceptionPointer { get; private set; }

		public unsafe ThrowInfo* ThrowInfo { get; private set; }

		public unsafe NativeExceptionInfo(void* exceptionPointer, ThrowInfo* throwInfo)
		{
			ExceptionPointer = exceptionPointer;
			ThrowInfo = throwInfo;
		}

		public unsafe bool Contains(RttiTypeDescriptor* rttiTypeDescriptor)
		{
			if (ThrowInfo == null)
			{
				return false;
			}
			ReadOnlySpan<CatchableType> catchableTypeArray = ThrowInfo->CatchableTypeArray;
			for (int i = 0; i < catchableTypeArray.Length; i = unchecked(i + 1))
			{
				if (catchableTypeArray[i].RttiTypeDescriptor == rttiTypeDescriptor)
				{
					return true;
				}
			}
			return false;
		}

		protected unsafe override void Dispose(bool disposing)
		{
			if (ExceptionPointer != null && ThrowInfo != null)
			{
				delegate*<void*, void> destructor = ThrowInfo->Destructor;
				if (destructor != unchecked((delegate*<void*, void>)null))
				{
					destructor(ExceptionPointer);
				}
			}
			ExceptionPointer = null;
			ThrowInfo = null;
		}
	}

	[MangledName("puts")]
	public unsafe static int PutString(sbyte* P_0)
	{
		try
		{
			Console.WriteLine(Marshal.PtrToStringAnsi((nint)P_0));
			return 0;
		}
		catch
		{
			return -1;
		}
	}

	[MangledName("_wassert")]
	[MightThrow]
	public unsafe static void Assert(char* message, char* file, uint line)
	{
		ExceptionInfo.Current = new AssertExceptionInfo($"Assertion failed: {Marshal.PtrToStringUni((nint)message)} at {Marshal.PtrToStringUni((nint)file)}:{line}");
	}

	[DoesNotReturn]
	[MangledName("_invoke_watson")]
	public unsafe static void InvokeWatson(char* expression, char* function, char* file, int line, long reserved)
	{
		throw new FatalException($"Fatal assertion failed: {Marshal.PtrToStringUni((nint)expression)} in {Marshal.PtrToStringUni((nint)function)} at {Marshal.PtrToStringUni((nint)file)}:{line}");
	}

	[DoesNotReturn]
	[MangledName("__std_terminate")]
	public static void Terminate()
	{
		throw new FatalException("Terminate");
	}

	[MangledName("llvm.va_start.p0")]
	public unsafe static void llvm_va_start(void** va_list)
	{
		throw new NotSupportedException();
	}

	[MangledName("llvm.va_copy.p0")]
	public unsafe static void llvm_va_copy(void** destination, void** source)
	{
		*destination = *source;
	}

	[MangledName("llvm.va_end.p0")]
	public unsafe static void llvm_va_end(void** va_list)
	{
	}

	[MangledName("strcmp")]
	public unsafe static int strcmp(byte* p1, byte* p2)
	{
		unchecked
		{
			while (*p1 == *p2 && *p1 != 0)
			{
				p1 = (byte*)checked(unchecked((nuint)p1) + (nuint)1u);
				p2 = (byte*)checked(unchecked((nuint)p2) + (nuint)1u);
			}
		}
		return *p1 - *p2;
	}

	[MangledName("strchr")]
	public unsafe static byte* strchr(byte* str, int c)
	{
		if (str == null)
		{
			return null;
		}
		unchecked
		{
			while (*str != 0)
			{
				if (*str == c)
				{
					return str;
				}
				str = (byte*)checked(unchecked((nuint)str) + (nuint)1u);
			}
			return null;
		}
	}

	[MangledName("strstr")]
	public unsafe static byte* strstr(byte* haystack, byte* needle)
	{
		if (haystack == null || needle == null)
		{
			return null;
		}
		long num = strlen(haystack);
		int num2 = MemoryExtensions.IndexOf(value: new ReadOnlySpan<byte>(needle, (int)strlen(needle)), span: new ReadOnlySpan<byte>(haystack, (int)num));
		unchecked
		{
			return (byte*)((num2 >= 0) ? checked(unchecked((nuint)haystack) + unchecked((nuint)num2)) : 0u);
		}
	}

	[MangledName("strrchr")]
	public unsafe static byte* strrchr(byte* str, int c)
	{
		if (str == null)
		{
			return null;
		}
		int num = new ReadOnlySpan<byte>(str, (int)strlen(str)).LastIndexOf((byte)c);
		unchecked
		{
			return (byte*)((num >= 0) ? checked(unchecked((nuint)str) + unchecked((nuint)num)) : 0u);
		}
	}

	[MangledName("strrstr")]
	public unsafe static byte* strrstr(byte* haystack, byte* needle)
	{
		if (haystack == null || needle == null)
		{
			return null;
		}
		long num = strlen(haystack);
		int num2 = MemoryExtensions.LastIndexOf(value: new ReadOnlySpan<byte>(needle, (int)strlen(needle)), span: new ReadOnlySpan<byte>(haystack, (int)num));
		unchecked
		{
			return (byte*)((num2 >= 0) ? checked(unchecked((nuint)haystack) + unchecked((nuint)num2)) : 0u);
		}
	}

	[MangledName("strlen")]
	public unsafe static long strlen(byte* str)
	{
		if (str == null)
		{
			return 0L;
		}
		long num = 0L;
		while (*str != 0)
		{
			num++;
			unchecked
			{
				str = (byte*)checked(unchecked((nuint)str) + (nuint)1u);
			}
		}
		return num;
	}

	[MangledName("strncpy")]
	public unsafe static byte* strncpy(byte* destination, byte* source, long count)
	{
		if (destination == null || source == null)
		{
			return null;
		}
		long num = StringLengthWithMaximum(source, count);
		if (num > 0)
		{
			Buffer.MemoryCopy(source, destination, count, num);
		}
		if (num < count)
		{
			new Span<byte>(unchecked((void*)checked(unchecked((nuint)destination) + unchecked((nuint)num))), (int)(count - num)).Clear();
		}
		return destination;
	}

	[MangledName("strncat")]
	public unsafe static byte* strncat(byte* destination, byte* source, long count)
	{
		if (destination == null || source == null)
		{
			return null;
		}
		long num = strlen(destination);
		long num2 = StringLengthWithMaximum(source, (int)count);
		unchecked
		{
			if (num2 > 0)
			{
				Buffer.MemoryCopy(source, (void*)checked(unchecked((nuint)destination) + unchecked((nuint)num)), count, num2);
			}
		}
		destination[num + num2] = 0;
		return destination;
	}

	private unsafe static long StringLengthWithMaximum(byte* str, long maxLength)
	{
		if (str == null)
		{
			return 0L;
		}
		long num = 0L;
		while (num < maxLength && *str != 0)
		{
			num++;
			unchecked
			{
				str = (byte*)checked(unchecked((nuint)str) + (nuint)1u);
			}
		}
		return num;
	}

	[MangledName("tolower")]
	public static int ToLower(int character)
	{
		unchecked
		{
			if ((uint)character >= 65535u)
			{
				return character;
			}
			return char.ToLower((char)character);
		}
	}

	[MangledName("isalpha")]
	public static int IsAlpha(int character)
	{
		unchecked
		{
			if ((uint)character >= 65535u)
			{
				return 0;
			}
			return char.IsLetter((char)character) ? 1 : 0;
		}
	}

	[MangledName("isdigit")]
	public static int IsDigit(int character)
	{
		unchecked
		{
			if ((uint)character >= 65535u)
			{
				return 0;
			}
			return char.IsDigit((char)character) ? 1 : 0;
		}
	}

	[MangledName("atoi")]
	public unsafe static int AsciiToInteger(byte* str)
	{
		if (str == null)
		{
			return 0;
		}
		byte* ptr;
		long num;
		unchecked
		{
			while (char.IsWhiteSpace((char)(*str)))
			{
				str = (byte*)checked(unchecked((nuint)str) + (nuint)1u);
			}
			switch (*str)
			{
			case 45:
				ptr = str;
				str = (byte*)checked(unchecked((nuint)str) + (nuint)1u);
				break;
			case 43:
				str = (byte*)checked(unchecked((nuint)str) + (nuint)1u);
				ptr = str;
				break;
			default:
				ptr = str;
				break;
			}
			while (char.IsDigit((char)(*str)))
			{
				str = (byte*)checked(unchecked((nuint)str) + (nuint)1u);
			}
			num = str - ptr;
			if (num == 0)
			{
				return 0;
			}
		}
		ReadOnlySpan<byte> utf8Text = new ReadOnlySpan<byte>(ptr, (int)num);
		if (num == 1 && utf8Text[0] == 45)
		{
			return 0;
		}
		return int.Parse(utf8Text, CultureInfo.InvariantCulture);
	}

	[MangledName("memcmp")]
	public unsafe static int memcmp(byte* p1, byte* p2, long count)
	{
		for (long num = 0L; num < count; num++)
		{
			if (p1[num] != p2[num])
			{
				return p1[num] - p2[num];
			}
		}
		return 0;
	}

	[MangledName("llvm.memcpy.p0.p0.i32")]
	public unsafe static void llvm_memcpy_p0_p0_i32(void* destination, void* source, int length, bool isVolatile)
	{
		Unsafe.CopyBlock(destination, source, (uint)length);
	}

	[MangledName("llvm.memcpy.p0.p0.i64")]
	public unsafe static void llvm_memcpy_p0_p0_i64(void* destination, void* source, long length, bool isVolatile)
	{
		Unsafe.CopyBlock(destination, source, (uint)length);
	}

	[MangledName("llvm.memmove.p0.p0.i32")]
	public unsafe static void llvm_memmove_p0_p0_i32(void* destination, void* source, int length, bool isVolatile)
	{
		byte[] array = ArrayPool<byte>.Shared.Rent(length);
		Span<byte> destination2 = new Span<byte>(array, 0, length);
		new ReadOnlySpan<byte>(source, length).CopyTo(destination2);
		destination2.CopyTo(new Span<byte>(destination, length));
		ArrayPool<byte>.Shared.Return(array);
	}

	[MangledName("llvm.memmove.p0.p0.i64")]
	public unsafe static void llvm_memmove_p0_p0_i64(void* destination, void* source, long length, bool isVolatile)
	{
		llvm_memmove_p0_p0_i32(destination, source, (int)length, isVolatile);
	}

	[MangledName("llvm.memset.p0.i32")]
	public unsafe static void llvm_memset_p0_i32(void* destination, sbyte value, int length, bool isVolatile)
	{
		new Span<byte>(destination, length).Fill(unchecked((byte)value));
	}

	[MangledName("llvm.memset.p0.i64")]
	public unsafe static void llvm_memset_p0_i64(void* destination, sbyte value, long length, bool isVolatile)
	{
		llvm_memset_p0_i32(destination, value, (int)length, isVolatile);
	}

	[MangledName("calloc")]
	public unsafe static void* CAlloc(long elementCount, long elementSize)
	{
		if (elementCount <= 0 || elementSize <= 0)
		{
			return null;
		}
		if (elementCount > int.MaxValue || elementSize > int.MaxValue)
		{
			return null;
		}
		long num = elementCount * elementSize;
		if (num > int.MaxValue)
		{
			return null;
		}
		void* ptr = Alloc(num);
		new Span<byte>(ptr, (int)num).Clear();
		return ptr;
	}

	[MangledName("malloc")]
	[MangledName("??2@YAPEAX_K@Z")]
	public unsafe static void* Alloc(long size)
	{
		return NativeMemoryHelper.Allocate(size);
	}

	[MangledName("realloc")]
	public unsafe static void* ReAlloc(void* ptr, long size)
	{
		return NativeMemoryHelper.Reallocate(ptr, size);
	}

	[MangledName("free")]
	public unsafe static void Free(void* ptr)
	{
		NativeMemoryHelper.Free(ptr);
	}

	[MangledName("_msize")]
	public unsafe static long Size(void* ptr)
	{
		return NativeMemoryHelper.Size(ptr);
	}

	[MangledName("??3@YAXPEAX_K@Z")]
	public unsafe static void Delete(void* ptr, long size)
	{
		NativeMemoryHelper.Free(ptr);
	}

	[MangledName("expand")]
	public unsafe static void* Expand(void* ptr, long size)
	{
		return null;
	}

	[MangledName("_CxxThrowException")]
	[MightThrow]
	public unsafe static void CxxThrowException(void* exceptionPointer, void* throwInfo)
	{
		ExceptionInfo.Current = new NativeExceptionInfo(exceptionPointer, unchecked((ThrowInfo*)throwInfo));
	}

	[MangledName("__CxxFrameHandler3")]
	public unsafe static int CxxFrameHandler3(ReadOnlySpan<nint> args)
	{
		if (args.Length != 3)
		{
			throw new ArgumentException("Expected 3 arguments", "args");
		}
		if (args[0] == 0 || args[1] == 0 || args[2] == 0)
		{
			throw new ArgumentNullException("args", "Arguments cannot be null");
		}
		unchecked
		{
			RttiTypeDescriptor* ptr = *(RttiTypeDescriptor**)checked((nuint)args[0]);
			int num = *(int*)checked((nuint)args[1]);
			void** ptr2 = (void**)checked((nuint)args[2]);
			if (ExceptionInfo.Current is NativeExceptionInfo nativeExceptionInfo)
			{
				if (ptr != null && !nativeExceptionInfo.Contains(ptr))
				{
					return 1;
				}
				if (ptr2 != null)
				{
					*ptr2 = nativeExceptionInfo.ExceptionPointer;
				}
				return 0;
			}
			if (ptr != null || ptr2 != null)
			{
				throw new NotSupportedException("Current exception is not a NativeExceptionInfo.");
			}
			return 0;
		}
	}
}
