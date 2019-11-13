using NUnit.Framework;

namespace DotSpatial.Projections.Tests
{
    [SetUpFixture]
    public class AssemblyInit
    {
        [OneTimeSetUp]
        public void RunBeforeAnyTests()
        {
            GridShift.InitializeExternalGrids("GeogTransformGrids", false);
        }
    }
}

