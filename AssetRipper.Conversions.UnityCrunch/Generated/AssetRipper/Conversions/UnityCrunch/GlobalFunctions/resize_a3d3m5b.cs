using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?resize@?$vector@I@crnd@@QEAA_NI@Z")]
[DemangledName("public: bool __cdecl crnd::vector<unsigned int>::resize(unsigned int)")]
[CleanName("resize")]
internal static partial class resize_a3d3m5b
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
			if (((crnd_vector_5*)@this)->field_1 != startFrame.GetLocalsPointer<LocalVariables>()->field_1)
			{
				if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1 < (uint)((crnd_vector_5*)@this)->field_1)
				{
					destruct_array_rsqiwgc.Invoke(parameter_1: ((crnd_vector_5*)@this)->field_1 - startFrame.GetLocalsPointer<LocalVariables>()->field_1, parameter_0: (byte*)((crnd_vector_5*)@this)->field_0 + (nint)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1 * (nint)4);
				}
				else
				{
					if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1 > (uint)((crnd_vector_5*)@this)->field_2)
					{
						bool flag = increase_capacity_h5f4usb.Invoke(grow_hint: startFrame.GetLocalsPointer<LocalVariables>()->field_1 == ((crnd_vector_5*)@this)->field_1 + 1, @this: @this, min_new_capacity: startFrame.GetLocalsPointer<LocalVariables>()->field_1);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (!flag)
						{
							startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
							goto IL_016d;
						}
					}
					construct_array_45u5mpd.Invoke(n: startFrame.GetLocalsPointer<LocalVariables>()->field_1 - ((crnd_vector_5*)@this)->field_1, p: (byte*)((crnd_vector_5*)@this)->field_0 + (nint)(uint)((crnd_vector_5*)@this)->field_1 * (nint)4);
				}
				((crnd_vector_5*)@this)->field_1 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
			}
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = true;
			goto IL_016d;
		}
		IL_016d:
		bool field_ = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
		StackFrameList.Current.Clear(startFrame);
		return field_;
	}
}
