using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?assign@?$vector@E@crnd@@QEAA_NAEBV12@@Z")]
[DemangledName("public: bool __cdecl crnd::vector<unsigned char>::assign(class crnd::vector<unsigned char> const &)")]
internal static partial class assign
{
	private partial struct LocalVariables
	{
		public bool field_0;

		public unsafe void* field_1;
	}

	public unsafe static bool Invoke(void* @this, void* other)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = other;
		unchecked
		{
			if (@this == startFrame.GetLocalsPointer<LocalVariables>()->field_1)
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = true;
			}
			else
			{
				if (((crnd_vector*)@this)->field_2 == ((crnd_vector*)startFrame.GetLocalsPointer<LocalVariables>()->field_1)->field_1)
				{
					resize_rzzl5xd.Invoke(@this, 0);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
				}
				else
				{
					clear_q4odfmb.Invoke(@this);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					bool flag = increase_capacity_a7boycc.Invoke(@this, ((crnd_vector*)startFrame.GetLocalsPointer<LocalVariables>()->field_1)->field_1, grow_hint: false);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (!flag)
					{
						startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
						goto IL_014e;
					}
				}
				llvm_memcpy_p0_p0_i64.Invoke(((crnd_vector*)@this)->field_0, ((crnd_vector*)startFrame.GetLocalsPointer<LocalVariables>()->field_1)->field_0, (long)(uint)((crnd_vector*)startFrame.GetLocalsPointer<LocalVariables>()->field_1)->field_1 * 1L, isVolatile: false);
				((crnd_vector*)@this)->field_1 = ((crnd_vector*)startFrame.GetLocalsPointer<LocalVariables>()->field_1)->field_1;
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = true;
			}
			goto IL_014e;
		}
		IL_014e:
		bool field_ = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
		StackFrameList.Current.Clear(startFrame);
		return field_;
	}
}
