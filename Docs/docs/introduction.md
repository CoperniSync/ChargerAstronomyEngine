# Introduction

This API serves as the official documentation of the Stagazer project. It's purpose is to describe the internal logic of the project.

The project is separated into 3 repositories.

1. ChargerAstronomyEngine - This is the "backend" of the project. It contains the data of astrological entities and the engine service that hosts astronomical position calculations.
2. ChargerAstronomyShared - This intermerdiate repository contains interfaces and class definitions for objects that are created or utilized by both ChargerAstronomyEngine and Stargazer.
3. Stargazer - This is the "frontend" of the project. It contains the Unity implementation of the Stargazer engine, including all Assets and Scripts inherited from the other repositories.

All data is loaded into the ChargerAstronomyEngine asynchronously on startup. The front end requests incremental pages of all objects through a queue to prevent overload. 