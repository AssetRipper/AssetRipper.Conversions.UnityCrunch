using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?decode_alpha_selectors@crn_unpacker@crnd@@AEAA_NXZ")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::decode_alpha_selectors(void)")]
internal static partial class decode_alpha_selectors
{
	private partial struct LocalVariables
	{
		public crnd_static_huffman_data_model field_0;

		public InlineArray_64_w3otm9c field_1;

		public int field_2;

		public int field_3;

		public int field_4;

		public int field_5;

		public int field_6;

		public int field_7;

		public int field_8;

		public int field_9;
	}

	public unsafe static bool Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = default(crnd_static_huffman_data_model);
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = default(InlineArray_64_w3otm9c);
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_4 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_5 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_6 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_7 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_8 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_9 = 0;
		unchecked
		{
			start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4, buf_size: operator_unsigned_int_4iyly2b.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_17.field_1), pBuf: (byte*)((crnd_crn_unpacker*)@this)->field_1 + (uint)operator_unsigned_int_4iyly2b.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_17.field_0));
			static_huffman_data_model_Constructor_tl33idc.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_0);
			decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &startFrame.GetLocalsPointer<LocalVariables>()->field_0);
			if (ExceptionInfo.Current == null)
			{
				crnd_vector_8* field_ = &((crnd_crn_unpacker*)@this)->field_11;
				int num = operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_17.field_2);
				if (ExceptionInfo.Current == null)
				{
					resize_w95s75a.Invoke(field_, num * 3);
					if (ExceptionInfo.Current == null)
					{
						startFrame.GetLocalsPointer<LocalVariables>()->field_2 = 0;
						while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 < 64u)
						{
							long num2 = (uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_2 & 7);
							byte num3 = (byte)((sbyte*)g_dxt5_from_linear.__pointer)[num2];
							long num4 = (uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_2 >>> 3);
							sbyte b = (sbyte)(num3 | ((byte)((sbyte*)g_dxt5_from_linear.__pointer)[num4] << 3));
							long num5 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2;
							((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[num5] = b;
							int field_2 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 + 1;
							startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_2;
						}
						startFrame.GetLocalsPointer<LocalVariables>()->field_3 = 0;
						startFrame.GetLocalsPointer<LocalVariables>()->field_4 = 0;
						startFrame.GetLocalsPointer<LocalVariables>()->field_5 = 0;
						while (true)
						{
							if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_5 < (uint)size_lxodu4b.Invoke(&((crnd_crn_unpacker*)@this)->field_11))
							{
								startFrame.GetLocalsPointer<LocalVariables>()->field_6 = 0;
								startFrame.GetLocalsPointer<LocalVariables>()->field_7 = 0;
								startFrame.GetLocalsPointer<LocalVariables>()->field_8 = 0;
								while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_8 < 24u)
								{
									int num6 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &startFrame.GetLocalsPointer<LocalVariables>()->field_0);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0242;
									}
									int field_3 = startFrame.GetLocalsPointer<LocalVariables>()->field_8;
									int field_4 = startFrame.GetLocalsPointer<LocalVariables>()->field_3 ^ (num6 << field_3);
									startFrame.GetLocalsPointer<LocalVariables>()->field_3 = field_4;
									long num7 = (uint)((startFrame.GetLocalsPointer<LocalVariables>()->field_3 >>> startFrame.GetLocalsPointer<LocalVariables>()->field_8) & 0x3F);
									int num8 = (byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[num7] << startFrame.GetLocalsPointer<LocalVariables>()->field_8;
									int field_5 = startFrame.GetLocalsPointer<LocalVariables>()->field_6 | num8;
									startFrame.GetLocalsPointer<LocalVariables>()->field_6 = field_5;
									int field_6 = startFrame.GetLocalsPointer<LocalVariables>()->field_8 + 6;
									startFrame.GetLocalsPointer<LocalVariables>()->field_8 = field_6;
								}
								startFrame.GetLocalsPointer<LocalVariables>()->field_9 = 0;
								while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_9 < 24u)
								{
									int num9 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &startFrame.GetLocalsPointer<LocalVariables>()->field_0);
									if (ExceptionInfo.Current != null)
									{
										goto end_IL_0242;
									}
									int field_7 = startFrame.GetLocalsPointer<LocalVariables>()->field_9;
									int field_8 = startFrame.GetLocalsPointer<LocalVariables>()->field_4 ^ (num9 << field_7);
									startFrame.GetLocalsPointer<LocalVariables>()->field_4 = field_8;
									long num10 = (uint)((startFrame.GetLocalsPointer<LocalVariables>()->field_4 >>> startFrame.GetLocalsPointer<LocalVariables>()->field_9) & 0x3F);
									int num11 = (byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1))[num10] << startFrame.GetLocalsPointer<LocalVariables>()->field_9;
									int field_9 = startFrame.GetLocalsPointer<LocalVariables>()->field_7 | num11;
									startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_9;
									int field_10 = startFrame.GetLocalsPointer<LocalVariables>()->field_9 + 6;
									startFrame.GetLocalsPointer<LocalVariables>()->field_9 = field_10;
								}
								short num12 = (short)startFrame.GetLocalsPointer<LocalVariables>()->field_6;
								crnd_vector_8* field_11 = &((crnd_crn_unpacker*)@this)->field_11;
								int field_12 = startFrame.GetLocalsPointer<LocalVariables>()->field_5;
								startFrame.GetLocalsPointer<LocalVariables>()->field_5 = field_12 + 1;
								void* ptr = Index_uimxdqb.Invoke(field_11, field_12);
								if (ExceptionInfo.Current != null)
								{
									break;
								}
								*(short*)ptr = num12;
								short num13 = (short)((startFrame.GetLocalsPointer<LocalVariables>()->field_6 >>> 16) | (startFrame.GetLocalsPointer<LocalVariables>()->field_7 << 8));
								crnd_vector_8* field_13 = &((crnd_crn_unpacker*)@this)->field_11;
								int field_14 = startFrame.GetLocalsPointer<LocalVariables>()->field_5;
								startFrame.GetLocalsPointer<LocalVariables>()->field_5 = field_14 + 1;
								void* ptr2 = Index_uimxdqb.Invoke(field_13, field_14);
								if (ExceptionInfo.Current != null)
								{
									break;
								}
								*(short*)ptr2 = num13;
								short num14 = (short)(startFrame.GetLocalsPointer<LocalVariables>()->field_7 >>> 8);
								crnd_vector_8* field_15 = &((crnd_crn_unpacker*)@this)->field_11;
								int field_16 = startFrame.GetLocalsPointer<LocalVariables>()->field_5;
								startFrame.GetLocalsPointer<LocalVariables>()->field_5 = field_16 + 1;
								void* ptr3 = Index_uimxdqb.Invoke(field_15, field_16);
								if (ExceptionInfo.Current != null)
								{
									break;
								}
								*(short*)ptr3 = num14;
								continue;
							}
							stop_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4);
							static_huffman_data_model_Destructor.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_0);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							StackFrameList.Current.Clear(startFrame);
							return true;
							continue;
							end_IL_0242:
							break;
						}
					}
				}
			}
			ExceptionInfo current = ExceptionInfo.Current;
			ExceptionInfo.Current = null;
			static_huffman_data_model_Destructor.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_0);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			ExceptionInfo.Current = current;
			return false;
		}
	}
}
