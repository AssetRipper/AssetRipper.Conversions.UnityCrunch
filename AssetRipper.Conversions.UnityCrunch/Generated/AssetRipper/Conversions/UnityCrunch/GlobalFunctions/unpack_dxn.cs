using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?unpack_dxn@crn_unpacker@crnd@@AEAA_NPEAPEAEIII@Z")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::unpack_dxn(unsigned char **, unsigned int, unsigned int, unsigned int)")]
internal static partial class unpack_dxn
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned char **")] void* pDst, [NativeType("unsigned int")] int row_pitch_in_bytes, [NativeType("unsigned int")] int output_width, [NativeType("unsigned int")] int output_height)
	{
		unchecked
		{
			int num = size_lxodu4b.Invoke(&((crnd_crn_unpacker*)@this)->field_10);
			int num2 = (output_width + 1) & -2;
			int num3 = (output_height + 1) & -2;
			int num4 = (row_pitch_in_bytes >>> 2) - (num2 << 2);
			if ((uint)size_jm5h2sb.Invoke(&((crnd_crn_unpacker*)@this)->field_12) < (uint)num2)
			{
				resize_kfwzjla.Invoke(&((crnd_crn_unpacker*)@this)->field_12, num2);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
			}
			int num5 = 0;
			int num6 = 0;
			sbyte b = 0;
			for (int i = 0; (uint)i < (uint)crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_8); i++)
			{
				void* ptr = ((void**)pDst)[(uint)i];
				int num7 = 0;
				while ((uint)num7 < (uint)num3)
				{
					sbyte b2 = (((uint)num7 < (uint)output_height) ? ((sbyte)1) : ((sbyte)0));
					int num8 = 0;
					while ((uint)num8 < (uint)num2)
					{
						b2 = (((b2 & 1) == 1 && (uint)num8 < (uint)output_width) ? ((sbyte)1) : ((sbyte)0));
						if ((num7 & 1) == 0 && (num8 & 1) == 0)
						{
							b = (sbyte)decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_5);
						}
						void* ptr2 = vector_struct_crnd_crn_unpacker_block_buffer_element_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_12, num8);
						sbyte b3;
						if ((num7 & 1) != 0)
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
							num5 += decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&((crnd_crn_unpacker*)@this)->field_6) + sizeof(crnd_static_huffman_data_model));
							if ((uint)num5 >= (uint)num)
							{
								num5 -= num;
							}
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_2 = (short)num5;
							num6 += decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&((crnd_crn_unpacker*)@this)->field_6) + sizeof(crnd_static_huffman_data_model));
							if ((uint)num6 >= (uint)num)
							{
								num6 -= num;
							}
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_3 = (short)num6;
						}
						else if ((byte)b3 == 1)
						{
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_2 = (short)num5;
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_3 = (short)num6;
						}
						else
						{
							num5 = (ushort)((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_2;
							num6 = (ushort)((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_3;
						}
						int num9 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&((crnd_crn_unpacker*)@this)->field_7) + sizeof(crnd_static_huffman_data_model));
						int num10 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&((crnd_crn_unpacker*)@this)->field_7) + sizeof(crnd_static_huffman_data_model));
						if ((b2 & 1) == 1)
						{
							void* ptr3 = vector_unsigned_short_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_11, num9 * 3);
							void* ptr4 = vector_unsigned_short_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_11, num10 * 3);
							*(int*)ptr = (ushort)(*(short*)vector_unsigned_short_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_10, num5)) | ((ushort)(*(short*)ptr3) << 16);
							((int*)ptr)[1] = (ushort)((short*)ptr3)[1] | ((ushort)((short*)ptr3)[2] << 16);
							((int*)ptr)[2] = (ushort)(*(short*)vector_unsigned_short_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_10, num6)) | ((ushort)(*(short*)ptr4) << 16);
							((int*)ptr)[3] = (ushort)((short*)ptr4)[1] | ((ushort)((short*)ptr4)[2] << 16);
						}
						num8++;
						ptr = (byte*)ptr + 16;
					}
					num7++;
					ptr = (byte*)ptr + (nint)num4 * (nint)4;
				}
			}
			return true;
		}
	}
}
