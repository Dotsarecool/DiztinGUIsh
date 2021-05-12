﻿using System;
using System.Linq;
using System.Reflection;
using Diz.Core.export;
using Diz.Core.export.assemblyGenerators;
using Diz.Core.util;
using LightInject;
using Xunit;

namespace Diz.Test.Tests.UtilsTests
{
    // we're not using this stuff yet, this testbed is more a proof of concept to start with
    
    public interface ILogCreator
    {
        
    }
    
    public interface IAsm
    {
        
    }

    public class AsmGeneratorTypeAttribute : Attribute
    {
        public string Tag { get; private set; }
        public AsmGeneratorTypeAttribute(string tag)
        {
            Tag = tag;
        }   
    }
    
 
    
    [AsmGeneratorType("%map")]
    public class Asm1 : IAsm
    {
        public ILogCreator LogCreator { get; set; }
    }

    public class FakeLogCreator : ILogCreator
    {
        
    }

    public static class MiscTests
    {
        [Fact]
        public static void TestServiceContainer()
        {
            ServiceProvider.Register(
                typeof(AssemblyPartialLineGenerator).Assembly,
                typeof(IAssemblyPartialGenerator));

            var container = ServiceProvider.ServiceContainer;
            container.Register<ILogCreator, FakeLogCreator>();
            var tag = typeof(Asm1).GetCustomAttribute<AsmGeneratorTypeAttribute>()?.Tag;
            if (tag != null)
                container.Register<IAsm, Asm1>(tag);

            var foo = (Asm1) container.GetInstance<IAsm>("%map");
            Assert.NotNull(foo.LogCreator);

            Assert.True(ServiceProvider.ServiceContainer.AvailableServices
                .FirstOrDefault(s =>
                    s.ImplementingType == typeof(AssemblyGenerateComment)) != null);
        }
    }
}