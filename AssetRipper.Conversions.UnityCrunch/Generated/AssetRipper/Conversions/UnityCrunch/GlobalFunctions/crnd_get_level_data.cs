using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_get_level_data@crnd@@YAPEBXPEBXIIPEAI@Z")]
[DemangledName("void const * __cdecl crnd::crnd_get_level_data(void const *, unsigned int, unsigned int, unsigned int *)")]
internal static partial class crnd_get_level_data
{
	public unsafe static void* Invoke(void* pData, int data_size, int level_index, void* pSize)
	{
		void* ptr = null;
		void* ptr2 = null;
		int num = 0;
		int num2 = 0;
		void* ptr3 = null;
		void* ptr4 = null;
		int num3 = 0;
		int num4 = 0;
		ptr2 = pSize;
		num = level_index;
		num2 = data_size;
		ptr3 = pData;
		unchecked
		{
			if (ptr2 != null)
			{
				*(int*)ptr2 = 0;
			}
			if (ptr3 == null || (uint)num2 < 62u)
			{
				return null;
			}
			ptr4 = crnd_get_header.Invoke(ptr3, num2);
			if (ptr4 == null)
			{
				return null;
			}
			if ((uint)num >= (uint)operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)ptr4)->field_7))
			{
				return null;
			}
			num3 = operator_unsigned_int_uxo4hgd.Invoke((byte*)(&((crnd_crn_header*)ptr4)->field_20) + (nint)(uint)num * (nint)sizeof(crnd_crn_packed_uint_0));
			if (ptr2 != null)
			{
				num4 = num2;
				if ((uint)(num + 1) < (uint)operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)ptr4)->field_7))
				{
					num4 = operator_unsigned_int_uxo4hgd.Invoke((byte*)(&((crnd_crn_header*)ptr4)->field_20) + (nint)(uint)(num + 1) * (nint)sizeof(crnd_crn_packed_uint_0));
				}
				*(int*)ptr2 = num4 - num3;
			}
			return (byte*)ptr3 + (uint)num3;
		}
	}
}
