using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_get_level_info@crnd@@YA_NPEBXIIPEAUcrn_level_info@1@@Z")]
[DemangledName("bool __cdecl crnd::crnd_get_level_info(void const *, unsigned int, unsigned int, struct crnd::crn_level_info *)")]
internal static partial class crnd_get_level_info
{
	public unsafe static bool Invoke(void* pData, int data_size, int level_index, void* pLevel_info)
	{
		bool flag = false;
		void* ptr = null;
		int num = 0;
		int num2 = 0;
		void* ptr2 = null;
		void* ptr3 = null;
		int num3 = 0;
		int num4 = 0;
		ptr = pLevel_info;
		num = level_index;
		num2 = data_size;
		ptr2 = pData;
		unchecked
		{
			if (ptr2 == null || (uint)num2 < 62u || ptr == null)
			{
				return false;
			}
			if ((long)(uint)((crnd_crn_level_info*)ptr)->field_0 != 32L)
			{
				return false;
			}
			ptr3 = crnd_get_header.Invoke(ptr2, num2);
			if (ptr3 == null)
			{
				return false;
			}
			if ((uint)num >= (uint)operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)ptr3)->field_7))
			{
				return false;
			}
			num3 = maximum.Invoke(1, operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr3)->field_5) >>> num);
			num4 = maximum.Invoke(1, operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr3)->field_6) >>> num);
			((crnd_crn_level_info*)ptr)->field_1 = num3;
			((crnd_crn_level_info*)ptr)->field_2 = num4;
			((crnd_crn_level_info*)ptr)->field_3 = operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)ptr3)->field_8);
			((crnd_crn_level_info*)ptr)->field_4 = num3 + 3 >>> 2;
			((crnd_crn_level_info*)ptr)->field_5 = num4 + 3 >>> 2;
			bool flag2 = ((operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)ptr3)->field_9) != 0) ? (operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)ptr3)->field_9) == 9) : true);
			_ = flag2;
			((crnd_crn_level_info*)ptr)->field_6 = InstructionHelper.Select(flag2, 8, 16);
			((crnd_crn_level_info*)ptr)->field_7 = operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)ptr3)->field_9);
			return true;
		}
	}
}
