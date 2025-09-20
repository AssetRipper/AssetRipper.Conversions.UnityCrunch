using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?unpack_dxt5@crn_unpacker@crnd@@AEAA_NPEAPEAEIII@Z")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::unpack_dxt5(unsigned char **, unsigned int, unsigned int, unsigned int)")]
internal static partial class unpack_dxt5
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned char **")] void* pDst, [NativeType("unsigned int")] int row_pitch_in_bytes, [NativeType("unsigned int")] int output_width, [NativeType("unsigned int")] int output_height)
	{
		int num = 0;
		int num2 = 0;
		sbyte b = 0;
		int num3 = 0;
		void* ptr = null;
		int num4 = 0;
		sbyte b2 = 0;
		int num5 = 0;
		void* ptr2 = null;
		sbyte b3 = 0;
		int num6 = 0;
		int num7 = 0;
		void* ptr3 = null;
		unchecked
		{
			int num8 = size_7uifdkc.Invoke(&((crnd_crn_unpacker*)@this)->field_8);
			int num9 = size_lxodu4b.Invoke(&((crnd_crn_unpacker*)@this)->field_10);
			int num10 = (output_width + 1) & -2;
			int num11 = (output_height + 1) & -2;
			int num12 = (row_pitch_in_bytes >>> 2) - (num10 << 2);
			if ((uint)size_jm5h2sb.Invoke(&((crnd_crn_unpacker*)@this)->field_12) < (uint)num10)
			{
				resize_kfwzjla.Invoke(&((crnd_crn_unpacker*)@this)->field_12, num10);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
			}
			num = 0;
			num2 = 0;
			b = 0;
			for (num3 = 0; (uint)num3 < (uint)crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_8); num3++)
			{
				ptr = ((void**)pDst)[(uint)num3];
				num4 = 0;
				while ((uint)num4 < (uint)num11)
				{
					b2 = (((uint)num4 < (uint)output_height) ? ((sbyte)1) : ((sbyte)0));
					num5 = 0;
					while ((uint)num5 < (uint)num10)
					{
						b2 = (((b2 & 1) == 1 && (uint)num5 < (uint)output_width) ? ((sbyte)1) : ((sbyte)0));
						if ((num4 & 1) == 0 && (num5 & 1) == 0)
						{
							b = (sbyte)decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_5);
						}
						ptr2 = vector_struct_crnd_crn_unpacker_block_buffer_element_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_12, num5);
						if ((num4 & 1) != 0)
						{
							b3 = (sbyte)((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_0;
						}
						else
						{
							b3 = (sbyte)((byte)b & 3);
							b = (sbyte)((byte)b >> 2);
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_0 = (short)((byte)b & 3);
							b = (sbyte)((byte)b >> 2);
						}
						if (b3 == 0)
						{
							num += decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_6);
							if ((uint)num >= (uint)num8)
							{
								num -= num8;
							}
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_1 = (short)num;
							num2 += decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&((crnd_crn_unpacker*)@this)->field_6) + sizeof(crnd_static_huffman_data_model));
							if ((uint)num2 >= (uint)num9)
							{
								num2 -= num9;
							}
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_2 = (short)num2;
						}
						else if ((byte)b3 == 1)
						{
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_1 = (short)num;
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_2 = (short)num2;
						}
						else
						{
							num = (ushort)((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_1;
							num2 = (ushort)((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_2;
						}
						num6 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_7);
						num7 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&((crnd_crn_unpacker*)@this)->field_7) + sizeof(crnd_static_huffman_data_model));
						if ((b2 & 1) == 1)
						{
							ptr3 = vector_unsigned_short_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_11, num7 * 3);
							*(int*)ptr = (ushort)(*(short*)vector_unsigned_short_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_10, num2)) | ((ushort)(*(short*)ptr3) << 16);
							((int*)ptr)[1] = (ushort)((short*)ptr3)[1] | ((ushort)((short*)ptr3)[2] << 16);
							((int*)ptr)[2] = *(int*)vector_unsigned_int_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_8, num);
							((int*)ptr)[3] = *(int*)vector_unsigned_int_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_9, num6);
						}
						num5++;
						ptr = (byte*)ptr + 16;
					}
					num4++;
					ptr = (byte*)ptr + (nint)num12 * (nint)4;
				}
			}
			return true;
		}
	}
}
