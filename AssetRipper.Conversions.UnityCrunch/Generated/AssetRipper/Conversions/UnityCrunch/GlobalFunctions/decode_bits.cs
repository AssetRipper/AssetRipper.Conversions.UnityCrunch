using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?decode_bits@symbol_codec@crnd@@QEAAII@Z")]
[DemangledName("public: unsigned int __cdecl crnd::symbol_codec::decode_bits(unsigned int)")]
internal static partial class decode_bits
{
	public unsafe static int Invoke(void* @this, int num_bits)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		num2 = num_bits;
		switch (num2)
		{
		case 0:
			return 0;
		default:
			return (Get_bits.Invoke(@this, unchecked(num2 - 16)) << 16) | Get_bits.Invoke(@this, 16);
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
		case 9:
		case 10:
		case 11:
		case 12:
		case 13:
		case 14:
		case 15:
		case 16:
			return Get_bits.Invoke(@this, num2);
		}
	}
}
