using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?unpack_level@crn_unpacker@crnd@@QEAA_NPEAPEAXIII@Z")]
[DemangledName("public: bool __cdecl crnd::crn_unpacker::unpack_level(void **, unsigned int, unsigned int, unsigned int)")]
[CleanName("unpack_level")]
internal static partial class unpack_level_cvfjdga
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("void **")] void* pDst, [NativeType("unsigned int")] int dst_size_in_bytes, [NativeType("unsigned int")] int row_pitch_in_bytes, [NativeType("unsigned int")] int level_index)
	{
		unchecked
		{
			int num = crn_packed_uint_4_ToUInt32.Invoke((byte*)(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_level_ofs) + (nint)(uint)level_index * (nint)sizeof(crnd_crn_packed_uint_jymcebc));
			int num2 = ((crnd_crn_unpacker*)@this)->m_data_size;
			if ((uint)(level_index + 1) < (uint)crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_levels))
			{
				num2 = crn_packed_uint_4_ToUInt32.Invoke((byte*)(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_level_ofs) + (nint)(uint)(level_index + 1) * (nint)sizeof(crnd_crn_packed_uint_jymcebc));
			}
			if ((uint)num2 <= (uint)num)
			{
				crnd_assert.Invoke(String_huvyfmc.__pointer, String_yguirrd.__pointer, 2982);
			}
			bool result = unpack_level_zjb72ec.Invoke(@this, (byte*)((crnd_crn_unpacker*)@this)->m_pData + (uint)num, num2 - num, pDst, dst_size_in_bytes, row_pitch_in_bytes, level_index);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			return result;
		}
	}
}
