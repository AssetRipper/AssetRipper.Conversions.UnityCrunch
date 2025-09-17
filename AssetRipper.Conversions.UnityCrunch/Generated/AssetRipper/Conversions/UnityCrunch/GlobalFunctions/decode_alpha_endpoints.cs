using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?decode_alpha_endpoints@crn_unpacker@crnd@@AEAA_NXZ")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::decode_alpha_endpoints(void)")]
internal static partial class decode_alpha_endpoints
{
	private partial struct LocalVariables
	{
		public bool field_0;

		public int field_1;

		public crnd_static_huffman_data_model field_2;

		public int field_3;

		public unsafe void* field_4;

		public int field_5;

		public int field_6;

		public int field_7;
	}

	public unsafe static bool Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = default(crnd_static_huffman_data_model);
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_4 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_5 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_6 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_7 = 0;
		unchecked
		{
			int field_ = operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_16.field_2);
			startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_;
			if (!start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4, buf_size: operator_unsigned_int_4iyly2b.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_16.field_1), pBuf: (byte*)((crnd_crn_unpacker*)@this)->field_1 + (uint)operator_unsigned_int_4iyly2b.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_16.field_0)))
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
			}
			else
			{
				static_huffman_data_model_Constructor_tl33idc.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_2);
				bool flag = decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &startFrame.GetLocalsPointer<LocalVariables>()->field_2);
				if (ExceptionInfo.Current != null)
				{
					goto IL_038a;
				}
				if (!flag)
				{
					startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
					startFrame.GetLocalsPointer<LocalVariables>()->field_3 = 1;
				}
				else
				{
					bool flag2 = resize_w95s75a.Invoke(&((crnd_crn_unpacker*)@this)->field_10, startFrame.GetLocalsPointer<LocalVariables>()->field_1);
					if (ExceptionInfo.Current != null)
					{
						goto IL_038a;
					}
					if (!flag2)
					{
						startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
						startFrame.GetLocalsPointer<LocalVariables>()->field_3 = 1;
					}
					else
					{
						void* field_2 = Index_uimxdqb.Invoke(&((crnd_crn_unpacker*)@this)->field_10, 0);
						if (ExceptionInfo.Current != null)
						{
							goto IL_038a;
						}
						startFrame.GetLocalsPointer<LocalVariables>()->field_4 = field_2;
						startFrame.GetLocalsPointer<LocalVariables>()->field_5 = 0;
						startFrame.GetLocalsPointer<LocalVariables>()->field_6 = 0;
						startFrame.GetLocalsPointer<LocalVariables>()->field_7 = 0;
						while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_7 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1)
						{
							int field_3 = startFrame.GetLocalsPointer<LocalVariables>()->field_5;
							int num = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &startFrame.GetLocalsPointer<LocalVariables>()->field_2);
							if (ExceptionInfo.Current == null)
							{
								startFrame.GetLocalsPointer<LocalVariables>()->field_5 = (field_3 + num) & 0xFF;
								int field_4 = startFrame.GetLocalsPointer<LocalVariables>()->field_6;
								int num2 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &startFrame.GetLocalsPointer<LocalVariables>()->field_2);
								if (ExceptionInfo.Current == null)
								{
									startFrame.GetLocalsPointer<LocalVariables>()->field_6 = (field_4 + num2) & 0xFF;
									short num3 = (short)(startFrame.GetLocalsPointer<LocalVariables>()->field_5 | (startFrame.GetLocalsPointer<LocalVariables>()->field_6 << 8));
									void* field_5 = startFrame.GetLocalsPointer<LocalVariables>()->field_4;
									startFrame.GetLocalsPointer<LocalVariables>()->field_4 = (byte*)field_5 + 2;
									*(short*)field_5 = num3;
									int field_6 = startFrame.GetLocalsPointer<LocalVariables>()->field_7 + 1;
									startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_6;
									continue;
								}
							}
							goto IL_038a;
						}
						stop_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4);
						startFrame.GetLocalsPointer<LocalVariables>()->field_0 = true;
						startFrame.GetLocalsPointer<LocalVariables>()->field_3 = 1;
					}
				}
				static_huffman_data_model_Destructor.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_2);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
			}
			bool field_7 = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
			StackFrameList.Current.Clear(startFrame);
			return field_7;
		}
		IL_038a:
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
