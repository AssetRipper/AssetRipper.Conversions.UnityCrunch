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
		unchecked
		{
			if (pFile_info != null)
			{
				if ((long)(uint)((crnd_crn_file_info*)pFile_info)->m_struct_size != 104L)
				{
					return false;
				}
				llvm_memset_p0_i64.Invoke(&((crnd_crn_file_info*)pFile_info)->m_struct_size + 1, 0, 100L, isVolatile: false);
			}
			if (pData == null || (uint)data_size < 62u)
			{
				return false;
			}
			void* ptr = crnd_get_header.Invoke(pData, data_size);
			if (ptr == null)
			{
				return false;
			}
			if ((ushort)crc16.Invoke(len: (int)checked(unchecked((uint)crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_header_size)) - unchecked((long)(&((crnd_crn_header*)ptr)->m_data_size) - (long)ptr)), pBuf: &((crnd_crn_header*)ptr)->m_data_size, crc: 0) != crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_header_crc16))
			{
				return false;
			}
			if ((ushort)crc16.Invoke(len: crn_packed_uint_4_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_data_size) - crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_header_size), pBuf: (byte*)pData + (uint)crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_header_size), crc: 0) != crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_data_crc16))
			{
				return false;
			}
			if (crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_faces) != 1 && crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_faces) != 6)
			{
				return false;
			}
			if ((uint)crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_width) < 1u || (uint)crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_width) > 4096u)
			{
				return false;
			}
			if ((uint)crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_height) < 1u || (uint)crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_height) > 4096u)
			{
				return false;
			}
			if ((uint)crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_levels) < 1u || (uint)crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_levels) > (uint)compute_max_mips.Invoke(height: crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_height), width: crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_width)))
			{
				return false;
			}
			if (crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_format) < 0 || crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_format) >= 15)
			{
				return false;
			}
			if (pFile_info != null)
			{
				((crnd_crn_file_info*)pFile_info)->m_actual_data_size = crn_packed_uint_4_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_data_size);
				((crnd_crn_file_info*)pFile_info)->m_header_size = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_header_size);
				((crnd_crn_file_info*)pFile_info)->m_total_palette_size = crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_color_endpoints.m_size) + crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_color_selectors.m_size) + crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_alpha_endpoints.m_size) + crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_alpha_selectors.m_size);
				((crnd_crn_file_info*)pFile_info)->m_tables_size = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_tables_size);
				((crnd_crn_file_info*)pFile_info)->m_levels = crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_levels);
				for (int i = 0; (uint)i < (uint)crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_levels); i++)
				{
					int num = crn_packed_uint_4_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_data_size);
					if ((uint)(i + 1) < (uint)crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_levels))
					{
						num = crn_packed_uint_4_ToUInt32.Invoke((byte*)(&((crnd_crn_header*)ptr)->m_level_ofs) + (nint)(uint)(i + 1) * (nint)sizeof(crnd_crn_packed_uint_jymcebc));
					}
					int num2 = num - crn_packed_uint_4_ToUInt32.Invoke((byte*)(&((crnd_crn_header*)ptr)->m_level_ofs) + (nint)(uint)i * (nint)sizeof(crnd_crn_packed_uint_jymcebc));
					((int*)(&((crnd_crn_file_info*)pFile_info)->m_level_compressed_size))[(uint)i] = num2;
				}
				((crnd_crn_file_info*)pFile_info)->m_color_endpoint_palette_entries = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_color_endpoints.m_num);
				((crnd_crn_file_info*)pFile_info)->m_color_selector_palette_entries = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_color_selectors.m_num);
				((crnd_crn_file_info*)pFile_info)->m_alpha_endpoint_palette_entries = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_alpha_endpoints.m_num);
				((crnd_crn_file_info*)pFile_info)->m_alpha_selector_palette_entries = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_alpha_selectors.m_num);
			}
			return true;
		}
	}
}
