#Instructions

To open DocFX locally:


Ensure you have [.NET SDK](https://dotnet.microsoft.com/en-us/download) 8.0 or higher:

```bash
dotnet --info
```

Install latest docfx:

```bash
dotnet tool update -g docfx
```

Preview the website at <http://localhost:8080>

```bash
docfx docfx.json --serve
```