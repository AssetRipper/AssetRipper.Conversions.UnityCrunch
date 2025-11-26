using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?clear@?$vector@E@crnd@@QEAAXXZ")]
[DemangledName("public: void __cdecl crnd::vector<unsigned char>::clear(void)")]
[CleanName("clear")]
internal static partial class clear_mzsqxg
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if (((crnd_vector_uksit8*)@this)->m_p != null)
			{
				destruct_array_s3iq3j.Invoke(parameter_1: ((crnd_vector_uksit8*)@this)->m_size, parameter_0: ((crnd_vector_uksit8*)@this)->m_p);
				crnd_free.Invoke(((crnd_vector_uksit8*)@this)->m_p);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				((crnd_vector_uksit8*)@this)->m_p = null;
				((crnd_vector_uksit8*)@this)->m_size = 0;
				((crnd_vector_uksit8*)@this)->m_capacity = 0;
			}
			((crnd_vector_uksit8*)@this)->m_alloc_failed = 0;
		}
	}
}
