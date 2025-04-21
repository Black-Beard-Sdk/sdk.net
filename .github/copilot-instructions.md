# Documentation rules
In the referenced document, generate documentation in English for C# code following these rules:
- For each object (class, interface, etc.):
    - Document the object header by analyzing its methods and properties.
- For methods and properties only if no documentation is already present, apply the following:
    - Do not modify the method implementation, only add XML documentation.
    - Include a concise description of the method’s behavior in a <remarks> block.
    - Specify constraints and details for each parameter in <param> tags.
    - List all possible exceptions that can be thrown in <exception> tags.
    - If the method is public, include a properly formatted example inside an <example> tag using <code lang="C#">. Ensure code formatting is correct, and replace < characters in generics with &lt;.
    - If the method returns a value (i.e., not void), describe the return value in a <returns> tag and include a <see> reference if applicable.
- For each property, add documentation describing its usage and reference where it is used in the project.


# Génération du fichier readme
You are an expert technical writer specialized in .NET libraries.
Your task is to generate a complete and professional README.md file in Markdown for a C# project.

## 🔍 Instructions:

Scan the entire project source code, detect and extract all public methods, classes, and extensions.

📄 The generated README.md must include the following sections, formatted with proper Markdown:

## Project Title
Extract the project name from the .csproj file and use it as the main title.

## Introduction
A clear explanation of the purpose and value of the package.
- What problems it solves.
- Why developers should use it.

## Installation
- List all prerequisites (.NET version, etc.).
- Show how to install the package via NuGet:

```sh
dotnet add package <PackageName>
```

## Features
- Use headings (###) to create a structured and scannable documentation of core features.
- For each feature group:
    - Provide a summary
    - Follow it with a code example in a csharp block:

```csharp
// Code example here
```

## Platform Compatibility
- List supported platforms and frameworks.
- Note any limitations or version constraints.

📌 Markdown formatting rules to follow:

- Use # to ###### headings for structure.
- Use proper bold, italic, and bold italic styles.
- Use - for lists and indentation for sub-lists.
- Format links using:
    - [Link text](https://example.com)
    - [Link with title](https://example.com "Title")
    - <https://example.com>
- Format images using:
    - ![Alt text](image-url.jpg)
    - ![Alt text](image-url.jpg "Optional title")

- All code must use triple backticks with language highlighting:
```csharp
// Code example here
```
