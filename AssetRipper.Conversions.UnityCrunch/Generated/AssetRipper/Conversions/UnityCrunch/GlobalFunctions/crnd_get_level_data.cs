using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_get_level_data@crnd@@YAPEBXPEBXIIPEAI@Z")]
[DemangledName("void const * __cdecl crnd::crnd_get_level_data(void const *, unsigned int, unsigned int, unsigned int *)")]
internal static partial class crnd_get_level_data
{
	[return: NativeType("void const *")]
	public unsafe static void* Invoke([NativeType("void const *")] void* pData, [NativeType("unsigned int")] int data_size, [NativeType("unsigned int")] int level_index, [NativeType("unsigned int *")] void* pSize)
	{
		unchecked
		{
			if (pSize != null)
			{
				*(int*)pSize = 0;
			}
			if (pData == null || (uint)data_size < 62u)
			{
				return null;
			}
			void* ptr = crnd_get_header.Invoke(pData, data_size);
			if (ptr == null)
			{
				return null;
			}
			if ((uint)level_index >= (uint)crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_levels))
			{
				return null;
			}
			int num = crn_packed_uint_4_ToUInt32.Invoke((byte*)(&((crnd_crn_header*)ptr)->m_level_ofs) + (nint)(uint)level_index * (nint)sizeof(crnd_crn_packed_uint_jymcebc));
			if (pSize != null)
			{
				int num2 = data_size;
				if ((uint)(level_index + 1) < (uint)crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->m_levels))
				{
					num2 = crn_packed_uint_4_ToUInt32.Invoke((byte*)(&((crnd_crn_header*)ptr)->m_level_ofs) + (nint)(uint)(level_index + 1) * (nint)sizeof(crnd_crn_packed_uint_jymcebc));
				}
				*(int*)pSize = num2 - num;
			}
			return (byte*)pData + (uint)num;
		}
	}
}
