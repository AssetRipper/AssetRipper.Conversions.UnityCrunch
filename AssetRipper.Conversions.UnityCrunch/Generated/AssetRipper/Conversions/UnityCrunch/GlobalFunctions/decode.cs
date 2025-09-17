using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?decode@symbol_codec@crnd@@QEAAIAEBVstatic_huffman_data_model@2@@Z")]
[DemangledName("public: unsigned int __cdecl crnd::symbol_codec::decode(class crnd::static_huffman_data_model const &)")]
internal static partial class decode
{
	public unsafe static int Invoke(void* @this, void* model)
	{
		int num = 0;
		void* ptr = null;
		void* ptr2 = null;
		int num2 = 0;
		int num3 = 0;
		void* ptr3 = null;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		ptr = model;
		unchecked
		{
			ptr2 = ((crnd_static_huffman_data_model*)ptr)->field_2;
			if (((crnd_symbol_codec*)@this)->field_5 < 24)
			{
				if (((crnd_symbol_codec*)@this)->field_5 < 16)
				{
					num2 = 0;
					num3 = 0;
					ptr3 = ((crnd_symbol_codec*)@this)->field_1;
					if (ptr3 < ((crnd_symbol_codec*)@this)->field_2)
					{
						void* ptr4 = ptr3;
						ptr3 = (byte*)ptr4 + 1;
						num2 = (byte)(*(sbyte*)ptr4);
					}
					if (ptr3 < ((crnd_symbol_codec*)@this)->field_2)
					{
						void* ptr5 = ptr3;
						ptr3 = (byte*)ptr5 + 1;
						num3 = (byte)(*(sbyte*)ptr5);
					}
					((crnd_symbol_codec*)@this)->field_1 = ptr3;
					int num11;
					checked
					{
						unchecked((crnd_symbol_codec*)@this)->field_5 += 16;
						num11 = ((num2 << 8) | num3) << 32 - unchecked((crnd_symbol_codec*)@this)->field_5;
					}
					((crnd_symbol_codec*)@this)->field_4 |= num11;
				}
				else
				{
					int num12;
					if (((crnd_symbol_codec*)@this)->field_1 < ((crnd_symbol_codec*)@this)->field_2)
					{
						void** field_ = &((crnd_symbol_codec*)@this)->field_1;
						void* ptr6 = *field_;
						*field_ = (byte*)ptr6 + 1;
						num12 = (byte)(*(sbyte*)ptr6);
					}
					else
					{
						num12 = 0;
					}
					num5 = num12;
					int num13;
					checked
					{
						unchecked((crnd_symbol_codec*)@this)->field_5 += 8;
						num13 = num5 << 32 - unchecked((crnd_symbol_codec*)@this)->field_5;
					}
					((crnd_symbol_codec*)@this)->field_4 |= num13;
				}
			}
			num6 = (((crnd_symbol_codec*)@this)->field_4 >>> 16) + 1;
			if ((uint)num6 <= (uint)((crnd_prefix_coding_decoder_tables*)ptr2)->field_4)
			{
				num9 = ((int*)((crnd_prefix_coding_decoder_tables*)ptr2)->field_11)[(uint)(((crnd_symbol_codec*)@this)->field_4 >>> 32 - ((crnd_prefix_coding_decoder_tables*)ptr2)->field_2)];
				int num14;
				if (num9 != -1)
				{
					num14 = -1;
				}
				else
				{
					crnd_assert.Invoke(String_fwybtzb.__pointer, String_yguirrd.__pointer, 2691);
					num14 = 0;
				}
				num7 = num9 & 0xFFFF;
				num8 = num9 >>> 16;
				int num15;
				if ((byte)(*(sbyte*)Index_3lowkad.Invoke(&((crnd_static_huffman_data_model*)ptr)->field_1, num7)) == num8)
				{
					num15 = -1;
				}
				else
				{
					crnd_assert.Invoke(String_e4i4x9a.__pointer, String_yguirrd.__pointer, 2695);
					num15 = 0;
				}
			}
			else
			{
				for (num8 = ((crnd_prefix_coding_decoder_tables*)ptr2)->field_5; (uint)num6 > (uint)((int*)(&((crnd_prefix_coding_decoder_tables*)ptr2)->field_8))[(uint)(num8 - 1)]; num8++)
				{
				}
				num10 = ((int*)(&((crnd_prefix_coding_decoder_tables*)ptr2)->field_9))[(uint)(num8 - 1)] + (((crnd_symbol_codec*)@this)->field_4 >>> 32 - num8);
				if ((uint)num10 >= (uint)((crnd_static_huffman_data_model*)ptr)->field_0)
				{
					crnd_assert.Invoke(String_xzkwrkb.__pointer, String_yguirrd.__pointer, 2709);
					return 0;
				}
				num7 = (ushort)((short*)((crnd_prefix_coding_decoder_tables*)ptr2)->field_13)[num10];
			}
			((crnd_symbol_codec*)@this)->field_4 <<= num8;
			((crnd_symbol_codec*)@this)->field_5 -= num8;
			return num7;
		}
	}
}
