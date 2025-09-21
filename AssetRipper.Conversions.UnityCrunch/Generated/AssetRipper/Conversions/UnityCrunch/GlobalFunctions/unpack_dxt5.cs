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
		unchecked
		{
			int num = size_7uifdkc.Invoke(&((crnd_crn_unpacker*)@this)->field_8);
			int num2 = size_lxodu4b.Invoke(&((crnd_crn_unpacker*)@this)->field_10);
			int num3 = (output_width + 1) & -2;
			int num4 = (output_height + 1) & -2;
			int num5 = (row_pitch_in_bytes >>> 2) - (num3 << 2);
			if ((uint)size_jm5h2sb.Invoke(&((crnd_crn_unpacker*)@this)->field_12) < (uint)num3)
			{
				resize_kfwzjla.Invoke(&((crnd_crn_unpacker*)@this)->field_12, num3);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
			}
			int num6 = 0;
			int num7 = 0;
			sbyte b = 0;
			for (int i = 0; (uint)i < (uint)crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_8); i++)
			{
				void* ptr = ((void**)pDst)[(uint)i];
				int num8 = 0;
				while ((uint)num8 < (uint)num4)
				{
					sbyte b2 = (((uint)num8 < (uint)output_height) ? ((sbyte)1) : ((sbyte)0));
					int num9 = 0;
					while ((uint)num9 < (uint)num3)
					{
						b2 = (((b2 & 1) == 1 && (uint)num9 < (uint)output_width) ? ((sbyte)1) : ((sbyte)0));
						if ((num8 & 1) == 0 && (num9 & 1) == 0)
						{
							b = (sbyte)decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_5);
						}
						void* ptr2 = vector_struct_crnd_crn_unpacker_block_buffer_element_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_12, num9);
						sbyte b3;
						if ((num8 & 1) != 0)
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
							num6 += decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_6);
							if ((uint)num6 >= (uint)num)
							{
								num6 -= num;
							}
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_1 = (short)num6;
							num7 += decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&((crnd_crn_unpacker*)@this)->field_6) + sizeof(crnd_static_huffman_data_model));
							if ((uint)num7 >= (uint)num2)
							{
								num7 -= num2;
							}
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_2 = (short)num7;
						}
						else if ((byte)b3 == 1)
						{
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_1 = (short)num6;
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_2 = (short)num7;
						}
						else
						{
							num6 = (ushort)((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_1;
							num7 = (ushort)((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_2;
						}
						int i2 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_7);
						int num10 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&((crnd_crn_unpacker*)@this)->field_7) + sizeof(crnd_static_huffman_data_model));
						if ((b2 & 1) == 1)
						{
							void* ptr3 = vector_unsigned_short_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_11, num10 * 3);
							*(int*)ptr = (ushort)(*(short*)vector_unsigned_short_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_10, num7)) | ((ushort)(*(short*)ptr3) << 16);
							((int*)ptr)[1] = (ushort)((short*)ptr3)[1] | ((ushort)((short*)ptr3)[2] << 16);
							((int*)ptr)[2] = *(int*)vector_unsigned_int_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_8, num6);
							((int*)ptr)[3] = *(int*)vector_unsigned_int_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_9, i2);
						}
						num9++;
						ptr = (byte*)ptr + 16;
					}
					num8++;
					ptr = (byte*)ptr + (nint)num5 * (nint)4;
				}
			}
			return true;
		}
	}
}
