using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?increase_capacity@elemental_vector@crnd@@QEAA_NI_NIP6AXPEAX1I@Z@Z")]
[DemangledName("public: bool __cdecl crnd::elemental_vector::increase_capacity(unsigned int, bool, unsigned int, void (__cdecl *)(void *, void *, unsigned int))")]
[CleanName("increase_capacity")]
internal static partial class increase_capacity_nb7lc5b
{
	private partial struct LocalVariables
	{
		public long field_0;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int min_new_capacity, [NativeType("bool")] bool grow_hint, [NativeType("unsigned int")] int element_size, [NativeType("void (__cdecl *)(void *, void *, unsigned int)")] void* pMover)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		bool flag = false;
		int num = 0;
		int num2 = 0;
		localsPointer->field_0 = 0L;
		void* ptr = null;
		void* ptr2 = null;
		sbyte b = (grow_hint ? ((sbyte)1) : ((sbyte)0));
		unchecked
		{
			int num3;
			if ((uint)((crnd_elemental_vector*)@this)->field_1 <= (uint)((crnd_elemental_vector*)@this)->field_2)
			{
				num3 = -1;
			}
			else
			{
				crnd_assert.Invoke(String_vmviqdc.__pointer, String_yguirrd.__pointer, 1659);
				num3 = 0;
			}
			int num4;
			if ((uint)min_new_capacity < 2147418112u / (uint)element_size)
			{
				num4 = -1;
			}
			else
			{
				crnd_assert.Invoke(String_hbzy3qd.__pointer, String_yguirrd.__pointer, 1660);
				num4 = 0;
			}
			if ((uint)((crnd_elemental_vector*)@this)->field_2 >= (uint)min_new_capacity)
			{
				flag = true;
			}
			else
			{
				num = min_new_capacity;
				if ((b & 1) == 1 && !is_power_of_2.Invoke(num))
				{
					num = next_pow2.Invoke(num);
				}
				int num5;
				if (num != 0 && (uint)num > (uint)((crnd_elemental_vector*)@this)->field_2)
				{
					num5 = -1;
				}
				else
				{
					crnd_assert.Invoke(String_rugjm7a.__pointer, String_yguirrd.__pointer, 1669);
					num5 = 0;
				}
				num2 = element_size * num;
				if (pMover == null)
				{
					void* ptr3 = crnd_realloc.Invoke(((crnd_elemental_vector*)@this)->field_0, (uint)num2, &localsPointer->field_0, movable: true);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					ptr = ptr3;
					if (ptr != null)
					{
						((crnd_elemental_vector*)@this)->field_0 = ptr;
						goto IL_0203;
					}
					flag = false;
				}
				else
				{
					void* ptr4 = crnd_malloc.Invoke((uint)num2, &localsPointer->field_0);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					ptr2 = ptr4;
					if (ptr2 != null)
					{
						void* ptr5 = pMover;
						int field_ = ((crnd_elemental_vector*)@this)->field_1;
						((delegate*<void*, void*, int, void>)ptr5)(ptr2, ((crnd_elemental_vector*)@this)->field_0, field_);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (((crnd_elemental_vector*)@this)->field_0 != null)
						{
							crnd_free.Invoke(((crnd_elemental_vector*)@this)->field_0);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
						}
						((crnd_elemental_vector*)@this)->field_0 = ptr2;
						goto IL_0203;
					}
					flag = false;
				}
			}
			goto IL_023e;
		}
		IL_023e:
		bool result = flag;
		StackFrameList.Current.Clear(startFrame);
		return result;
		IL_0203:
		unchecked
		{
			if ((ulong)localsPointer->field_0 > (ulong)(uint)num2)
			{
				((crnd_elemental_vector*)@this)->field_2 = (int)((ulong)localsPointer->field_0 / (ulong)(uint)element_size);
			}
			else
			{
				((crnd_elemental_vector*)@this)->field_2 = num;
			}
			flag = true;
			goto IL_023e;
		}
	}
}
