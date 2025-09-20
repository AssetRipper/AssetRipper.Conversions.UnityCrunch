using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$crnd_delete_array@I@crnd@@YAXPEAI@Z")]
[DemangledName("void __cdecl crnd::crnd_delete_array<unsigned int>(unsigned int *)")]
[CleanName("crnd_delete_array")]
internal static partial class crnd_delete_array_nughn5d
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("unsigned int *")] void* p)
	{
		int num = 0;
		unchecked
		{
			if (p != null)
			{
				num = *(int*)((byte*)p + -4);
				int num2;
				if (num != 0 && num == (*(int*)((byte*)p + -8) ^ -1))
				{
					num2 = -1;
				}
				else
				{
					crnd_assert.Invoke(String_zzvckkc.__pointer, String_yguirrd.__pointer, 347);
					num2 = 0;
				}
				destruct_array_lrbdoxa.Invoke(p, num);
				crnd_free.Invoke((byte*)p + -8);
				if (ExceptionInfo.Current == null)
				{
				}
			}
		}
	}
}
