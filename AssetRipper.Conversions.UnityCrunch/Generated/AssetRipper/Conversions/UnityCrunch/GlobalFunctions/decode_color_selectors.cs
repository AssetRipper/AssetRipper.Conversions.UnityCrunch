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
		localsPointer->field_0 = default(crnd_static_huffman_data_model);
		unchecked
		{
			sbyte b = (sbyte)(byte)((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_format) == 10) ? (-1) : ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_format) == 11) ? (-1) : ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_format) == 12) ? (-1) : ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_format) != 13) ? ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_format) == 14) ? 1 : 0) : (-1)))));
			sbyte b2 = (sbyte)(byte)((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_format) == 10) ? (-1) : ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_format) != 11) ? ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_format) == 12) ? 1 : 0) : (-1)));
			start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, buf_size: crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_color_selectors.m_size), pBuf: (byte*)((crnd_crn_unpacker*)@this)->m_pData + (uint)crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_color_selectors.m_ofs));
			static_huffman_data_model_Constructor_tl33idc.Invoke(&localsPointer->field_0);
			decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &localsPointer->field_0);
			if (ExceptionInfo.Current == null)
			{
				crnd_vector_maaktjc* color_selectors = &((crnd_crn_unpacker*)@this)->m_color_selectors;
				int num = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_color_selectors.m_num);
				if (ExceptionInfo.Current == null)
				{
					resize_a3d3m5b.Invoke(color_selectors, num << InstructionHelper.Select((b2 & 1) == 1, 1, 0));
					if (ExceptionInfo.Current == null)
					{
						int num2 = 0;
						int num3 = 0;
						while (true)
						{
							int num4 = num3;
							int num5 = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_color_selectors.m_num);
							if (ExceptionInfo.Current != null)
							{
								break;
							}
							if ((uint)num4 < (uint)num5)
							{
								for (int i = 0; (uint)i < 32u; i += 4)
								{
									int num6 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &localsPointer->field_0);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_01ed;
									}
									num2 ^= num6 << i;
								}
								if ((b & 1) == 1)
								{
									int num7 = ((num2 ^ -1) & -1431655766) | ((num2 ^ (num2 >>> 1) ^ -1) & 0x55555555);
									int num8 = 8;
									int num9 = 0;
									while ((uint)num9 < 4u)
									{
										int num10 = 0;
										while ((uint)num10 < 4u)
										{
											if ((b2 & 1) == 1)
											{
												int num11 = num7 >>> ((num10 << 3) | (num9 << 1));
												int num12 = (((num11 >>> 1) & 1) | ((num11 & 1) << 16)) << (num8 & 0xF);
												void* ptr = vector_unsigned_int_Index.Invoke(&((crnd_crn_unpacker*)@this)->m_color_selectors, num3 << 1);
												if (ExceptionInfo.Current != null)
												{
													goto end_IL_01ed;
												}
												*(int*)ptr |= num12;
											}
											int num13 = num7 >>> ((num9 << 3) | (num10 << 1));
											int num14 = (((num13 >>> 1) & 1) | ((num13 & 1) << 16)) << (num8 & 0xF);
											void* ptr2 = vector_unsigned_int_Index.Invoke(&((crnd_crn_unpacker*)@this)->m_color_selectors, ((b2 & 1) != 1) ? num3 : ((num3 << 1) | 1));
											if (ExceptionInfo.Current != null)
											{
												goto end_IL_01ed;
											}
											*(int*)ptr2 |= num14;
											num10++;
											num8 += 4;
										}
										num9++;
										num8 -= 15;
									}
								}
								else
								{
									int num15 = ((num2 ^ (num2 << 1)) & -1431655766) | ((num2 >>> 1) & 0x55555555);
									void* ptr3 = vector_unsigned_int_Index.Invoke(&((crnd_crn_unpacker*)@this)->m_color_selectors, num3);
									if (ExceptionInfo.Current != null)
									{
										break;
									}
									*(int*)ptr3 = num15;
								}
								num3++;
								continue;
							}
							stop_decoding.Invoke(&((crnd_crn_unpacker*)@this)->m_codec);
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
