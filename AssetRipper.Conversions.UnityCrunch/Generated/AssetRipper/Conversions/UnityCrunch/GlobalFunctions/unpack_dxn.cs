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
			int num = size_g72hpe.Invoke(&((crnd_crn_unpacker*)@this)->m_alpha_endpoints);
			int num2 = (output_width + 1) & -2;
			int num3 = (output_height + 1) & -2;
			int num4 = (row_pitch_in_bytes >>> 2) - (num2 << 2);
			if ((uint)size_yykac7.Invoke(&((crnd_crn_unpacker*)@this)->m_block_buffer) < (uint)num2)
			{
				resize_2tt9kz.Invoke(&((crnd_crn_unpacker*)@this)->m_block_buffer, num2);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
			}
			int num5 = 0;
			int num6 = 0;
			sbyte b = 0;
			for (int i = 0; (uint)i < (uint)crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_faces); i++)
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
							b = (sbyte)decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &((crnd_crn_unpacker*)@this)->m_reference_encoding_dm);
						}
						void* ptr2 = vector_struct_crnd_crn_unpacker_block_buffer_element_Operator.Invoke(&((crnd_crn_unpacker*)@this)->m_block_buffer, num8);
						sbyte b3;
						if ((num7 & 1) != 0)
						{
							b3 = (sbyte)((crnd_crn_unpacker_block_buffer_element*)ptr2)->endpoint_reference;
						}
						else
						{
							b3 = (sbyte)((byte)b & 3);
							b = (sbyte)((byte)b >> 2);
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->endpoint_reference = (short)((byte)b & 3);
							b = (sbyte)((byte)b >> 2);
						}
						if (b3 == 0)
						{
							num5 += decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, (byte*)(&((crnd_crn_unpacker*)@this)->m_endpoint_delta_dm) + sizeof(crnd_static_huffman_data_model));
							if ((uint)num5 >= (uint)num)
							{
								num5 -= num;
							}
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->alpha0_endpoint_index = (short)num5;
							num6 += decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, (byte*)(&((crnd_crn_unpacker*)@this)->m_endpoint_delta_dm) + sizeof(crnd_static_huffman_data_model));
							if ((uint)num6 >= (uint)num)
							{
								num6 -= num;
							}
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->alpha1_endpoint_index = (short)num6;
						}
						else if ((byte)b3 == 1)
						{
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->alpha0_endpoint_index = (short)num5;
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->alpha1_endpoint_index = (short)num6;
						}
						else
						{
							num5 = (ushort)((crnd_crn_unpacker_block_buffer_element*)ptr2)->alpha0_endpoint_index;
							num6 = (ushort)((crnd_crn_unpacker_block_buffer_element*)ptr2)->alpha1_endpoint_index;
						}
						int num9 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, (byte*)(&((crnd_crn_unpacker*)@this)->m_selector_delta_dm) + sizeof(crnd_static_huffman_data_model));
						int num10 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, (byte*)(&((crnd_crn_unpacker*)@this)->m_selector_delta_dm) + sizeof(crnd_static_huffman_data_model));
						if ((b2 & 1) == 1)
						{
							void* ptr3 = vector_unsigned_short_Operator.Invoke(&((crnd_crn_unpacker*)@this)->m_alpha_selectors, num9 * 3);
							void* ptr4 = vector_unsigned_short_Operator.Invoke(&((crnd_crn_unpacker*)@this)->m_alpha_selectors, num10 * 3);
							*(int*)ptr = (ushort)(*(short*)vector_unsigned_short_Operator.Invoke(&((crnd_crn_unpacker*)@this)->m_alpha_endpoints, num5)) | ((ushort)(*(short*)ptr3) << 16);
							((int*)ptr)[1] = (ushort)((short*)ptr3)[1] | ((ushort)((short*)ptr3)[2] << 16);
							((int*)ptr)[2] = (ushort)(*(short*)vector_unsigned_short_Operator.Invoke(&((crnd_crn_unpacker*)@this)->m_alpha_endpoints, num6)) | ((ushort)(*(short*)ptr4) << 16);
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
