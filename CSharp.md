# CSharp Coding Standards

## CheckList
* Ensure there are no unneeded using clauses ( grey )
* Always define variables as type var
* No magic strings, e.g. always use a DateTime extension method to format a date
* No spaces immeditely before or after brackets
* Inject services into Controller constructors 
* DRY ( dont repeat yourself )
	* custom Attributes
	* meta data
	* partial views
* Inject service classes into controller constructors using structuremap

## Other
* Define new Attribute descendants where appropiate e.g. to encode data relating to a enumeration value

* When a partial needs its own Model, use @Html.Action()
	* Decorate the action with [ChildActionOnly] assuming you dont want to be able to hit endpoint by hitting its URL
	* This action can return Partial e.g.  return PartialView("_Navigation", model);