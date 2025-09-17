using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?increase_capacity@?$vector@Ublock_buffer_element@crn_unpacker@crnd@@@crnd@@AEAA_NI_N@Z")]
[DemangledName("private: bool __cdecl crnd::vector<struct crnd::crn_unpacker::block_buffer_element>::increase_capacity(unsigned int, bool)")]
[CleanName("increase_capacity")]
internal static partial class increase_capacity_ucojcwb
{
	private partial struct LocalVariables
	{
		public bool field_0;

		public int field_1;
	}

	public unsafe static bool Invoke(void* @this, int min_new_capacity, bool grow_hint)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		bool num = grow_hint;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = min_new_capacity;
		bool flag = increase_capacity_nb7lc5b.Invoke(@this, startFrame.GetLocalsPointer<LocalVariables>()->field_1, ((num ? 1u : 0u) & 1u) == 1, 8, null);
		if (ExceptionInfo.Current != null)
		{
			return false;
		}
		if (!flag)
		{
			unchecked((crnd_vector_11*)@this)->field_3 = 1;
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		}
		else
		{
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = true;
		}
		bool field_ = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
		StackFrameList.Current.Clear(startFrame);
		return field_;
	}
}
