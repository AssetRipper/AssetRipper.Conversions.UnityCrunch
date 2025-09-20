using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_validate_file@crnd@@YA_NPEBXIPEAUcrn_file_info@1@@Z")]
[DemangledName("bool __cdecl crnd::crnd_validate_file(void const *, unsigned int, struct crnd::crn_file_info *)")]
internal static partial class crnd_validate_file
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke([NativeType("void const *")] void* pData, [NativeType("unsigned int")] int data_size, [NativeType("struct crnd::crn_file_info *")] void* pFile_info)
	{
		bool flag = false;
		void* ptr = null;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		unchecked
		{
			if (pFile_info != null)
			{
				if ((long)(uint)((crnd_crn_file_info*)pFile_info)->field_0 != 104L)
				{
					return false;
				}
				llvm_memset_p0_i64.Invoke(&((crnd_crn_file_info*)pFile_info)->field_0 + 1, 0, 100L, isVolatile: false);
			}
			if (pData == null || (uint)data_size < 62u)
			{
				return false;
			}
			ptr = crnd_get_header.Invoke(pData, data_size);
			if (ptr == null)
			{
				return false;
			}
			if ((ushort)crc16.Invoke(len: (int)checked(unchecked((uint)crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_1)) - unchecked((long)(&((crnd_crn_header*)ptr)->field_3) - (long)ptr)), pBuf: &((crnd_crn_header*)ptr)->field_3, crc: 0) != crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_2))
			{
				return false;
			}
			if ((ushort)crc16.Invoke(len: crn_packed_uint_4_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_3) - crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_1), pBuf: (byte*)pData + (uint)crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_1), crc: 0) != crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_4))
			{
				return false;
			}
			if (crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_8) != 1 && crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_8) != 6)
			{
				return false;
			}
			if ((uint)crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_5) < 1u || (uint)crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_5) > 4096u)
			{
				return false;
			}
			if ((uint)crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_6) < 1u || (uint)crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_6) > 4096u)
			{
				return false;
			}
			if ((uint)crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_7) < 1u || (uint)crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_7) > (uint)compute_max_mips.Invoke(height: crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_6), width: crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_5)))
			{
				return false;
			}
			if (crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_9) < 0 || crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_9) >= 15)
			{
				return false;
			}
			if (pFile_info != null)
			{
				((crnd_crn_file_info*)pFile_info)->field_1 = crn_packed_uint_4_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_3);
				((crnd_crn_file_info*)pFile_info)->field_2 = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_1);
				((crnd_crn_file_info*)pFile_info)->field_3 = crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_14.field_1) + crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_15.field_1) + crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_16.field_1) + crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_17.field_1);
				((crnd_crn_file_info*)pFile_info)->field_4 = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_18);
				((crnd_crn_file_info*)pFile_info)->field_5 = crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_7);
				for (num3 = 0; (uint)num3 < (uint)crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_7); num3++)
				{
					num4 = crn_packed_uint_4_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_3);
					if ((uint)(num3 + 1) < (uint)crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_7))
					{
						num4 = crn_packed_uint_4_ToUInt32.Invoke((byte*)(&((crnd_crn_header*)ptr)->field_20) + (nint)(uint)(num3 + 1) * (nint)sizeof(crnd_crn_packed_uint_jymcebc));
					}
					int num5 = num4 - crn_packed_uint_4_ToUInt32.Invoke((byte*)(&((crnd_crn_header*)ptr)->field_20) + (nint)(uint)num3 * (nint)sizeof(crnd_crn_packed_uint_jymcebc));
					((int*)(&((crnd_crn_file_info*)pFile_info)->field_6))[(uint)num3] = num5;
				}
				((crnd_crn_file_info*)pFile_info)->field_7 = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_14.field_2);
				((crnd_crn_file_info*)pFile_info)->field_8 = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_15.field_2);
				((crnd_crn_file_info*)pFile_info)->field_9 = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_16.field_2);
				((crnd_crn_file_info*)pFile_info)->field_10 = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_17.field_2);
			}
			return true;
		}
	}
}
