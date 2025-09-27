using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?unpack_dxt1@crn_unpacker@crnd@@AEAA_NPEAPEAEIII@Z")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::unpack_dxt1(unsigned char **, unsigned int, unsigned int, unsigned int)")]
internal static partial class unpack_dxt1
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned char **")] void* pDst, [NativeType("unsigned int")] int output_pitch_in_bytes, [NativeType("unsigned int")] int output_width, [NativeType("unsigned int")] int output_height)
	{
		unchecked
		{
			int num = size_7uifdkc.Invoke(&((crnd_crn_unpacker*)@this)->m_color_endpoints);
			int num2 = (output_width + 1) & -2;
			int num3 = (output_height + 1) & -2;
			int num4 = (output_pitch_in_bytes >>> 2) - (num2 << 1);
			if ((uint)size_jm5h2sb.Invoke(&((crnd_crn_unpacker*)@this)->m_block_buffer) < (uint)num2)
			{
				resize_kfwzjla.Invoke(&((crnd_crn_unpacker*)@this)->m_block_buffer, num2);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
			}
			int num5 = 0;
			sbyte b = 0;
			for (int i = 0; (uint)i < (uint)crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_faces); i++)
			{
				void* ptr = ((void**)pDst)[(uint)i];
				int num6 = 0;
				while ((uint)num6 < (uint)num3)
				{
					sbyte b2 = (((uint)num6 < (uint)output_height) ? ((sbyte)1) : ((sbyte)0));
					int num7 = 0;
					while ((uint)num7 < (uint)num2)
					{
						b2 = (((b2 & 1) == 1 && (uint)num7 < (uint)output_width) ? ((sbyte)1) : ((sbyte)0));
						if ((num6 & 1) == 0 && (num7 & 1) == 0)
						{
							b = (sbyte)decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &((crnd_crn_unpacker*)@this)->m_reference_encoding_dm);
						}
						void* ptr2 = vector_struct_crnd_crn_unpacker_block_buffer_element_Index.Invoke(&((crnd_crn_unpacker*)@this)->m_block_buffer, num7);
						sbyte b3;
						if ((num6 & 1) != 0)
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
							num5 += decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &((crnd_crn_unpacker*)@this)->m_endpoint_delta_dm);
							if ((uint)num5 >= (uint)num)
							{
								num5 -= num;
							}
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->color_endpoint_index = (short)num5;
						}
						else if ((byte)b3 == 1)
						{
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->color_endpoint_index = (short)num5;
						}
						else
						{
							num5 = (ushort)((crnd_crn_unpacker_block_buffer_element*)ptr2)->color_endpoint_index;
						}
						int i2 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &((crnd_crn_unpacker*)@this)->m_selector_delta_dm);
						if ((b2 & 1) == 1)
						{
							*(int*)ptr = *(int*)vector_unsigned_int_Index.Invoke(&((crnd_crn_unpacker*)@this)->m_color_endpoints, num5);
							((int*)ptr)[1] = *(int*)vector_unsigned_int_Index.Invoke(&((crnd_crn_unpacker*)@this)->m_color_selectors, i2);
						}
						num7++;
						ptr = (byte*)ptr + 8;
					}
					num6++;
					ptr = (byte*)ptr + (nint)num4 * (nint)4;
				}
			}
			return true;
		}
	}
}
