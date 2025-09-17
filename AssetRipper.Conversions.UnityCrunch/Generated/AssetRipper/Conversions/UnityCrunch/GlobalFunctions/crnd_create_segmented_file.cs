using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_create_segmented_file@crnd@@YA_NPEBXIPEAXI@Z")]
[DemangledName("bool __cdecl crnd::crnd_create_segmented_file(void const *, unsigned int, void *, unsigned int)")]
internal static partial class crnd_create_segmented_file
{
	public unsafe static bool Invoke(void* pData, int data_size, void* pBase_data, int base_data_size)
	{
		bool flag = false;
		int num = 0;
		void* ptr = null;
		int num2 = 0;
		void* ptr2 = null;
		void* ptr3 = null;
		int num3 = 0;
		void* ptr4 = null;
		num = base_data_size;
		ptr = pBase_data;
		num2 = data_size;
		ptr2 = pData;
		unchecked
		{
			if (ptr2 == null || (uint)num2 < 62u)
			{
				return false;
			}
			ptr3 = crnd_get_header.Invoke(ptr2, num2);
			if (ptr3 == null)
			{
				return false;
			}
			if ((operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr3)->field_10) & 1) != 0)
			{
				return false;
			}
			num3 = crnd_get_segmented_file_size.Invoke(ptr2, num2);
			if ((uint)num < (uint)num3)
			{
				return false;
			}
			llvm_memcpy_p0_p0_i64.Invoke(ptr, ptr2, (uint)num3, isVolatile: false);
			ptr4 = ptr;
			_4_crn_packed_uint_5xksx5a.Invoke(val: operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr4)->field_10) | 1, @this: &((crnd_crn_header*)ptr4)->field_10);
			_4_crn_packed_uint_53ytska.Invoke(&((crnd_crn_header*)ptr4)->field_3, num3);
			_4_crn_packed_uint_5xksx5a.Invoke(val: (ushort)crc16.Invoke(len: operator_unsigned_int_uxo4hgd.Invoke(&((crnd_crn_header*)ptr4)->field_3) - operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr4)->field_1), pBuf: (byte*)ptr + (uint)operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr4)->field_1), crc: 0), @this: &((crnd_crn_header*)ptr4)->field_4);
			_4_crn_packed_uint_5xksx5a.Invoke(val: (ushort)crc16.Invoke(len: operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr4)->field_1) - (int)((long)(&((crnd_crn_header*)ptr4)->field_3) - (long)ptr4), pBuf: &((crnd_crn_header*)ptr4)->field_3, crc: 0), @this: &((crnd_crn_header*)ptr4)->field_2);
			int num4;
			if (crnd_validate_file.Invoke(ptr4, num3, null))
			{
				num4 = -1;
			}
			else
			{
				crnd_assert.Invoke(String_2bpyz2d.__pointer, String_yguirrd.__pointer, 2374);
				num4 = 0;
			}
			return true;
		}
	}
}
