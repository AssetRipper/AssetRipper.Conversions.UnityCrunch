using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?decode_receive_static_data_model@symbol_codec@crnd@@QEAA_NAEAVstatic_huffman_data_model@2@@Z")]
[DemangledName("public: bool __cdecl crnd::symbol_codec::decode_receive_static_data_model(class crnd::static_huffman_data_model &)")]
internal static partial class decode_receive_static_data_model
{
	private partial struct LocalVariables
	{
		public bool field_0;

		public unsafe void* field_1;

		public int field_2;

		public int field_3;

		public crnd_static_huffman_data_model field_4;

		public int field_5;

		public int field_6;

		public int field_7;

		public int field_8;

		public int field_9;

		public int field_10;

		public int field_11;

		public int field_12;

		public int field_13;

		public int field_14;
	}

	public unsafe static bool Invoke(void* @this, void* model)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_4 = default(crnd_static_huffman_data_model);
		startFrame.GetLocalsPointer<LocalVariables>()->field_5 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_6 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_7 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_8 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_9 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_10 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_11 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_12 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_13 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_14 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = model;
		int field_ = decode_bits.Invoke(@this, total_bits.Invoke(8192));
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_;
		unchecked
		{
			if (startFrame.GetLocalsPointer<LocalVariables>()->field_2 == 0)
			{
				clear_egw7ktb.Invoke(startFrame.GetLocalsPointer<LocalVariables>()->field_1);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = true;
			}
			else
			{
				bool flag = resize_rzzl5xd.Invoke(&((crnd_static_huffman_data_model*)startFrame.GetLocalsPointer<LocalVariables>()->field_1)->field_1, startFrame.GetLocalsPointer<LocalVariables>()->field_2);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag)
				{
					startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
				}
				else
				{
					llvm_memset_p0_i64.Invoke(Index_o39mi9c.Invoke(&((crnd_static_huffman_data_model*)startFrame.GetLocalsPointer<LocalVariables>()->field_1)->field_1, 0), 0, 1L * (long)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2, isVolatile: false);
					int field_2 = decode_bits.Invoke(@this, 5);
					startFrame.GetLocalsPointer<LocalVariables>()->field_3 = field_2;
					if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_3 >= 1u && (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_3 <= 21u)
					{
						static_huffman_data_model_Constructor_tl33idc.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_4);
						bool flag2 = resize_rzzl5xd.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_4.field_1, 21);
						if (ExceptionInfo.Current == null)
						{
							if (!flag2)
							{
								startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
								startFrame.GetLocalsPointer<LocalVariables>()->field_5 = 1;
							}
							else
							{
								startFrame.GetLocalsPointer<LocalVariables>()->field_6 = 0;
								while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_6 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_3)
								{
									int num = decode_bits.Invoke(@this, 3);
									if (ExceptionInfo.Current == null)
									{
										sbyte b = (sbyte)num;
										crnd_vector* field_3 = &startFrame.GetLocalsPointer<LocalVariables>()->field_4.field_1;
										long num2 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_6;
										void* ptr = Index_o39mi9c.Invoke(field_3, (byte)((sbyte*)g_most_probable_codelength_codes.__pointer)[num2]);
										if (ExceptionInfo.Current == null)
										{
											*(sbyte*)ptr = b;
											int field_4 = startFrame.GetLocalsPointer<LocalVariables>()->field_6 + 1;
											startFrame.GetLocalsPointer<LocalVariables>()->field_6 = field_4;
											continue;
										}
									}
									goto IL_0921;
								}
								bool flag3 = prepare_decoder_tables.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_4);
								if (ExceptionInfo.Current != null)
								{
									goto IL_0921;
								}
								if (!flag3)
								{
									startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
									startFrame.GetLocalsPointer<LocalVariables>()->field_5 = 1;
								}
								else
								{
									startFrame.GetLocalsPointer<LocalVariables>()->field_7 = 0;
									while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_7 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2)
									{
										int field_5 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 - startFrame.GetLocalsPointer<LocalVariables>()->field_7;
										startFrame.GetLocalsPointer<LocalVariables>()->field_8 = field_5;
										int field_6 = decode.Invoke(@this, &startFrame.GetLocalsPointer<LocalVariables>()->field_4);
										if (ExceptionInfo.Current == null)
										{
											startFrame.GetLocalsPointer<LocalVariables>()->field_9 = field_6;
											if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_9 <= 16u)
											{
												sbyte b2 = (sbyte)startFrame.GetLocalsPointer<LocalVariables>()->field_9;
												crnd_vector* field_7 = &((crnd_static_huffman_data_model*)startFrame.GetLocalsPointer<LocalVariables>()->field_1)->field_1;
												int field_8 = startFrame.GetLocalsPointer<LocalVariables>()->field_7;
												startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_8 + 1;
												void* ptr2 = Index_o39mi9c.Invoke(field_7, field_8);
												if (ExceptionInfo.Current == null)
												{
													*(sbyte*)ptr2 = b2;
													continue;
												}
											}
											else if (startFrame.GetLocalsPointer<LocalVariables>()->field_9 == 17)
											{
												int num3 = decode_bits.Invoke(@this, 3);
												if (ExceptionInfo.Current == null)
												{
													startFrame.GetLocalsPointer<LocalVariables>()->field_10 = num3 + 3;
													if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_10 <= (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_8)
													{
														int field_9 = startFrame.GetLocalsPointer<LocalVariables>()->field_10;
														int field_10 = startFrame.GetLocalsPointer<LocalVariables>()->field_7 + field_9;
														startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_10;
														continue;
													}
													goto IL_04fd;
												}
											}
											else if (startFrame.GetLocalsPointer<LocalVariables>()->field_9 == 18)
											{
												int num4 = decode_bits.Invoke(@this, 7);
												if (ExceptionInfo.Current == null)
												{
													startFrame.GetLocalsPointer<LocalVariables>()->field_11 = num4 + 11;
													if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_11 <= (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_8)
													{
														int field_11 = startFrame.GetLocalsPointer<LocalVariables>()->field_11;
														int field_12 = startFrame.GetLocalsPointer<LocalVariables>()->field_7 + field_11;
														startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_12;
														continue;
													}
													goto IL_05b5;
												}
											}
											else
											{
												if (startFrame.GetLocalsPointer<LocalVariables>()->field_9 != 19 && startFrame.GetLocalsPointer<LocalVariables>()->field_9 != 20)
												{
													goto IL_082b;
												}
												if (startFrame.GetLocalsPointer<LocalVariables>()->field_9 == 19)
												{
													int num5 = decode_bits.Invoke(@this, 2);
													if (ExceptionInfo.Current == null)
													{
														startFrame.GetLocalsPointer<LocalVariables>()->field_12 = num5 + 3;
														goto IL_06a3;
													}
												}
												else
												{
													int num6 = decode_bits.Invoke(@this, 6);
													if (ExceptionInfo.Current == null)
													{
														startFrame.GetLocalsPointer<LocalVariables>()->field_12 = num6 + 7;
														goto IL_06a3;
													}
												}
											}
										}
										goto IL_0921;
										IL_06a3:
										if (startFrame.GetLocalsPointer<LocalVariables>()->field_7 == 0 || (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_12 > (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_8)
										{
											goto IL_06d7;
										}
										void* ptr3 = Index_o39mi9c.Invoke(&((crnd_static_huffman_data_model*)startFrame.GetLocalsPointer<LocalVariables>()->field_1)->field_1, startFrame.GetLocalsPointer<LocalVariables>()->field_7 - 1);
										if (ExceptionInfo.Current == null)
										{
											int field_13 = (byte)(*(sbyte*)ptr3);
											startFrame.GetLocalsPointer<LocalVariables>()->field_13 = field_13;
											if (startFrame.GetLocalsPointer<LocalVariables>()->field_13 == 0)
											{
												goto IL_075b;
											}
											int field_14 = startFrame.GetLocalsPointer<LocalVariables>()->field_7 + startFrame.GetLocalsPointer<LocalVariables>()->field_12;
											startFrame.GetLocalsPointer<LocalVariables>()->field_14 = field_14;
											while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_7 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_14)
											{
												sbyte b3 = (sbyte)startFrame.GetLocalsPointer<LocalVariables>()->field_13;
												crnd_vector* field_15 = &((crnd_static_huffman_data_model*)startFrame.GetLocalsPointer<LocalVariables>()->field_1)->field_1;
												int field_16 = startFrame.GetLocalsPointer<LocalVariables>()->field_7;
												startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_16 + 1;
												void* ptr4 = Index_o39mi9c.Invoke(field_15, field_16);
												if (ExceptionInfo.Current == null)
												{
													*(sbyte*)ptr4 = b3;
													continue;
												}
												goto IL_0921;
											}
											continue;
										}
										goto IL_0921;
									}
									if (startFrame.GetLocalsPointer<LocalVariables>()->field_7 != startFrame.GetLocalsPointer<LocalVariables>()->field_2)
									{
										startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
										startFrame.GetLocalsPointer<LocalVariables>()->field_5 = 1;
									}
									else
									{
										bool field_17 = prepare_decoder_tables.Invoke(startFrame.GetLocalsPointer<LocalVariables>()->field_1);
										if (ExceptionInfo.Current != null)
										{
											goto IL_0921;
										}
										startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_17;
										startFrame.GetLocalsPointer<LocalVariables>()->field_5 = 1;
									}
								}
							}
							goto IL_0903;
						}
						goto IL_0921;
					}
					startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
				}
			}
			goto IL_0953;
		}
		IL_0953:
		bool field_18 = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
		StackFrameList.Current.Clear(startFrame);
		return field_18;
		IL_04fd:
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		startFrame.GetLocalsPointer<LocalVariables>()->field_5 = 1;
		goto IL_0903;
		IL_075b:
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		startFrame.GetLocalsPointer<LocalVariables>()->field_5 = 1;
		goto IL_0903;
		IL_082b:
		crnd_assert.Invoke(String_xzkwrkb.__pointer, String_yguirrd.__pointer, 2598);
		if (ExceptionInfo.Current == null)
		{
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
			startFrame.GetLocalsPointer<LocalVariables>()->field_5 = 1;
			goto IL_0903;
		}
		goto IL_0921;
		IL_0903:
		static_huffman_data_model_Destructor.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_4);
		if (ExceptionInfo.Current != null)
		{
			return false;
		}
		goto IL_0953;
		IL_05b5:
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		startFrame.GetLocalsPointer<LocalVariables>()->field_5 = 1;
		goto IL_0903;
		IL_06d7:
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		startFrame.GetLocalsPointer<LocalVariables>()->field_5 = 1;
		goto IL_0903;
		IL_0921:
		ExceptionInfo current = ExceptionInfo.Current;
		ExceptionInfo.Current = null;
		static_huffman_data_model_Destructor.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_4);
		if (ExceptionInfo.Current != null)
		{
			return false;
		}
		ExceptionInfo.Current = current;
		return false;
	}
}
