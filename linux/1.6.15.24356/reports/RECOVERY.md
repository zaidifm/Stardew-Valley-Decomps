# Recovery notes

- ILSpy decompiler library: 11.0.0.9375 (user-supplied binary distribution).
- Runtime used to execute the exporter: user-supplied .NET SDK 10.0.400.
- Main assembly SHA-256: `f3e97f01d3fd2b1e6094fc8d2b59950aa6cb9d6cd1bf1b39d72d58edda8aad12`.
- GameData assembly SHA-256: `352e3b9189cdee588f88b1f956db368c56caf89e45258b0f75377f2225dcf311`.
- Main batch export: 954 top-level metadata types processed, 954 successful, 0 failures; 4 compiler-generated top-level types decompiled to empty standalone output and are omitted from the readable source tree.
- Readable main tree contains 950 non-empty recovered type files plus AssemblyInfo.
- GameData WholeProjectDecompiler export: 0 failures.

The full one-shot WholeProjectDecompiler for the main 6 MB assembly exceeded the container tool's 45-second execution window, so the same ILSpy decompiler was driven in deterministic top-level-type batches. This is a harness accommodation, not a recovery-quality downgrade. Nested types are emitted with their enclosing top-level type.
