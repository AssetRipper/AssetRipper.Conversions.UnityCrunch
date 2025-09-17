using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?decode_color_selectors@crn_unpacker@crnd@@AEAA_NXZ")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::decode_color_selectors(void)")]
internal static partial class decode_color_selectors
{
	private partial struct LocalVariables
	{
		public sbyte field_0;

		public sbyte field_1;

		public crnd_static_huffman_data_model field_2;

		public int field_3;

		public int field_4;

		public int field_5;

		public int field_6;

		public int field_7;

		public int field_8;

		public int field_9;

		public int field_10;

		public int field_11;
	}

	public unsafe static bool Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = default(crnd_static_huffman_data_model);
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_4 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_5 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_6 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_7 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_8 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_9 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_10 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_11 = 0;
		unchecked
		{
			int num = ((operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 10) ? (-1) : ((operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 11) ? (-1) : ((operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 12) ? (-1) : ((operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) != 13) ? ((operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 14) ? 1 : 0) : (-1)))));
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = (sbyte)(byte)num;
			int num2 = ((operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 10) ? (-1) : ((operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) != 11) ? ((operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 12) ? 1 : 0) : (-1)));
			startFrame.GetLocalsPointer<LocalVariables>()->field_1 = (sbyte)(byte)num2;
			start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4, buf_size: operator_unsigned_int_4iyly2b.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_15.field_1), pBuf: (byte*)((crnd_crn_unpacker*)@this)->field_1 + (uint)operator_unsigned_int_4iyly2b.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_15.field_0));
			static_huffman_data_model_Constructor_tl33idc.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_2);
			decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &startFrame.GetLocalsPointer<LocalVariables>()->field_2);
			if (ExceptionInfo.Current == null)
			{
				crnd_vector_5* field_ = &((crnd_crn_unpacker*)@this)->field_9;
				int num3 = operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_15.field_2);
				if (ExceptionInfo.Current == null)
				{
					bool flag = (startFrame.GetLocalsPointer<LocalVariables>()->field_1 & 1) == 1;
					_ = flag;
					resize_a3d3m5b.Invoke(field_, num3 << InstructionHelper.Select(flag, 1, 0));
					if (ExceptionInfo.Current == null)
					{
						startFrame.GetLocalsPointer<LocalVariables>()->field_3 = 0;
						startFrame.GetLocalsPointer<LocalVariables>()->field_4 = 0;
						while (true)
						{
							int field_2 = startFrame.GetLocalsPointer<LocalVariables>()->field_4;
							int num4 = operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_15.field_2);
							if (ExceptionInfo.Current != null)
							{
								break;
							}
							if ((uint)field_2 < (uint)num4)
							{
								startFrame.GetLocalsPointer<LocalVariables>()->field_5 = 0;
								while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_5 < 32u)
								{
									int num5 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &startFrame.GetLocalsPointer<LocalVariables>()->field_2);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0298;
									}
									int field_3 = startFrame.GetLocalsPointer<LocalVariables>()->field_5;
									int field_4 = startFrame.GetLocalsPointer<LocalVariables>()->field_3 ^ (num5 << field_3);
									startFrame.GetLocalsPointer<LocalVariables>()->field_3 = field_4;
									int field_5 = startFrame.GetLocalsPointer<LocalVariables>()->field_5 + 4;
									startFrame.GetLocalsPointer<LocalVariables>()->field_5 = field_5;
								}
								if ((startFrame.GetLocalsPointer<LocalVariables>()->field_0 & 1) == 1)
								{
									int field_6 = ((startFrame.GetLocalsPointer<LocalVariables>()->field_3 ^ -1) & -1431655766) | ((startFrame.GetLocalsPointer<LocalVariables>()->field_3 ^ (startFrame.GetLocalsPointer<LocalVariables>()->field_3 >>> 1) ^ -1) & 0x55555555);
									startFrame.GetLocalsPointer<LocalVariables>()->field_6 = field_6;
									startFrame.GetLocalsPointer<LocalVariables>()->field_7 = 8;
									startFrame.GetLocalsPointer<LocalVariables>()->field_8 = 0;
									while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_8 < 4u)
									{
										startFrame.GetLocalsPointer<LocalVariables>()->field_9 = 0;
										while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_9 < 4u)
										{
											if ((startFrame.GetLocalsPointer<LocalVariables>()->field_1 & 1) == 1)
											{
												int field_7 = startFrame.GetLocalsPointer<LocalVariables>()->field_6 >>> ((startFrame.GetLocalsPointer<LocalVariables>()->field_9 << 3) | (startFrame.GetLocalsPointer<LocalVariables>()->field_8 << 1));
												startFrame.GetLocalsPointer<LocalVariables>()->field_10 = field_7;
												int num6 = (((startFrame.GetLocalsPointer<LocalVariables>()->field_10 >>> 1) & 1) | ((startFrame.GetLocalsPointer<LocalVariables>()->field_10 & 1) << 16)) << (startFrame.GetLocalsPointer<LocalVariables>()->field_7 & 0xF);
												void* ptr = Index_rfutjka.Invoke(&((crnd_crn_unpacker*)@this)->field_9, startFrame.GetLocalsPointer<LocalVariables>()->field_4 << 1);
												if (ExceptionInfo.Current != null)
												{
													goto end_IL_0298;
												}
												*(int*)ptr |= num6;
											}
											int field_8 = startFrame.GetLocalsPointer<LocalVariables>()->field_6 >>> ((startFrame.GetLocalsPointer<LocalVariables>()->field_8 << 3) | (startFrame.GetLocalsPointer<LocalVariables>()->field_9 << 1));
											startFrame.GetLocalsPointer<LocalVariables>()->field_11 = field_8;
											int num7 = (((startFrame.GetLocalsPointer<LocalVariables>()->field_11 >>> 1) & 1) | ((startFrame.GetLocalsPointer<LocalVariables>()->field_11 & 1) << 16)) << (startFrame.GetLocalsPointer<LocalVariables>()->field_7 & 0xF);
											void* ptr2 = Index_rfutjka.Invoke(&((crnd_crn_unpacker*)@this)->field_9, ((startFrame.GetLocalsPointer<LocalVariables>()->field_1 & 1) != 1) ? startFrame.GetLocalsPointer<LocalVariables>()->field_4 : ((startFrame.GetLocalsPointer<LocalVariables>()->field_4 << 1) | 1));
											if (ExceptionInfo.Current != null)
											{
												goto end_IL_0298;
											}
											*(int*)ptr2 |= num7;
											int field_9 = startFrame.GetLocalsPointer<LocalVariables>()->field_9 + 1;
											startFrame.GetLocalsPointer<LocalVariables>()->field_9 = field_9;
											int field_10 = startFrame.GetLocalsPointer<LocalVariables>()->field_7 + 4;
											startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_10;
										}
										int field_11 = startFrame.GetLocalsPointer<LocalVariables>()->field_8 + 1;
										startFrame.GetLocalsPointer<LocalVariables>()->field_8 = field_11;
										int field_12 = startFrame.GetLocalsPointer<LocalVariables>()->field_7 - 15;
										startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_12;
									}
								}
								else
								{
									int num8 = ((startFrame.GetLocalsPointer<LocalVariables>()->field_3 ^ (startFrame.GetLocalsPointer<LocalVariables>()->field_3 << 1)) & -1431655766) | ((startFrame.GetLocalsPointer<LocalVariables>()->field_3 >>> 1) & 0x55555555);
									void* ptr3 = Index_rfutjka.Invoke(&((crnd_crn_unpacker*)@this)->field_9, startFrame.GetLocalsPointer<LocalVariables>()->field_4);
									if (ExceptionInfo.Current != null)
									{
										break;
									}
									*(int*)ptr3 = num8;
								}
								int field_13 = startFrame.GetLocalsPointer<LocalVariables>()->field_4 + 1;
								startFrame.GetLocalsPointer<LocalVariables>()->field_4 = field_13;
								continue;
							}
							stop_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4);
							static_huffman_data_model_Destructor.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_2);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							StackFrameList.Current.Clear(startFrame);
							return true;
							continue;
							end_IL_0298:
							break;
						}
					}
				}
			}
			ExceptionInfo current = ExceptionInfo.Current;
			ExceptionInfo.Current = null;
			static_huffman_data_model_Destructor.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_2);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			ExceptionInfo.Current = current;
			return false;
		}
	}
}
