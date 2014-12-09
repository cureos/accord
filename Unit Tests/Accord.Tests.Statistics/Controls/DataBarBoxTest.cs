﻿// Accord Unit Tests
// The Accord.NET Framework
// http://accord-framework.net
//
// Copyright © César Souza, 2009-2015
// cesarsouza at gmail.com
//
//    This library is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 2.1 of the License, or (at your option) any later version.
//
//    This library is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public
//    License along with this library; if not, write to the Free Software
//    Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
//

namespace Accord.Tests.Statistics
{
    using Accord.Statistics;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Accord.Math;
    using Accord;
    using System.Data;
    using Accord.Controls;
    using System;

    [TestClass()]
    public class DataBarBoxText
    {

        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod, Ignore]
        public void ComputeTest1()
        {
            double[] data = new double[] { 100.0, 150.0, 42.0 };
            string[] labels = { "1", "2", "3" };

            DataBarBox.Show(labels, data)
                .Hold();
        }

    }
}
