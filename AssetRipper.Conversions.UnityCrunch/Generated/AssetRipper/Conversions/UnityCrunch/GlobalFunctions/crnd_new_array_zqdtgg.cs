using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$crnd_new_array@I@crnd@@YAPEAII@Z")]
[DemangledName("unsigned int * __cdecl crnd::crnd_new_array<unsigned int>(unsigned int)")]
[CleanName("crnd_new_array")]
internal static partial class crnd_new_array_zqdtgg
{
	[return: NativeType("unsigned int *")]
	public unsafe static void* Invoke([NativeType("unsigned int")] int num)
	{
		int num2 = num;
		if (num2 == 0)
		{
			num2 = 1;
		}
		unchecked
		{
			void* ptr = crnd_malloc.Invoke(8L + 4L * (long)(uint)num2, null);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			void* ptr2 = ptr;
			if (ptr2 == null)
			{
				return null;
			}
			void* ptr3 = (byte*)ptr2 + 8;
			*(int*)((byte*)ptr3 + -4) = num2;
			*(int*)((byte*)ptr3 + -8) = num2 ^ -1;
			construct_array_7hpyj8.Invoke(ptr3, num2);
			return ptr3;
		}
	}
}
