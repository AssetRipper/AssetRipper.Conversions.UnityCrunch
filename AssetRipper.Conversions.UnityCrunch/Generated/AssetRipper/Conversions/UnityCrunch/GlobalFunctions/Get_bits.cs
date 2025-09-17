using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?get_bits@symbol_codec@crnd@@AEAAII@Z")]
[DemangledName("private: unsigned int __cdecl crnd::symbol_codec::get_bits(unsigned int)")]
internal static partial class Get_bits
{
	public unsafe static int Invoke(void* @this, int num_bits)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		num = num_bits;
		unchecked
		{
			int num4;
			if ((uint)num <= 32u)
			{
				num4 = -1;
			}
			else
			{
				crnd_assert.Invoke(String_bhrpdhd.__pointer, String_yguirrd.__pointer, 2642);
				num4 = 0;
			}
			while (((crnd_symbol_codec*)@this)->field_5 < num)
			{
				num2 = 0;
				if (((crnd_symbol_codec*)@this)->field_1 != ((crnd_symbol_codec*)@this)->field_2)
				{
					void** field_ = &((crnd_symbol_codec*)@this)->field_1;
					void* ptr = *field_;
					*field_ = (byte*)ptr + 1;
					num2 = (byte)(*(sbyte*)ptr);
				}
				int num6;
				checked
				{
					unchecked((crnd_symbol_codec*)@this)->field_5 += 8;
					int num5;
					if (unchecked((crnd_symbol_codec*)@this)->field_5 <= 32)
					{
						num5 = -1;
					}
					else
					{
						crnd_assert.Invoke(String_kf9n5db.__pointer, String_yguirrd.__pointer, 2650);
						num5 = 0;
					}
					num6 = num2 << 32 - unchecked((crnd_symbol_codec*)@this)->field_5;
				}
				((crnd_symbol_codec*)@this)->field_4 |= num6;
			}
			num3 = ((crnd_symbol_codec*)@this)->field_4 >>> 32 - num;
			((crnd_symbol_codec*)@this)->field_4 <<= num;
			((crnd_symbol_codec*)@this)->field_5 -= num;
			return num3;
		}
	}
}
