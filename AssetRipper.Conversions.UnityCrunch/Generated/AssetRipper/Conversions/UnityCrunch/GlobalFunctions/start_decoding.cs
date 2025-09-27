using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?start_decoding@symbol_codec@crnd@@QEAA_NPEBEI@Z")]
[DemangledName("public: bool __cdecl crnd::symbol_codec::start_decoding(unsigned char const *, unsigned int)")]
internal static partial class start_decoding
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned char const *")] void* pBuf, [NativeType("unsigned int")] int buf_size)
	{
		if (buf_size == 0)
		{
			return false;
		}
		unchecked
		{
			((crnd_symbol_codec*)@this)->m_pDecode_buf = pBuf;
			((crnd_symbol_codec*)@this)->m_pDecode_buf_next = pBuf;
			((crnd_symbol_codec*)@this)->m_decode_buf_size = buf_size;
			((crnd_symbol_codec*)@this)->m_pDecode_buf_end = (byte*)pBuf + (uint)buf_size;
			Get_bits_init.Invoke(@this);
			return true;
		}
	}
}
