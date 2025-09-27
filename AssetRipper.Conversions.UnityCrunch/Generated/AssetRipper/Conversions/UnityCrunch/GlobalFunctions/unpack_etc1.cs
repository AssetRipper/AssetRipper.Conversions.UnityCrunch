using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?unpack_etc1@crn_unpacker@crnd@@AEAA_NPEAPEAEIII@Z")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::unpack_etc1(unsigned char **, unsigned int, unsigned int, unsigned int)")]
internal static partial class unpack_etc1
{
	private partial struct LocalVariables
	{
		public InlineArray4_SByte field_0;

		public InlineArray4_SByte field_1;

		public InlineArray4_SByte field_2;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned char **")] void* pDst, [NativeType("unsigned int")] int output_pitch_in_bytes, [NativeType("unsigned int")] int output_width, [NativeType("unsigned int")] int output_height)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(InlineArray4_SByte);
		localsPointer->field_1 = default(InlineArray4_SByte);
		localsPointer->field_2 = default(InlineArray4_SByte);
		unchecked
		{
			int num = size_7uifdkc.Invoke(&((crnd_crn_unpacker*)@this)->m_color_endpoints);
			int num2 = (output_width + 1) & -2;
			int num3 = (output_height + 1) & -2;
			int num4 = (output_pitch_in_bytes >>> 2) - (num2 << 1);
			if ((uint)size_jm5h2sb.Invoke(&((crnd_crn_unpacker*)@this)->m_block_buffer) < (uint)(num2 << 1))
			{
				resize_kfwzjla.Invoke(&((crnd_crn_unpacker*)@this)->m_block_buffer, num2 << 1);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
			}
			int num5 = 0;
			int num6 = 0;
			for (int i = 0; (uint)i < (uint)crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_faces); i++)
			{
				void* ptr = ((void**)pDst)[(uint)i];
				int num7 = 0;
				while ((uint)num7 < (uint)num3)
				{
					sbyte b = (((uint)num7 < (uint)output_height) ? ((sbyte)1) : ((sbyte)0));
					int num8 = 0;
					while ((uint)num8 < (uint)num2)
					{
						b = (((b & 1) == 1 && (uint)num8 < (uint)output_width) ? ((sbyte)1) : ((sbyte)0));
						void* ptr2 = vector_struct_crnd_crn_unpacker_block_buffer_element_Index.Invoke(&((crnd_crn_unpacker*)@this)->m_block_buffer, num8 << 1);
						sbyte b2;
						if ((num7 & 1) != 0)
						{
							b2 = (sbyte)((crnd_crn_unpacker_block_buffer_element*)ptr2)->endpoint_reference;
						}
						else
						{
							sbyte b3 = (sbyte)decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &((crnd_crn_unpacker*)@this)->m_reference_encoding_dm);
							b2 = (sbyte)(((byte)b3 & 3) | (((byte)b3 >> 2) & 0xC));
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->endpoint_reference = (short)((((byte)b3 >> 2) & 3) | (((byte)b3 >> 4) & 0xC));
						}
						if (((byte)b2 & 3) == 0)
						{
							num5 += decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &((crnd_crn_unpacker*)@this)->m_endpoint_delta_dm);
							if ((uint)num5 >= (uint)num)
							{
								num5 -= num;
							}
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->color_endpoint_index = (short)num5;
						}
						else if (((byte)b2 & 3) == 1)
						{
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->color_endpoint_index = (short)num5;
						}
						else if (((byte)b2 & 3) == 3)
						{
							int num9 = num6;
							num5 = num9;
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->color_endpoint_index = (short)num9;
						}
						else
						{
							num5 = (ushort)((crnd_crn_unpacker_block_buffer_element*)ptr2)->color_endpoint_index;
						}
						b2 = (sbyte)((byte)b2 >> 2);
						int num10 = *(int*)vector_unsigned_int_Index.Invoke(&((crnd_crn_unpacker*)@this)->m_color_endpoints, num5);
						*(int*)(&localsPointer->field_1) = num10;
						int num11 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &((crnd_crn_unpacker*)@this)->m_selector_delta_dm);
						if (b2 != 0)
						{
							num5 += decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &((crnd_crn_unpacker*)@this)->m_endpoint_delta_dm);
							if ((uint)num5 >= (uint)num)
							{
								num5 -= num;
							}
						}
						num6 = (ushort)((crnd_crn_unpacker_block_buffer_element*)vector_struct_crnd_crn_unpacker_block_buffer_element_Index.Invoke(&((crnd_crn_unpacker*)@this)->m_block_buffer, (num8 << 1) | 1))->color_endpoint_index;
						((crnd_crn_unpacker_block_buffer_element*)vector_struct_crnd_crn_unpacker_block_buffer_element_Index.Invoke(&((crnd_crn_unpacker*)@this)->m_block_buffer, (num8 << 1) | 1))->color_endpoint_index = (short)num5;
						int num12 = *(int*)vector_unsigned_int_Index.Invoke(&((crnd_crn_unpacker*)@this)->m_color_endpoints, num5);
						*(int*)(&localsPointer->field_2) = num12;
						if ((b & 1) == 1)
						{
							int num13 = ((byte)b2 >> 1) ^ 1;
							int num14 = 1;
							int num15 = 0;
							while (num14 != 0 && (uint)num15 < 3u)
							{
								checked
								{
									num14 = ((unchecked((byte)((sbyte*)(&localsPointer->field_1))[(uint)num15]) + 3 >= unchecked((byte)((sbyte*)(&localsPointer->field_2))[(uint)num15]) && unchecked((byte)((sbyte*)(&localsPointer->field_2))[(uint)num15]) + 4 >= unchecked((byte)((sbyte*)(&localsPointer->field_1))[(uint)num15])) ? num14 : 0);
								}
								num15++;
							}
							for (int j = 0; (uint)j < 3u; j++)
							{
								int num16 = ((num14 == 0) ? ((((byte)((sbyte*)(&localsPointer->field_1))[(uint)j] << 3) & 0xF0) | ((byte)((sbyte*)(&localsPointer->field_2))[(uint)j] >> 1)) : (((byte)((sbyte*)(&localsPointer->field_1))[(uint)j] << 3) | (checked(unchecked((byte)((sbyte*)(&localsPointer->field_2))[(uint)j]) - unchecked((byte)((sbyte*)(&localsPointer->field_1))[(uint)j])) & 7)));
								((sbyte*)(&localsPointer->field_0))[(uint)j] = (sbyte)num16;
							}
							sbyte b4 = (sbyte)(((byte)((sbyte*)(&localsPointer->field_1))[3] << 5) | ((byte)((sbyte*)(&localsPointer->field_2))[3] << 2) | (num14 << 1) | num13);
							((sbyte*)(&localsPointer->field_0))[3] = b4;
							*(int*)ptr = *(int*)(&localsPointer->field_0);
							((int*)ptr)[1] = *(int*)vector_unsigned_int_Index.Invoke(&((crnd_crn_unpacker*)@this)->m_color_selectors, (num11 << 1) | num13);
						}
						num8++;
						ptr = (byte*)ptr + 8;
					}
					num7++;
					ptr = (byte*)ptr + (nint)num4 * (nint)4;
				}
			}
			StackFrameList.Current.Clear(startFrame);
			return true;
		}
	}
}
