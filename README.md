// <Name>[RC0202] Namensmuster Manager wird eingehalten</Name>
warnif count > 0
 
let namePattern = "Manager"
let allowedMethods = new []{"Add","Update","Remove"}
let allowedPrefixes = new[]{"Get","Is","Are"}
 
 
let managementClasses = JustMyCode.Types.Where(t => !t.ParentNamespace.NameLike("DataClasses") 
                                                 && !t.IsGeneratedByCompiler)
 
from t in managementClasses.Where(t1 => t1.Name.EndsWith(namePattern))
 
let trueMethods = t.Methods.Where(m => !m.IsGeneratedByCompiler 
                                    && !m.IsPropertyGetter
                                    && !m.IsPropertySetter 
                                    && !m.IsConstructor)
 
let forbiddenMethods = trueMethods.Where(m => !allowedMethods.Any(m1 => m.SimpleName == m1) 
&& allowedPrefixes.All(mp => !m.SimpleName.StartsWith(mp)))

where forbiddenMethods.Any()
 
select new { t, forbiddenMethods }
