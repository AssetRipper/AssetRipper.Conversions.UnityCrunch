using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?resize@?$vector@Ublock_buffer_element@crn_unpacker@crnd@@@crnd@@QEAA_NI@Z")]
[DemangledName("public: bool __cdecl crnd::vector<struct crnd::crn_unpacker::block_buffer_element>::resize(unsigned int)")]
[CleanName("resize")]
internal static partial class resize_kfwzjla
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
			if (((crnd_vector_11*)@this)->field_1 != startFrame.GetLocalsPointer<LocalVariables>()->field_1)
			{
				if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1 < (uint)((crnd_vector_11*)@this)->field_1)
				{
					destruct_array_h3fegud.Invoke(n: ((crnd_vector_11*)@this)->field_1 - startFrame.GetLocalsPointer<LocalVariables>()->field_1, p: (byte*)((crnd_vector_11*)@this)->field_0 + (nint)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1 * (nint)sizeof(crnd_crn_unpacker_block_buffer_element));
				}
				else
				{
					if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1 > (uint)((crnd_vector_11*)@this)->field_2)
					{
						bool flag = increase_capacity_ucojcwb.Invoke(grow_hint: startFrame.GetLocalsPointer<LocalVariables>()->field_1 == ((crnd_vector_11*)@this)->field_1 + 1, @this: @this, min_new_capacity: startFrame.GetLocalsPointer<LocalVariables>()->field_1);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (!flag)
						{
							startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
							goto IL_0177;
						}
					}
					construct_array_5afuwda.Invoke(n: startFrame.GetLocalsPointer<LocalVariables>()->field_1 - ((crnd_vector_11*)@this)->field_1, p: (byte*)((crnd_vector_11*)@this)->field_0 + (nint)(uint)((crnd_vector_11*)@this)->field_1 * (nint)sizeof(crnd_crn_unpacker_block_buffer_element));
				}
				((crnd_vector_11*)@this)->field_1 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
			}
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = true;
			goto IL_0177;
		}
		IL_0177:
		bool field_ = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
		StackFrameList.Current.Clear(startFrame);
		return field_;
	}
}
