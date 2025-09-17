using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_get_header@crnd@@YAPEBUcrn_header@1@PEBXI@Z")]
[DemangledName("struct crnd::crn_header const * __cdecl crnd::crnd_get_header(void const *, unsigned int)")]
internal static partial class crnd_get_header
{
	public unsafe static void* Invoke(void* pData, int data_size)
	{
		void* ptr = null;
		int num = 0;
		void* ptr2 = null;
		void* ptr3 = null;
		num = data_size;
		ptr2 = pData;
		unchecked
		{
			if (ptr2 == null || (ulong)(uint)num < 74uL)
			{
				return null;
			}
			ptr3 = ptr2;
			if (operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr3)->field_0) != 18552)
			{
				return null;
			}
			if ((ulong)(uint)operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr3)->field_1) < 74uL || (uint)num < (uint)operator_unsigned_int_uxo4hgd.Invoke(&((crnd_crn_header*)ptr3)->field_3))
			{
				return null;
			}
			return ptr3;
		}
	}
}
