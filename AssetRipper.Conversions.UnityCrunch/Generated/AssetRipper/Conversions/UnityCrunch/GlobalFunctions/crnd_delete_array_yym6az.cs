using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$crnd_delete_array@G@crnd@@YAXPEAG@Z")]
[DemangledName("void __cdecl crnd::crnd_delete_array<unsigned short>(unsigned short *)")]
[CleanName("crnd_delete_array")]
internal static partial class crnd_delete_array_yym6az
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("unsigned short *")] void* p)
	{
		unchecked
		{
			if (p != null)
			{
				int num = *(int*)((byte*)p + -4);
				if (num == 0 || num != (*(int*)((byte*)p + -8) ^ -1))
				{
					crnd_assert.Invoke(String_576cmw.__pointer, String_vvx8bt.__pointer, 347);
				}
				destruct_array_v2phiu.Invoke(p, num);
				crnd_free.Invoke((byte*)p + -8);
				if (ExceptionInfo.Current == null)
				{
				}
			}
		}
	}
}
