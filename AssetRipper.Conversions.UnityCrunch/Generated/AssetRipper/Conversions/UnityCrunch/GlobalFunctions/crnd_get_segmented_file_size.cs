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
		unchecked
		{
			if (pData == null || (uint)data_size < 62u)
			{
				return 0;
			}
			void* ptr = crnd_get_header.Invoke(pData, data_size);
			if (ptr == null)
			{
				return 0;
			}
			return maximum.Invoke(maximum.Invoke(maximum.Invoke(maximum.Invoke(maximum.Invoke(crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_header_size), crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_color_endpoints.m_ofs) + crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_color_endpoints.m_size)), crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_color_selectors.m_ofs) + crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_color_selectors.m_size)), crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_alpha_endpoints.m_ofs) + crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_alpha_endpoints.m_size)), crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_alpha_selectors.m_ofs) + crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_alpha_selectors.m_size)), crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_tables_ofs) + crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_tables_size));
		}
	}
}
