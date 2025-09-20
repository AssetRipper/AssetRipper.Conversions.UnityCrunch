using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?decode_alpha_selectors@crn_unpacker@crnd@@AEAA_NXZ")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::decode_alpha_selectors(void)")]
internal static partial class decode_alpha_selectors
{
	private partial struct LocalVariables
	{
		public crnd_static_huffman_data_model field_0;

		public InlineArray64_SByte field_1;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(crnd_static_huffman_data_model);
		localsPointer->field_1 = default(InlineArray64_SByte);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		unchecked
		{
			start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4, buf_size: crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_17.field_1), pBuf: (byte*)((crnd_crn_unpacker*)@this)->field_1 + (uint)crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_17.field_0));
			static_huffman_data_model_Constructor_tl33idc.Invoke(&localsPointer->field_0);
			decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &localsPointer->field_0);
			if (ExceptionInfo.Current == null)
			{
				crnd_vector_rf9iywd* field_ = &((crnd_crn_unpacker*)@this)->field_11;
				int num9 = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_17.field_2);
				if (ExceptionInfo.Current == null)
				{
					resize_w95s75a.Invoke(field_, num9 * 3);
					if (ExceptionInfo.Current == null)
					{
						for (num = 0; (uint)num < 64u; num++)
						{
							sbyte b = (sbyte)((byte)((sbyte*)g_dxt5_from_linear.__pointer)[(uint)(num & 7)] | ((byte)((sbyte*)g_dxt5_from_linear.__pointer)[(uint)(num >>> 3)] << 3));
							((sbyte*)(&localsPointer->field_1))[(uint)num] = b;
						}
						num2 = 0;
						num3 = 0;
						num4 = 0;
						while (true)
						{
							if ((uint)num4 < (uint)size_lxodu4b.Invoke(&((crnd_crn_unpacker*)@this)->field_11))
							{
								num5 = 0;
								num6 = 0;
								for (num7 = 0; (uint)num7 < 24u; num7 += 6)
								{
									int num10 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &localsPointer->field_0);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0160;
									}
									num2 ^= num10 << num7;
									num5 |= (byte)((sbyte*)(&localsPointer->field_1))[(uint)((num2 >>> num7) & 0x3F)] << num7;
								}
								for (num8 = 0; (uint)num8 < 24u; num8 += 6)
								{
									int num11 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &localsPointer->field_0);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0160;
									}
									num3 ^= num11 << num8;
									num6 |= (byte)((sbyte*)(&localsPointer->field_1))[(uint)((num3 >>> num8) & 0x3F)] << num8;
								}
								short num12 = (short)num5;
								void* ptr = vector_unsigned_short_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_11, num4++);
								if (ExceptionInfo.Current != null)
								{
									break;
								}
								*(short*)ptr = num12;
								short num13 = (short)((num5 >>> 16) | (num6 << 8));
								void* ptr2 = vector_unsigned_short_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_11, num4++);
								if (ExceptionInfo.Current != null)
								{
									break;
								}
								*(short*)ptr2 = num13;
								short num14 = (short)(num6 >>> 8);
								void* ptr3 = vector_unsigned_short_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_11, num4++);
								if (ExceptionInfo.Current != null)
								{
									break;
								}
								*(short*)ptr3 = num14;
								continue;
							}
							stop_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4);
							static_huffman_data_model_Destructor.Invoke(&localsPointer->field_0);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							StackFrameList.Current.Clear(startFrame);
							return true;
							continue;
							end_IL_0160:
							break;
						}
					}
				}
			}
			ExceptionInfo current = ExceptionInfo.Current;
			ExceptionInfo.Current = null;
			static_huffman_data_model_Destructor.Invoke(&localsPointer->field_0);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			ExceptionInfo.Current = current;
			return false;
		}
	}
}
