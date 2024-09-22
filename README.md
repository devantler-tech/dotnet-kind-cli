# ⚗️ .NET Kind CLI

[![License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Test](https://github.com/devantler/dotnet-kind-cli/actions/workflows/test.yaml/badge.svg)](https://github.com/devantler/dotnet-kind-cli/actions/workflows/test.yaml)
[![codecov](https://codecov.io/gh/devantler/dotnet-kind-cli/graph/badge.svg?token=RhQPb4fE7z)](https://codecov.io/gh/devantler/dotnet-kind-cli)

<details>
  <summary>Show/hide folder structure</summary>

<!-- readme-tree start -->
```
.
├── .github
│   ├── scripts
│   └── workflows
├── Devantler.KindCLI
│   └── runtimes
│       ├── linux-arm64
│       │   └── native
│       ├── linux-x64
│       │   └── native
│       ├── osx-arm64
│       │   └── native
│       ├── osx-x64
│       │   └── native
│       └── win-x64
│           └── native
└── Devantler.KindCLI.Tests
    ├── KindTests
    └── assets

18 directories
```
<!-- readme-tree end -->

</details>

A simple .NET library that embeds the Kind CLI.

## 🚀 Getting Started

To get started, you can install the package from NuGet.

```bash
dotnet add package Devantler.KindCLI
```

## 📝 Usage

You can execute the Kind CLI commands using the `Kind` class.

```csharp
using Devantler.KindCLI;

// Create a new Kind cluster
_ = await Kind.CreateClusterAsync("my-cluster", "path/to/kind-config.yaml", cancellationToken);

// List all Kind clusters
_ = await Kind.ListClustersAsync(cancellationToken);

// Stop a Kind cluster
_ = await Kind.StopClusterAsync("my-cluster", cancellationToken);

// Start a Kind cluster
_ = await Kind.StartClusterAsync("my-cluster", cancellationToken);

// Delete a Kind cluster
_ = await Kind.DeleteClusterAsync("my-cluster", cancellationToken);
```
