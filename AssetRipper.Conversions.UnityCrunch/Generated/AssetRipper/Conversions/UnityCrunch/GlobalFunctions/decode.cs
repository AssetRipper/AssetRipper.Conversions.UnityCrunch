using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?decode@symbol_codec@crnd@@QEAAIAEBVstatic_huffman_data_model@2@@Z")]
[DemangledName("public: unsigned int __cdecl crnd::symbol_codec::decode(class crnd::static_huffman_data_model const &)")]
internal static partial class decode
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this, [NativeType("class crnd::static_huffman_data_model const &")] void* model)
	{
		unchecked
		{
			void* field_ = ((crnd_static_huffman_data_model*)model)->field_2;
			if (((crnd_symbol_codec*)@this)->field_5 < 24)
			{
				if (((crnd_symbol_codec*)@this)->field_5 < 16)
				{
					int num = 0;
					int num2 = 0;
					void* ptr = ((crnd_symbol_codec*)@this)->field_1;
					if (ptr < ((crnd_symbol_codec*)@this)->field_2)
					{
						void* ptr2 = ptr;
						ptr = (byte*)ptr2 + 1;
						num = (byte)(*(sbyte*)ptr2);
					}
					if (ptr < ((crnd_symbol_codec*)@this)->field_2)
					{
						void* ptr3 = ptr;
						ptr = (byte*)ptr3 + 1;
						num2 = (byte)(*(sbyte*)ptr3);
					}
					((crnd_symbol_codec*)@this)->field_1 = ptr;
					int num3;
					checked
					{
						unchecked((crnd_symbol_codec*)@this)->field_5 += 16;
						num3 = ((num << 8) | num2) << 32 - unchecked((crnd_symbol_codec*)@this)->field_5;
					}
					((crnd_symbol_codec*)@this)->field_4 |= num3;
				}
				else
				{
					int num4;
					if (((crnd_symbol_codec*)@this)->field_1 < ((crnd_symbol_codec*)@this)->field_2)
					{
						void** field_2 = &((crnd_symbol_codec*)@this)->field_1;
						void* ptr4 = *field_2;
						*field_2 = (byte*)ptr4 + 1;
						num4 = (byte)(*(sbyte*)ptr4);
					}
					else
					{
						num4 = 0;
					}
					int num5 = num4;
					int num6;
					checked
					{
						unchecked((crnd_symbol_codec*)@this)->field_5 += 8;
						num6 = num5 << 32 - unchecked((crnd_symbol_codec*)@this)->field_5;
					}
					((crnd_symbol_codec*)@this)->field_4 |= num6;
				}
			}
			int num7 = (((crnd_symbol_codec*)@this)->field_4 >>> 16) + 1;
			int num9;
			int i;
			if ((uint)num7 <= (uint)((crnd_prefix_coding_decoder_tables*)field_)->field_4)
			{
				int num8 = ((int*)((crnd_prefix_coding_decoder_tables*)field_)->field_11)[(uint)(((crnd_symbol_codec*)@this)->field_4 >>> 32 - ((crnd_prefix_coding_decoder_tables*)field_)->field_2)];
				if (num8 == -1)
				{
					crnd_assert.Invoke(String_fwybtzb.__pointer, String_yguirrd.__pointer, 2691);
				}
				num9 = num8 & 0xFFFF;
				i = num8 >>> 16;
				if ((byte)(*(sbyte*)vector_unsigned_char_Index_3lowkad.Invoke(&((crnd_static_huffman_data_model*)model)->field_1, num9)) != i)
				{
					crnd_assert.Invoke(String_e4i4x9a.__pointer, String_yguirrd.__pointer, 2695);
				}
			}
			else
			{
				for (i = ((crnd_prefix_coding_decoder_tables*)field_)->field_5; (uint)num7 > (uint)((int*)(&((crnd_prefix_coding_decoder_tables*)field_)->field_8))[(uint)(i - 1)]; i++)
				{
				}
				int num10 = ((int*)(&((crnd_prefix_coding_decoder_tables*)field_)->field_9))[(uint)(i - 1)] + (((crnd_symbol_codec*)@this)->field_4 >>> 32 - i);
				if ((uint)num10 >= (uint)((crnd_static_huffman_data_model*)model)->field_0)
				{
					crnd_assert.Invoke(String_xzkwrkb.__pointer, String_yguirrd.__pointer, 2709);
					return 0;
				}
				num9 = (ushort)((short*)((crnd_prefix_coding_decoder_tables*)field_)->field_13)[num10];
			}
			((crnd_symbol_codec*)@this)->field_4 <<= i;
			((crnd_symbol_codec*)@this)->field_5 -= i;
			return num9;
		}
	}
}
