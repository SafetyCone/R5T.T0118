using System;

using R5T.T0143;


namespace R5T.T0118
{
    /// <summary>
    /// Marks an interface as being a service text fixture. Not inherited, as deriving classes will just be "tests", not a text fixture.
    /// Also allows specifying that a class is *not* a service test fixture. (Useful for decorating extraneous types that also happen to be in a service test fixtures directory/file.)
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    [MarkerAttributeMarker]
    public class ServiceTestFixtureMarkerAttribute : Attribute
    {
        private readonly bool zIsServiceTestFixture;
        public bool IsServiceTestFixture
        {
            get
            {
                return this.zIsServiceTestFixture;
            }
        }


        public ServiceTestFixtureMarkerAttribute(
            bool isServiceTestFixture = true)
        {
            this.zIsServiceTestFixture = isServiceTestFixture;
        }
    }
}