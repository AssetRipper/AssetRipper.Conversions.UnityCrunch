using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??0crn_unpacker@crnd@@QEAA@XZ")]
[DemangledName("public: __cdecl crnd::crn_unpacker::crn_unpacker(void)")]
internal static partial class crn_unpacker_Constructor
{
	public unsafe static void* Invoke(void* @this)
	{
		unchecked
		{
			((crnd_crn_unpacker*)@this)->field_0 = 519686845;
			((crnd_crn_unpacker*)@this)->field_1 = null;
			((crnd_crn_unpacker*)@this)->field_2 = 0;
			((crnd_crn_unpacker*)@this)->field_3 = null;
			symbol_codec_Constructor.Invoke(&((crnd_crn_unpacker*)@this)->field_4);
			crnd_static_huffman_data_model* field_ = &((crnd_crn_unpacker*)@this)->field_5;
			static_huffman_data_model_Constructor_tl33idc.Invoke(field_);
			InlineArray2_crnd_static_huffman_data_model* field_2 = &((crnd_crn_unpacker*)@this)->field_6;
			crnd_static_huffman_data_model* ptr = (crnd_static_huffman_data_model*)field_2;
			crnd_static_huffman_data_model* ptr2 = ptr + 2L;
			crnd_static_huffman_data_model* intPtr = ptr;
			while (true)
			{
				void* ptr3 = intPtr;
				static_huffman_data_model_Constructor_tl33idc.Invoke(ptr3);
				if (ExceptionInfo.Current == null)
				{
					crnd_static_huffman_data_model* ptr4 = (crnd_static_huffman_data_model*)ptr3 + 1;
					if (ptr4 != ptr2)
					{
						intPtr = ptr4;
						continue;
					}
					InlineArray2_crnd_static_huffman_data_model* field_3 = &((crnd_crn_unpacker*)@this)->field_7;
					crnd_static_huffman_data_model* ptr5 = (crnd_static_huffman_data_model*)field_3;
					crnd_static_huffman_data_model* ptr6 = ptr5 + 2L;
					crnd_static_huffman_data_model* intPtr2 = ptr5;
					while (true)
					{
						void* ptr7 = intPtr2;
						static_huffman_data_model_Constructor_tl33idc.Invoke(ptr7);
						if (ExceptionInfo.Current == null)
						{
							crnd_static_huffman_data_model* ptr8 = (crnd_static_huffman_data_model*)ptr7 + 1;
							if (ptr8 != ptr6)
							{
								intPtr2 = ptr8;
								continue;
							}
							crnd_vector_maaktjc* field_4 = &((crnd_crn_unpacker*)@this)->field_8;
							vector_unsigned_int_Constructor.Invoke(field_4);
							if (ExceptionInfo.Current == null)
							{
								crnd_vector_maaktjc* field_5 = &((crnd_crn_unpacker*)@this)->field_9;
								vector_unsigned_int_Constructor.Invoke(field_5);
								if (ExceptionInfo.Current == null)
								{
									crnd_vector_rf9iywd* field_6 = &((crnd_crn_unpacker*)@this)->field_10;
									vector_unsigned_short_Constructor.Invoke(field_6);
									if (ExceptionInfo.Current == null)
									{
										crnd_vector_rf9iywd* field_7 = &((crnd_crn_unpacker*)@this)->field_11;
										vector_unsigned_short_Constructor.Invoke(field_7);
										if (ExceptionInfo.Current == null)
										{
											vector_struct_crnd_crn_unpacker_block_buffer_element_Constructor.Invoke(&((crnd_crn_unpacker*)@this)->field_12);
											if (ExceptionInfo.Current == null)
											{
												return @this;
											}
											ExceptionInfo current = ExceptionInfo.Current;
											ExceptionInfo.Current = null;
											vector_unsigned_short_Destructor.Invoke(field_7);
											if (ExceptionInfo.Current != null)
											{
												return null;
											}
											ExceptionInfo.Current = current;
										}
										ExceptionInfo current2 = ExceptionInfo.Current;
										ExceptionInfo.Current = null;
										vector_unsigned_short_Destructor.Invoke(field_6);
										if (ExceptionInfo.Current != null)
										{
											return null;
										}
										ExceptionInfo.Current = current2;
									}
									ExceptionInfo current3 = ExceptionInfo.Current;
									ExceptionInfo.Current = null;
									vector_unsigned_int_Destructor.Invoke(field_5);
									if (ExceptionInfo.Current != null)
									{
										return null;
									}
									ExceptionInfo.Current = current3;
								}
								ExceptionInfo current4 = ExceptionInfo.Current;
								ExceptionInfo.Current = null;
								vector_unsigned_int_Destructor.Invoke(field_4);
								if (ExceptionInfo.Current != null)
								{
									return null;
								}
								ExceptionInfo.Current = current4;
							}
							ExceptionInfo current5 = ExceptionInfo.Current;
							ExceptionInfo.Current = null;
							crnd_static_huffman_data_model* ptr9 = (crnd_static_huffman_data_model*)field_3;
							nint num = (nint)(ptr9 + 2L);
							while (true)
							{
								crnd_static_huffman_data_model* ptr10 = (crnd_static_huffman_data_model*)(num + (nint)(-1) * sizeof(crnd_static_huffman_data_model));
								static_huffman_data_model_Destructor.Invoke(ptr10);
								if (ExceptionInfo.Current != null)
								{
									return null;
								}
								if (ptr10 == ptr9)
								{
									break;
								}
								num = (nint)ptr10;
							}
							ExceptionInfo.Current = current5;
							break;
						}
						ExceptionInfo current6 = ExceptionInfo.Current;
						ExceptionInfo.Current = null;
						if (ptr5 != ptr7)
						{
							nint num2 = (nint)ptr7;
							while (true)
							{
								crnd_static_huffman_data_model* ptr11 = (crnd_static_huffman_data_model*)(num2 + (nint)(-1) * sizeof(crnd_static_huffman_data_model));
								static_huffman_data_model_Destructor.Invoke(ptr11);
								if (ExceptionInfo.Current != null)
								{
									return null;
								}
								if (ptr11 == ptr5)
								{
									break;
								}
								num2 = (nint)ptr11;
							}
						}
						ExceptionInfo.Current = current6;
						break;
					}
					ExceptionInfo current7 = ExceptionInfo.Current;
					ExceptionInfo.Current = null;
					crnd_static_huffman_data_model* ptr12 = (crnd_static_huffman_data_model*)field_2;
					nint num3 = (nint)(ptr12 + 2L);
					while (true)
					{
						crnd_static_huffman_data_model* ptr13 = (crnd_static_huffman_data_model*)(num3 + (nint)(-1) * sizeof(crnd_static_huffman_data_model));
						static_huffman_data_model_Destructor.Invoke(ptr13);
						if (ExceptionInfo.Current != null)
						{
							return null;
						}
						if (ptr13 == ptr12)
						{
							break;
						}
						num3 = (nint)ptr13;
					}
					ExceptionInfo.Current = current7;
					break;
				}
				ExceptionInfo current8 = ExceptionInfo.Current;
				ExceptionInfo.Current = null;
				if (ptr != ptr3)
				{
					nint num4 = (nint)ptr3;
					while (true)
					{
						crnd_static_huffman_data_model* ptr14 = (crnd_static_huffman_data_model*)(num4 + (nint)(-1) * sizeof(crnd_static_huffman_data_model));
						static_huffman_data_model_Destructor.Invoke(ptr14);
						if (ExceptionInfo.Current != null)
						{
							return null;
						}
						if (ptr14 == ptr)
						{
							break;
						}
						num4 = (nint)ptr14;
					}
				}
				ExceptionInfo.Current = current8;
				break;
			}
			ExceptionInfo current9 = ExceptionInfo.Current;
			ExceptionInfo.Current = null;
			static_huffman_data_model_Destructor.Invoke(field_);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			ExceptionInfo.Current = current9;
			return null;
		}
	}
}
