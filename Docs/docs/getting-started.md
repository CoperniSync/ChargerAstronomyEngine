# Getting Started

This document provides instructions on how to set up a Developer environment for Stargazer.

It includes setting up the 3 individual repositories, as well as installing Unity and connecting it to the project.

## Requirements

- [Visual Studio](https://visualstudio.microsoft.com/downloads/)
- [Unity](https://unity.com/download)
- [.NET Core 2.1.x](https://dotnet.microsoft.com/en-us/download/dotnet/2.1)

## Cloning the repositories:

Create the 'ChargerAstronomyProject' directory:
```bash
cd ~/source/repos
mkdir ChargerAstronomyProject
```

Clone into the three repositories:
```bash
git clone https://github.com/CoperniSync/Stargazer.git
git clone https://github.com/CoperniSync/ChargerAstronomyShared.git
git clone https://github.com/CoperniSync/ChargerAstronomyEngine.git
```

## Initializing Stargazer in Unity

To set up Stargazer in Unity, you will first need to install Unity Hub.

After installing Unity hub, install editor `6000.2.0f1`. The project will not work with any other editor.

Select 'import project', and select the "ChargerAstronomyProject" directory. 