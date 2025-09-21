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
			((crnd_symbol_codec*)@this)->field_0 = pBuf;
			((crnd_symbol_codec*)@this)->field_1 = pBuf;
			((crnd_symbol_codec*)@this)->field_3 = buf_size;
			((crnd_symbol_codec*)@this)->field_2 = (byte*)pBuf + (uint)buf_size;
			Get_bits_init.Invoke(@this);
			return true;
		}
	}
}
