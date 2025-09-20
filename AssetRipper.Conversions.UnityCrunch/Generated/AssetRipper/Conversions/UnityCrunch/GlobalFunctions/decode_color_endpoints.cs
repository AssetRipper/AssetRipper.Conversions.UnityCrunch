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
		bool flag = false;
		sbyte b = 0;
		sbyte b2 = 0;
		localsPointer->field_0 = default(InlineArray2_crnd_static_huffman_data_model);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		void* ptr = null;
		int num9 = 0;
		unchecked
		{
			int num10 = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_14.field_2);
			b = (sbyte)(byte)((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 10) ? (-1) : ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 11) ? (-1) : ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 12) ? (-1) : ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) != 13) ? ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 14) ? 1 : 0) : (-1)))));
			b2 = (sbyte)(byte)((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 10) ? (-1) : ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) != 11) ? ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 12) ? 1 : 0) : (-1)));
			bool flag2 = resize_a3d3m5b.Invoke(&((crnd_crn_unpacker*)@this)->field_8, num10);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag2)
			{
				flag = false;
			}
			else if (!start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4, buf_size: crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_14.field_1), pBuf: (byte*)((crnd_crn_unpacker*)@this)->field_1 + (uint)crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_14.field_0)))
			{
				flag = false;
			}
			else
			{
				crnd_static_huffman_data_model* ptr2 = (crnd_static_huffman_data_model*)(&localsPointer->field_0);
				crnd_static_huffman_data_model* ptr3 = ptr2 + 2L;
				crnd_static_huffman_data_model* intPtr = ptr2;
				while (true)
				{
					void* ptr4 = intPtr;
					static_huffman_data_model_Constructor_tl33idc.Invoke(ptr4);
					if (ExceptionInfo.Current == null)
					{
						crnd_static_huffman_data_model* ptr5 = (crnd_static_huffman_data_model*)ptr4 + 1;
						if (ptr5 == ptr3)
						{
							break;
						}
						intPtr = ptr5;
						continue;
					}
					ExceptionInfo current = ExceptionInfo.Current;
					ExceptionInfo.Current = null;
					if (ptr2 != ptr4)
					{
						nint num11 = (nint)ptr4;
						while (true)
						{
							crnd_static_huffman_data_model* ptr6 = (crnd_static_huffman_data_model*)(num11 + (nint)(-1) * sizeof(crnd_static_huffman_data_model));
							static_huffman_data_model_Destructor.Invoke(ptr6);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							if (ptr6 == ptr2)
							{
								break;
							}
							num11 = (nint)ptr6;
						}
					}
					ExceptionInfo.Current = current;
					return false;
				}
				num = 0;
				while (true)
				{
					int num12 = num;
					bool flag3 = (b & 1) == 1;
					_ = flag3;
					if ((uint)num12 < (uint)InstructionHelper.Select(flag3, 1, 2))
					{
						bool flag4 = decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&localsPointer->field_0) + (nint)(uint)num * (nint)sizeof(crnd_static_huffman_data_model));
						if (ExceptionInfo.Current == null)
						{
							if (!flag4)
							{
								flag = false;
								num2 = 1;
								break;
							}
							num++;
							continue;
						}
					}
					else
					{
						num3 = 0;
						num4 = 0;
						num5 = 0;
						num6 = 0;
						num7 = 0;
						num8 = 0;
						void* ptr7 = vector_unsigned_int_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_8, 0);
						if (ExceptionInfo.Current == null)
						{
							ptr = ptr7;
							for (num9 = 0; (uint)num9 < (uint)num10; num9++)
							{
								if ((b & 1) == 1)
								{
									num4 = 0;
									while ((uint)num4 < 32u)
									{
										int num13 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &localsPointer->field_0);
										if (ExceptionInfo.Current == null)
										{
											num3 += num13 << num4;
											num4 += 8;
											continue;
										}
										goto IL_0581;
									}
									num3 &= 0x1F1F1F1F;
									int num14 = (((b2 & 1) != 1) ? (((num3 & 0x7000000) << 5) | ((num3 & 0x7000000) << 2) | 0x2000000 | ((num3 & 0x1F1F1F) << 3)) : num3);
									void* ptr8 = ptr;
									ptr = (byte*)ptr8 + 4;
									*(int*)ptr8 = num14;
									continue;
								}
								int num15 = num3;
								int num16 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &localsPointer->field_0);
								if (ExceptionInfo.Current == null)
								{
									num3 = (num15 + num16) & 0x1F;
									int num17 = num4;
									int num18 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&localsPointer->field_0) + sizeof(crnd_static_huffman_data_model));
									if (ExceptionInfo.Current == null)
									{
										num4 = (num17 + num18) & 0x3F;
										int num19 = num5;
										int num20 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &localsPointer->field_0);
										if (ExceptionInfo.Current == null)
										{
											num5 = (num19 + num20) & 0x1F;
											int num21 = num6;
											int num22 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &localsPointer->field_0);
											if (ExceptionInfo.Current == null)
											{
												num6 = (num21 + num22) & 0x1F;
												int num23 = num7;
												int num24 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&localsPointer->field_0) + sizeof(crnd_static_huffman_data_model));
												if (ExceptionInfo.Current == null)
												{
													num7 = (num23 + num24) & 0x3F;
													int num25 = num8;
													int num26 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &localsPointer->field_0);
													if (ExceptionInfo.Current == null)
													{
														num8 = (num25 + num26) & 0x1F;
														int num27 = num5 | (num4 << 5) | (num3 << 11) | (num8 << 16) | (num7 << 21) | (num6 << 27);
														void* ptr9 = ptr;
														ptr = (byte*)ptr9 + 4;
														*(int*)ptr9 = num27;
														continue;
													}
												}
											}
										}
									}
								}
								goto IL_0581;
							}
							stop_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4);
							flag = true;
							num2 = 1;
							break;
						}
					}
					goto IL_0581;
					IL_0581:
					ExceptionInfo current2 = ExceptionInfo.Current;
					ExceptionInfo.Current = null;
					crnd_static_huffman_data_model* ptr10 = (crnd_static_huffman_data_model*)(&localsPointer->field_0);
					nint num28 = (nint)(ptr10 + 2L);
					while (true)
					{
						crnd_static_huffman_data_model* ptr11 = (crnd_static_huffman_data_model*)(num28 + (nint)(-1) * sizeof(crnd_static_huffman_data_model));
						static_huffman_data_model_Destructor.Invoke(ptr11);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (ptr11 == ptr10)
						{
							break;
						}
						num28 = (nint)ptr11;
					}
					ExceptionInfo.Current = current2;
					return false;
				}
				crnd_static_huffman_data_model* ptr12 = (crnd_static_huffman_data_model*)(&localsPointer->field_0);
				nint num29 = (nint)(ptr12 + 2L);
				while (true)
				{
					crnd_static_huffman_data_model* ptr13 = (crnd_static_huffman_data_model*)(num29 + (nint)(-1) * sizeof(crnd_static_huffman_data_model));
					static_huffman_data_model_Destructor.Invoke(ptr13);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (ptr13 != ptr12)
					{
						num29 = (nint)ptr13;
						continue;
					}
					break;
				}
			}
			bool result = flag;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}
}
