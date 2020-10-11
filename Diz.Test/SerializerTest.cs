﻿using System.Xml;
using Diz.Core.model;
using Diz.Core.serialization.xml_serializer;
using Diz.Core.util;
using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using IX.Observable;
using IX.StandardExtensions;
using Xunit;
using Xunit.Abstractions;

namespace Diz.Test
{
    public class SerializerTest
    {
        private readonly ITestOutputHelper testOutputHelper;

        public SerializerTest(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        public class TestRoot
        {
            public ObservableDictionary<int, string> ODW { get; set; } = new ObservableDictionary<int, string>() {
                {1, "Z test1"},
                {2, "Z test3"},
            };
            public ObservableDictionary<int, Label> ODW2 { get; set; } = new ObservableDictionary<int, Label>() {
                {100, new Label {comment = "c1", name = "location1"}},
                {200, new Label {comment = "c2", name = "location2"}},
            };

            #region Equality
            protected bool Equals(TestRoot other)
            {
                return
                    System.Linq.Enumerable.SequenceEqual(ODW, other.ODW) &&
                    System.Linq.Enumerable.SequenceEqual(ODW2, other.ODW2);
            }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != this.GetType()) return false;
                return Equals((TestRoot)obj);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    return ((ODW != null ? ODW.GetHashCode() : 0) * 397) ^ (ODW2 != null ? ODW2.GetHashCode() : 0);
                }
            }
            #endregion
        }

        private static IConfigurationContainer GetSerializer()
        {
            return XmlSerializerSupport.GetSerializer()
                .EnableImplicitTyping(typeof(TestRoot));
        }

        [Fact]
        private void Serializer()
        {
            var serializer = GetSerializer().Create();

            var xmlStr = serializer.Serialize(
                new XmlWriterSettings() {},
                testRootElementGood);

            testOutputHelper.WriteLine(xmlStr);

            Assert.Equal(xmlShouldBe, xmlStr);
        }

        [Fact]
        private void DeSerialize()
        {
            var serializer = GetSerializer().Create();
            var restoredRoot = serializer.Deserialize<TestRoot>(xmlShouldBe);

            Assert.Equal(testRootElementGood, restoredRoot);
        }

        private readonly TestRoot testRootElementGood = new TestRoot();

        string xmlShouldBe = "<?xml version=\"1.0\" encoding=\"utf-8\"?><SerializerTest-TestRoot xmlns:ns1=\"clr-namespace:IX.Observable;assembly=IX.Observable\" xmlns:sys=\"https://extendedxmlserializer.github.io/system\" xmlns:exs=\"https://extendedxmlserializer.github.io/v2\" xmlns:ns2=\"clr-namespace:Diz.Core.model;assembly=Diz.Core\"><ODW AutomaticallyCaptureSubItems=\"false\" HistoryLevels=\"50\"><sys:Item Key=\"1\" Value=\"Z test1\" /><sys:Item Key=\"2\" Value=\"Z test3\" /></ODW><ODW2 AutomaticallyCaptureSubItems=\"false\" HistoryLevels=\"50\"><sys:Item Key=\"100\"><Value name=\"location1\" comment=\"c1\" /></sys:Item><sys:Item Key=\"200\"><Value name=\"location2\" comment=\"c2\" /></sys:Item></ODW2></SerializerTest-TestRoot>";
    }
}