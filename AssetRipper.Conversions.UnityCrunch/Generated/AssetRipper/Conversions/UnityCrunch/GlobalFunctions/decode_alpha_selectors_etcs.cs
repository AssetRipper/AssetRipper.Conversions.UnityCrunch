using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;
using AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?decode_alpha_selectors_etcs@crn_unpacker@crnd@@AEAA_NXZ")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::decode_alpha_selectors_etcs(void)")]
internal static partial class decode_alpha_selectors_etcs
{
	private partial struct LocalVariables
	{
		public crnd_static_huffman_data_model field_0;

		public InlineArray8_SByte field_1;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(crnd_static_huffman_data_model);
		localsPointer->field_1 = default(InlineArray8_SByte);
		void* ptr = null;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		sbyte b = 0;
		sbyte b2 = 0;
		sbyte b3 = 0;
		sbyte b4 = 0;
		unchecked
		{
			start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4, buf_size: crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_17.field_1), pBuf: (byte*)((crnd_crn_unpacker*)@this)->field_1 + (uint)crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_17.field_0));
			static_huffman_data_model_Constructor_tl33idc.Invoke(&localsPointer->field_0);
			decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &localsPointer->field_0);
			if (ExceptionInfo.Current == null)
			{
				crnd_vector_rf9iywd* field_ = &((crnd_crn_unpacker*)@this)->field_11;
				int num4 = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_17.field_2);
				if (ExceptionInfo.Current == null)
				{
					resize_w95s75a.Invoke(field_, num4 * 3);
					if (ExceptionInfo.Current == null)
					{
						llvm_memset_p0_i64.Invoke(&localsPointer->field_1, 0, 8L, isVolatile: false);
						void* ptr2 = begin.Invoke(&((crnd_crn_unpacker*)@this)->field_11);
						if (ExceptionInfo.Current == null)
						{
							ptr = ptr2;
							num = 0;
							while (true)
							{
								int num5 = num;
								int num6 = size_lxodu4b.Invoke(&((crnd_crn_unpacker*)@this)->field_11);
								if (ExceptionInfo.Current != null)
								{
									break;
								}
								if ((uint)num5 < (uint)(num6 << 1))
								{
									num2 = 0;
									for (num3 = 0; (uint)num3 < 16u; num3++)
									{
										int num7;
										if ((num3 & 1) != 0)
										{
											num7 = num2 >>> 3;
										}
										else
										{
											int num8 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &localsPointer->field_0);
											if (ExceptionInfo.Current != null)
											{
												goto end_IL_013b;
											}
											sbyte* ptr3 = (sbyte*)(&localsPointer->field_1) + (uint)(num3 >>> 1);
											num7 = (byte)(*ptr3 = (sbyte)((byte)(*ptr3) ^ num8));
										}
										num2 = num7;
										b = (sbyte)(num2 & 7);
										if ((byte)b <= 3)
										{
											b = (sbyte)checked(3 - unchecked((byte)b));
										}
										b2 = (sbyte)(3 * (num3 + 1) + 9 * ((num3 & 3) - (num3 >>> 2)));
										b3 = (sbyte)((byte)b2 >> 3);
										b4 = (sbyte)((byte)b2 & 7);
										int num9 = (byte)b << checked(8 - unchecked((byte)b4));
										sbyte* ptr4 = (sbyte*)ptr + (uint)(num + (byte)b3);
										*ptr4 = (sbyte)((byte)(*ptr4) | num9);
										if ((byte)b4 < 3)
										{
											int num10 = (byte)b >> (int)(byte)b4;
											sbyte* ptr5 = (sbyte*)ptr + (uint)(num + (byte)b3 - 1);
											*ptr5 = (sbyte)((byte)(*ptr5) | num10);
										}
									}
									num += 6;
									continue;
								}
								stop_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4);
								static_huffman_data_model_Destructor.Invoke(&localsPointer->field_0);
								if (ExceptionInfo.Current != null)
								{
									return false;
								}
								StackFrameList.Current.Clear(startFrame);
								return true;
								continue;
								end_IL_013b:
								break;
							}
						}
					}
				}
			}
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
}
