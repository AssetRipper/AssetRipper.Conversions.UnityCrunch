using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_get_header@crnd@@YAPEBUcrn_header@1@PEBXI@Z")]
[DemangledName("struct crnd::crn_header const * __cdecl crnd::crnd_get_header(void const *, unsigned int)")]
internal static partial class crnd_get_header
{
	[return: NativeType("struct crnd::crn_header const *")]
	public unsafe static void* Invoke([NativeType("void const *")] void* pData, [NativeType("unsigned int")] int data_size)
	{
		unchecked
		{
			if (pData == null || (ulong)(uint)data_size < 74uL)
			{
				return null;
			}
			if (crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)pData)->m_sig) != 18552)
			{
				return null;
			}
			if ((ulong)(uint)crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)pData)->m_header_size) < 74uL || (uint)data_size < (uint)crn_packed_uint_4_ToUInt32.Invoke(&((crnd_crn_header*)pData)->m_data_size))
			{
				return null;
			}
			return pData;
		}
	}
}
