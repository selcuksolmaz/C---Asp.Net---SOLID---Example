﻿using MentalBilisim.Core.Aspects.Postsharp.ExceptionAspects;
using MentalBilisim.Core.Aspects.Postsharp.LogAspects;
using MentalBilisim.Core.Aspects.Postsharp.PerformanceAspects;
using MentalBilisim.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Bir bütünleştirilmiş koda ilişkin Genel Bilgiler aşağıdaki öznitelikler kümesiyle
// denetlenir. Bütünleştirilmiş kod ile ilişkili bilgileri değiştirmek için
// bu öznitelik değerlerini değiştirin.
[assembly: AssemblyTitle("MentalBilisim.Northwind.Business")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("MentalBilisim.Northwind.Business")]
[assembly: AssemblyCopyright("Copyright ©  2019")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: LogAspect(typeof(DatabaseLogger),AttributeTargetTypes  = "MentalBilisim.Northwind.Business.Concrete.Managers.*")]
[assembly: LogAspect(typeof(FileLogger), AttributeTargetTypes = "MentalBilisim.Northwind.Business.Concrete.Managers.*")]
[assembly: ExceptionLogAspect(typeof(DatabaseLogger), AttributeTargetTypes = "MentalBilisim.Northwind.Business.Concrete.Managers.*")]
[assembly: PerformanceCounterAspect(AttributeTargetTypes = "MentalBilisim.Northwind.Business.Concrete.Managers.*")]

// ComVisible özniteliğinin false olarak ayarlanması bu bütünleştirilmiş koddaki türleri
// COM bileşenleri için görünmez yapar. Bu bütünleştirilmiş koddaki bir türe
// erişmeniz gerekirse ComVisible özniteliğini o türde true olarak ayarlayın.
[assembly: ComVisible(false)]

// Bu proje COM'un kullanımına sunulursa, aşağıdaki GUID tür kitaplığının kimliği içindir
[assembly: Guid("283710f3-93fe-4e25-9e49-610e6d17f4e9")]

// Bir derlemenin sürüm bilgileri aşağıdaki dört değerden oluşur:
//
//      Ana Sürüm
//      İkincil Sürüm 
//      Yapı Numarası
//      Düzeltme
//
// Tüm değerleri belirtebilir veya varsayılan Derleme ve Düzeltme Numaralarını kullanmak için
// '*' kullanarak varsayılana ayarlayabilirsiniz:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
