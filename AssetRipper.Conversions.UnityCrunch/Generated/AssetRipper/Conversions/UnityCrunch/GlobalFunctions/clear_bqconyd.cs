using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?clear@?$vector@G@crnd@@QEAAXXZ")]
[DemangledName("public: void __cdecl crnd::vector<unsigned short>::clear(void)")]
[CleanName("clear")]
internal static partial class clear_bqconyd
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if (((crnd_vector_rf9iywd*)@this)->field_0 != null)
			{
				destruct_array_l9jmj2b.Invoke(parameter_1: ((crnd_vector_rf9iywd*)@this)->field_1, parameter_0: ((crnd_vector_rf9iywd*)@this)->field_0);
				crnd_free.Invoke(((crnd_vector_rf9iywd*)@this)->field_0);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				((crnd_vector_rf9iywd*)@this)->field_0 = null;
				((crnd_vector_rf9iywd*)@this)->field_1 = 0;
				((crnd_vector_rf9iywd*)@this)->field_2 = 0;
			}
			((crnd_vector_rf9iywd*)@this)->field_3 = 0;
		}
	}
}
