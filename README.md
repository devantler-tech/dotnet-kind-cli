# ⚗️ .NET Kind CLI

[![License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Test](https://github.com/devantler-tech/dotnet-kind-cli/actions/workflows/test.yaml/badge.svg)](https://github.com/devantler-tech/dotnet-kind-cli/actions/workflows/test.yaml)
[![codecov](https://codecov.io/gh/devantler-tech/dotnet-kind-cli/graph/badge.svg?token=RhQPb4fE7z)](https://codecov.io/gh/devantler-tech/dotnet-kind-cli)

A simple .NET library that embeds the Kind CLI.

## 🚀 Getting Started

## Prerequisites

- .NET 9.0 or later
- [Kind CLI](<https://kind.sigs.k8s.io/docs/user/quick-start/#installation>) installed and available in your system's PATH

## Installation

To get started, you can install the package from NuGet.

```sh
dotnet add package DevantlerTech.KindCLI
```

## 📝 Usage

You can execute the Kind CLI commands using the `Kind` class.

```csharp
using DevantlerTech.KindCLI;

var (exitCode, message) = await Kind.RunAsync(["arg1", "arg2"]);
```
