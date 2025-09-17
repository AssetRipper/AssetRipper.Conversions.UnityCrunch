using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_unpack_begin@crnd@@YAPEAXPEBXI@Z")]
[DemangledName("void * __cdecl crnd::crnd_unpack_begin(void const *, unsigned int)")]
internal static partial class crnd_unpack_begin
{
	private partial struct LocalVariables
	{
		public unsafe void* field_0;

		public int field_1;

		public unsafe void* field_2;

		public unsafe void* field_3;
	}

	public unsafe static void* Invoke(void* pData, int data_size)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = data_size;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = pData;
		if (startFrame.GetLocalsPointer<LocalVariables>()->field_2 == null || unchecked((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1) < 62u)
		{
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = null;
		}
		else
		{
			void* field_ = crnd_new_xzix9sb.Invoke();
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			startFrame.GetLocalsPointer<LocalVariables>()->field_3 = field_;
			if (startFrame.GetLocalsPointer<LocalVariables>()->field_3 == null)
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = null;
			}
			else
			{
				bool flag = init_lqqdgrc.Invoke(startFrame.GetLocalsPointer<LocalVariables>()->field_3, data_size: startFrame.GetLocalsPointer<LocalVariables>()->field_1, pData: startFrame.GetLocalsPointer<LocalVariables>()->field_2);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				if (!flag)
				{
					crnd_delete_e7rwdhb.Invoke(startFrame.GetLocalsPointer<LocalVariables>()->field_3);
					if (ExceptionInfo.Current != null)
					{
						return null;
					}
					startFrame.GetLocalsPointer<LocalVariables>()->field_0 = null;
				}
				else
				{
					void* field_2 = startFrame.GetLocalsPointer<LocalVariables>()->field_3;
					startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_2;
				}
			}
		}
		void* field_3 = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
		StackFrameList.Current.Clear(startFrame);
		return field_3;
	}
}
