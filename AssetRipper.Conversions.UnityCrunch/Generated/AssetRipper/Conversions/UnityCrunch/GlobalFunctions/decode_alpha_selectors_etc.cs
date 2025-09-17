using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;
using AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?decode_alpha_selectors_etc@crn_unpacker@crnd@@AEAA_NXZ")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::decode_alpha_selectors_etc(void)")]
internal static partial class decode_alpha_selectors_etc
{
	private partial struct LocalVariables
	{
		public crnd_static_huffman_data_model field_0;

		public InlineArray_8_w3otm9c field_1;

		public unsafe void* field_2;

		public int field_3;

		public int field_4;

		public int field_5;

		public sbyte field_6;

		public sbyte field_7;

		public sbyte field_8;

		public sbyte field_9;
	}

	public unsafe static bool Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = default(crnd_static_huffman_data_model);
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = default(InlineArray_8_w3otm9c);
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = null;
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
					resize_w95s75a.Invoke(field_, num * 6);
					if (ExceptionInfo.Current == null)
					{
						llvm_memset_p0_i64.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_1, 0, 8L, isVolatile: false);
						void* field_2 = begin.Invoke(&((crnd_crn_unpacker*)@this)->field_11);
						startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_2;
						startFrame.GetLocalsPointer<LocalVariables>()->field_3 = 0;
						while (true)
						{
							if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_3 < (uint)size_lxodu4b.Invoke(&((crnd_crn_unpacker*)@this)->field_11))
							{
								startFrame.GetLocalsPointer<LocalVariables>()->field_4 = 0;
								startFrame.GetLocalsPointer<LocalVariables>()->field_5 = 0;
								while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_5 < 16u)
								{
									int field_3;
									if ((startFrame.GetLocalsPointer<LocalVariables>()->field_5 & 1) != 0)
									{
										field_3 = startFrame.GetLocalsPointer<LocalVariables>()->field_4 >>> 3;
									}
									else
									{
										int num2 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &startFrame.GetLocalsPointer<LocalVariables>()->field_0);
										if (ExceptionInfo.Current != null)
										{
											goto end_IL_01a4;
										}
										long num3 = (uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_5 >>> 1);
										sbyte* ptr = (sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_1) + num3;
										field_3 = (byte)(*ptr = (sbyte)((byte)(*ptr) ^ num2));
									}
									startFrame.GetLocalsPointer<LocalVariables>()->field_4 = field_3;
									sbyte field_4 = (sbyte)(startFrame.GetLocalsPointer<LocalVariables>()->field_4 & 7);
									startFrame.GetLocalsPointer<LocalVariables>()->field_6 = field_4;
									if ((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_6 <= 3)
									{
										sbyte field_5 = (sbyte)checked(3 - unchecked((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_6));
										startFrame.GetLocalsPointer<LocalVariables>()->field_6 = field_5;
									}
									int num4 = startFrame.GetLocalsPointer<LocalVariables>()->field_5 + 1;
									startFrame.GetLocalsPointer<LocalVariables>()->field_7 = (sbyte)(3 * num4);
									sbyte field_6 = (sbyte)((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_7 >> 3);
									startFrame.GetLocalsPointer<LocalVariables>()->field_8 = field_6;
									sbyte field_7 = (sbyte)((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_7 & 7);
									startFrame.GetLocalsPointer<LocalVariables>()->field_9 = field_7;
									int num5 = (byte)startFrame.GetLocalsPointer<LocalVariables>()->field_6 << checked(8 - unchecked((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_9));
									sbyte* ptr2 = (sbyte*)startFrame.GetLocalsPointer<LocalVariables>()->field_2 + (byte)startFrame.GetLocalsPointer<LocalVariables>()->field_8;
									*ptr2 = (sbyte)((byte)(*ptr2) | num5);
									if ((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_9 < 3)
									{
										int num6 = (byte)startFrame.GetLocalsPointer<LocalVariables>()->field_6 >> (int)(byte)startFrame.GetLocalsPointer<LocalVariables>()->field_9;
										sbyte* ptr3 = (sbyte*)startFrame.GetLocalsPointer<LocalVariables>()->field_2 + checked(unchecked((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_8) - 1);
										*ptr3 = (sbyte)((byte)(*ptr3) | num6);
									}
									int num7 = (startFrame.GetLocalsPointer<LocalVariables>()->field_5 & 3) - (startFrame.GetLocalsPointer<LocalVariables>()->field_5 >>> 2);
									sbyte field_8 = (sbyte)((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_7 + 9 * num7);
									startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_8;
									sbyte field_9 = (sbyte)((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_7 >> 3);
									startFrame.GetLocalsPointer<LocalVariables>()->field_8 = field_9;
									sbyte field_10 = (sbyte)((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_7 & 7);
									startFrame.GetLocalsPointer<LocalVariables>()->field_9 = field_10;
									int num8;
									sbyte* ptr4;
									checked
									{
										num8 = unchecked((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_6) << 8 - unchecked((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_9);
										ptr4 = unchecked((sbyte*)startFrame.GetLocalsPointer<LocalVariables>()->field_2) + (unchecked((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_8) + 6);
									}
									*ptr4 = (sbyte)((byte)(*ptr4) | num8);
									if ((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_9 < 3)
									{
										int num9 = (byte)startFrame.GetLocalsPointer<LocalVariables>()->field_6 >> (int)(byte)startFrame.GetLocalsPointer<LocalVariables>()->field_9;
										sbyte* ptr5 = (sbyte*)startFrame.GetLocalsPointer<LocalVariables>()->field_2 + checked(unchecked((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_8) + 5);
										*ptr5 = (sbyte)((byte)(*ptr5) | num9);
									}
									int field_11 = startFrame.GetLocalsPointer<LocalVariables>()->field_5 + 1;
									startFrame.GetLocalsPointer<LocalVariables>()->field_5 = field_11;
								}
								int field_12 = startFrame.GetLocalsPointer<LocalVariables>()->field_3 + 6;
								startFrame.GetLocalsPointer<LocalVariables>()->field_3 = field_12;
								void* field_13 = (byte*)startFrame.GetLocalsPointer<LocalVariables>()->field_2 + 12;
								startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_13;
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
							end_IL_01a4:
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
