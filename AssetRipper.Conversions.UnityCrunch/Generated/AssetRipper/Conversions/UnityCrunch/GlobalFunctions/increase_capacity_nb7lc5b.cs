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
		public bool field_0;

		public unsafe void* field_1;

		public int field_2;

		public sbyte field_3;

		public int field_4;

		public int field_5;

		public int field_6;

		public long field_7;

		public unsafe void* field_8;

		public unsafe void* field_9;
	}

	public unsafe static bool Invoke(void* @this, int min_new_capacity, bool grow_hint, int element_size, void* pMover)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_4 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_5 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_6 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_7 = 0L;
		startFrame.GetLocalsPointer<LocalVariables>()->field_8 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_9 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = pMover;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = element_size;
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = (grow_hint ? ((sbyte)1) : ((sbyte)0));
		startFrame.GetLocalsPointer<LocalVariables>()->field_4 = min_new_capacity;
		unchecked
		{
			int num;
			if ((uint)((crnd_elemental_vector*)@this)->field_1 <= (uint)((crnd_elemental_vector*)@this)->field_2)
			{
				num = -1;
			}
			else
			{
				crnd_assert.Invoke(String_vmviqdc.__pointer, String_yguirrd.__pointer, 1659);
				num = 0;
			}
			int num2;
			if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_4 < 2147418112u / (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2)
			{
				num2 = -1;
			}
			else
			{
				crnd_assert.Invoke(String_hbzy3qd.__pointer, String_yguirrd.__pointer, 1660);
				num2 = 0;
			}
			if ((uint)((crnd_elemental_vector*)@this)->field_2 >= (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_4)
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = true;
			}
			else
			{
				int field_ = startFrame.GetLocalsPointer<LocalVariables>()->field_4;
				startFrame.GetLocalsPointer<LocalVariables>()->field_5 = field_;
				if ((startFrame.GetLocalsPointer<LocalVariables>()->field_3 & 1) == 1 && !is_power_of_2.Invoke(startFrame.GetLocalsPointer<LocalVariables>()->field_5))
				{
					int field_2 = next_pow2.Invoke(startFrame.GetLocalsPointer<LocalVariables>()->field_5);
					startFrame.GetLocalsPointer<LocalVariables>()->field_5 = field_2;
				}
				int num3;
				if (startFrame.GetLocalsPointer<LocalVariables>()->field_5 != 0 && (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_5 > (uint)((crnd_elemental_vector*)@this)->field_2)
				{
					num3 = -1;
				}
				else
				{
					crnd_assert.Invoke(String_rugjm7a.__pointer, String_yguirrd.__pointer, 1669);
					num3 = 0;
				}
				int field_3 = startFrame.GetLocalsPointer<LocalVariables>()->field_2 * startFrame.GetLocalsPointer<LocalVariables>()->field_5;
				startFrame.GetLocalsPointer<LocalVariables>()->field_6 = field_3;
				if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 == null)
				{
					void* field_4 = crnd_realloc.Invoke(size: (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_6, p: ((crnd_elemental_vector*)@this)->field_0, pActual_size: &startFrame.GetLocalsPointer<LocalVariables>()->field_7, movable: true);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					startFrame.GetLocalsPointer<LocalVariables>()->field_8 = field_4;
					if (startFrame.GetLocalsPointer<LocalVariables>()->field_8 != null)
					{
						((crnd_elemental_vector*)@this)->field_0 = startFrame.GetLocalsPointer<LocalVariables>()->field_8;
						goto IL_03ed;
					}
					startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
				}
				else
				{
					void* field_5 = crnd_malloc.Invoke((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_6, &startFrame.GetLocalsPointer<LocalVariables>()->field_7);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					startFrame.GetLocalsPointer<LocalVariables>()->field_9 = field_5;
					if (startFrame.GetLocalsPointer<LocalVariables>()->field_9 != null)
					{
						void* field_6 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
						int field_7 = ((crnd_elemental_vector*)@this)->field_1;
						void* field_8 = ((crnd_elemental_vector*)@this)->field_0;
						((delegate*<void*, void*, int, void>)field_6)(startFrame.GetLocalsPointer<LocalVariables>()->field_9, field_8, field_7);
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
						((crnd_elemental_vector*)@this)->field_0 = startFrame.GetLocalsPointer<LocalVariables>()->field_9;
						goto IL_03ed;
					}
					startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
				}
			}
			goto IL_0462;
		}
		IL_0462:
		bool field_9 = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
		StackFrameList.Current.Clear(startFrame);
		return field_9;
		IL_03ed:
		unchecked
		{
			if ((ulong)startFrame.GetLocalsPointer<LocalVariables>()->field_7 > (ulong)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_6)
			{
				((crnd_elemental_vector*)@this)->field_2 = (int)((ulong)startFrame.GetLocalsPointer<LocalVariables>()->field_7 / (ulong)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2);
			}
			else
			{
				((crnd_elemental_vector*)@this)->field_2 = startFrame.GetLocalsPointer<LocalVariables>()->field_5;
			}
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = true;
			goto IL_0462;
		}
	}
}
