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
		localsPointer->field_0 = default(crnd_static_huffman_data_model);
		unchecked
		{
			int num = crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_alpha_endpoints.m_num);
			bool flag;
			if (!start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, buf_size: crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_alpha_endpoints.m_size), pBuf: (byte*)((crnd_crn_unpacker*)@this)->m_pData + (uint)crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_alpha_endpoints.m_ofs)))
			{
				flag = false;
			}
			else
			{
				static_huffman_data_model_Constructor_c98ih8.Invoke(&localsPointer->field_0);
				bool flag2 = decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &localsPointer->field_0);
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
					bool flag3 = resize_9ubjj8.Invoke(&((crnd_crn_unpacker*)@this)->m_alpha_endpoints, num);
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
						void* ptr = vector_unsigned_short_Operator.Invoke(&((crnd_crn_unpacker*)@this)->m_alpha_endpoints, 0);
						if (ExceptionInfo.Current != null)
						{
							goto IL_01e3;
						}
						void* ptr2 = ptr;
						int num2 = 0;
						int num3 = 0;
						int num4 = 0;
						while ((uint)num4 < (uint)num)
						{
							int num5 = num2;
							int num6 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &localsPointer->field_0);
							if (ExceptionInfo.Current == null)
							{
								num2 = (num5 + num6) & 0xFF;
								int num7 = num3;
								int num8 = decode.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &localsPointer->field_0);
								if (ExceptionInfo.Current == null)
								{
									num3 = (num7 + num8) & 0xFF;
									short num9 = (short)(num2 | (num3 << 8));
									void* ptr3 = ptr2;
									ptr2 = (byte*)ptr3 + 2;
									*(short*)ptr3 = num9;
									num4++;
									continue;
								}
							}
							goto IL_01e3;
						}
						stop_decoding.Invoke(&((crnd_crn_unpacker*)@this)->m_codec);
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
