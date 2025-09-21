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
		public crnd_static_huffman_data_model field_0;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("class crnd::static_huffman_data_model &")] void* model)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		bool flag = false;
		int num = 0;
		localsPointer->field_0 = default(crnd_static_huffman_data_model);
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		int num11 = decode_bits.Invoke(@this, total_bits.Invoke(8192));
		unchecked
		{
			if (num11 == 0)
			{
				clear_egw7ktb.Invoke(model);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				flag = true;
			}
			else
			{
				bool flag2 = resize_rzzl5xd.Invoke(&((crnd_static_huffman_data_model*)model)->field_1, num11);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag2)
				{
					flag = false;
				}
				else
				{
					llvm_memset_p0_i64.Invoke(vector_unsigned_char_Index_o39mi9c.Invoke(&((crnd_static_huffman_data_model*)model)->field_1, 0), 0, 1L * (long)(uint)num11, isVolatile: false);
					num = decode_bits.Invoke(@this, 5);
					if ((uint)num >= 1u && (uint)num <= 21u)
					{
						static_huffman_data_model_Constructor_tl33idc.Invoke(&localsPointer->field_0);
						bool flag3 = resize_rzzl5xd.Invoke(&localsPointer->field_0.field_1, 21);
						if (ExceptionInfo.Current == null)
						{
							if (!flag3)
							{
								flag = false;
							}
							else
							{
								num2 = 0;
								while ((uint)num2 < (uint)num)
								{
									int num12 = decode_bits.Invoke(@this, 3);
									if (ExceptionInfo.Current == null)
									{
										sbyte b = (sbyte)num12;
										void* ptr = vector_unsigned_char_Index_o39mi9c.Invoke(&localsPointer->field_0.field_1, (byte)((sbyte*)g_most_probable_codelength_codes.__pointer)[(uint)num2]);
										if (ExceptionInfo.Current == null)
										{
											*(sbyte*)ptr = b;
											num2++;
											continue;
										}
									}
									goto IL_0428;
								}
								bool flag4 = prepare_decoder_tables.Invoke(&localsPointer->field_0);
								if (ExceptionInfo.Current != null)
								{
									goto IL_0428;
								}
								if (!flag4)
								{
									flag = false;
								}
								else
								{
									num3 = 0;
									while ((uint)num3 < (uint)num11)
									{
										num4 = num11 - num3;
										int num13 = decode.Invoke(@this, &localsPointer->field_0);
										if (ExceptionInfo.Current == null)
										{
											num5 = num13;
											if ((uint)num5 <= 16u)
											{
												sbyte b2 = (sbyte)num5;
												void* ptr2 = vector_unsigned_char_Index_o39mi9c.Invoke(&((crnd_static_huffman_data_model*)model)->field_1, num3++);
												if (ExceptionInfo.Current == null)
												{
													*(sbyte*)ptr2 = b2;
													continue;
												}
											}
											else if (num5 == 17)
											{
												int num14 = decode_bits.Invoke(@this, 3);
												if (ExceptionInfo.Current == null)
												{
													num6 = num14 + 3;
													if ((uint)num6 <= (uint)num4)
													{
														num3 += num6;
														continue;
													}
													goto IL_0267;
												}
											}
											else if (num5 == 18)
											{
												int num15 = decode_bits.Invoke(@this, 7);
												if (ExceptionInfo.Current == null)
												{
													num7 = num15 + 11;
													if ((uint)num7 <= (uint)num4)
													{
														num3 += num7;
														continue;
													}
													goto IL_02af;
												}
											}
											else
											{
												if (num5 != 19 && num5 != 20)
												{
													goto IL_03bc;
												}
												if (num5 == 19)
												{
													int num16 = decode_bits.Invoke(@this, 2);
													if (ExceptionInfo.Current == null)
													{
														num8 = num16 + 3;
														goto IL_0323;
													}
												}
												else
												{
													int num17 = decode_bits.Invoke(@this, 6);
													if (ExceptionInfo.Current == null)
													{
														num8 = num17 + 7;
														goto IL_0323;
													}
												}
											}
										}
										goto IL_0428;
										IL_0323:
										if (num3 == 0 || (uint)num8 > (uint)num4)
										{
											goto IL_0339;
										}
										void* ptr3 = vector_unsigned_char_Index_o39mi9c.Invoke(&((crnd_static_huffman_data_model*)model)->field_1, num3 - 1);
										if (ExceptionInfo.Current == null)
										{
											num9 = (byte)(*(sbyte*)ptr3);
											if (num9 == 0)
											{
												goto IL_0371;
											}
											num10 = num3 + num8;
											while ((uint)num3 < (uint)num10)
											{
												sbyte b3 = (sbyte)num9;
												void* ptr4 = vector_unsigned_char_Index_o39mi9c.Invoke(&((crnd_static_huffman_data_model*)model)->field_1, num3++);
												if (ExceptionInfo.Current == null)
												{
													*(sbyte*)ptr4 = b3;
													continue;
												}
												goto IL_0428;
											}
											continue;
										}
										goto IL_0428;
									}
									if (num3 != num11)
									{
										flag = false;
									}
									else
									{
										bool flag5 = prepare_decoder_tables.Invoke(model);
										if (ExceptionInfo.Current != null)
										{
											goto IL_0428;
										}
										flag = flag5;
									}
								}
							}
							goto IL_0410;
						}
						goto IL_0428;
					}
					flag = false;
				}
			}
			goto IL_0454;
		}
		IL_0454:
		bool result = flag;
		StackFrameList.Current.Clear(startFrame);
		return result;
		IL_0267:
		flag = false;
		goto IL_0410;
		IL_0371:
		flag = false;
		goto IL_0410;
		IL_03bc:
		crnd_assert.Invoke(String_xzkwrkb.__pointer, String_yguirrd.__pointer, 2598);
		if (ExceptionInfo.Current == null)
		{
			flag = false;
			goto IL_0410;
		}
		goto IL_0428;
		IL_0410:
		static_huffman_data_model_Destructor.Invoke(&localsPointer->field_0);
		if (ExceptionInfo.Current != null)
		{
			return false;
		}
		goto IL_0454;
		IL_02af:
		flag = false;
		goto IL_0410;
		IL_0339:
		flag = false;
		goto IL_0410;
		IL_0428:
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
