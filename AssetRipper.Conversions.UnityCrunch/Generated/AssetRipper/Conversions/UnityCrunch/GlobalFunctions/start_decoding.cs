using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?start_decoding@symbol_codec@crnd@@QEAA_NPEBEI@Z")]
[DemangledName("public: bool __cdecl crnd::symbol_codec::start_decoding(unsigned char const *, unsigned int)")]
internal static partial class start_decoding
{
	public unsafe static bool Invoke(void* @this, void* pBuf, int buf_size)
	{
		bool flag = false;
		int num = 0;
		void* ptr = null;
		num = buf_size;
		ptr = pBuf;
		if (num == 0)
		{
			return false;
		}
		unchecked
		{
			((crnd_symbol_codec*)@this)->field_0 = ptr;
			((crnd_symbol_codec*)@this)->field_1 = ptr;
			((crnd_symbol_codec*)@this)->field_3 = num;
			((crnd_symbol_codec*)@this)->field_2 = (byte*)ptr + (uint)num;
			Get_bits_init.Invoke(@this);
			return true;
		}
	}
}
