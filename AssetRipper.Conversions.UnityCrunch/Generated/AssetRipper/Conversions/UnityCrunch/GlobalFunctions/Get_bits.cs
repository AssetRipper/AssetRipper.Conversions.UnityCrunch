using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?get_bits@symbol_codec@crnd@@AEAAII@Z")]
[DemangledName("private: unsigned int __cdecl crnd::symbol_codec::get_bits(unsigned int)")]
internal static partial class Get_bits
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this, [NativeType("unsigned int")] int num_bits)
	{
		int num = 0;
		int num2 = 0;
		unchecked
		{
			int num3;
			if ((uint)num_bits <= 32u)
			{
				num3 = -1;
			}
			else
			{
				crnd_assert.Invoke(String_bhrpdhd.__pointer, String_yguirrd.__pointer, 2642);
				num3 = 0;
			}
			while (((crnd_symbol_codec*)@this)->field_5 < num_bits)
			{
				num = 0;
				if (((crnd_symbol_codec*)@this)->field_1 != ((crnd_symbol_codec*)@this)->field_2)
				{
					void** field_ = &((crnd_symbol_codec*)@this)->field_1;
					void* ptr = *field_;
					*field_ = (byte*)ptr + 1;
					num = (byte)(*(sbyte*)ptr);
				}
				int num5;
				checked
				{
					unchecked((crnd_symbol_codec*)@this)->field_5 += 8;
					int num4;
					if (unchecked((crnd_symbol_codec*)@this)->field_5 <= 32)
					{
						num4 = -1;
					}
					else
					{
						crnd_assert.Invoke(String_kf9n5db.__pointer, String_yguirrd.__pointer, 2650);
						num4 = 0;
					}
					num5 = num << 32 - unchecked((crnd_symbol_codec*)@this)->field_5;
				}
				((crnd_symbol_codec*)@this)->field_4 |= num5;
			}
			num2 = ((crnd_symbol_codec*)@this)->field_4 >>> 32 - num_bits;
			((crnd_symbol_codec*)@this)->field_4 <<= num_bits;
			((crnd_symbol_codec*)@this)->field_5 -= num_bits;
			return num2;
		}
	}
}
