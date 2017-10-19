# Autofac.bug

```

Unhandled Exception: System.IO.FileNotFoundException: Could not load file or assembly 'System.ServiceModel.Primitives, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'. The system cannot find the file specified.
   at System.ModuleHandle.ResolveType(RuntimeModule module, Int32 typeToken, IntPtr* typeInstArgs, Int32 typeInstCount, IntPtr* methodInstArgs, Int32 methodInstCount, ObjectHandleOnStack type)
   at System.ModuleHandle.ResolveTypeHandleInternal(RuntimeModule module, Int32 typeToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext)
   at System.Reflection.RuntimeModule.ResolveType(Int32 metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
   at System.Reflection.CustomAttribute.FilterCustomAttributeRecord(CustomAttributeRecord caRecord, MetadataImport scope, Assembly& lastAptcaOkAssembly, RuntimeModule decoratedModule, MetadataToken decoratedToken, RuntimeType attributeFilterType, Boolean mustBeInheritable, Object[] attributes, IList derivedAttributes, RuntimeType& attributeType, IRuntimeMethodInfo& ctor, Boolean& ctorHasParameters, Boolean& isVarArg)
   at System.Reflection.CustomAttribute.GetCustomAttributes(RuntimeModule decoratedModule, Int32 decoratedMetadataToken, Int32 pcaCount, RuntimeType attributeFilterType, Boolean mustBeInheritable, IList derivedAttributes, Boolean isDecoratedTargetSecurityTransparent)
   at System.Reflection.CustomAttribute.GetCustomAttributes(RuntimeType type, RuntimeType caType, Boolean inherit)
   at System.Attribute.GetCustomAttributes(MemberInfo element, Type type, Boolean inherit)
   at System.Reflection.CustomAttributeExtensions.GetCustomAttributes[T](MemberInfo element)
   at Autofac.Util.TypeExtensions.IsCompilerGenerated(Type type)
   at Autofac.Features.Scanning.ScanningRegistrationExtensions.<>c__DisplayClass3_0.<ScanTypes>b__2(Type t)
   at System.Linq.Enumerable.WhereEnumerableIterator`1.MoveNext()
   at Autofac.Features.Scanning.ScanningRegistrationExtensions.ScanTypes(IEnumerable`1 types, IComponentRegistry cr, IRegistrationBuilder`3 rb)
   at Autofac.ContainerBuilder.Build(IComponentRegistry componentRegistry, Boolean excludeDefaultModules)
   at Autofac.ContainerBuilder.Build(ContainerBuildOptions options)
   at Autofac.ModuleRegistrationExtensions.RegisterAssemblyModules(IModuleRegistrar registrar, Type moduleType, Assembly[] assemblies)
   at Program.Main(String[] args) in C:\1\A\Program.cs:line 34

```



