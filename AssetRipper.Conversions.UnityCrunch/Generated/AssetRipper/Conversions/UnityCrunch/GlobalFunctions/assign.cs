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
		if (@this == other)
		{
			return true;
		}
		unchecked
		{
			if (((crnd_vector_uksit8*)@this)->m_capacity == ((crnd_vector_uksit8*)other)->m_size)
			{
				resize_zpvfc7.Invoke(@this, 0);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
			}
			else
			{
				clear_mzsqxg.Invoke(@this);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				bool flag = increase_capacity_2iysmi.Invoke(@this, ((crnd_vector_uksit8*)other)->m_size, grow_hint: false);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag)
				{
					return false;
				}
			}
			llvm_memcpy_p0_p0_i64.Invoke(((crnd_vector_uksit8*)@this)->m_p, ((crnd_vector_uksit8*)other)->m_p, (long)(uint)((crnd_vector_uksit8*)other)->m_size * 1L, isVolatile: false);
			((crnd_vector_uksit8*)@this)->m_size = ((crnd_vector_uksit8*)other)->m_size;
			return true;
		}
	}
}
