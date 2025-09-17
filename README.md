# AssetRipper.Conversions.UnityCrunch

Translation of [Unity's modified crunch](https://github.com/Unity-Technologies/crunch/tree/unity) for use in C#.

## Generation

### LLVM IR

```
clang -S source.cpp -o source.ll -emit-llvm -w -g -fno-discard-value-names -fstandalone-debug
```

### C# Code

```
AssetRipper.Translation.LlvmIR.exe
source.ll
--namespace AssetRipper.Conversions.UnityCrunch
--module-name AssetRipper.Conversions.UnityCrunch
--class-name UnityCrunch
--decompile-directory
./AssetRipper.Conversions.UnityCrunch/Generated
```
