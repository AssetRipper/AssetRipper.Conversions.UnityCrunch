using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?decode_color_selectors@crn_unpacker@crnd@@AEAA_NXZ")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::decode_color_selectors(void)")]
internal static partial class decode_color_selectors
{
	private partial struct LocalVariables
	{
		public crnd_static_huffman_data_model field_0;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		sbyte b = 0;
		sbyte b2 = 0;
		localsPointer->field_0 = default(crnd_static_huffman_data_model);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		unchecked
		{
			b = (sbyte)(byte)((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 10) ? (-1) : ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 11) ? (-1) : ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 12) ? (-1) : ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) != 13) ? ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 14) ? 1 : 0) : (-1)))));
			b2 = (sbyte)(byte)((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 10) ? (-1) : ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) != 11) ? ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 12) ? 1 : 0) : (-1)));
			start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4, buf_size: crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_15.field_1), pBuf: (byte*)((crnd_crn_unpacker*)@this)->field_1 + (uint)crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_15.field_0));
			static_huffman_data_model_Constructor_tl33idc.Invoke(&localsPointer->field_0);
			decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &localsPointer->field_0);
			if (ExceptionInfo.Current == null)
			{
				crnd_vector_maaktjc* field_ = &((crnd_crn_unpacker*)@this)->field_9;
				int num10 = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_15.field_2);
				if (ExceptionInfo.Current == null)
				{
					bool flag = (b2 & 1) == 1;
					_ = flag;
					resize_a3d3m5b.Invoke(field_, num10 << InstructionHelper.Select(flag, 1, 0));
					if (ExceptionInfo.Current == null)
					{
						num = 0;
						num2 = 0;
						while (true)
						{
							int num11 = num2;
							int num12 = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_15.field_2);
							if (ExceptionInfo.Current != null)
							{
								break;
							}
							if ((uint)num11 < (uint)num12)
							{
								for (num3 = 0; (uint)num3 < 32u; num3 += 4)
								{
									int num13 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &localsPointer->field_0);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_01ed;
									}
									num ^= num13 << num3;
								}
								if ((b & 1) == 1)
								{
									num4 = ((num ^ -1) & -1431655766) | ((num ^ (num >>> 1) ^ -1) & 0x55555555);
									num5 = 8;
									num6 = 0;
									while ((uint)num6 < 4u)
									{
										num7 = 0;
										while ((uint)num7 < 4u)
										{
											if ((b2 & 1) == 1)
											{
												num8 = num4 >>> ((num7 << 3) | (num6 << 1));
												int num14 = (((num8 >>> 1) & 1) | ((num8 & 1) << 16)) << (num5 & 0xF);
												void* ptr = vector_unsigned_int_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_9, num2 << 1);
												if (ExceptionInfo.Current != null)
												{
													goto end_IL_01ed;
												}
												*(int*)ptr |= num14;
											}
											num9 = num4 >>> ((num6 << 3) | (num7 << 1));
											int num15 = (((num9 >>> 1) & 1) | ((num9 & 1) << 16)) << (num5 & 0xF);
											void* ptr2 = vector_unsigned_int_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_9, ((b2 & 1) != 1) ? num2 : ((num2 << 1) | 1));
											if (ExceptionInfo.Current != null)
											{
												goto end_IL_01ed;
											}
											*(int*)ptr2 |= num15;
											num7++;
											num5 += 4;
										}
										num6++;
										num5 -= 15;
									}
								}
								else
								{
									int num16 = ((num ^ (num << 1)) & -1431655766) | ((num >>> 1) & 0x55555555);
									void* ptr3 = vector_unsigned_int_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_9, num2);
									if (ExceptionInfo.Current != null)
									{
										break;
									}
									*(int*)ptr3 = num16;
								}
								num2++;
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
							end_IL_01ed:
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
