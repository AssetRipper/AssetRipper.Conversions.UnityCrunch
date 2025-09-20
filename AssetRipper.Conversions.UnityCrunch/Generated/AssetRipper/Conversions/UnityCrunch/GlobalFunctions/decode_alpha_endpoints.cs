using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?decode_alpha_endpoints@crn_unpacker@crnd@@AEAA_NXZ")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::decode_alpha_endpoints(void)")]
internal static partial class decode_alpha_endpoints
{
	private partial struct LocalVariables
	{
		public crnd_static_huffman_data_model field_0;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		bool flag = false;
		localsPointer->field_0 = default(crnd_static_huffman_data_model);
		int num = 0;
		void* ptr = null;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		unchecked
		{
			int num5 = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_16.field_2);
			if (!start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4, buf_size: crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_16.field_1), pBuf: (byte*)((crnd_crn_unpacker*)@this)->field_1 + (uint)crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_16.field_0)))
			{
				flag = false;
			}
			else
			{
				static_huffman_data_model_Constructor_tl33idc.Invoke(&localsPointer->field_0);
				bool flag2 = decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &localsPointer->field_0);
				if (ExceptionInfo.Current != null)
				{
					goto IL_01ef;
				}
				if (!flag2)
				{
					flag = false;
					num = 1;
				}
				else
				{
					bool flag3 = resize_w95s75a.Invoke(&((crnd_crn_unpacker*)@this)->field_10, num5);
					if (ExceptionInfo.Current != null)
					{
						goto IL_01ef;
					}
					if (!flag3)
					{
						flag = false;
						num = 1;
					}
					else
					{
						void* ptr2 = vector_unsigned_short_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_10, 0);
						if (ExceptionInfo.Current != null)
						{
							goto IL_01ef;
						}
						ptr = ptr2;
						num2 = 0;
						num3 = 0;
						num4 = 0;
						while ((uint)num4 < (uint)num5)
						{
							int num6 = num2;
							int num7 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &localsPointer->field_0);
							if (ExceptionInfo.Current == null)
							{
								num2 = (num6 + num7) & 0xFF;
								int num8 = num3;
								int num9 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &localsPointer->field_0);
								if (ExceptionInfo.Current == null)
								{
									num3 = (num8 + num9) & 0xFF;
									short num10 = (short)(num2 | (num3 << 8));
									void* ptr3 = ptr;
									ptr = (byte*)ptr3 + 2;
									*(short*)ptr3 = num10;
									num4++;
									continue;
								}
							}
							goto IL_01ef;
						}
						stop_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4);
						flag = true;
						num = 1;
					}
				}
				static_huffman_data_model_Destructor.Invoke(&localsPointer->field_0);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
			}
			bool result = flag;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
		IL_01ef:
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
