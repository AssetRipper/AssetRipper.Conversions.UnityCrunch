using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?clear@?$vector@I@crnd@@QEAAXXZ")]
[DemangledName("public: void __cdecl crnd::vector<unsigned int>::clear(void)")]
[CleanName("clear")]
internal static partial class clear_utei2oa
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if (((crnd_vector_maaktjc*)@this)->field_0 != null)
			{
				destruct_array_rsqiwgc.Invoke(parameter_1: ((crnd_vector_maaktjc*)@this)->field_1, parameter_0: ((crnd_vector_maaktjc*)@this)->field_0);
				crnd_free.Invoke(((crnd_vector_maaktjc*)@this)->field_0);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				((crnd_vector_maaktjc*)@this)->field_0 = null;
				((crnd_vector_maaktjc*)@this)->field_1 = 0;
				((crnd_vector_maaktjc*)@this)->field_2 = 0;
			}
			((crnd_vector_maaktjc*)@this)->field_3 = 0;
		}
	}
}
