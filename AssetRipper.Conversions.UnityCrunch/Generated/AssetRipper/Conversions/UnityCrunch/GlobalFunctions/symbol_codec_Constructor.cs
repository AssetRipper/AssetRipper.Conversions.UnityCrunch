using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??0symbol_codec@crnd@@QEAA@XZ")]
[DemangledName("public: __cdecl crnd::symbol_codec::symbol_codec(void)")]
internal static partial class symbol_codec_Constructor
{
	public unsafe static void* Invoke(void* @this)
	{
		unchecked
		{
			((crnd_symbol_codec*)@this)->m_pDecode_buf = null;
			((crnd_symbol_codec*)@this)->m_pDecode_buf_next = null;
			((crnd_symbol_codec*)@this)->m_pDecode_buf_end = null;
			((crnd_symbol_codec*)@this)->m_decode_buf_size = 0;
			((crnd_symbol_codec*)@this)->m_bit_buf = 0;
			((crnd_symbol_codec*)@this)->m_bit_count = 0;
			return @this;
		}
	}
}
