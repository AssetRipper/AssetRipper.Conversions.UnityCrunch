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
		localsPointer->field_0 = default(InlineArray4_SByte);
		localsPointer->field_1 = default(InlineArray4_SByte);
		localsPointer->field_2 = default(InlineArray4_SByte);
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		unchecked
		{
			int num11 = size_7uifdkc.Invoke(&((crnd_crn_unpacker*)@this)->field_8);
			int num12 = (output_width + 1) & -2;
			int num13 = (output_height + 1) & -2;
			int num14 = (output_pitch_in_bytes >>> 2) - (num12 << 1);
			if ((uint)size_jm5h2sb.Invoke(&((crnd_crn_unpacker*)@this)->field_12) < (uint)(num12 << 1))
			{
				resize_kfwzjla.Invoke(&((crnd_crn_unpacker*)@this)->field_12, num12 << 1);
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
				while ((uint)num4 < (uint)num13)
				{
					b2 = (((uint)num4 < (uint)output_height) ? ((sbyte)1) : ((sbyte)0));
					num5 = 0;
					while ((uint)num5 < (uint)num12)
					{
						b2 = (((b2 & 1) == 1 && (uint)num5 < (uint)output_width) ? ((sbyte)1) : ((sbyte)0));
						ptr2 = vector_struct_crnd_crn_unpacker_block_buffer_element_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_12, num5 << 1);
						if ((num4 & 1) != 0)
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
							if ((uint)num >= (uint)num11)
							{
								num -= num11;
							}
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_1 = (short)num;
						}
						else if (((byte)b3 & 3) == 1)
						{
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_1 = (short)num;
						}
						else if (((byte)b3 & 3) == 3)
						{
							int num15 = num2;
							num = num15;
							((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_1 = (short)num15;
						}
						else
						{
							num = (ushort)((crnd_crn_unpacker_block_buffer_element*)ptr2)->field_1;
						}
						b3 = (sbyte)((byte)b3 >> 2);
						int num16 = *(int*)vector_unsigned_int_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_8, num);
						*(int*)(&localsPointer->field_1) = num16;
						num6 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_7);
						if (b3 != 0)
						{
							num += decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_6);
							if ((uint)num >= (uint)num11)
							{
								num -= num11;
							}
						}
						num2 = (ushort)((crnd_crn_unpacker_block_buffer_element*)vector_struct_crnd_crn_unpacker_block_buffer_element_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_12, (num5 << 1) | 1))->field_1;
						((crnd_crn_unpacker_block_buffer_element*)vector_struct_crnd_crn_unpacker_block_buffer_element_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_12, (num5 << 1) | 1))->field_1 = (short)num;
						int num17 = *(int*)vector_unsigned_int_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_8, num);
						*(int*)(&localsPointer->field_2) = num17;
						if ((b2 & 1) == 1)
						{
							num7 = ((byte)b3 >> 1) ^ 1;
							num8 = 1;
							num9 = 0;
							while (num8 != 0 && (uint)num9 < 3u)
							{
								checked
								{
									num8 = ((unchecked((byte)((sbyte*)(&localsPointer->field_1))[(uint)num9]) + 3 >= unchecked((byte)((sbyte*)(&localsPointer->field_2))[(uint)num9]) && unchecked((byte)((sbyte*)(&localsPointer->field_2))[(uint)num9]) + 4 >= unchecked((byte)((sbyte*)(&localsPointer->field_1))[(uint)num9])) ? num8 : 0);
								}
								num9++;
							}
							for (num10 = 0; (uint)num10 < 3u; num10++)
							{
								int num18 = ((num8 == 0) ? ((((byte)((sbyte*)(&localsPointer->field_1))[(uint)num10] << 3) & 0xF0) | ((byte)((sbyte*)(&localsPointer->field_2))[(uint)num10] >> 1)) : (((byte)((sbyte*)(&localsPointer->field_1))[(uint)num10] << 3) | (checked(unchecked((byte)((sbyte*)(&localsPointer->field_2))[(uint)num10]) - unchecked((byte)((sbyte*)(&localsPointer->field_1))[(uint)num10])) & 7)));
								((sbyte*)(&localsPointer->field_0))[(uint)num10] = (sbyte)num18;
							}
							sbyte b4 = (sbyte)(((byte)((sbyte*)(&localsPointer->field_1))[3] << 5) | ((byte)((sbyte*)(&localsPointer->field_2))[3] << 2) | (num8 << 1) | num7);
							((sbyte*)(&localsPointer->field_0))[3] = b4;
							*(int*)ptr = *(int*)(&localsPointer->field_0);
							((int*)ptr)[1] = *(int*)vector_unsigned_int_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_9, (num6 << 1) | num7);
						}
						num5++;
						ptr = (byte*)ptr + 8;
					}
					num4++;
					ptr = (byte*)ptr + (nint)num14 * (nint)4;
				}
			}
			StackFrameList.Current.Clear(startFrame);
			return true;
		}
	}
}
