using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_get_texture_info@crnd@@YA_NPEBXIPEAUcrn_texture_info@1@@Z")]
[DemangledName("bool __cdecl crnd::crnd_get_texture_info(void const *, unsigned int, struct crnd::crn_texture_info *)")]
internal static partial class crnd_get_texture_info
{
	public unsafe static bool Invoke(void* pData, int data_size, void* pInfo)
	{
		bool flag = false;
		void* ptr = null;
		int num = 0;
		void* ptr2 = null;
		void* ptr3 = null;
		ptr = pInfo;
		num = data_size;
		ptr2 = pData;
		unchecked
		{
			if (ptr2 == null || (ulong)(uint)num < 74uL || ptr == null)
			{
				return false;
			}
			if ((long)(uint)((crnd_crn_texture_info*)ptr)->field_0 != 36L)
			{
				return false;
			}
			ptr3 = crnd_get_header.Invoke(ptr2, num);
			if (ptr3 == null)
			{
				return false;
			}
			((crnd_crn_texture_info*)ptr)->field_1 = operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr3)->field_5);
			((crnd_crn_texture_info*)ptr)->field_2 = operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr3)->field_6);
			((crnd_crn_texture_info*)ptr)->field_3 = operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)ptr3)->field_7);
			((crnd_crn_texture_info*)ptr)->field_4 = operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)ptr3)->field_8);
			((crnd_crn_texture_info*)ptr)->field_8 = operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)ptr3)->field_9);
			bool flag2 = ((operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)ptr3)->field_9) == 0) ? true : ((operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)ptr3)->field_9) == 9) ? true : ((operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)ptr3)->field_9) == 10) ? true : ((operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)ptr3)->field_9) != 11) ? (operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)ptr3)->field_9) == 13) : true))));
			_ = flag2;
			((crnd_crn_texture_info*)ptr)->field_5 = InstructionHelper.Select(flag2, 8, 16);
			((crnd_crn_texture_info*)ptr)->field_6 = operator_unsigned_int_uxo4hgd.Invoke(&((crnd_crn_header*)ptr3)->field_12);
			((crnd_crn_texture_info*)ptr)->field_7 = operator_unsigned_int_uxo4hgd.Invoke(&((crnd_crn_header*)ptr3)->field_13);
			return true;
		}
	}
}
