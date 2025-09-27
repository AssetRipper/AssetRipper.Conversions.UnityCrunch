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
		localsPointer->field_0 = 0L;
		sbyte b = (grow_hint ? ((sbyte)1) : ((sbyte)0));
		bool flag;
		int num;
		int num2;
		unchecked
		{
			if ((uint)((crnd_elemental_vector*)@this)->m_size > (uint)((crnd_elemental_vector*)@this)->m_capacity)
			{
				crnd_assert.Invoke(String_vmviqdc.__pointer, String_yguirrd.__pointer, 1659);
			}
			if ((uint)min_new_capacity >= 2147418112u / (uint)element_size)
			{
				crnd_assert.Invoke(String_hbzy3qd.__pointer, String_yguirrd.__pointer, 1660);
			}
			if ((uint)((crnd_elemental_vector*)@this)->m_capacity >= (uint)min_new_capacity)
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
				if (num == 0 || (uint)num <= (uint)((crnd_elemental_vector*)@this)->m_capacity)
				{
					crnd_assert.Invoke(String_rugjm7a.__pointer, String_yguirrd.__pointer, 1669);
				}
				num2 = element_size * num;
				if (pMover == null)
				{
					void* ptr = crnd_realloc.Invoke(((crnd_elemental_vector*)@this)->m_p, (uint)num2, &localsPointer->field_0, movable: true);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					void* ptr2 = ptr;
					if (ptr2 != null)
					{
						((crnd_elemental_vector*)@this)->m_p = ptr2;
						goto IL_0203;
					}
					flag = false;
				}
				else
				{
					void* ptr3 = crnd_malloc.Invoke((uint)num2, &localsPointer->field_0);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					void* ptr4 = ptr3;
					if (ptr4 != null)
					{
						void* ptr5 = pMover;
						int size = ((crnd_elemental_vector*)@this)->m_size;
						((delegate*<void*, void*, int, void>)ptr5)(ptr4, ((crnd_elemental_vector*)@this)->m_p, size);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (((crnd_elemental_vector*)@this)->m_p != null)
						{
							crnd_free.Invoke(((crnd_elemental_vector*)@this)->m_p);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
						}
						((crnd_elemental_vector*)@this)->m_p = ptr4;
						goto IL_0203;
					}
					flag = false;
				}
			}
			goto IL_023e;
		}
		IL_0203:
		unchecked
		{
			if ((ulong)localsPointer->field_0 > (ulong)(uint)num2)
			{
				((crnd_elemental_vector*)@this)->m_capacity = (int)((ulong)localsPointer->field_0 / (ulong)(uint)element_size);
			}
			else
			{
				((crnd_elemental_vector*)@this)->m_capacity = num;
			}
			flag = true;
			goto IL_023e;
		}
		IL_023e:
		bool result = flag;
		StackFrameList.Current.Clear(startFrame);
		return result;
	}
}
