# Instructions

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

## Notes

You can delete the `api` and `_site` folders freely. They will be recreated when the serve command is ran.

I don't recommend doing that unless you are updating documentation, though.
