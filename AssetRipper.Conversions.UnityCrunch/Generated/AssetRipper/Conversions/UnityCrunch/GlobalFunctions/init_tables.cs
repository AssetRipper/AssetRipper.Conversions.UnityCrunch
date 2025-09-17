using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?init_tables@crn_unpacker@crnd@@AEAA_NXZ")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::init_tables(void)")]
internal static partial class init_tables
{
	private partial struct LocalVariables
	{
		public bool field_0;
	}

	public unsafe static bool Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		unchecked
		{
			if (!start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4, buf_size: operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_18), pBuf: (byte*)((crnd_crn_unpacker*)@this)->field_1 + (uint)operator_unsigned_int_4iyly2b.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_19)))
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
			}
			else
			{
				bool flag = decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_5);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag)
				{
					startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
				}
				else if (operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_14.field_2) == 0 && operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_16.field_2) == 0)
				{
					startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
				}
				else
				{
					if (operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_14.field_2) == 0)
					{
						goto IL_0189;
					}
					bool flag2 = decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_6);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (!flag2)
					{
						startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
					}
					else
					{
						bool flag3 = decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_7);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (flag3)
						{
							goto IL_0189;
						}
						startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
					}
				}
			}
			goto IL_0243;
		}
		IL_0189:
		unchecked
		{
			if (operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_16.field_2) == 0)
			{
				goto IL_0224;
			}
			bool flag4 = decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&((crnd_crn_unpacker*)@this)->field_6) + sizeof(crnd_static_huffman_data_model));
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag4)
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
			}
			else
			{
				bool flag5 = decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&((crnd_crn_unpacker*)@this)->field_7) + sizeof(crnd_static_huffman_data_model));
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (flag5)
				{
					goto IL_0224;
				}
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
			}
			goto IL_0243;
		}
		IL_0224:
		stop_decoding.Invoke(&unchecked((crnd_crn_unpacker*)@this)->field_4);
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = true;
		goto IL_0243;
		IL_0243:
		bool field_ = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
		StackFrameList.Current.Clear(startFrame);
		return field_;
	}
}
