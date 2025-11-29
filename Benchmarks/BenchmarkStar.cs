using ChargerAstronomyShared.Contracts.Models;
using ChargerAstronomyShared.Domain.Equatorial;
using ChargerAstronomyShared.Domain.Horizontal;


// Simple wrapper over Ihorizontal (since the spatial index requires it, but we don't need its functionality for benchmarking) 
// it was more of a unity related thing 

public class BenchmarkStar : IHorizontal
{
    public HorizontalBody HorizontalBody { get; }

    public BenchmarkStar(EquatorialStar equatorialStar)
    {
        HorizontalBody = new HorizontalStar(equatorialStar);
    }

    public void SetState(bool visible) { }
    public void UpdatePosition() { }
}