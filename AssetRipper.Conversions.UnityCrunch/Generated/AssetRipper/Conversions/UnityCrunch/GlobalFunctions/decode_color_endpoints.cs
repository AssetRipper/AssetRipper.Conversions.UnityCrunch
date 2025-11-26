using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?decode_color_endpoints@crn_unpacker@crnd@@AEAA_NXZ")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::decode_color_endpoints(void)")]
internal static partial class decode_color_endpoints
{
	private partial struct LocalVariables
	{
		public InlineArray2_crnd_static_huffman_data_model field_0;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(InlineArray2_crnd_static_huffman_data_model);
		unchecked
		{
			int num = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_color_endpoints.m_num);
			sbyte b = (sbyte)(byte)((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_format) == 10) ? (-1) : ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_format) == 11) ? (-1) : ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_format) == 12) ? (-1) : ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_format) != 13) ? ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_format) == 14) ? 1 : 0) : (-1)))));
			sbyte b2 = (sbyte)(byte)((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_format) == 10) ? (-1) : ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_format) != 11) ? ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_format) == 12) ? 1 : 0) : (-1)));
			bool flag = resize_dreg6y.Invoke(&((crnd_crn_unpacker*)@this)->m_color_endpoints, num);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			bool flag2;
			if (!flag)
			{
				flag2 = false;
			}
			else if (!start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, buf_size: crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_color_endpoints.m_size), pBuf: (byte*)((crnd_crn_unpacker*)@this)->m_pData + (uint)crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_color_endpoints.m_ofs)))
			{
				flag2 = false;
			}
			else
			{
				crnd_static_huffman_data_model* ptr = (crnd_static_huffman_data_model*)(&localsPointer->field_0);
				crnd_static_huffman_data_model* ptr2 = ptr + 2L;
				crnd_static_huffman_data_model* intPtr = ptr;
				while (true)
				{
					void* ptr3 = intPtr;
					static_huffman_data_model_Constructor_c98ih8.Invoke(ptr3);
					if (ExceptionInfo.Current == null)
					{
						crnd_static_huffman_data_model* ptr4 = (crnd_static_huffman_data_model*)ptr3 + 1;
						if (ptr4 == ptr2)
						{
							break;
						}
						intPtr = ptr4;
						continue;
					}
					ExceptionInfo current = ExceptionInfo.Current;
					ExceptionInfo.Current = null;
					if (ptr != ptr3)
					{
						nint num2 = (nint)ptr3;
						while (true)
						{
							crnd_static_huffman_data_model* ptr5 = (crnd_static_huffman_data_model*)(num2 + (nint)(-1) * sizeof(crnd_static_huffman_data_model));
							static_huffman_data_model_Destructor.Invoke(ptr5);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							if (ptr5 == ptr)
							{
								break;
							}
							num2 = (nint)ptr5;
						}
					}
					ExceptionInfo.Current = current;
					return false;
				}
				int num3 = 0;
				while (true)
				{
					if ((uint)num3 < (uint)InstructionHelper.Select((b & 1) == 1, 1, 2))
					{
						bool flag3 = decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, (byte*)(&localsPointer->field_0) + (nint)(uint)num3 * (nint)sizeof(crnd_static_huffman_data_model));
						if (ExceptionInfo.Current == null)
						{
							if (!flag3)
							{
								flag2 = false;
								break;
							}
							num3++;
							continue;
						}
					}
					else
					{
						int num4 = 0;
						int num5 = 0;
						int num6 = 0;
						int num7 = 0;
						int num8 = 0;
						int num9 = 0;
						void* ptr6 = vector_unsigned_int_Operator.Invoke(&((crnd_crn_unpacker*)@this)->m_color_endpoints, 0);
						if (ExceptionInfo.Current == null)
						{
							void* ptr7 = ptr6;
							for (int i = 0; (uint)i < (uint)num; i++)
							{
								if ((b & 1) == 1)
								{
									num5 = 0;
									while ((uint)num5 < 32u)
									{
										int num10 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &localsPointer->field_0);
										if (ExceptionInfo.Current == null)
										{
											num4 += num10 << num5;
											num5 += 8;
											continue;
										}
										goto IL_0575;
									}
									num4 &= 0x1F1F1F1F;
									int num11 = (((b2 & 1) != 1) ? (((num4 & 0x7000000) << 5) | ((num4 & 0x7000000) << 2) | 0x2000000 | ((num4 & 0x1F1F1F) << 3)) : num4);
									void* ptr8 = ptr7;
									ptr7 = (byte*)ptr8 + 4;
									*(int*)ptr8 = num11;
									continue;
								}
								int num12 = num4;
								int num13 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &localsPointer->field_0);
								if (ExceptionInfo.Current == null)
								{
									num4 = (num12 + num13) & 0x1F;
									int num14 = num5;
									int num15 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, (byte*)(&localsPointer->field_0) + sizeof(crnd_static_huffman_data_model));
									if (ExceptionInfo.Current == null)
									{
										num5 = (num14 + num15) & 0x3F;
										int num16 = num6;
										int num17 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &localsPointer->field_0);
										if (ExceptionInfo.Current == null)
										{
											num6 = (num16 + num17) & 0x1F;
											int num18 = num7;
											int num19 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &localsPointer->field_0);
											if (ExceptionInfo.Current == null)
											{
												num7 = (num18 + num19) & 0x1F;
												int num20 = num8;
												int num21 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, (byte*)(&localsPointer->field_0) + sizeof(crnd_static_huffman_data_model));
												if (ExceptionInfo.Current == null)
												{
													num8 = (num20 + num21) & 0x3F;
													int num22 = num9;
													int num23 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &localsPointer->field_0);
													if (ExceptionInfo.Current == null)
													{
														num9 = (num22 + num23) & 0x1F;
														int num24 = num6 | (num5 << 5) | (num4 << 11) | (num9 << 16) | (num8 << 21) | (num7 << 27);
														void* ptr9 = ptr7;
														ptr7 = (byte*)ptr9 + 4;
														*(int*)ptr9 = num24;
														continue;
													}
												}
											}
										}
									}
								}
								goto IL_0575;
							}
							stop_decoding.Invoke(&((crnd_crn_unpacker*)@this)->m_codec);
							flag2 = true;
							break;
						}
					}
					goto IL_0575;
					IL_0575:
					ExceptionInfo current2 = ExceptionInfo.Current;
					ExceptionInfo.Current = null;
					crnd_static_huffman_data_model* ptr10 = (crnd_static_huffman_data_model*)(&localsPointer->field_0);
					nint num25 = (nint)(ptr10 + 2L);
					while (true)
					{
						crnd_static_huffman_data_model* ptr11 = (crnd_static_huffman_data_model*)(num25 + (nint)(-1) * sizeof(crnd_static_huffman_data_model));
						static_huffman_data_model_Destructor.Invoke(ptr11);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (ptr11 == ptr10)
						{
							break;
						}
						num25 = (nint)ptr11;
					}
					ExceptionInfo.Current = current2;
					return false;
				}
				crnd_static_huffman_data_model* ptr12 = (crnd_static_huffman_data_model*)(&localsPointer->field_0);
				nint num26 = (nint)(ptr12 + 2L);
				while (true)
				{
					crnd_static_huffman_data_model* ptr13 = (crnd_static_huffman_data_model*)(num26 + (nint)(-1) * sizeof(crnd_static_huffman_data_model));
					static_huffman_data_model_Destructor.Invoke(ptr13);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (ptr13 != ptr12)
					{
						num26 = (nint)ptr13;
						continue;
					}
					break;
				}
			}
			bool result = flag2;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}
}
