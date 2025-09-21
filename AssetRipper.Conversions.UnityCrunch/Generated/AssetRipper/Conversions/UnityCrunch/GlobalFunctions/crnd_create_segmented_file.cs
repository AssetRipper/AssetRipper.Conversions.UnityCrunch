using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_create_segmented_file@crnd@@YA_NPEBXIPEAXI@Z")]
[DemangledName("bool __cdecl crnd::crnd_create_segmented_file(void const *, unsigned int, void *, unsigned int)")]
internal static partial class crnd_create_segmented_file
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke([NativeType("void const *")] void* pData, [NativeType("unsigned int")] int data_size, [NativeType("void *")] void* pBase_data, [NativeType("unsigned int")] int base_data_size)
	{
		unchecked
		{
			if (pData == null || (uint)data_size < 62u)
			{
				return false;
			}
			void* ptr = crnd_get_header.Invoke(pData, data_size);
			if (ptr == null)
			{
				return false;
			}
			if ((crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_10) & 1) != 0)
			{
				return false;
			}
			int num = crnd_get_segmented_file_size.Invoke(pData, data_size);
			if ((uint)base_data_size < (uint)num)
			{
				return false;
			}
			llvm_memcpy_p0_p0_i64.Invoke(pBase_data, pData, (uint)num, isVolatile: false);
			crn_packed_uint_2_Assignment.Invoke(val: crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)pBase_data)->field_10) | 1, @this: &((crnd_crn_header*)pBase_data)->field_10);
			crn_packed_uint_4_Assignment.Invoke(&((crnd_crn_header*)pBase_data)->field_3, num);
			crn_packed_uint_2_Assignment.Invoke(val: (ushort)crc16.Invoke(len: crn_packed_uint_4_ToUInt32.Invoke(&((crnd_crn_header*)pBase_data)->field_3) - crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)pBase_data)->field_1), pBuf: (byte*)pBase_data + (uint)crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)pBase_data)->field_1), crc: 0), @this: &((crnd_crn_header*)pBase_data)->field_4);
			crn_packed_uint_2_Assignment.Invoke(val: (ushort)crc16.Invoke(len: crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)pBase_data)->field_1) - (int)((long)(&((crnd_crn_header*)pBase_data)->field_3) - (long)pBase_data), pBuf: &((crnd_crn_header*)pBase_data)->field_3, crc: 0), @this: &((crnd_crn_header*)pBase_data)->field_2);
			if (!crnd_validate_file.Invoke(pBase_data, num, null))
			{
				crnd_assert.Invoke(String_2bpyz2d.__pointer, String_yguirrd.__pointer, 2374);
			}
			return true;
		}
	}
}
