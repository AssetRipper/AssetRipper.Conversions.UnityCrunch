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
		unchecked
		{
			start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, buf_size: crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_alpha_selectors.m_size), pBuf: (byte*)((crnd_crn_unpacker*)@this)->m_pData + (uint)crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_alpha_selectors.m_ofs));
			static_huffman_data_model_Constructor_tl33idc.Invoke(&localsPointer->field_0);
			decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &localsPointer->field_0);
			if (ExceptionInfo.Current == null)
			{
				crnd_vector_rf9iywd* alpha_selectors = &((crnd_crn_unpacker*)@this)->m_alpha_selectors;
				int num = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_alpha_selectors.m_num);
				if (ExceptionInfo.Current == null)
				{
					resize_w95s75a.Invoke(alpha_selectors, num * 3);
					if (ExceptionInfo.Current == null)
					{
						llvm_memset_p0_i64.Invoke(&localsPointer->field_1, 0, 8L, isVolatile: false);
						void* ptr = begin.Invoke(&((crnd_crn_unpacker*)@this)->m_alpha_selectors);
						if (ExceptionInfo.Current == null)
						{
							void* ptr2 = ptr;
							int num2 = 0;
							while (true)
							{
								int num3 = num2;
								int num4 = size_lxodu4b.Invoke(&((crnd_crn_unpacker*)@this)->m_alpha_selectors);
								if (ExceptionInfo.Current != null)
								{
									break;
								}
								if ((uint)num3 < (uint)(num4 << 1))
								{
									int num5 = 0;
									for (int i = 0; (uint)i < 16u; i++)
									{
										int num6;
										if ((i & 1) != 0)
										{
											num6 = num5 >>> 3;
										}
										else
										{
											int num7 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &localsPointer->field_0);
											if (ExceptionInfo.Current != null)
											{
												goto end_IL_013b;
											}
											sbyte* ptr3 = (sbyte*)(&localsPointer->field_1) + (uint)(i >>> 1);
											num6 = (byte)(*ptr3 = (sbyte)((byte)(*ptr3) ^ num7));
										}
										num5 = num6;
										sbyte b = (sbyte)(num5 & 7);
										if ((byte)b <= 3)
										{
											b = (sbyte)checked(3 - unchecked((byte)b));
										}
										sbyte b2 = (sbyte)(3 * (i + 1) + 9 * ((i & 3) - (i >>> 2)));
										sbyte b3 = (sbyte)((byte)b2 >> 3);
										sbyte b4 = (sbyte)((byte)b2 & 7);
										int num8 = (byte)b << checked(8 - unchecked((byte)b4));
										sbyte* ptr4 = (sbyte*)ptr2 + (uint)(num2 + (byte)b3);
										*ptr4 = (sbyte)((byte)(*ptr4) | num8);
										if ((byte)b4 < 3)
										{
											int num9 = (byte)b >> (int)(byte)b4;
											sbyte* ptr5 = (sbyte*)ptr2 + (uint)(num2 + (byte)b3 - 1);
											*ptr5 = (sbyte)((byte)(*ptr5) | num9);
										}
									}
									num2 += 6;
									continue;
								}
								stop_decoding.Invoke(&((crnd_crn_unpacker*)@this)->m_codec);
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
