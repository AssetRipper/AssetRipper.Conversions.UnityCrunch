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
		void* ptr = null;
		int num8 = 0;
		unchecked
		{
			int num9 = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_14.field_2);
			b = (sbyte)(byte)((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 10) ? (-1) : ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 11) ? (-1) : ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 12) ? (-1) : ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) != 13) ? ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 14) ? 1 : 0) : (-1)))));
			b2 = (sbyte)(byte)((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 10) ? (-1) : ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) != 11) ? ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 12) ? 1 : 0) : (-1)));
			bool flag2 = resize_a3d3m5b.Invoke(&((crnd_crn_unpacker*)@this)->field_8, num9);
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
						nint num10 = (nint)ptr4;
						while (true)
						{
							crnd_static_huffman_data_model* ptr6 = (crnd_static_huffman_data_model*)(num10 + (nint)(-1) * sizeof(crnd_static_huffman_data_model));
							static_huffman_data_model_Destructor.Invoke(ptr6);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							if (ptr6 == ptr2)
							{
								break;
							}
							num10 = (nint)ptr6;
						}
					}
					ExceptionInfo.Current = current;
					return false;
				}
				num = 0;
				while (true)
				{
					int num11 = num;
					bool flag3 = (b & 1) == 1;
					_ = flag3;
					if ((uint)num11 < (uint)InstructionHelper.Select(flag3, 1, 2))
					{
						bool flag4 = decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&localsPointer->field_0) + (nint)(uint)num * (nint)sizeof(crnd_static_huffman_data_model));
						if (ExceptionInfo.Current == null)
						{
							if (!flag4)
							{
								flag = false;
								break;
							}
							num++;
							continue;
						}
					}
					else
					{
						num2 = 0;
						num3 = 0;
						num4 = 0;
						num5 = 0;
						num6 = 0;
						num7 = 0;
						void* ptr7 = vector_unsigned_int_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_8, 0);
						if (ExceptionInfo.Current == null)
						{
							ptr = ptr7;
							for (num8 = 0; (uint)num8 < (uint)num9; num8++)
							{
								if ((b & 1) == 1)
								{
									num3 = 0;
									while ((uint)num3 < 32u)
									{
										int num12 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &localsPointer->field_0);
										if (ExceptionInfo.Current == null)
										{
											num2 += num12 << num3;
											num3 += 8;
											continue;
										}
										goto IL_0575;
									}
									num2 &= 0x1F1F1F1F;
									int num13 = (((b2 & 1) != 1) ? (((num2 & 0x7000000) << 5) | ((num2 & 0x7000000) << 2) | 0x2000000 | ((num2 & 0x1F1F1F) << 3)) : num2);
									void* ptr8 = ptr;
									ptr = (byte*)ptr8 + 4;
									*(int*)ptr8 = num13;
									continue;
								}
								int num14 = num2;
								int num15 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &localsPointer->field_0);
								if (ExceptionInfo.Current == null)
								{
									num2 = (num14 + num15) & 0x1F;
									int num16 = num3;
									int num17 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&localsPointer->field_0) + sizeof(crnd_static_huffman_data_model));
									if (ExceptionInfo.Current == null)
									{
										num3 = (num16 + num17) & 0x3F;
										int num18 = num4;
										int num19 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &localsPointer->field_0);
										if (ExceptionInfo.Current == null)
										{
											num4 = (num18 + num19) & 0x1F;
											int num20 = num5;
											int num21 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &localsPointer->field_0);
											if (ExceptionInfo.Current == null)
											{
												num5 = (num20 + num21) & 0x1F;
												int num22 = num6;
												int num23 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&localsPointer->field_0) + sizeof(crnd_static_huffman_data_model));
												if (ExceptionInfo.Current == null)
												{
													num6 = (num22 + num23) & 0x3F;
													int num24 = num7;
													int num25 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &localsPointer->field_0);
													if (ExceptionInfo.Current == null)
													{
														num7 = (num24 + num25) & 0x1F;
														int num26 = num4 | (num3 << 5) | (num2 << 11) | (num7 << 16) | (num6 << 21) | (num5 << 27);
														void* ptr9 = ptr;
														ptr = (byte*)ptr9 + 4;
														*(int*)ptr9 = num26;
														continue;
													}
												}
											}
										}
									}
								}
								goto IL_0575;
							}
							stop_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4);
							flag = true;
							break;
						}
					}
					goto IL_0575;
					IL_0575:
					ExceptionInfo current2 = ExceptionInfo.Current;
					ExceptionInfo.Current = null;
					crnd_static_huffman_data_model* ptr10 = (crnd_static_huffman_data_model*)(&localsPointer->field_0);
					nint num27 = (nint)(ptr10 + 2L);
					while (true)
					{
						crnd_static_huffman_data_model* ptr11 = (crnd_static_huffman_data_model*)(num27 + (nint)(-1) * sizeof(crnd_static_huffman_data_model));
						static_huffman_data_model_Destructor.Invoke(ptr11);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (ptr11 == ptr10)
						{
							break;
						}
						num27 = (nint)ptr11;
					}
					ExceptionInfo.Current = current2;
					return false;
				}
				crnd_static_huffman_data_model* ptr12 = (crnd_static_huffman_data_model*)(&localsPointer->field_0);
				nint num28 = (nint)(ptr12 + 2L);
				while (true)
				{
					crnd_static_huffman_data_model* ptr13 = (crnd_static_huffman_data_model*)(num28 + (nint)(-1) * sizeof(crnd_static_huffman_data_model));
					static_huffman_data_model_Destructor.Invoke(ptr13);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (ptr13 != ptr12)
					{
						num28 = (nint)ptr13;
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
