# 就不能不换DB吗？——抽象工厂模式

> 提供一个创建一系列相关或相互依赖对象的接口，而无需指定它们具体的类

![抽象工厂模式结构图](picture/第十五章/抽象工厂模式结构图.png)



**用反射+抽象工厂的数据访问程序(演示程序中的DataAccess类)**

用的编程方式：**依赖注入**

了解一个简单的**.NET技术“反射”**

```c#
Assembly.Load("程序集名称").CreateInstance("命名空间.类名称");//反射的格式举例
```

程序集名字->由.NET编译生成的EXE文件或DLL文件就是程序集

CreateInstance才需要完整的命名空间

==但是还是有点小遗憾，在更换数据库访问时，我们还是得改程序(db这个字符串的值)重编译，接下来介绍一个方法==

**用反射+配置文件实现数据访问程序**

```c#
//config配置文件
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
	<appSettings>
		<add key="DB" value="Sqlserver"/>
	</appSettings>
</configuration>
```



```c#
//反射加配置文件的配合使用
using System.Configuration;
//private static readonly string db = "Access"; //不用配置文件
private static readonly string db = ConfigurationManager.AppSettings["DB"]; //使用配置文件
```

==**从这个角度来说，所有用简单工厂的地方，都可以考虑用反射技术来去除switch或if，解除分支判断带来的耦合**==

