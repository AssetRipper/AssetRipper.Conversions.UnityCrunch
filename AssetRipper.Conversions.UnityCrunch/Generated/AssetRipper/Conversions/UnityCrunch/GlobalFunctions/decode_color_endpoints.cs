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
		public bool field_0;

		public int field_1;

		public sbyte field_2;

		public sbyte field_3;

		public InlineArray_2_tahu2ya field_4;

		public int field_5;

		public int field_6;

		public int field_7;

		public int field_8;

		public int field_9;

		public int field_10;

		public int field_11;

		public int field_12;

		public unsafe void* field_13;

		public int field_14;
	}

	public unsafe static bool Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_4 = default(InlineArray_2_tahu2ya);
		startFrame.GetLocalsPointer<LocalVariables>()->field_5 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_6 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_7 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_8 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_9 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_10 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_11 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_12 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_13 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_14 = 0;
		unchecked
		{
			int field_ = operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_14.field_2);
			startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_;
			int num = ((operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 10) ? (-1) : ((operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 11) ? (-1) : ((operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 12) ? (-1) : ((operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) != 13) ? ((operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 14) ? 1 : 0) : (-1)))));
			startFrame.GetLocalsPointer<LocalVariables>()->field_2 = (sbyte)(byte)num;
			int num2 = ((operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 10) ? (-1) : ((operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) != 11) ? ((operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 12) ? 1 : 0) : (-1)));
			startFrame.GetLocalsPointer<LocalVariables>()->field_3 = (sbyte)(byte)num2;
			bool flag = resize_a3d3m5b.Invoke(&((crnd_crn_unpacker*)@this)->field_8, startFrame.GetLocalsPointer<LocalVariables>()->field_1);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag)
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
			}
			else if (!start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4, buf_size: operator_unsigned_int_4iyly2b.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_14.field_1), pBuf: (byte*)((crnd_crn_unpacker*)@this)->field_1 + (uint)operator_unsigned_int_4iyly2b.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_14.field_0)))
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
			}
			else
			{
				crnd_static_huffman_data_model* ptr = (crnd_static_huffman_data_model*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_4);
				crnd_static_huffman_data_model* ptr2 = ptr + 2L;
				crnd_static_huffman_data_model* intPtr = ptr;
				while (true)
				{
					void* ptr3 = intPtr;
					static_huffman_data_model_Constructor_tl33idc.Invoke(ptr3);
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
						nint num3 = (nint)ptr3;
						while (true)
						{
							crnd_static_huffman_data_model* ptr5 = (crnd_static_huffman_data_model*)(num3 + (nint)(-1) * sizeof(crnd_static_huffman_data_model));
							static_huffman_data_model_Destructor.Invoke(ptr5);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							if (ptr5 == ptr)
							{
								break;
							}
							num3 = (nint)ptr5;
						}
					}
					ExceptionInfo.Current = current;
					return false;
				}
				startFrame.GetLocalsPointer<LocalVariables>()->field_5 = 0;
				while (true)
				{
					int field_2 = startFrame.GetLocalsPointer<LocalVariables>()->field_5;
					bool flag2 = (startFrame.GetLocalsPointer<LocalVariables>()->field_2 & 1) == 1;
					_ = flag2;
					if ((uint)field_2 < (uint)InstructionHelper.Select(flag2, 1, 2))
					{
						crnd_symbol_codec* field_3 = &((crnd_crn_unpacker*)@this)->field_4;
						long num4 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_5;
						bool flag3 = decode_receive_static_data_model.Invoke(field_3, (byte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_4) + (nint)num4 * sizeof(crnd_static_huffman_data_model));
						if (ExceptionInfo.Current == null)
						{
							if (!flag3)
							{
								startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
								startFrame.GetLocalsPointer<LocalVariables>()->field_6 = 1;
								break;
							}
							int field_4 = startFrame.GetLocalsPointer<LocalVariables>()->field_5 + 1;
							startFrame.GetLocalsPointer<LocalVariables>()->field_5 = field_4;
							continue;
						}
					}
					else
					{
						startFrame.GetLocalsPointer<LocalVariables>()->field_7 = 0;
						startFrame.GetLocalsPointer<LocalVariables>()->field_8 = 0;
						startFrame.GetLocalsPointer<LocalVariables>()->field_9 = 0;
						startFrame.GetLocalsPointer<LocalVariables>()->field_10 = 0;
						startFrame.GetLocalsPointer<LocalVariables>()->field_11 = 0;
						startFrame.GetLocalsPointer<LocalVariables>()->field_12 = 0;
						void* field_5 = Index_rfutjka.Invoke(&((crnd_crn_unpacker*)@this)->field_8, 0);
						if (ExceptionInfo.Current == null)
						{
							startFrame.GetLocalsPointer<LocalVariables>()->field_13 = field_5;
							startFrame.GetLocalsPointer<LocalVariables>()->field_14 = 0;
							int field_18;
							for (; (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_14 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1; field_18 = startFrame.GetLocalsPointer<LocalVariables>()->field_14 + 1, startFrame.GetLocalsPointer<LocalVariables>()->field_14 = field_18)
							{
								if ((startFrame.GetLocalsPointer<LocalVariables>()->field_2 & 1) == 1)
								{
									startFrame.GetLocalsPointer<LocalVariables>()->field_8 = 0;
									while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_8 < 32u)
									{
										int num5 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &startFrame.GetLocalsPointer<LocalVariables>()->field_4);
										if (ExceptionInfo.Current == null)
										{
											int field_6 = startFrame.GetLocalsPointer<LocalVariables>()->field_8;
											int field_7 = startFrame.GetLocalsPointer<LocalVariables>()->field_7 + (num5 << field_6);
											startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_7;
											int field_8 = startFrame.GetLocalsPointer<LocalVariables>()->field_8 + 8;
											startFrame.GetLocalsPointer<LocalVariables>()->field_8 = field_8;
											continue;
										}
										goto IL_0943;
									}
									int field_9 = startFrame.GetLocalsPointer<LocalVariables>()->field_7 & 0x1F1F1F1F;
									startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_9;
									int num6 = (((startFrame.GetLocalsPointer<LocalVariables>()->field_3 & 1) != 1) ? (((startFrame.GetLocalsPointer<LocalVariables>()->field_7 & 0x7000000) << 5) | ((startFrame.GetLocalsPointer<LocalVariables>()->field_7 & 0x7000000) << 2) | 0x2000000 | ((startFrame.GetLocalsPointer<LocalVariables>()->field_7 & 0x1F1F1F) << 3)) : startFrame.GetLocalsPointer<LocalVariables>()->field_7);
									void* field_10 = startFrame.GetLocalsPointer<LocalVariables>()->field_13;
									startFrame.GetLocalsPointer<LocalVariables>()->field_13 = (byte*)field_10 + 4;
									*(int*)field_10 = num6;
									continue;
								}
								int field_11 = startFrame.GetLocalsPointer<LocalVariables>()->field_7;
								int num7 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &startFrame.GetLocalsPointer<LocalVariables>()->field_4);
								if (ExceptionInfo.Current == null)
								{
									startFrame.GetLocalsPointer<LocalVariables>()->field_7 = (field_11 + num7) & 0x1F;
									int field_12 = startFrame.GetLocalsPointer<LocalVariables>()->field_8;
									int num8 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_4) + sizeof(crnd_static_huffman_data_model));
									if (ExceptionInfo.Current == null)
									{
										startFrame.GetLocalsPointer<LocalVariables>()->field_8 = (field_12 + num8) & 0x3F;
										int field_13 = startFrame.GetLocalsPointer<LocalVariables>()->field_9;
										int num9 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &startFrame.GetLocalsPointer<LocalVariables>()->field_4);
										if (ExceptionInfo.Current == null)
										{
											startFrame.GetLocalsPointer<LocalVariables>()->field_9 = (field_13 + num9) & 0x1F;
											int field_14 = startFrame.GetLocalsPointer<LocalVariables>()->field_10;
											int num10 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &startFrame.GetLocalsPointer<LocalVariables>()->field_4);
											if (ExceptionInfo.Current == null)
											{
												startFrame.GetLocalsPointer<LocalVariables>()->field_10 = (field_14 + num10) & 0x1F;
												int field_15 = startFrame.GetLocalsPointer<LocalVariables>()->field_11;
												int num11 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_4) + sizeof(crnd_static_huffman_data_model));
												if (ExceptionInfo.Current == null)
												{
													startFrame.GetLocalsPointer<LocalVariables>()->field_11 = (field_15 + num11) & 0x3F;
													int field_16 = startFrame.GetLocalsPointer<LocalVariables>()->field_12;
													int num12 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &startFrame.GetLocalsPointer<LocalVariables>()->field_4);
													if (ExceptionInfo.Current == null)
													{
														startFrame.GetLocalsPointer<LocalVariables>()->field_12 = (field_16 + num12) & 0x1F;
														int num13 = startFrame.GetLocalsPointer<LocalVariables>()->field_9 | (startFrame.GetLocalsPointer<LocalVariables>()->field_8 << 5) | (startFrame.GetLocalsPointer<LocalVariables>()->field_7 << 11) | (startFrame.GetLocalsPointer<LocalVariables>()->field_12 << 16) | (startFrame.GetLocalsPointer<LocalVariables>()->field_11 << 21) | (startFrame.GetLocalsPointer<LocalVariables>()->field_10 << 27);
														void* field_17 = startFrame.GetLocalsPointer<LocalVariables>()->field_13;
														startFrame.GetLocalsPointer<LocalVariables>()->field_13 = (byte*)field_17 + 4;
														*(int*)field_17 = num13;
														continue;
													}
												}
											}
										}
									}
								}
								goto IL_0943;
							}
							stop_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4);
							startFrame.GetLocalsPointer<LocalVariables>()->field_0 = true;
							startFrame.GetLocalsPointer<LocalVariables>()->field_6 = 1;
							break;
						}
					}
					goto IL_0943;
					IL_0943:
					ExceptionInfo current2 = ExceptionInfo.Current;
					ExceptionInfo.Current = null;
					crnd_static_huffman_data_model* ptr6 = (crnd_static_huffman_data_model*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_4);
					nint num14 = (nint)(ptr6 + 2L);
					while (true)
					{
						crnd_static_huffman_data_model* ptr7 = (crnd_static_huffman_data_model*)(num14 + (nint)(-1) * sizeof(crnd_static_huffman_data_model));
						static_huffman_data_model_Destructor.Invoke(ptr7);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (ptr7 == ptr6)
						{
							break;
						}
						num14 = (nint)ptr7;
					}
					ExceptionInfo.Current = current2;
					return false;
				}
				crnd_static_huffman_data_model* ptr8 = (crnd_static_huffman_data_model*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_4);
				nint num15 = (nint)(ptr8 + 2L);
				while (true)
				{
					crnd_static_huffman_data_model* ptr9 = (crnd_static_huffman_data_model*)(num15 + (nint)(-1) * sizeof(crnd_static_huffman_data_model));
					static_huffman_data_model_Destructor.Invoke(ptr9);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (ptr9 != ptr8)
					{
						num15 = (nint)ptr9;
						continue;
					}
					break;
				}
			}
			bool field_19 = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
			StackFrameList.Current.Clear(startFrame);
			return field_19;
		}
	}
}
