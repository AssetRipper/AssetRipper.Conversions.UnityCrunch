using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?init@crn_unpacker@crnd@@QEAA_NPEBXI@Z")]
[DemangledName("public: bool __cdecl crnd::crn_unpacker::init(void const *, unsigned int)")]
[CleanName("init")]
internal static partial class init_lqqdgrc
{
	private partial struct LocalVariables
	{
		public bool field_0;

		public int field_1;

		public unsafe void* field_2;
	}

	public unsafe static bool Invoke(void* @this, void* pData, int data_size)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = data_size;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = pData;
		unchecked
		{
			((crnd_crn_unpacker*)@this)->field_3 = crnd_get_header.Invoke(data_size: startFrame.GetLocalsPointer<LocalVariables>()->field_1, pData: startFrame.GetLocalsPointer<LocalVariables>()->field_2);
			if (((crnd_crn_unpacker*)@this)->field_3 == null)
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
			}
			else
			{
				((crnd_crn_unpacker*)@this)->field_1 = startFrame.GetLocalsPointer<LocalVariables>()->field_2;
				((crnd_crn_unpacker*)@this)->field_2 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
				bool flag = init_tables.Invoke(@this);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag)
				{
					startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
				}
				else
				{
					bool flag2 = decode_palettes.Invoke(@this);
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
						startFrame.GetLocalsPointer<LocalVariables>()->field_0 = true;
					}
				}
			}
			bool field_ = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
			StackFrameList.Current.Clear(startFrame);
			return field_;
		}
	}
}
