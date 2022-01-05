using System;


namespace R5T.T0118
{
    /// <summary>
    /// Empty marker interface to communicate that the implementing type is a service test fixture.
    /// </summary>
    // Not itself marked with the service test fixture marker attribute to avoid erroneous identification as a service test fixture.
    public interface IServiceTestFixture
    {
    }
}