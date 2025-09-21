using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?unpack_etc2a@crn_unpacker@crnd@@AEAA_NPEAPEAEIII@Z")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::unpack_etc2a(unsigned char **, unsigned int, unsigned int, unsigned int)")]
internal static partial class unpack_etc2a
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
			int num = size_7uifdkc.Invoke(&((crnd_crn_unpacker*)@this)->field_8);
			int num2 = size_lxodu4b.Invoke(&((crnd_crn_unpacker*)@this)->field_10);
			int num3 = (output_width + 1) & -2;
			int num4 = (output_height + 1) & -2;
			int num5 = (output_pitch_in_bytes >>> 2) - (num3 << 2);
			if ((uint)size_jm5h2sb.Invoke(&((crnd_crn_unpacker*)@this)->field_12) < (uint)(num3 << 1))
			{
				resize_kfwzjla.Invoke(&((crnd_crn_unpacker*)@this)->field_12, num3 << 1);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
			}
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			int num9 = 0;
			for (int i = 0; (uint)i < (uint)crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_8); i++)
			{
				void* ptr = ((void**)pDst)[(uint)i];
				int num10 = 0;
				while ((uint)num10 < (uint)num4)
				{
					sbyte b = (((uint)num10 < (uint)output_height) ? ((sbyte)1) : ((sbyte)0));
					int num11 = 0;
					while ((uint)num11 < (uint)num3)
					{
						b = (((b & 1) == 1 && (uint)num11 < (uint)output_width) ? ((sbyte)1) : ((sbyte)0));
						void* ptr2 = vector_struct_crnd_crn_unpacker_block_buffer_element_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_12, num11 << 1);
						sbyte b2;
						if ((num10 & 1) != 0)
						{
							b2 = (sbyte)((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_0;
						}
						else
						{
							sbyte b3 = (sbyte)decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_5);
							b2 = (sbyte)(((byte)b3 & 3) | (((byte)b3 >> 2) & 0xC));
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_0 = (short)((((byte)b3 >> 2) & 3) | (((byte)b3 >> 4) & 0xC));
						}
						if (((byte)b2 & 3) == 0)
						{
							num6 += decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_6);
							if ((uint)num6 >= (uint)num)
							{
								num6 -= num;
							}
							num8 += decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&((crnd_crn_unpacker*)@this)->field_6) + sizeof(crnd_static_huffman_data_model));
							if ((uint)num8 >= (uint)num2)
							{
								num8 -= num2;
							}
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_1 = (short)num6;
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_2 = (short)num8;
						}
						else if (((byte)b2 & 3) == 1)
						{
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_1 = (short)num6;
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_2 = (short)num8;
						}
						else if (((byte)b2 & 3) == 3)
						{
							int num12 = num7;
							num6 = num12;
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_1 = (short)num12;
							int num13 = num9;
							num8 = num13;
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_2 = (short)num13;
						}
						else
						{
							num6 = (ushort)((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_1;
							num8 = (ushort)((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_2;
						}
						b2 = (sbyte)((byte)b2 >> 2);
						int num14 = *(int*)vector_unsigned_int_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_8, num6);
						*(int*)(&localsPointer->field_1) = num14;
						int num15 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_7);
						int num16 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&((crnd_crn_unpacker*)@this)->field_7) + sizeof(crnd_static_huffman_data_model));
						if (b2 != 0)
						{
							num6 += decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_6);
							if ((uint)num6 >= (uint)num)
							{
								num6 -= num;
							}
						}
						int num17 = *(int*)vector_unsigned_int_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_8, num6);
						*(int*)(&localsPointer->field_2) = num17;
						num7 = (ushort)((crnd_crn_unpacker_block_buffer_element*)vector_struct_crnd_crn_unpacker_block_buffer_element_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_12, (num11 << 1) | 1))->field_1;
						num9 = (ushort)((crnd_crn_unpacker_block_buffer_element*)vector_struct_crnd_crn_unpacker_block_buffer_element_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_12, (num11 << 1) | 1))->field_2;
						((crnd_crn_unpacker_block_buffer_element*)vector_struct_crnd_crn_unpacker_block_buffer_element_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_12, (num11 << 1) | 1))->field_1 = (short)num6;
						((crnd_crn_unpacker_block_buffer_element*)vector_struct_crnd_crn_unpacker_block_buffer_element_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_12, (num11 << 1) | 1))->field_2 = (short)num8;
						if ((b & 1) == 1)
						{
							int num18 = ((byte)b2 >> 1) ^ 1;
							int num19 = 1;
							int num20 = 0;
							while (num19 != 0 && (uint)num20 < 3u)
							{
								checked
								{
									num19 = ((unchecked((byte)((sbyte*)(&localsPointer->field_1))[(uint)num20]) + 3 >= unchecked((byte)((sbyte*)(&localsPointer->field_2))[(uint)num20]) && unchecked((byte)((sbyte*)(&localsPointer->field_2))[(uint)num20]) + 4 >= unchecked((byte)((sbyte*)(&localsPointer->field_1))[(uint)num20])) ? num19 : 0);
								}
								num20++;
							}
							for (int j = 0; (uint)j < 3u; j++)
							{
								int num21 = ((num19 == 0) ? ((((byte)((sbyte*)(&localsPointer->field_1))[(uint)j] << 3) & 0xF0) | ((byte)((sbyte*)(&localsPointer->field_2))[(uint)j] >> 1)) : (((byte)((sbyte*)(&localsPointer->field_1))[(uint)j] << 3) | (checked(unchecked((byte)((sbyte*)(&localsPointer->field_2))[(uint)j]) - unchecked((byte)((sbyte*)(&localsPointer->field_1))[(uint)j])) & 7)));
								((sbyte*)(&localsPointer->field_0))[(uint)j] = (sbyte)num21;
							}
							sbyte b4 = (sbyte)(((byte)((sbyte*)(&localsPointer->field_1))[3] << 5) | ((byte)((sbyte*)(&localsPointer->field_2))[3] << 2) | (num19 << 1) | num18);
							((sbyte*)(&localsPointer->field_0))[3] = b4;
							void* ptr3 = vector_unsigned_short_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_11, num16 * 6 + InstructionHelper.Select(num18 != 0, 3, 0));
							*(int*)ptr = (ushort)(*(short*)vector_unsigned_short_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_10, num8)) | ((ushort)(*(short*)ptr3) << 16);
							((int*)ptr)[1] = (ushort)((short*)ptr3)[1] | ((ushort)((short*)ptr3)[2] << 16);
							((int*)ptr)[2] = *(int*)(&localsPointer->field_0);
							((int*)ptr)[3] = *(int*)vector_unsigned_int_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_9, (num15 << 1) | num18);
						}
						num11++;
						ptr = (byte*)ptr + 16;
					}
					num10++;
					ptr = (byte*)ptr + (nint)num5 * (nint)4;
				}
			}
			StackFrameList.Current.Clear(startFrame);
			return true;
		}
	}
}
