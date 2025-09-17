using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_get_segmented_file_size@crnd@@YAIPEBXI@Z")]
[DemangledName("unsigned int __cdecl crnd::crnd_get_segmented_file_size(void const *, unsigned int)")]
internal static partial class crnd_get_segmented_file_size
{
	public unsafe static int Invoke(void* pData, int data_size)
	{
		int num = 0;
		int num2 = 0;
		void* ptr = null;
		void* ptr2 = null;
		int num3 = 0;
		num2 = data_size;
		ptr = pData;
		unchecked
		{
			if (ptr == null || (uint)num2 < 62u)
			{
				return 0;
			}
			ptr2 = crnd_get_header.Invoke(ptr, num2);
			if (ptr2 == null)
			{
				return 0;
			}
			return maximum.Invoke(maximum.Invoke(maximum.Invoke(maximum.Invoke(maximum.Invoke(operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr2)->field_1), operator_unsigned_int_4iyly2b.Invoke(&((crnd_crn_header*)ptr2)->field_14.field_0) + operator_unsigned_int_4iyly2b.Invoke(&((crnd_crn_header*)ptr2)->field_14.field_1)), operator_unsigned_int_4iyly2b.Invoke(&((crnd_crn_header*)ptr2)->field_15.field_0) + operator_unsigned_int_4iyly2b.Invoke(&((crnd_crn_header*)ptr2)->field_15.field_1)), operator_unsigned_int_4iyly2b.Invoke(&((crnd_crn_header*)ptr2)->field_16.field_0) + operator_unsigned_int_4iyly2b.Invoke(&((crnd_crn_header*)ptr2)->field_16.field_1)), operator_unsigned_int_4iyly2b.Invoke(&((crnd_crn_header*)ptr2)->field_17.field_0) + operator_unsigned_int_4iyly2b.Invoke(&((crnd_crn_header*)ptr2)->field_17.field_1)), operator_unsigned_int_4iyly2b.Invoke(&((crnd_crn_header*)ptr2)->field_19) + operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr2)->field_18));
		}
	}
}
