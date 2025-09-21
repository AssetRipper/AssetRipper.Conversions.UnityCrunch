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

		public InlineArray8_SByte field_1;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(crnd_static_huffman_data_model);
		localsPointer->field_1 = default(InlineArray8_SByte);
		unchecked
		{
			start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4, buf_size: crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_17.field_1), pBuf: (byte*)((crnd_crn_unpacker*)@this)->field_1 + (uint)crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_17.field_0));
			static_huffman_data_model_Constructor_tl33idc.Invoke(&localsPointer->field_0);
			decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &localsPointer->field_0);
			if (ExceptionInfo.Current == null)
			{
				crnd_vector_rf9iywd* field_ = &((crnd_crn_unpacker*)@this)->field_11;
				int num = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_17.field_2);
				if (ExceptionInfo.Current == null)
				{
					resize_w95s75a.Invoke(field_, num * 6);
					if (ExceptionInfo.Current == null)
					{
						llvm_memset_p0_i64.Invoke(&localsPointer->field_1, 0, 8L, isVolatile: false);
						void* ptr = begin.Invoke(&((crnd_crn_unpacker*)@this)->field_11);
						int num2 = 0;
						while (true)
						{
							if ((uint)num2 < (uint)size_lxodu4b.Invoke(&((crnd_crn_unpacker*)@this)->field_11))
							{
								int num3 = 0;
								for (int i = 0; (uint)i < 16u; i++)
								{
									int num4;
									if ((i & 1) != 0)
									{
										num4 = num3 >>> 3;
									}
									else
									{
										int num5 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &localsPointer->field_0);
										if (ExceptionInfo.Current != null)
										{
											goto end_IL_012b;
										}
										sbyte* ptr2 = (sbyte*)(&localsPointer->field_1) + (uint)(i >>> 1);
										num4 = (byte)(*ptr2 = (sbyte)((byte)(*ptr2) ^ num5));
									}
									num3 = num4;
									sbyte b = (sbyte)(num3 & 7);
									if ((byte)b <= 3)
									{
										b = (sbyte)checked(3 - unchecked((byte)b));
									}
									sbyte b2 = (sbyte)(3 * (i + 1));
									sbyte b3 = (sbyte)((byte)b2 >> 3);
									sbyte b4 = (sbyte)((byte)b2 & 7);
									int num6 = (byte)b << checked(8 - unchecked((byte)b4));
									sbyte* ptr3 = (sbyte*)ptr + (byte)b3;
									*ptr3 = (sbyte)((byte)(*ptr3) | num6);
									if ((byte)b4 < 3)
									{
										int num7 = (byte)b >> (int)(byte)b4;
										sbyte* ptr4 = (sbyte*)ptr + checked(unchecked((byte)b3) - 1);
										*ptr4 = (sbyte)((byte)(*ptr4) | num7);
									}
									b2 = (sbyte)((byte)b2 + 9 * ((i & 3) - (i >>> 2)));
									b3 = (sbyte)((byte)b2 >> 3);
									b4 = (sbyte)((byte)b2 & 7);
									int num8;
									sbyte* ptr5;
									checked
									{
										num8 = unchecked((byte)b) << 8 - unchecked((byte)b4);
										ptr5 = unchecked((sbyte*)ptr) + (unchecked((byte)b3) + 6);
									}
									*ptr5 = (sbyte)((byte)(*ptr5) | num8);
									if ((byte)b4 < 3)
									{
										int num9 = (byte)b >> (int)(byte)b4;
										sbyte* ptr6 = (sbyte*)ptr + checked(unchecked((byte)b3) + 5);
										*ptr6 = (sbyte)((byte)(*ptr6) | num9);
									}
								}
								num2 += 6;
								ptr = (byte*)ptr + 12;
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
							end_IL_012b:
							break;
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
