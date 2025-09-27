using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_get_texture_info@crnd@@YA_NPEBXIPEAUcrn_texture_info@1@@Z")]
[DemangledName("bool __cdecl crnd::crnd_get_texture_info(void const *, unsigned int, struct crnd::crn_texture_info *)")]
internal static partial class crnd_get_texture_info
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke([NativeType("void const *")] void* pData, [NativeType("unsigned int")] int data_size, [NativeType("struct crnd::crn_texture_info *")] void* pInfo)
	{
		unchecked
		{
			if (pData == null || (ulong)(uint)data_size < 74uL || pInfo == null)
			{
				return false;
			}
			if ((long)(uint)((crnd_crn_texture_info*)pInfo)->m_struct_size != 36L)
			{
				return false;
			}
			void* ptr = crnd_get_header.Invoke(pData, data_size);
			if (ptr == null)
			{
				return false;
			}
			((crnd_crn_texture_info*)pInfo)->m_width = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_width);
			((crnd_crn_texture_info*)pInfo)->m_height = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_height);
			((crnd_crn_texture_info*)pInfo)->m_levels = crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_levels);
			((crnd_crn_texture_info*)pInfo)->m_faces = crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_faces);
			((crnd_crn_texture_info*)pInfo)->m_format = crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_format);
			((crnd_crn_texture_info*)pInfo)->m_bytes_per_block = InstructionHelper.Select((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_format) == 0) ? true : ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_format) == 9) ? true : ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_format) == 10) ? true : ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_format) != 11) ? (crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_format) == 13) : true))), 8, 16);
			((crnd_crn_texture_info*)pInfo)->m_userdata0 = crn_packed_uint_4_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_userdata0);
			((crnd_crn_texture_info*)pInfo)->m_userdata1 = crn_packed_uint_4_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_userdata1);
			return true;
		}
	}
}
