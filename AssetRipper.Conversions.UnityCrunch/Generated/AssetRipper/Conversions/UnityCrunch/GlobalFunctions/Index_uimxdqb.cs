using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??A?$vector@G@crnd@@QEAAAEAGI@Z")]
[DemangledName("public: unsigned short & __cdecl crnd::vector<unsigned short>::operator[](unsigned int)")]
[CleanName("Index")]
internal static partial class Index_uimxdqb
{
	public unsafe static void* Invoke(void* @this, int i)
	{
		int num = 0;
		num = i;
		unchecked
		{
			int num2;
			if ((uint)num < (uint)((crnd_vector_8*)@this)->field_1)
			{
				num2 = -1;
			}
			else
			{
				crnd_assert.Invoke(String_ededlgd.__pointer, String_yguirrd.__pointer, 590);
				num2 = 0;
			}
			return (byte*)((crnd_vector_8*)@this)->field_0 + (nint)(uint)num * (nint)2;
		}
	}
}
