# ChargerAstronomyEngine

This repository serves as the "backend" of the Stargazer project. It contains the classes used for celestial calculations, spatial indexing, heat indexing, and creating object queues. It also contains the classes used to parse celestial object data from files to insantiate them as equatorial and horizontal objects.

The engine also contains project benchmarks, documentation, and tests.

## Data

The Data directory contains all of the classes used to instantiate celestial objects from files. They are seperated based on type of object.

## Streaming

The Streaming directory contains the main services of the engine.

- The equatorial calculator provides new coordinates for horizontal stars and solar system bodies based on their current equatorial coordinates.

- The heat service adjusts the heat values of tiles in the current spatial index based on camera position and observer location.

- The engine service is the main class of the backend. It manages all of the backend services, primarily the afformentioned two.
