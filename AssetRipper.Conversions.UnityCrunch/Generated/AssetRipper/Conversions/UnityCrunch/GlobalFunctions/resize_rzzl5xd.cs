using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?resize@?$vector@E@crnd@@QEAA_NI@Z")]
[DemangledName("public: bool __cdecl crnd::vector<unsigned char>::resize(unsigned int)")]
[CleanName("resize")]
internal static partial class resize_rzzl5xd
{
	private partial struct LocalVariables
	{
		public bool field_0;

		public int field_1;
	}

	public unsafe static bool Invoke(void* @this, int new_size)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = new_size;
		unchecked
		{
			if (((crnd_vector*)@this)->field_1 != startFrame.GetLocalsPointer<LocalVariables>()->field_1)
			{
				if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1 < (uint)((crnd_vector*)@this)->field_1)
				{
					destruct_array_dhbxund.Invoke(parameter_1: ((crnd_vector*)@this)->field_1 - startFrame.GetLocalsPointer<LocalVariables>()->field_1, parameter_0: (byte*)((crnd_vector*)@this)->field_0 + (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1);
				}
				else
				{
					if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1 > (uint)((crnd_vector*)@this)->field_2)
					{
						bool flag = increase_capacity_a7boycc.Invoke(grow_hint: startFrame.GetLocalsPointer<LocalVariables>()->field_1 == ((crnd_vector*)@this)->field_1 + 1, @this: @this, min_new_capacity: startFrame.GetLocalsPointer<LocalVariables>()->field_1);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (!flag)
						{
							startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
							goto IL_0169;
						}
					}
					construct_array_oifcoec.Invoke(n: startFrame.GetLocalsPointer<LocalVariables>()->field_1 - ((crnd_vector*)@this)->field_1, p: (byte*)((crnd_vector*)@this)->field_0 + (uint)((crnd_vector*)@this)->field_1);
				}
				((crnd_vector*)@this)->field_1 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
			}
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = true;
			goto IL_0169;
		}
		IL_0169:
		bool field_ = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
		StackFrameList.Current.Clear(startFrame);
		return field_;
	}
}
