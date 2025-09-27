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
		unchecked
		{
			if ((uint)num_bits > 32u)
			{
				crnd_assert.Invoke(String_bhrpdhd.__pointer, String_yguirrd.__pointer, 2642);
			}
			while (((crnd_symbol_codec*)@this)->m_bit_count < num_bits)
			{
				int num = 0;
				if (((crnd_symbol_codec*)@this)->m_pDecode_buf_next != ((crnd_symbol_codec*)@this)->m_pDecode_buf_end)
				{
					void** pDecode_buf_next = &((crnd_symbol_codec*)@this)->m_pDecode_buf_next;
					void* ptr = *pDecode_buf_next;
					*pDecode_buf_next = (byte*)ptr + 1;
					num = (byte)(*(sbyte*)ptr);
				}
				int num2;
				checked
				{
					unchecked((crnd_symbol_codec*)@this)->m_bit_count += 8;
					if (unchecked((crnd_symbol_codec*)@this)->m_bit_count > 32)
					{
						crnd_assert.Invoke(String_kf9n5db.__pointer, String_yguirrd.__pointer, 2650);
					}
					num2 = num << 32 - unchecked((crnd_symbol_codec*)@this)->m_bit_count;
				}
				((crnd_symbol_codec*)@this)->m_bit_buf |= num2;
			}
			int result = ((crnd_symbol_codec*)@this)->m_bit_buf >>> 32 - num_bits;
			((crnd_symbol_codec*)@this)->m_bit_buf <<= num_bits;
			((crnd_symbol_codec*)@this)->m_bit_count -= num_bits;
			return result;
		}
	}
}
