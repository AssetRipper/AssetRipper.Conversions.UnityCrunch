using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??A?$vector@I@crnd@@QEAAAEAII@Z")]
[DemangledName("public: unsigned int & __cdecl crnd::vector<unsigned int>::operator[](unsigned int)")]
[CleanName("Index")]
internal static partial class Index_rfutjka
{
	public unsafe static void* Invoke(void* @this, int i)
	{
		int num = 0;
		num = i;
		unchecked
		{
			int num2;
			if ((uint)num < (uint)((crnd_vector_5*)@this)->field_1)
			{
				num2 = -1;
			}
			else
			{
				crnd_assert.Invoke(String_ededlgd.__pointer, String_yguirrd.__pointer, 590);
				num2 = 0;
			}
			return (byte*)((crnd_vector_5*)@this)->field_0 + (nint)(uint)num * (nint)4;
		}
	}
}
