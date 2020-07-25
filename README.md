# Xunit.MSTest

[![NuGet package](https://img.shields.io/nuget/v/xunit.MSTest.svg)](https://nuget.org/packages/xunit.MSTest)

Adds XUnit backwards compatibility to MSTest to make the migration from MSTest to Xunit easier:
- Compiling code throughout the migration, i.e. side by side usage of MSTest and Xunit
- Obsolete tags with migration instructions

## Get Started

Step 1: Install nuget package [xunit.MSTest](https://www.nuget.org/packages/xunit.MSTest)

```diff
<ItemGroup>
  <PackageReference Include="Microsoft.NET.Test.Sdk" Version="16.5.0" />
-  <PackageReference Include="MSTest.TestAdapter" Version="2.1.0" />
-  <PackageReference Include="MSTest.TestFramework" Version="2.1.0" />
+  <PackageReference Include="xunit" Version="2.4.0" />
+  <PackageReference Include="xunit.runner.visualstudio" Version="2.4.0" />
+  <PackageReference Include="xunit.MSTest" Version="1.0.0" />
  <PackageReference Include="coverlet.collector" Version="1.2.0" />
</ItemGroup>
```

Step 2: Apply all suggested changes, e.g.

```diff
using Microsoft.VisualStudio.TestTools.UnitTesting;

-// Warning CS0618 'TestClassAttribute' is obsolete: 'Remove this attribute.'
-[TestClass]
public class UnitTest1
{
-  // Warning CS0618 'TestMethodAttribute' is obsolete: 'Use Fact instead.'
-  [TestMethod]
+  [Fact]
  public void TestMethod1()
  {
-    // Warning CS0618 'Assert.IsTrue(bool, string)' is obsolete: 'Use True instead.'
-    Assert.IsTrue(true);
+    Assert.True(true);
  }
}
```

Step 3: Switch to xunit

```diff
-using Microsoft.VisualStudio.TestTools.UnitTesting;
+using Xunit;

public class UnitTest1
{
```

Step 4: Remove backwards compatibility nuget package

```diff
<ItemGroup>
  <PackageReference Include="Microsoft.NET.Test.Sdk" Version="16.5.0" />
  <PackageReference Include="xunit" Version="2.4.0" />
  <PackageReference Include="xunit.runner.visualstudio" Version="2.4.0" />
-  <PackageReference Include="xunit.MSTest" Version="1.0.0" />
  <PackageReference Include="coverlet.collector" Version="1.2.0" />
</ItemGroup>
```

## Contribute

File an issue or provide a pull request.
