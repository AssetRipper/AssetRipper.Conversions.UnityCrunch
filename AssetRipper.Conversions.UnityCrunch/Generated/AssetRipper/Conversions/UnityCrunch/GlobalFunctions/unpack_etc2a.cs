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
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		sbyte b = 0;
		int num5 = 0;
		void* ptr = null;
		int num6 = 0;
		sbyte b2 = 0;
		int num7 = 0;
		void* ptr2 = null;
		sbyte b3 = 0;
		localsPointer->field_0 = default(InlineArray4_SByte);
		localsPointer->field_1 = default(InlineArray4_SByte);
		localsPointer->field_2 = default(InlineArray4_SByte);
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		int num11 = 0;
		int num12 = 0;
		int num13 = 0;
		void* ptr3 = null;
		unchecked
		{
			int num14 = size_7uifdkc.Invoke(&((crnd_crn_unpacker*)@this)->field_8);
			int num15 = size_lxodu4b.Invoke(&((crnd_crn_unpacker*)@this)->field_10);
			int num16 = (output_width + 1) & -2;
			int num17 = (output_height + 1) & -2;
			int num18 = (output_pitch_in_bytes >>> 2) - (num16 << 2);
			if ((uint)size_jm5h2sb.Invoke(&((crnd_crn_unpacker*)@this)->field_12) < (uint)(num16 << 1))
			{
				resize_kfwzjla.Invoke(&((crnd_crn_unpacker*)@this)->field_12, num16 << 1);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
			}
			num = 0;
			num2 = 0;
			num3 = 0;
			num4 = 0;
			b = 0;
			for (num5 = 0; (uint)num5 < (uint)crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_8); num5++)
			{
				ptr = ((void**)pDst)[(uint)num5];
				num6 = 0;
				while ((uint)num6 < (uint)num17)
				{
					b2 = (((uint)num6 < (uint)output_height) ? ((sbyte)1) : ((sbyte)0));
					num7 = 0;
					while ((uint)num7 < (uint)num16)
					{
						b2 = (((b2 & 1) == 1 && (uint)num7 < (uint)output_width) ? ((sbyte)1) : ((sbyte)0));
						ptr2 = vector_struct_crnd_crn_unpacker_block_buffer_element_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_12, num7 << 1);
						if ((num6 & 1) != 0)
						{
							b3 = (sbyte)((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_0;
						}
						else
						{
							b = (sbyte)decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_5);
							b3 = (sbyte)(((byte)b & 3) | (((byte)b >> 2) & 0xC));
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_0 = (short)((((byte)b >> 2) & 3) | (((byte)b >> 4) & 0xC));
						}
						if (((byte)b3 & 3) == 0)
						{
							num += decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_6);
							if ((uint)num >= (uint)num14)
							{
								num -= num14;
							}
							num3 += decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&((crnd_crn_unpacker*)@this)->field_6) + sizeof(crnd_static_huffman_data_model));
							if ((uint)num3 >= (uint)num15)
							{
								num3 -= num15;
							}
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_1 = (short)num;
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_2 = (short)num3;
						}
						else if (((byte)b3 & 3) == 1)
						{
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_1 = (short)num;
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_2 = (short)num3;
						}
						else if (((byte)b3 & 3) == 3)
						{
							int num19 = num2;
							num = num19;
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_1 = (short)num19;
							int num20 = num4;
							num3 = num20;
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_2 = (short)num20;
						}
						else
						{
							num = (ushort)((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_1;
							num3 = (ushort)((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_2;
						}
						b3 = (sbyte)((byte)b3 >> 2);
						int num21 = *(int*)vector_unsigned_int_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_8, num);
						*(int*)(&localsPointer->field_1) = num21;
						num8 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_7);
						num9 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&((crnd_crn_unpacker*)@this)->field_7) + sizeof(crnd_static_huffman_data_model));
						if (b3 != 0)
						{
							num += decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_6);
							if ((uint)num >= (uint)num14)
							{
								num -= num14;
							}
						}
						int num22 = *(int*)vector_unsigned_int_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_8, num);
						*(int*)(&localsPointer->field_2) = num22;
						num2 = (ushort)((crnd_crn_unpacker_block_buffer_element*)vector_struct_crnd_crn_unpacker_block_buffer_element_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_12, (num7 << 1) | 1))->field_1;
						num4 = (ushort)((crnd_crn_unpacker_block_buffer_element*)vector_struct_crnd_crn_unpacker_block_buffer_element_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_12, (num7 << 1) | 1))->field_2;
						((crnd_crn_unpacker_block_buffer_element*)vector_struct_crnd_crn_unpacker_block_buffer_element_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_12, (num7 << 1) | 1))->field_1 = (short)num;
						((crnd_crn_unpacker_block_buffer_element*)vector_struct_crnd_crn_unpacker_block_buffer_element_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_12, (num7 << 1) | 1))->field_2 = (short)num3;
						if ((b2 & 1) == 1)
						{
							num10 = ((byte)b3 >> 1) ^ 1;
							num11 = 1;
							num12 = 0;
							while (num11 != 0 && (uint)num12 < 3u)
							{
								checked
								{
									num11 = ((unchecked((byte)((sbyte*)(&localsPointer->field_1))[(uint)num12]) + 3 >= unchecked((byte)((sbyte*)(&localsPointer->field_2))[(uint)num12]) && unchecked((byte)((sbyte*)(&localsPointer->field_2))[(uint)num12]) + 4 >= unchecked((byte)((sbyte*)(&localsPointer->field_1))[(uint)num12])) ? num11 : 0);
								}
								num12++;
							}
							for (num13 = 0; (uint)num13 < 3u; num13++)
							{
								int num23 = ((num11 == 0) ? ((((byte)((sbyte*)(&localsPointer->field_1))[(uint)num13] << 3) & 0xF0) | ((byte)((sbyte*)(&localsPointer->field_2))[(uint)num13] >> 1)) : (((byte)((sbyte*)(&localsPointer->field_1))[(uint)num13] << 3) | (checked(unchecked((byte)((sbyte*)(&localsPointer->field_2))[(uint)num13]) - unchecked((byte)((sbyte*)(&localsPointer->field_1))[(uint)num13])) & 7)));
								((sbyte*)(&localsPointer->field_0))[(uint)num13] = (sbyte)num23;
							}
							sbyte b4 = (sbyte)(((byte)((sbyte*)(&localsPointer->field_1))[3] << 5) | ((byte)((sbyte*)(&localsPointer->field_2))[3] << 2) | (num11 << 1) | num10);
							((sbyte*)(&localsPointer->field_0))[3] = b4;
							crnd_vector_rf9iywd* field_ = &((crnd_crn_unpacker*)@this)->field_11;
							int num24 = num9 * 6;
							bool flag = num10 != 0;
							_ = flag;
							ptr3 = vector_unsigned_short_Index.Invoke(field_, num24 + InstructionHelper.Select(flag, 3, 0));
							*(int*)ptr = (ushort)(*(short*)vector_unsigned_short_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_10, num3)) | ((ushort)(*(short*)ptr3) << 16);
							((int*)ptr)[1] = (ushort)((short*)ptr3)[1] | ((ushort)((short*)ptr3)[2] << 16);
							((int*)ptr)[2] = *(int*)(&localsPointer->field_0);
							((int*)ptr)[3] = *(int*)vector_unsigned_int_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_9, (num8 << 1) | num10);
						}
						num7++;
						ptr = (byte*)ptr + 16;
					}
					num6++;
					ptr = (byte*)ptr + (nint)num18 * (nint)4;
				}
			}
			StackFrameList.Current.Clear(startFrame);
			return true;
		}
	}
}
