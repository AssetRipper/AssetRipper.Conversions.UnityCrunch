using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_get_segmented_file_size@crnd@@YAIPEBXI@Z")]
[DemangledName("unsigned int __cdecl crnd::crnd_get_segmented_file_size(void const *, unsigned int)")]
internal static partial class crnd_get_segmented_file_size
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("void const *")] void* pData, [NativeType("unsigned int")] int data_size)
	{
		int num = 0;
		void* ptr = null;
		int num2 = 0;
		unchecked
		{
			if (pData == null || (uint)data_size < 62u)
			{
				return 0;
			}
			ptr = crnd_get_header.Invoke(pData, data_size);
			if (ptr == null)
			{
				return 0;
			}
			return maximum.Invoke(maximum.Invoke(maximum.Invoke(maximum.Invoke(maximum.Invoke(crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_1), crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_14.field_0) + crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_14.field_1)), crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_15.field_0) + crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_15.field_1)), crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_16.field_0) + crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_16.field_1)), crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_17.field_0) + crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_17.field_1)), crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_19) + crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_18));
		}
	}
}
