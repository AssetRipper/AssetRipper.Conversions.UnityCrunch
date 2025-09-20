using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??4?$vector@E@crnd@@QEAAAEAV01@AEBV01@@Z")]
[DemangledName("public: class crnd::vector<unsigned char> & __cdecl crnd::vector<unsigned char>::operator=(class crnd::vector<unsigned char> const &)")]
internal static partial class vector_unsigned_char_Assignment
{
	[return: NativeType("class crnd::vector<unsigned char> &")]
	public unsafe static void* Invoke(void* @this, [NativeType("class crnd::vector<unsigned char> const &")] void* other)
	{
		assign.Invoke(@this, other);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		return @this;
	}
}
