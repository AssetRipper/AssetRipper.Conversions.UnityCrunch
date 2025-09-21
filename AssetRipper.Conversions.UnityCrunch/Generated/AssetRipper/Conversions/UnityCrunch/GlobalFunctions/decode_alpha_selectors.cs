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
		unchecked
		{
			start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4, buf_size: crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_17.field_1), pBuf: (byte*)((crnd_crn_unpacker*)@this)->field_1 + (uint)crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_17.field_0));
			static_huffman_data_model_Constructor_tl33idc.Invoke(&localsPointer->field_0);
			decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &localsPointer->field_0);
			if (ExceptionInfo.Current == null)
			{
				crnd_vector_rf9iywd* field_ = &((crnd_crn_unpacker*)@this)->field_11;
				int num = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_17.field_2);
				if (ExceptionInfo.Current == null)
				{
					resize_w95s75a.Invoke(field_, num * 3);
					if (ExceptionInfo.Current == null)
					{
						for (int i = 0; (uint)i < 64u; i++)
						{
							sbyte b = (sbyte)((byte)((sbyte*)g_dxt5_from_linear.__pointer)[(uint)(i & 7)] | ((byte)((sbyte*)g_dxt5_from_linear.__pointer)[(uint)(i >>> 3)] << 3));
							((sbyte*)(&localsPointer->field_1))[(uint)i] = b;
						}
						int num2 = 0;
						int num3 = 0;
						int num4 = 0;
						while (true)
						{
							if ((uint)num4 < (uint)size_lxodu4b.Invoke(&((crnd_crn_unpacker*)@this)->field_11))
							{
								int num5 = 0;
								int num6 = 0;
								for (int j = 0; (uint)j < 24u; j += 6)
								{
									int num7 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &localsPointer->field_0);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0160;
									}
									num2 ^= num7 << j;
									num5 |= (byte)((sbyte*)(&localsPointer->field_1))[(uint)((num2 >>> j) & 0x3F)] << j;
								}
								for (int k = 0; (uint)k < 24u; k += 6)
								{
									int num8 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &localsPointer->field_0);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0160;
									}
									num3 ^= num8 << k;
									num6 |= (byte)((sbyte*)(&localsPointer->field_1))[(uint)((num3 >>> k) & 0x3F)] << k;
								}
								short num9 = (short)num5;
								void* ptr = vector_unsigned_short_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_11, num4++);
								if (ExceptionInfo.Current != null)
								{
									break;
								}
								*(short*)ptr = num9;
								short num10 = (short)((num5 >>> 16) | (num6 << 8));
								void* ptr2 = vector_unsigned_short_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_11, num4++);
								if (ExceptionInfo.Current != null)
								{
									break;
								}
								*(short*)ptr2 = num10;
								short num11 = (short)(num6 >>> 8);
								void* ptr3 = vector_unsigned_short_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_11, num4++);
								if (ExceptionInfo.Current != null)
								{
									break;
								}
								*(short*)ptr3 = num11;
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
