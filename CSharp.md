# CSharp Coding Standards

## CheckList
* Ensure there are no unneeded using clauses ( grey )
* Always define variables as type var
* Ensure there are no Resharper hints to look at
* No magic strings, e.g. always use a DateTime extension method to format a date
* No spaces immeditely before or after brackets
* Inject services into Controller constructors 
* All methods should be easy to understand by other coders
	* Can improve readability by extracting code, e.g. switch statements, into private methods
* DRY ( dont repeat yourself )
	* custom Attributes
	* meta data
	* partial views
* Inject service classes into controller constructors using structuremap
* Ensure that any LINQ resolves to SQL i.e. that it does not generate in memory processing

* XDocument.Load is banned. Use (LordsBiz) IWebClientService. This is much more robust ( e.g. three retrys, use of a TimedWebClient which includes a timeout ) 

```c#
public interface IWebClientService
{
    XDocument GetXmlWebResponse(string url);
    string GetJsonStringWebResponse(string url);
    Task<string> GetJsonStringWebResponseAsync(string url);
    T GetJsonWebResponse<T>(string url) where T : new();
}
```

* Place Form around markup even if you want to handle in JavaScript. It means Enter in a control will cause the action to fire.

* Services should return IEnumerable NOT IQueryable
* Within services, IQueryables should be used, inefficient SQL is generated even if you pass in a param which is a IQueryable, if the recieving function defines it as a IEnumerable. It must be defined as IQueryable to get efficent SQL.

## Other
* Define new Attribute descendants where appropiate e.g. to encode data relating to a enumeration value

* When a partial needs its own Model, use @Html.Action()
	* Decorate the action with [ChildActionOnly] assuming you dont want to be able to hit endpoint by hitting its URL
	* This action can return Partial e.g.  return PartialView("_Navigation", model);


## Mappers

