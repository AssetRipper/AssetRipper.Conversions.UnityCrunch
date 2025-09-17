using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_validate_file@crnd@@YA_NPEBXIPEAUcrn_file_info@1@@Z")]
[DemangledName("bool __cdecl crnd::crnd_validate_file(void const *, unsigned int, struct crnd::crn_file_info *)")]
internal static partial class crnd_validate_file
{
	public unsafe static bool Invoke(void* pData, int data_size, void* pFile_info)
	{
		bool flag = false;
		void* ptr = null;
		int num = 0;
		void* ptr2 = null;
		void* ptr3 = null;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		ptr = pFile_info;
		num = data_size;
		ptr2 = pData;
		unchecked
		{
			if (ptr != null)
			{
				if ((long)(uint)((crnd_crn_file_info*)ptr)->field_0 != 104L)
				{
					return false;
				}
				llvm_memset_p0_i64.Invoke(&((crnd_crn_file_info*)ptr)->field_0 + 1, 0, 100L, isVolatile: false);
			}
			if (ptr2 == null || (uint)num < 62u)
			{
				return false;
			}
			ptr3 = crnd_get_header.Invoke(ptr2, num);
			if (ptr3 == null)
			{
				return false;
			}
			if ((ushort)crc16.Invoke(len: (int)checked(unchecked((uint)operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr3)->field_1)) - unchecked((long)(&((crnd_crn_header*)ptr3)->field_3) - (long)ptr3)), pBuf: &((crnd_crn_header*)ptr3)->field_3, crc: 0) != operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr3)->field_2))
			{
				return false;
			}
			if ((ushort)crc16.Invoke(len: operator_unsigned_int_uxo4hgd.Invoke(&((crnd_crn_header*)ptr3)->field_3) - operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr3)->field_1), pBuf: (byte*)ptr2 + (uint)operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr3)->field_1), crc: 0) != operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr3)->field_4))
			{
				return false;
			}
			if (operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)ptr3)->field_8) != 1 && operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)ptr3)->field_8) != 6)
			{
				return false;
			}
			if ((uint)operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr3)->field_5) < 1u || (uint)operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr3)->field_5) > 4096u)
			{
				return false;
			}
			if ((uint)operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr3)->field_6) < 1u || (uint)operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr3)->field_6) > 4096u)
			{
				return false;
			}
			if ((uint)operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)ptr3)->field_7) < 1u || (uint)operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)ptr3)->field_7) > (uint)compute_max_mips.Invoke(height: operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr3)->field_6), width: operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr3)->field_5)))
			{
				return false;
			}
			if (operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)ptr3)->field_9) < 0 || operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)ptr3)->field_9) >= 15)
			{
				return false;
			}
			if (ptr != null)
			{
				((crnd_crn_file_info*)ptr)->field_1 = operator_unsigned_int_uxo4hgd.Invoke(&((crnd_crn_header*)ptr3)->field_3);
				((crnd_crn_file_info*)ptr)->field_2 = operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr3)->field_1);
				((crnd_crn_file_info*)ptr)->field_3 = operator_unsigned_int_4iyly2b.Invoke(&((crnd_crn_header*)ptr3)->field_14.field_1) + operator_unsigned_int_4iyly2b.Invoke(&((crnd_crn_header*)ptr3)->field_15.field_1) + operator_unsigned_int_4iyly2b.Invoke(&((crnd_crn_header*)ptr3)->field_16.field_1) + operator_unsigned_int_4iyly2b.Invoke(&((crnd_crn_header*)ptr3)->field_17.field_1);
				((crnd_crn_file_info*)ptr)->field_4 = operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr3)->field_18);
				((crnd_crn_file_info*)ptr)->field_5 = operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)ptr3)->field_7);
				for (num4 = 0; (uint)num4 < (uint)operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)ptr3)->field_7); num4++)
				{
					num5 = operator_unsigned_int_uxo4hgd.Invoke(&((crnd_crn_header*)ptr3)->field_3);
					if ((uint)(num4 + 1) < (uint)operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)ptr3)->field_7))
					{
						num5 = operator_unsigned_int_uxo4hgd.Invoke((byte*)(&((crnd_crn_header*)ptr3)->field_20) + (nint)(uint)(num4 + 1) * (nint)sizeof(crnd_crn_packed_uint_0));
					}
					int num6 = num5 - operator_unsigned_int_uxo4hgd.Invoke((byte*)(&((crnd_crn_header*)ptr3)->field_20) + (nint)(uint)num4 * (nint)sizeof(crnd_crn_packed_uint_0));
					((int*)(&((crnd_crn_file_info*)ptr)->field_6))[(uint)num4] = num6;
				}
				((crnd_crn_file_info*)ptr)->field_7 = operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr3)->field_14.field_2);
				((crnd_crn_file_info*)ptr)->field_8 = operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr3)->field_15.field_2);
				((crnd_crn_file_info*)ptr)->field_9 = operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr3)->field_16.field_2);
				((crnd_crn_file_info*)ptr)->field_10 = operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)ptr3)->field_17.field_2);
			}
			return true;
		}
	}
}
