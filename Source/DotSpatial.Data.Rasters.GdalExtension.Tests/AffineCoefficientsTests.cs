// Copyright (c) DotSpatial Team. All rights reserved.
// Licensed under the MIT license. See License.txt file in the project root for full license information.

using System;
using DotSpatial.Data.Rasters.GdalExtension;
using GeoAPI.Geometries;
using NUnit.Framework;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;

namespace DotSpatial.Data.Tests
{
    /// <summary>
    /// This is a class testing the implementation of affine coefficients.
    /// </summary>
    [TestClass]
    public class AffineCoefficientsTests
    {
        #region Methods

        /// <summary>
        /// A test for affine coefficients in GdalRaster: use gdal to load a raster file with
        /// known geolocation and test the location of the center of the first grid cell.
        /// Without a half-cell shift applied to the origin of the grid in GdalRaster.ReadHeader,
        /// this test fails because affine coefficients are defined differently in gdal and dotspatial.
        /// </summary>
        [TestMethod]
        public void GdalRasterTest()
        {
            var rp = new GdalRasterProvider();
            var raster = rp.Open(@"Data\Grids\sample_geotiff.tif");
            var at = new AffineTransform(raster.Bounds.AffineCoefficients);
            Assert.AreEqual(at.CellCenterToProj(0, 0), new Coordinate(-179.9499969, 89.9499969)); // correct location from sample_geotiff.tfw
        }

        #endregion
    }
}