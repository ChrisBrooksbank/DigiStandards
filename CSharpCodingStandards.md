# CSharp Coding Standards

* Ensure there are no unneeded using clauses ( grey )
* Always define variables as type var
* No spaces immeditely before or after brackets
* Define new Attribute descendants where appropiate e.g. to encode data relating to a enumeration value
* When a partial needs its own Model, use @Html.Action()
	* Decorate the action with [ChildActionOnly] assuming you dont want to be able to hit endpoint by hitting its URL
	* This action can return Partial e.g.  return PartialView("_Navigation", model);
* Use Extension methods e.g. to format dates in different ways or to interact with Enums	
* Inject services into Controller constructors 