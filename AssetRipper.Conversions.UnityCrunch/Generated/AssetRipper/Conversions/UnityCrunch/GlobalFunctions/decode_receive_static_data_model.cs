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
		int num11 = 0;
		int num12 = decode_bits.Invoke(@this, total_bits.Invoke(8192));
		unchecked
		{
			if (num12 == 0)
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
				bool flag2 = resize_rzzl5xd.Invoke(&((crnd_static_huffman_data_model*)model)->field_1, num12);
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
					llvm_memset_p0_i64.Invoke(vector_unsigned_char_Index_o39mi9c.Invoke(&((crnd_static_huffman_data_model*)model)->field_1, 0), 0, 1L * (long)(uint)num12, isVolatile: false);
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
								num2 = 1;
							}
							else
							{
								num3 = 0;
								while ((uint)num3 < (uint)num)
								{
									int num13 = decode_bits.Invoke(@this, 3);
									if (ExceptionInfo.Current == null)
									{
										sbyte b = (sbyte)num13;
										void* ptr = vector_unsigned_char_Index_o39mi9c.Invoke(&localsPointer->field_0.field_1, (byte)((sbyte*)g_most_probable_codelength_codes.__pointer)[(uint)num3]);
										if (ExceptionInfo.Current == null)
										{
											*(sbyte*)ptr = b;
											num3++;
											continue;
										}
									}
									goto IL_0449;
								}
								bool flag4 = prepare_decoder_tables.Invoke(&localsPointer->field_0);
								if (ExceptionInfo.Current != null)
								{
									goto IL_0449;
								}
								if (!flag4)
								{
									flag = false;
									num2 = 1;
								}
								else
								{
									num4 = 0;
									while ((uint)num4 < (uint)num12)
									{
										num5 = num12 - num4;
										int num14 = decode.Invoke(@this, &localsPointer->field_0);
										if (ExceptionInfo.Current == null)
										{
											num6 = num14;
											if ((uint)num6 <= 16u)
											{
												sbyte b2 = (sbyte)num6;
												void* ptr2 = vector_unsigned_char_Index_o39mi9c.Invoke(&((crnd_static_huffman_data_model*)model)->field_1, num4++);
												if (ExceptionInfo.Current == null)
												{
													*(sbyte*)ptr2 = b2;
													continue;
												}
											}
											else if (num6 == 17)
											{
												int num15 = decode_bits.Invoke(@this, 3);
												if (ExceptionInfo.Current == null)
												{
													num7 = num15 + 3;
													if ((uint)num7 <= (uint)num5)
													{
														num4 += num7;
														continue;
													}
													goto IL_0270;
												}
											}
											else if (num6 == 18)
											{
												int num16 = decode_bits.Invoke(@this, 7);
												if (ExceptionInfo.Current == null)
												{
													num8 = num16 + 11;
													if ((uint)num8 <= (uint)num5)
													{
														num4 += num8;
														continue;
													}
													goto IL_02bb;
												}
											}
											else
											{
												if (num6 != 19 && num6 != 20)
												{
													goto IL_03d4;
												}
												if (num6 == 19)
												{
													int num17 = decode_bits.Invoke(@this, 2);
													if (ExceptionInfo.Current == null)
													{
														num9 = num17 + 3;
														goto IL_0332;
													}
												}
												else
												{
													int num18 = decode_bits.Invoke(@this, 6);
													if (ExceptionInfo.Current == null)
													{
														num9 = num18 + 7;
														goto IL_0332;
													}
												}
											}
										}
										goto IL_0449;
										IL_0332:
										if (num4 == 0 || (uint)num9 > (uint)num5)
										{
											goto IL_0348;
										}
										void* ptr3 = vector_unsigned_char_Index_o39mi9c.Invoke(&((crnd_static_huffman_data_model*)model)->field_1, num4 - 1);
										if (ExceptionInfo.Current == null)
										{
											num10 = (byte)(*(sbyte*)ptr3);
											if (num10 == 0)
											{
												goto IL_0383;
											}
											num11 = num4 + num9;
											while ((uint)num4 < (uint)num11)
											{
												sbyte b3 = (sbyte)num10;
												void* ptr4 = vector_unsigned_char_Index_o39mi9c.Invoke(&((crnd_static_huffman_data_model*)model)->field_1, num4++);
												if (ExceptionInfo.Current == null)
												{
													*(sbyte*)ptr4 = b3;
													continue;
												}
												goto IL_0449;
											}
											continue;
										}
										goto IL_0449;
									}
									if (num4 != num12)
									{
										flag = false;
										num2 = 1;
									}
									else
									{
										bool flag5 = prepare_decoder_tables.Invoke(model);
										if (ExceptionInfo.Current != null)
										{
											goto IL_0449;
										}
										flag = flag5;
										num2 = 1;
									}
								}
							}
							goto IL_0431;
						}
						goto IL_0449;
					}
					flag = false;
				}
			}
			goto IL_0475;
		}
		IL_0475:
		bool result = flag;
		StackFrameList.Current.Clear(startFrame);
		return result;
		IL_0270:
		flag = false;
		num2 = 1;
		goto IL_0431;
		IL_0383:
		flag = false;
		num2 = 1;
		goto IL_0431;
		IL_03d4:
		crnd_assert.Invoke(String_xzkwrkb.__pointer, String_yguirrd.__pointer, 2598);
		if (ExceptionInfo.Current == null)
		{
			flag = false;
			num2 = 1;
			goto IL_0431;
		}
		goto IL_0449;
		IL_0431:
		static_huffman_data_model_Destructor.Invoke(&localsPointer->field_0);
		if (ExceptionInfo.Current != null)
		{
			return false;
		}
		goto IL_0475;
		IL_02bb:
		flag = false;
		num2 = 1;
		goto IL_0431;
		IL_0348:
		flag = false;
		num2 = 1;
		goto IL_0431;
		IL_0449:
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
