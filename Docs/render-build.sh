#!/usr/bin/env bash

wget https://github.com/dotnet/docfx/releases/download/v2.77.0/docfx-linux-x64-v2.77.0.zip
unzip -o docfx-linux-x64-v2.77.0.zip -d docfx

# Build from repo root
cd Docs
../docfx/docfx build docfx.json
