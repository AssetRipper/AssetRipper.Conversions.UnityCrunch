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
		void* ptr = null;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		unchecked
		{
			int num4 = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_16.field_2);
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
					goto IL_01e3;
				}
				if (!flag2)
				{
					flag = false;
				}
				else
				{
					bool flag3 = resize_w95s75a.Invoke(&((crnd_crn_unpacker*)@this)->field_10, num4);
					if (ExceptionInfo.Current != null)
					{
						goto IL_01e3;
					}
					if (!flag3)
					{
						flag = false;
					}
					else
					{
						void* ptr2 = vector_unsigned_short_Index.Invoke(&((crnd_crn_unpacker*)@this)->field_10, 0);
						if (ExceptionInfo.Current != null)
						{
							goto IL_01e3;
						}
						ptr = ptr2;
						num = 0;
						num2 = 0;
						num3 = 0;
						while ((uint)num3 < (uint)num4)
						{
							int num5 = num;
							int num6 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &localsPointer->field_0);
							if (ExceptionInfo.Current == null)
							{
								num = (num5 + num6) & 0xFF;
								int num7 = num2;
								int num8 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &localsPointer->field_0);
								if (ExceptionInfo.Current == null)
								{
									num2 = (num7 + num8) & 0xFF;
									short num9 = (short)(num | (num2 << 8));
									void* ptr3 = ptr;
									ptr = (byte*)ptr3 + 2;
									*(short*)ptr3 = num9;
									num3++;
									continue;
								}
							}
							goto IL_01e3;
						}
						stop_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4);
						flag = true;
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
		IL_01e3:
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
