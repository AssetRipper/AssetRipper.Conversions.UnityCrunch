using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?resize@?$vector@I@crnd@@QEAA_NI@Z")]
[DemangledName("public: bool __cdecl crnd::vector<unsigned int>::resize(unsigned int)")]
[CleanName("resize")]
internal static partial class resize_a3d3m5b
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int new_size)
	{
		unchecked
		{
			if (((crnd_vector_maaktjc*)@this)->field_1 != new_size)
			{
				if ((uint)new_size < (uint)((crnd_vector_maaktjc*)@this)->field_1)
				{
					destruct_array_rsqiwgc.Invoke(parameter_1: ((crnd_vector_maaktjc*)@this)->field_1 - new_size, parameter_0: (byte*)((crnd_vector_maaktjc*)@this)->field_0 + (nint)(uint)new_size * (nint)4);
				}
				else
				{
					if ((uint)new_size > (uint)((crnd_vector_maaktjc*)@this)->field_2)
					{
						bool flag = increase_capacity_h5f4usb.Invoke(@this, new_size, new_size == ((crnd_vector_maaktjc*)@this)->field_1 + 1);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (!flag)
						{
							return false;
						}
					}
					construct_array_45u5mpd.Invoke(n: new_size - ((crnd_vector_maaktjc*)@this)->field_1, p: (byte*)((crnd_vector_maaktjc*)@this)->field_0 + (nint)(uint)((crnd_vector_maaktjc*)@this)->field_1 * (nint)4);
				}
				((crnd_vector_maaktjc*)@this)->field_1 = new_size;
			}
			return true;
		}
	}
}
