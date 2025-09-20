using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?assign@?$vector@E@crnd@@QEAA_NAEBV12@@Z")]
[DemangledName("public: bool __cdecl crnd::vector<unsigned char>::assign(class crnd::vector<unsigned char> const &)")]
internal static partial class assign
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("class crnd::vector<unsigned char> const &")] void* other)
	{
		bool flag = false;
		if (@this == other)
		{
			return true;
		}
		unchecked
		{
			if (((crnd_vector_f3cmzmc*)@this)->field_2 == ((crnd_vector_f3cmzmc*)other)->field_1)
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
				bool flag2 = increase_capacity_a7boycc.Invoke(@this, ((crnd_vector_f3cmzmc*)other)->field_1, grow_hint: false);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag2)
				{
					return false;
				}
			}
			llvm_memcpy_p0_p0_i64.Invoke(((crnd_vector_f3cmzmc*)@this)->field_0, ((crnd_vector_f3cmzmc*)other)->field_0, (long)(uint)((crnd_vector_f3cmzmc*)other)->field_1 * 1L, isVolatile: false);
			((crnd_vector_f3cmzmc*)@this)->field_1 = ((crnd_vector_f3cmzmc*)other)->field_1;
			return true;
		}
	}
}
