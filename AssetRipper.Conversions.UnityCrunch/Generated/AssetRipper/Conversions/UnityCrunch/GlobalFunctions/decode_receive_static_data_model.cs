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
		localsPointer->field_0 = default(crnd_static_huffman_data_model);
		int num = decode_bits.Invoke(@this, total_bits.Invoke(8192));
		bool flag;
		unchecked
		{
			if (num == 0)
			{
				clear_9udjtr.Invoke(model);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				flag = true;
			}
			else
			{
				bool flag2 = resize_zpvfc7.Invoke(&((crnd_static_huffman_data_model*)model)->m_code_sizes, num);
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
					llvm_memset_p0_i64.Invoke(vector_unsigned_char_Operator_ggxbum.Invoke(&((crnd_static_huffman_data_model*)model)->m_code_sizes, 0), 0, 1L * (long)(uint)num, isVolatile: false);
					int num2 = decode_bits.Invoke(@this, 5);
					if ((uint)num2 >= 1u && (uint)num2 <= 21u)
					{
						static_huffman_data_model_Constructor_c98ih8.Invoke(&localsPointer->field_0);
						bool flag3 = resize_zpvfc7.Invoke(&localsPointer->field_0.m_code_sizes, 21);
						if (ExceptionInfo.Current == null)
						{
							if (!flag3)
							{
								flag = false;
							}
							else
							{
								int num3 = 0;
								while ((uint)num3 < (uint)num2)
								{
									int num4 = decode_bits.Invoke(@this, 3);
									if (ExceptionInfo.Current == null)
									{
										sbyte b = (sbyte)num4;
										void* ptr = vector_unsigned_char_Operator_ggxbum.Invoke(&localsPointer->field_0.m_code_sizes, (byte)((sbyte*)g_most_probable_codelength_codes.__pointer)[(uint)num3]);
										if (ExceptionInfo.Current == null)
										{
											*(sbyte*)ptr = b;
											num3++;
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
									int num5 = 0;
									while ((uint)num5 < (uint)num)
									{
										int num6 = num - num5;
										int num7 = decode.Invoke(@this, &localsPointer->field_0);
										int num14;
										if (ExceptionInfo.Current == null)
										{
											int num8 = num7;
											if ((uint)num8 <= 16u)
											{
												sbyte b2 = (sbyte)num8;
												void* ptr2 = vector_unsigned_char_Operator_ggxbum.Invoke(&((crnd_static_huffman_data_model*)model)->m_code_sizes, num5++);
												if (ExceptionInfo.Current == null)
												{
													*(sbyte*)ptr2 = b2;
													continue;
												}
											}
											else if (num8 == 17)
											{
												int num9 = decode_bits.Invoke(@this, 3);
												if (ExceptionInfo.Current == null)
												{
													int num10 = num9 + 3;
													if ((uint)num10 <= (uint)num6)
													{
														num5 += num10;
														continue;
													}
													goto IL_0267;
												}
											}
											else if (num8 == 18)
											{
												int num11 = decode_bits.Invoke(@this, 7);
												if (ExceptionInfo.Current == null)
												{
													int num12 = num11 + 11;
													if ((uint)num12 <= (uint)num6)
													{
														num5 += num12;
														continue;
													}
													goto IL_02af;
												}
											}
											else
											{
												if (num8 != 19 && num8 != 20)
												{
													goto IL_03bc;
												}
												if (num8 == 19)
												{
													int num13 = decode_bits.Invoke(@this, 2);
													if (ExceptionInfo.Current == null)
													{
														num14 = num13 + 3;
														goto IL_0323;
													}
												}
												else
												{
													int num15 = decode_bits.Invoke(@this, 6);
													if (ExceptionInfo.Current == null)
													{
														num14 = num15 + 7;
														goto IL_0323;
													}
												}
											}
										}
										goto IL_0428;
										IL_0323:
										if (num5 == 0 || (uint)num14 > (uint)num6)
										{
											goto IL_0339;
										}
										void* ptr3 = vector_unsigned_char_Operator_ggxbum.Invoke(&((crnd_static_huffman_data_model*)model)->m_code_sizes, num5 - 1);
										if (ExceptionInfo.Current == null)
										{
											int num16 = (byte)(*(sbyte*)ptr3);
											if (num16 == 0)
											{
												goto IL_0371;
											}
											int num17 = num5 + num14;
											while ((uint)num5 < (uint)num17)
											{
												sbyte b3 = (sbyte)num16;
												void* ptr4 = vector_unsigned_char_Operator_ggxbum.Invoke(&((crnd_static_huffman_data_model*)model)->m_code_sizes, num5++);
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
									if (num5 != num)
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
		crnd_assert.Invoke(String_m5q5qr.__pointer, String_vvx8bt.__pointer, 2598);
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
