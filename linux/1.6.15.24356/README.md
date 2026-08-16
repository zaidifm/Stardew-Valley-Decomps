# Stardew Valley Linux 1.6.15.24356

Current Steam/Linux managed-code recovery.

- Target: `Stardew Valley 1.6.15.24356`
- Runtime target: `linux-x64`, .NET 6
- Recovery: ILSpy 11 against the actual shipped managed assemblies
- Main assembly inventory: 1,887 total types, 18,367 methods, 17,741 methods with ordinary IL bodies
- Main recovered source: 950 non-empty top-level source units plus assembly metadata
- GameData recovered source: 168 C# files
- Recorded decompilation failures: zero

Original game DLLs and Content assets are not committed. The `manifests/` directory records binary/content provenance and searchable metadata indexes.
