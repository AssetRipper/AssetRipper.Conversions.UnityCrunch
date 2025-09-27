using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_get_level_info@crnd@@YA_NPEBXIIPEAUcrn_level_info@1@@Z")]
[DemangledName("bool __cdecl crnd::crnd_get_level_info(void const *, unsigned int, unsigned int, struct crnd::crn_level_info *)")]
internal static partial class crnd_get_level_info
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke([NativeType("void const *")] void* pData, [NativeType("unsigned int")] int data_size, [NativeType("unsigned int")] int level_index, [NativeType("struct crnd::crn_level_info *")] void* pLevel_info)
	{
		unchecked
		{
			if (pData == null || (uint)data_size < 62u || pLevel_info == null)
			{
				return false;
			}
			if ((long)(uint)((crnd_crn_level_info*)pLevel_info)->m_struct_size != 32L)
			{
				return false;
			}
			void* ptr = crnd_get_header.Invoke(pData, data_size);
			if (ptr == null)
			{
				return false;
			}
			if ((uint)level_index >= (uint)crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_levels))
			{
				return false;
			}
			int num = maximum.Invoke(1, crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_width) >>> level_index);
			int num2 = maximum.Invoke(1, crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_height) >>> level_index);
			((crnd_crn_level_info*)pLevel_info)->m_width = num;
			((crnd_crn_level_info*)pLevel_info)->m_height = num2;
			((crnd_crn_level_info*)pLevel_info)->m_faces = crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_faces);
			((crnd_crn_level_info*)pLevel_info)->m_blocks_x = num + 3 >>> 2;
			((crnd_crn_level_info*)pLevel_info)->m_blocks_y = num2 + 3 >>> 2;
			((crnd_crn_level_info*)pLevel_info)->m_bytes_per_block = InstructionHelper.Select((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_format) != 0) ? (crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_format) == 9) : true, 8, 16);
			((crnd_crn_level_info*)pLevel_info)->m_format = crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_format);
			return true;
		}
	}
}
